Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq.Expressions

Public Class frmConfiguracion

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        If txtIp.Text = "" Or txtDb.Text = "" Or txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Por favor completar todos los campos", vbCritical, "Operacion Cancelada")
        End If

        Dim archivo As StreamWriter
        Try
            archivo = New StreamWriter(Application.StartupPath + "\IP.txt")
            archivo.WriteLine(txtIp.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\DB.txt")
            archivo.WriteLine(txtDb.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\USER.txt")
            archivo.WriteLine(txtUser.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\PASS.txt")
            archivo.WriteLine(txtPass.Text.Trim)
            archivo.Flush()
            archivo.Close()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

        btnCancelar.PerformClick()
    End Sub

    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If File.Exists(Application.StartupPath + "\IP.txt") Then
                txtIp.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\IP.txt")
            End If

            If File.Exists(Application.StartupPath + "\USER.txt") Then
                txtUser.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\USER.txt")
            End If

            If File.Exists(Application.StartupPath + "\PASS.txt") Then
                txtPass.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\PASS.txt")
            End If

            If File.Exists(Application.StartupPath + "\DB.txt") Then
                txtDb.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\DB.txt")
            End If

            If txtIp.Text.Length = 0 Or txtUser.Text.Length = 0 Or txtPass.Text.Length = 0 Or txtDb.Text.Length = 0 Then
                MsgBox("Faltan parametros de conexion", vbCritical, "Error de CONEXION")
            Else
                conexion = New SqlConnection("Data Source=" & ip.Trim & "; Initial Catalog=" & db.Trim & "; User Id=" & user.Trim & "; Password=" & pass.Trim & ";")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
