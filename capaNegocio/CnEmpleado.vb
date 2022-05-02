Imports capaEntidad
Imports capaDatos


Public Class CnEmpleado

    Dim DatosEmpleado As New CdEmpleado()
    Public Function ValidarDatos(ByVal empleado As CeEmpleado) As Boolean
        Dim Resultado As Boolean = True

        If empleado.Nombre = "" Then
            Resultado = False
            MessageBox.Show("El nombre es obligatorio")
        End If
        If empleado.Apellido = "" Then
            Resultado = False
            MessageBox.Show("El apellido es obligatorio")
        End If


        Return Resultado
    End Function

    Public Sub PruebaPostgres()
        DatosEmpleado.ProbarConexion()
    End Sub

    Public Sub Insertar(ByVal empleado As CeEmpleado)
        DatosEmpleado.Insertar(empleado)
    End Sub
    Public Sub Actualizar(ByVal empleado As CeEmpleado)
        DatosEmpleado.Actualizar(empleado)
    End Sub
    Public Sub Eliminar(ByVal empleado As CeEmpleado)
        If MessageBox.Show("Estas seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            DatosEmpleado.Eliminar(empleado)
        End If

    End Sub

    Public Function Listar() As DataSet
        Return DatosEmpleado.Listar()
    End Function
End Class
