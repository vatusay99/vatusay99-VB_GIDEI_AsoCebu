Imports System.Data.SqlClient

Public Class frmDepartamento
    Private Sub frmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactivarControlles()
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
        Width = 662
        Height = 169
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ActivarControlles()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        DesactivarControlles()
        LimpiarControles()
    End Sub
End Class