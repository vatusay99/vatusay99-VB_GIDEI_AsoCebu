
Imports System.Data.SqlClient
Imports System.IO

Module ConectarDB
    Public ip As String = "", user As String = "", pass As String = "", db As String = ""
    Public conexion As SqlConnection
    Public adaptador As SqlDataAdapter
    Public tabla As New DataTable


    Public nombre As String
    Public usuario As String
    Public tipoUsuario As String

    Public Sub establecerConexion()
        Try
            If File.Exists(Application.StartupPath + "\IP.txt") Then
                ip = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\IP.txt")
            End If

            If File.Exists(Application.StartupPath + "\USER.txt") Then
                user = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\USER.txt")
            End If

            If File.Exists(Application.StartupPath + "\PASS.txt") Then
                pass = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\PASS.txt")
            End If

            If File.Exists(Application.StartupPath + "\DB.txt") Then
                db = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\DB.txt")
            End If

            If ip.Length = 0 Or user.Length = 0 Or pass.Length = 0 Or db.Length = 0 Then
                MsgBox("Faltan parametros de conexion", vbCritical, "Error de CONEXION")
            Else

                'conexion = New SqlConnection("Data Source=ingrid\LOCALDB#B5414560;Initial Catalog=gestorInventarioEquipos;User ID=sinedin;Encrypt=True")
                conexion = New SqlConnection("Data Source=" & ip.Trim & ";Initial Catalog=" & db.Trim & ";User ID=" & user.Trim & "; Password=" & pass.Trim & "; ")
                'Data Source=(localdb)\MSSQLLocalDB;Persist Security Info=False;User ID=sinedin;Pooling=False;Multiple Active Result Sets=False;Encrypt=True;Trust Server Certificate=False;Command Timeout=0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function obtenerConexion() As String
        Dim miConexion As String = ""
        Try
            If File.Exists(Application.StartupPath + "\IP.txt") Then
                ip = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\IP.txt")
            End If

            If File.Exists(Application.StartupPath + "\USER.txt") Then
                user = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\USER.txt")
            End If

            If File.Exists(Application.StartupPath + "\PASS.txt") Then
                pass = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\PASS.txt")
            End If

            If File.Exists(Application.StartupPath + "\DB.txt") Then
                db = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\DB.txt")
            End If

            If ip.Length = 0 Or user.Length = 0 Or pass.Length = 0 Or db.Length = 0 Then
                MsgBox("Faltan parametros de conexion", vbCritical, "Error de CONEXION")
            Else
                miConexion = "Data Source=" & ip.Trim & "; Initial Catalog=" & db.Trim & "; User Id=" & user.Trim & "; Password=" & pass.Trim & "; "
                'miConexion = "Data Source=ingrid\LOCALDB#B5414560;Initial Catalog=gestorInventarioEquipos;User ID=sinedin;Encrypt=True"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Return miConexion

    End Function
End Module
