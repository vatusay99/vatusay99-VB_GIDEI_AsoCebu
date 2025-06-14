Imports System.Data.SqlClient

Public Class frmUsuarios
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado.SelectedIndexChanged

    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControlles()
        LlenarDatos()
    End Sub

    Sub DesactivarControlles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False

        txtNombre.Enabled = False
        txtUsuario.Enabled = False
        txtContraseña.Enabled = False

        cboTipouser.Enabled = False
        cboEstado.Enabled = False

        btnNuevo.Enabled = True

    End Sub

    Sub ActivarControlles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True

        txtNombre.Enabled = True
        txtUsuario.Enabled = True
        txtContraseña.Enabled = True

        cboTipouser.Enabled = True
        cboEstado.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()
        txtNombre.Text = ""
        txtUsuario.Text = ""
        txtContraseña.Clear()
        txtId.Text = ""
        txtBuscar.Text = ""

        cboEstado.Text = ""
        cboTipouser.Text = ""


    End Sub

    Sub InsertarUsuario()
        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar nuevo Registro", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub
        End If

        adaptador = New SqlDataAdapter("SELECT * FROM t_usuarios WHERE usuario = '" & txtUsuario.Text & "'", obtenerConexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtUsuario.Text = tabla.Rows(0).Item("usuario")
            MsgBox("El registro ya exixte en la base de datos", vbInformation, "Sistema Inventario")
            Exit Sub
        End If

        If txtNombre.Text = "" Or txtUsuario.Text = "" Or txtContraseña.Text = "" Or cboTipouser.Text = "" Or cboEstado.Text = "" Then
            MsgBox("Existen Campos vacios", vbInformation, "Sistema Inventario")
            Exit Sub
        Else
            sql = "INSERT INTO [dbo].[t_usuarios] ([nombre_completo],[usuario],[password],[tipo_usurio],[estado]) VALUES ('" & txtNombre.Text & "','" & txtUsuario.Text & "','" & txtContraseña.Text & "','" & cboTipouser.Text & "','" & cboEstado.Text & "')"
            Dim conect As New SqlConnection(obtenerConexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro realizxado con exito", vbInformation, "sistema Inventario")
        End If

    End Sub

    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen campos vacios", vbInformation, "Sistema de inventario")
        Else
            Dim sql As String
            sql = "UPDATE t_usuarios SET nombre_completo = '" & txtNombre.Text & "', usuario = '" & txtUsuario.Text & "', 
                   password = '" & txtContraseña.Text & "', tipo_usurio = '" & cboTipouser.Text & "',
                   estado = '" & cboEstado.Text & "' WHERE id_usuario = '" & txtId.Text & "'"
            Dim conect As New SqlConnection(obtenerConexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()

            End Using
            conect.Close()
            MsgBox("Registro editado exitosamnete.", vbInformation, "Sistema de inventario")
            LimpiarControles()
        End If
    End Sub

    Sub Eliminar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen campos vacios", vbInformation, "Sistema de inventario")
        Else
            If MsgBox("Esta seguro que desea eliminar el registro: " + Trim(txtNombre.Text) + " !!", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
                LimpiarControles()
                Exit Sub
            Else
                Dim sql As String
                sql = "DELETE FROM t_usuarios WHERE id_usuario = " & Trim(txtId.Text)
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

    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT * FROM t_usuarios"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerConexion)
            adaptador.Fill(tabla)
            dgbUsuarios.DataSource = tabla
            lblTotal.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha detectado el siguiente error" + ex.ToString + " Sistema Inventario")
        End Try
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControlles()
        LimpiarControles()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        InsertarUsuario()
        LlenarDatos()
        Call DesactivarControlles()
        LimpiarControles()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call DesactivarControlles()
        LimpiarControles()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
        DesactivarControlles()
        LlenarDatos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
        DesactivarControlles()
        LlenarDatos()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            LlenarDatos()
        End If

        adaptador = New SqlDataAdapter("SELECT * FROM t_usuarios WHERE nombre_completo LIKE '%" & txtBuscar.Text & "%'", obtenerConexion)

        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            dgbUsuarios.DataSource = tabla
            lblTotal.Text = tabla.Rows.Count
        Else
            dgbUsuarios.DataSource = ""
        End If

    End Sub

    Private Sub dgbUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbUsuarios.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgbUsuarios.Item("id_usuario", dgbUsuarios.CurrentCell.RowIndex).Value)
        txtNombre.Text = CStr(dgbUsuarios.Item("nombre_completo", dgbUsuarios.CurrentCell.RowIndex).Value)
        txtUsuario.Text = CStr(dgbUsuarios.Item("usuario", dgbUsuarios.CurrentCell.RowIndex).Value)
        txtContraseña.Text = CStr(dgbUsuarios.Item("password", dgbUsuarios.CurrentCell.RowIndex).Value)
        cboTipouser.Text = CStr(dgbUsuarios.Item("tipo_usurio", dgbUsuarios.CurrentCell.RowIndex).Value)
        cboEstado.Text = CStr(dgbUsuarios.Item("estado", dgbUsuarios.CurrentCell.RowIndex).Value)
        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = True

        txtNombre.Enabled = True
        txtUsuario.Enabled = True
        txtContraseña.Enabled = True

        cboEstado.Enabled = True
        cboTipouser.Enabled = True

        txtNombre.Focus()


    End Sub
End Class