Imports Npgsql
Imports capaEntidad

Public Class CdEmpleado
    Private _cadenaConexion As String = "Server=127.0.0.1;User id=jorge;Password=12345678;Port=5432;Database=frond_test_1"

    Public Sub ProbarConexion()
        Dim Conexion As New NpgsqlConnection(_cadenaConexion)

        Try
            Conexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        MessageBox.Show("Conectado")

        Conexion.Close()
    End Sub

    Public Sub Insertar(ByVal empleado As CeEmpleado)
        Dim Conexion As New NpgsqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "INSERT INTO public.empleados (nombre, apellido, foto) VALUES ('" & empleado.Nombre & "', '" & empleado.Apellido & "', '" & empleado.Foto.Replace("\\", "\\\\") & "');"
        Dim Comando As New NpgsqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()

    End Sub

    Public Sub Actualizar(ByVal empleado As CeEmpleado)
        Dim Conexion As New NpgsqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "UPDATE public.empleados SET nombre='" & empleado.Nombre & "', apellido='" & empleado.Apellido & "', foto='" & empleado.Foto.Replace("\\", "\\\\") & "' WHERE id = " & empleado.Id & ";"
        Dim Comando As New NpgsqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()

    End Sub
    Public Sub Eliminar(ByVal empleado As CeEmpleado)
        Dim Conexion As New NpgsqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "DELETE FROM public.empleados WHERE id = " & empleado.Id & ";"
        Dim Comando As New NpgsqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()
        MessageBox.Show("Registro Eliminado")

    End Sub

    Public Function Listar() As DataSet
        Dim Conexion As New NpgsqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "SELECT * FROM public.empleados"
        Dim Adaptador As NpgsqlDataAdapter
        Dim dataSet As New DataSet

        Adaptador = New NpgsqlDataAdapter(Query, Conexion)
        Adaptador.Fill(dataSet, "empleados")

        Return dataSet

    End Function
End Class
