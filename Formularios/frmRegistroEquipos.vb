Imports System.Data.SqlClient

Public Class frmEquipos

    Private tabla_departamentos As New DataTable
    Private tabla_usuarios As New DataTable

    Sub DesactivarControlles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnBuscar.Enabled = True

        txtNombreEquipo.Enabled = False
        txtTipoEquipo.Enabled = False
        txtSerial.Enabled = False
        txtID.Enabled = False
        dtpFechaIngresoEquipo.Enabled = True
        CheckActivo.Enabled = False
        cbxIdDepartamento.Enabled = True
        cbxIdUsuarioAsignado.Enabled = True

        btnNuevo.Enabled = True

    End Sub

    Sub ActivarControlles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True

        txtNombreEquipo.Enabled = True
        txtTipoEquipo.Enabled = True
        txtSerial.Enabled = True
        txtID.Enabled = True
        dtpFechaIngresoEquipo.Enabled = True
        CheckActivo.Enabled = True
        cbxIdDepartamento.Enabled = True
        cbxIdUsuarioAsignado.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()
        txtNombreEquipo.Text = ""
        txtTipoEquipo.Text = ""
        txtSerial.Text = ""
        txtID.Text = ""
        'dtpFechaIngresoEquipo = True
        CheckActivo.Checked = True
        cbxIdDepartamento.Text = ""
        cbxIdUsuarioAsignado.Text = ""
    End Sub

    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT * FROM t_registro_de_equipos"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerConexion)
            adaptador.Fill(tabla)
            dgvEquipos.DataSource = tabla
            lblTotal.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha detectado el siguiente error" + ex.ToString + " Sistema Inventario")
        End Try
    End Sub

    Sub InsertarEquipo()
        Dim sql As String
        Dim id As Integer
        Dim id_Usuario As Integer
        Dim sqlIdUser As String
        Dim estadoActivo As String

        If MsgBox("Guardar nuevo Registro", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub
        End If

        id_Usuario = CInt(cbxIdUsuarioAsignado.SelectedValue)
        sqlIdUser = "SELECT u.nombre_completo, COUNT(r.id_usuario_encargado) AS Total_registro FROM t_usuarios u
                      INNER JOIN t_registro_de_equipos r ON u.id_usuario = r.id_usuario_encargado
                      GROUP BY r.id_usuario_encargado, u.nombre_completo
                      HAVING r.id_usuario_encargado = " & id_Usuario

        adaptador = New SqlDataAdapter(sqlIdUser, obtenerConexion)
        'MsgBox(sqlIdUser, vbInformation, "Consulta sql")
        tabla.Clear()
        adaptador.Fill(tabla)
        'MsgBox("Conteo de registro: " & tabla.Rows.Count.ToString, vbInformation, "Conteo")

        If tabla.Rows.Count > 0 Then
            cbxIdUsuarioAsignado.Text = tabla.Rows(0).Item("nombre_completo")
            MsgBox("El usuario '" & cbxIdUsuarioAsignado.Text & "' ya tiene un equipo asignado en base de datos", vbCritical, "Sistema Inventario - Accion no permitida")
            Exit Sub
        End If

        If CheckActivo.Checked Then
            estadoActivo = "Activo"
        Else
            estadoActivo = "Inactivo"
        End If

        Try
            If txtNombreEquipo.Text = "" Or txtTipoEquipo.Text = "" Or txtSerial.Text = "" Or dtpFechaIngresoEquipo.Text = "" Then
                MsgBox("Existen Campos vacios", vbInformation, "Sistema Inventario")
                Exit Sub
            Else
                sql = "INSERT INTO t_registro_de_equipos 
                    ([nombre]
                    ,[tipo]
                    ,[serial]
                    ,[id_departamento_area]
                    ,[fecha_ingreso]
                    ,[activo]
                    ,[id_usuario_encargado])
                    VALUES ('" & txtNombreEquipo.Text & "'
                    ,'" & txtTipoEquipo.Text & "'
                    ,'" & txtSerial.Text & "'
                    ,'" & cbxIdDepartamento.SelectedValue & "'
                    ,''
                    ,'" & estadoActivo & "'
                    ,'" & cbxIdUsuarioAsignado.SelectedValue & "')"

                Dim conect As New SqlConnection(obtenerConexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()
                End Using
                conect.Close()
                MsgBox("Registro Creado con exito", vbInformation, "sistema Inventario")
            End If

        Catch ex As Exception
            MsgBox("Se ha detectado el siguiente error" + ex.ToString + " Sistema Inventario")
        End Try


    End Sub
    Private Sub frmEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControlles()
        LlenarDatos()
        dgvEquipos.AutoGenerateColumns = False
        MostrarDepartamento()
        MostrarUsuario()
        cbxIdDepartamento.SelectedIndex = -1
        cbxIdUsuarioAsignado.SelectedIndex = -1
    End Sub

    Private Function listarDepartamento() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT id_departamento, nombre_area_departamento FROM t_departamento_area"

        Using adaptador = New SqlDataAdapter(sql, obtenerConexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using

        Return tabla
    End Function

    Private Sub MostrarDepartamento()
        tabla_departamentos = listarDepartamento()
        cbxIdDepartamento.DataSource = tabla_departamentos
        cbxIdDepartamento.DisplayMember = "nombre_area_departamento"
        cbxIdDepartamento.ValueMember = "id_departamento"
    End Sub

    Private Function listarUsuarios() As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT id_usuario, nombre_completo FROM t_usuarios"

        Using adaptador = New SqlDataAdapter(sql, obtenerConexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using

        Return tabla
    End Function

    Private Sub MostrarUsuario()
        tabla_usuarios = listarUsuarios()
        cbxIdUsuarioAsignado.DataSource = tabla_usuarios
        cbxIdUsuarioAsignado.DisplayMember = "nombre_completo"
        cbxIdUsuarioAsignado.ValueMember = "id_usuario"
    End Sub

    Sub BuscarDatos()

        LlenarDatos()

        If rbEquipo.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If

            adaptador = New SqlDataAdapter("SELECT * FROM t_registro_de_equipos WHERE tipo LIKE '%" & txtBuscar.Text & "%'", obtenerConexion)

            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvEquipos.DataSource = tabla
                lblTotal.Text = tabla.Rows.Count
            Else
                dgvEquipos.DataSource = ""
            End If
        End If

        If rbDepartamento.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If

            adaptador = New SqlDataAdapter("SELECT * FROM t_registro_de_equipos WHERE id_departamento_area LIKE '%" & txtBuscar.Text & "%'", obtenerConexion)

            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvEquipos.DataSource = tabla
                lblTotal.Text = tabla.Rows.Count
            Else
                dgvEquipos.DataSource = ""
            End If
        End If

        If rbidUsuario.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If

            adaptador = New SqlDataAdapter("SELECT * FROM t_registro_de_equipos WHERE id_usuario_encargado LIKE '%" & txtBuscar.Text & "%'", obtenerConexion)

            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvEquipos.DataSource = tabla
                lblTotal.Text = tabla.Rows.Count
            Else
                dgvEquipos.DataSource = ""
            End If
        End If

        If rbInactivo.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If

            adaptador = New SqlDataAdapter("SELECT * FROM t_registro_de_equipos WHERE activo = 'Inactivo'", obtenerConexion)

            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvEquipos.DataSource = tabla
                lblTotal.Text = tabla.Rows.Count
            Else
                dgvEquipos.DataSource = ""
            End If
        End If
    End Sub

    Sub EditarEquipo()
        Dim id As Integer
        Dim estadoEquipo As String
        If txtID.Text = "" Then
            MsgBox("Existen campos vacios", vbInformation, "Sistema de inventario")
        Else
            Dim sql As String
            If CheckActivo.Checked Then
                estadoEquipo = "Activo"
            Else
                estadoEquipo = "Inactivo"
            End If
            Try
                'pendiente agregar campo fecha
                sql = "UPDATE t_registro_de_equipos SET nombre = '" & txtNombreEquipo.Text & "'
                   , tipo = '" & txtTipoEquipo.Text & "'
                   , serial = '" & txtSerial.Text & "'
                   , id_departamento_area = " & cbxIdDepartamento.Text & "
                   , activo = '" & estadoEquipo & "'
                   , id_usuario_encargado = " & cbxIdUsuarioAsignado.Text & "
                   WHERE id_equipo = " & txtID.Text & ""

                Dim conect As New SqlConnection(obtenerConexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()
                End Using
                conect.Close()
                MsgBox("Registro editado exitosamnete.", vbInformation, "Sistema de inventario")
                LimpiarControles()
            Catch ex As Exception
                MsgBox("Se ha detectado el siguiente error" + ex.ToString + " Sistema Inventario")
            End Try
        End If
    End Sub

    Sub EliminarEquipo()
        Dim id As Integer
        If txtID.Text = "" Then
            MsgBox("Existen campos vacios", vbInformation, "Sistema de inventario")
        Else
            If MsgBox("Esta seguro que desea eliminar el registro: " + Trim(txtNombreEquipo.Text) + " !!", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
                LimpiarControles()
                DesactivarControlles()
                Exit Sub
            Else
                Dim sql As String
                sql = "DELETE FROM t_registro_de_equipos WHERE id_equipo = " & Trim(txtID.Text)
                Dim conect As New SqlConnection(obtenerConexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()

                End Using
                conect.Close()
                MsgBox("Registro Eliminado exitosamnete.", vbInformation, "Sistema de inventario")
                LimpiarControles()
            End If
        End If
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ActivarControlles()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        InsertarEquipo()
        LlenarDatos()
        DesactivarControlles()
        LimpiarControles()

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
    End Sub

    Private Sub rbActivo_CheckedChanged(sender As Object, e As EventArgs) Handles rbActivo.CheckedChanged
        If rbActivo.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If

            adaptador = New SqlDataAdapter("SELECT * FROM t_registro_de_equipos WHERE activo = 'Activo';", obtenerConexion)

            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvEquipos.DataSource = tabla
                lblTotal.Text = tabla.Rows.Count
            Else
                dgvEquipos.DataSource = ""
            End If
        End If
    End Sub

    Private Sub rbInactivo_CheckedChanged(sender As Object, e As EventArgs) Handles rbInactivo.CheckedChanged
        If rbInactivo.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If

            adaptador = New SqlDataAdapter("SELECT * FROM t_registro_de_equipos WHERE activo = 'Inactivo'", obtenerConexion)

            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvEquipos.DataSource = tabla
                lblTotal.Text = tabla.Rows.Count
            Else
                dgvEquipos.DataSource = ""
            End If
        End If
    End Sub

    Private Sub dgvEquipos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquipos.CellDoubleClick
        On Error Resume Next
        txtID.Text = CStr(dgvEquipos.Item("id_equipo", dgvEquipos.CurrentCell.RowIndex).Value)
        txtNombreEquipo.Text = CStr(dgvEquipos.Item("nombre", dgvEquipos.CurrentCell.RowIndex).Value)
        txtTipoEquipo.Text = CStr(dgvEquipos.Item("tipo", dgvEquipos.CurrentCell.RowIndex).Value)
        txtSerial.Text = CStr(dgvEquipos.Item("serial", dgvEquipos.CurrentCell.RowIndex).Value)
        cbxIdDepartamento.Text = CStr(dgvEquipos.Item("id_departamento_area", dgvEquipos.CurrentCell.RowIndex).Value)
        cbxIdUsuarioAsignado.Text = CStr(dgvEquipos.Item("id_usuario_encargado", dgvEquipos.CurrentCell.RowIndex).Value)
        dtpFechaIngresoEquipo.Text = CStr(dgvEquipos.Item("fecha_ingreso", dgvEquipos.CurrentCell.RowIndex).Value)
        If dgvEquipos.Item("activo", dgvEquipos.CurrentCell.RowIndex).Value = "Activo" Then
            CheckActivo.Checked = True
        Else
            CheckActivo.Checked = False
        End If

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = True

        txtNombreEquipo.Enabled = True
        txtTipoEquipo.Enabled = True
        txtSerial.Enabled = True
        dtpFechaIngresoEquipo.Enabled = True
        CheckActivo.Enabled = True

        txtNombreEquipo.Focus()
    End Sub

    Private Sub rbEquipo_CheckedChanged(sender As Object, e As EventArgs) Handles rbEquipo.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub rbDepartamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepartamento.CheckedChanged
        txtBuscar.Focus()

    End Sub

    Private Sub rbidUsuario_CheckedChanged(sender As Object, e As EventArgs) Handles rbidUsuario.CheckedChanged
        txtBuscar.Focus()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarEquipo()
        DesactivarControlles()
        LlenarDatos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarEquipo()
        DesactivarControlles()
        LlenarDatos()
    End Sub
End Class

