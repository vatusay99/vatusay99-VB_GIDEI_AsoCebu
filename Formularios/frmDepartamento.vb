Imports System.Data.SqlClient

Public Class frmDepartamento
    Private Sub frmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactivarControlles()
        TamañoReal()
    End Sub

    Sub DesactivarControlles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnBuscar.Enabled = True

        txtDepartamento.Enabled = False
        txtDescripcion.Enabled = False
        txtCentroCostos.Enabled = False
        txtJefeArea.Enabled = False

        btnNuevo.Enabled = True

    End Sub

    Sub ActivarControlles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True

        txtDepartamento.Enabled = True
        txtDescripcion.Enabled = True
        txtCentroCostos.Enabled = True
        txtJefeArea.Enabled = True

        btnNuevo.Enabled = False

    End Sub

    Sub LimpiarControles()
        txtDepartamento.Text = ""
        txtDescripcion.Text = ""
        txtCentroCostos.Text = ""
        txtJefeArea.Text = ""
        txtId.Text = ""
        txtBuscar.Text = ""
    End Sub

    Sub TamañoReal()
        Width = 765
        Height = 170
        Panel1.Visible = False
    End Sub

    Sub TamañoRealBuscar()
        Width = 765
        Height = 380
        Panel1.Visible = True
        txtBuscar.Focus()
        txtBuscar.BackColor = Color.AliceBlue

    End Sub

    Sub InsertarDepartamento()
        Dim sql As String
        Dim id As Integer

        If MsgBox("Guardar nuevo Departamento o Area", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
            Exit Sub
        End If

        adaptador = New SqlDataAdapter("SELECT * FROM t_departamento_area WHERE nombre_area_departamento = '" & txtDepartamento.Text & "'", obtenerConexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtDepartamento.Text = tabla.Rows(0).Item("nombre_area_departamento")
            MsgBox("El registro ya exixte en la base de datos", vbInformation, "Sistema Inventario")
            Exit Sub
        End If

        If txtDepartamento.Text = "" Or txtDescripcion.Text = "" Or txtCentroCostos.Text = "" Or txtJefeArea.Text = "" Then
            MsgBox("Existen Campos vacios", vbInformation, "Sistema Inventario")
            Exit Sub
        Else
            sql = "INSERT INTO [dbo].[t_departamento_area] ([nombre_area_departamento],[centro_de_costos],[nombre_jefe_area],[descripcion]) VALUES ('" & txtDepartamento.Text & "','" & txtCentroCostos.Text & "','" & txtJefeArea.Text & "','" & txtDescripcion.Text & "')"
            Dim conect As New SqlConnection(obtenerConexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro realizxado con exito", vbInformation, "sistema Inventario")
        End If

    End Sub

    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT * FROM t_departamento_area"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerConexion)
            adaptador.Fill(tabla)
            dgvDepartamento.DataSource = tabla
            lblTotal.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha detectado el siguiente error" + ex.ToString + " Sistema Inventario")
        End Try
    End Sub

    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen campos vacios", vbInformation, "Sistema de inventario")
        Else
            Dim sql As String
            sql = "UPDATE t_departamento_area SET nombre_area_departamento = '" & txtDepartamento.Text & "', centro_de_costos = '" & txtCentroCostos.Text & "', 
                   nombre_jefe_area = '" & txtJefeArea.Text & "', descripcion = '" & txtDescripcion.Text & "'
                   WHERE id_departamento = '" & txtId.Text & "'"
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
            If MsgBox("Esta seguro que desea eliminar el registro: " + Trim(txtDepartamento.Text) + " !!", vbQuestion + vbYesNo, "Sistema de inventario") = vbNo Then
                LimpiarControles()
                Exit Sub
            Else
                Dim sql As String
                sql = "DELETE FROM t_departamento_area WHERE id_departamento = " & Trim(txtId.Text)
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

        InsertarDepartamento()
        LlenarDatos()
        Call DesactivarControlles()
        LimpiarControles()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        TamañoRealBuscar()
        btnCancelar.Enabled = True
        btnBuscar.Enabled = False
        LlenarDatos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TamañoReal()
        LimpiarControles()
        DesactivarControlles()
        Panel1.Visible = False
        btnCancelar.Enabled = False
        btnBuscar.Enabled = True
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            LlenarDatos()
        End If

        adaptador = New SqlDataAdapter("SELECT * FROM t_departamento_area WHERE nombre_area_departamento LIKE '%" & txtBuscar.Text & "%'", obtenerConexion)

        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            dgvDepartamento.DataSource = tabla
            lblTotal.Text = tabla.Rows.Count
        Else
            dgvDepartamento.DataSource = ""
        End If
    End Sub

    Private Sub dgvDepartamento_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartamento.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvDepartamento.Item("id_departamento", dgvDepartamento.CurrentCell.RowIndex).Value)
        txtDepartamento.Text = CStr(dgvDepartamento.Item("nombre_area_departamento", dgvDepartamento.CurrentCell.RowIndex).Value)
        txtCentroCostos.Text = CStr(dgvDepartamento.Item("centro_de_costos", dgvDepartamento.CurrentCell.RowIndex).Value)
        txtJefeArea.Text = CStr(dgvDepartamento.Item("nombre_jefe_area", dgvDepartamento.CurrentCell.RowIndex).Value)
        txtDescripcion.Text = CStr(dgvDepartamento.Item("descripcion", dgvDepartamento.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = True

        txtDepartamento.Enabled = True
        txtDescripcion.Enabled = True
        txtJefeArea.Enabled = True

        txtDepartamento.Focus()
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
End Class