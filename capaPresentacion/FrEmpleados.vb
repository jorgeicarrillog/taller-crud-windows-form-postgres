Imports capaEntidad
Imports capaNegocio

Public Class FrEmpleados

    Dim NegocioEmpleado As New CnEmpleado()
    Private Sub FrEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLista()
    End Sub

    Private Sub CargarLista()
        DataSource.DataSource = NegocioEmpleado.Listar().Tables("empleados")
    End Sub

    Private Sub Limpiar()
        txtId.Value = 0
        txtNombre.Text = ""
        txtApellido.Text = ""
        picPhoto.Image = Nothing
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub LinkFoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkFoto.LinkClicked
        OpenFoto.ShowDialog()
        If OpenFoto.FileName <> "" Then
            picPhoto.Load(OpenFoto.FileName)
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Dim empleado As New CeEmpleado()
        Dim Validacion As Boolean

        empleado.Id = txtId.Value
        empleado.Nombre = txtNombre.Text
        empleado.Apellido = txtApellido.Text
        empleado.Foto = picPhoto.ImageLocation

        Validacion = NegocioEmpleado.ValidarDatos(empleado)

        If Validacion = False Then
            Exit Sub
        End If

        If empleado.Id = 0 Then
            NegocioEmpleado.Insertar(empleado)
            MessageBox.Show("Registro Creado")
        Else
            NegocioEmpleado.Actualizar(empleado)
            MessageBox.Show("Registro Actualizado")
        End If
        CargarLista()
        Limpiar()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        If txtId.Value = 0 Then Exit Sub
        Dim empleado As New CeEmpleado()
        empleado.Id = txtId.Value
        NegocioEmpleado.Eliminar(empleado)
        Limpiar()
        CargarLista()
    End Sub

    Private Sub DataSource_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataSource.CellContentDoubleClick
        txtId.Value = DataSource.CurrentRow.Cells("id").Value
        txtNombre.Text = DataSource.CurrentRow.Cells("nombre").Value
        txtApellido.Text = DataSource.CurrentRow.Cells("apellido").Value
        If DataSource.CurrentRow.Cells("foto").Value <> "" And System.IO.File.Exists(DataSource.CurrentRow.Cells("foto").Value) Then
            picPhoto.Load(DataSource.CurrentRow.Cells("foto").Value)
        End If
    End Sub
End Class
