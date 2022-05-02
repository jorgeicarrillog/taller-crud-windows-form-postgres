<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrEmpleados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim btnEliminar As System.Windows.Forms.Button
        Dim btnGuardar As System.Windows.Forms.Button
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.NumericUpDown()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.LinkFoto = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.OpenFoto = New System.Windows.Forms.OpenFileDialog()
        Me.DataSource = New System.Windows.Forms.DataGridView()
        btnEliminar = New System.Windows.Forms.Button()
        btnGuardar = New System.Windows.Forms.Button()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        btnEliminar.Location = New System.Drawing.Point(175, 329)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New System.Drawing.Size(94, 29)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        AddHandler btnEliminar.Click, AddressOf Me.btnEliminar_Click
        '
        'btnGuardar
        '
        btnGuardar.Location = New System.Drawing.Point(303, 329)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New System.Drawing.Size(94, 29)
        btnGuardar.TabIndex = 11
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        AddHandler btnGuardar.Click, AddressOf Me.btnGuardar_Click
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(141, 51)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(256, 27)
        Me.txtNombre.TabIndex = 0
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(141, 84)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(256, 27)
        Me.txtApellido.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(141, 18)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(46, 27)
        Me.txtId.TabIndex = 2
        '
        'picPhoto
        '
        Me.picPhoto.BackColor = System.Drawing.SystemColors.ControlDark
        Me.picPhoto.Location = New System.Drawing.Point(141, 118)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(114, 148)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 3
        Me.picPhoto.TabStop = False
        '
        'LinkFoto
        '
        Me.LinkFoto.AutoSize = True
        Me.LinkFoto.Location = New System.Drawing.Point(141, 273)
        Me.LinkFoto.Name = "LinkFoto"
        Me.LinkFoto.Size = New System.Drawing.Size(85, 20)
        Me.LinkFoto.TabIndex = 4
        Me.LinkFoto.TabStop = True
        Me.LinkFoto.Text = "Seleccionar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Foto"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(36, 329)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(94, 29)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'DataSource
        '
        Me.DataSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataSource.Location = New System.Drawing.Point(433, 18)
        Me.DataSource.Name = "DataSource"
        Me.DataSource.RowHeadersWidth = 51
        Me.DataSource.RowTemplate.Height = 29
        Me.DataSource.Size = New System.Drawing.Size(489, 359)
        Me.DataSource.TabIndex = 12
        '
        'FrEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 389)
        Me.Controls.Add(Me.DataSource)
        Me.Controls.Add(btnGuardar)
        Me.Controls.Add(btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkFoto)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "FrEmpleados"
        Me.Text = "Form1"
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents picPhoto As PictureBox
    Friend WithEvents LinkFoto As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents OpenFoto As OpenFileDialog
    Friend WithEvents DataSource As DataGridView
End Class
