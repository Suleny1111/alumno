<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCèdula = New System.Windows.Forms.TextBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtCarrera = New System.Windows.Forms.TextBox()
        Me.txtTelèfono = New System.Windows.Forms.TextBox()
        Me.txtDirecciòn = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmdinsertar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cèdula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telèfono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direcciòn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cèdula "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Matricula "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Carrera "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telèfono "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Direcciòn "
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(73, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 7
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(73, 46)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 8
        '
        'txtCèdula
        '
        Me.txtCèdula.Location = New System.Drawing.Point(73, 79)
        Me.txtCèdula.Name = "txtCèdula"
        Me.txtCèdula.Size = New System.Drawing.Size(100, 20)
        Me.txtCèdula.TabIndex = 9
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(73, 115)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(100, 20)
        Me.txtMatricula.TabIndex = 10
        '
        'txtCarrera
        '
        Me.txtCarrera.Location = New System.Drawing.Point(73, 147)
        Me.txtCarrera.Name = "txtCarrera"
        Me.txtCarrera.Size = New System.Drawing.Size(100, 20)
        Me.txtCarrera.TabIndex = 11
        '
        'txtTelèfono
        '
        Me.txtTelèfono.Location = New System.Drawing.Point(73, 183)
        Me.txtTelèfono.Name = "txtTelèfono"
        Me.txtTelèfono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelèfono.TabIndex = 12
        '
        'txtDirecciòn
        '
        Me.txtDirecciòn.Location = New System.Drawing.Point(73, 215)
        Me.txtDirecciòn.Name = "txtDirecciòn"
        Me.txtDirecciòn.Size = New System.Drawing.Size(100, 20)
        Me.txtDirecciòn.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.apellido, Me.cèdula, Me.matricula, Me.carrera, Me.telèfono, Me.direcciòn})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 273)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(741, 174)
        Me.DataGridView1.TabIndex = 14
        '
        'cmdinsertar
        '
        Me.cmdinsertar.Location = New System.Drawing.Point(94, 242)
        Me.cmdinsertar.Name = "cmdinsertar"
        Me.cmdinsertar.Size = New System.Drawing.Size(75, 23)
        Me.cmdinsertar.TabIndex = 15
        Me.cmdinsertar.Text = "Insertar "
        Me.cmdinsertar.UseVisualStyleBackColor = True
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Location = New System.Drawing.Point(203, 241)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 23)
        Me.cmdActualizar.TabIndex = 16
        Me.cmdActualizar.Text = "Actualizar "
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(303, 241)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEliminar.TabIndex = 17
        Me.cmdEliminar.Text = "Eliminar "
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(398, 241)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdLimpiar.TabIndex = 18
        Me.cmdLimpiar.Text = "Limpiar "
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(495, 241)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 19
        Me.cmdSalir.Text = "Salir "
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre "
        Me.nombre.HeaderText = "Nombre "
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido "
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        '
        'cèdula
        '
        Me.cèdula.DataPropertyName = "cèdula "
        Me.cèdula.HeaderText = "Cèdula "
        Me.cèdula.Name = "cèdula"
        Me.cèdula.ReadOnly = True
        '
        'matricula
        '
        Me.matricula.DataPropertyName = "matricula"
        Me.matricula.HeaderText = "Matricula"
        Me.matricula.Name = "matricula"
        Me.matricula.ReadOnly = True
        '
        'carrera
        '
        Me.carrera.DataPropertyName = "carrera"
        Me.carrera.HeaderText = "Carrera"
        Me.carrera.Name = "carrera"
        Me.carrera.ReadOnly = True
        '
        'telèfono
        '
        Me.telèfono.DataPropertyName = "telèfono "
        Me.telèfono.HeaderText = "Telèfono"
        Me.telèfono.Name = "telèfono"
        Me.telèfono.ReadOnly = True
        '
        'direcciòn
        '
        Me.direcciòn.DataPropertyName = "direcciòn "
        Me.direcciòn.HeaderText = "Direcciòn"
        Me.direcciòn.Name = "direcciòn"
        Me.direcciòn.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 459)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.cmdinsertar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtDirecciòn)
        Me.Controls.Add(Me.txtTelèfono)
        Me.Controls.Add(Me.txtCarrera)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.txtCèdula)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtCèdula As System.Windows.Forms.TextBox
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtCarrera As System.Windows.Forms.TextBox
    Friend WithEvents txtTelèfono As System.Windows.Forms.TextBox
    Friend WithEvents txtDirecciòn As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdinsertar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button

   
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cèdula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents matricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents carrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telèfono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direcciòn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
