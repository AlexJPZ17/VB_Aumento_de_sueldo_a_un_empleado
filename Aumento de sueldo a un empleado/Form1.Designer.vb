<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Sueldo = New System.Windows.Forms.TextBox()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.TextBox_N_Enpleado = New System.Windows.Forms.TextBox()
        Me.TextBox_SueldoAum = New System.Windows.Forms.TextBox()
        Me.Button_Calcular = New System.Windows.Forms.Button()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.ListBox_Sueldo = New System.Windows.Forms.ListBox()
        Me.ComboBox_Departamento = New System.Windows.Forms.ComboBox()
        Me.PictureBox_Carita1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Carita2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Carita3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_Carita1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Carita2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Carita3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Close
        '
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Location = New System.Drawing.Point(430, 0)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(35, 23)
        Me.Button_Close.TabIndex = 0
        Me.Button_Close.Text = "X"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sueldo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Departamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "N de Empledo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sueldo con aumento"
        '
        'TextBox_Sueldo
        '
        Me.TextBox_Sueldo.Location = New System.Drawing.Point(115, 57)
        Me.TextBox_Sueldo.Name = "TextBox_Sueldo"
        Me.TextBox_Sueldo.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Sueldo.TabIndex = 6
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(115, 94)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Nombre.TabIndex = 7
        '
        'TextBox_N_Enpleado
        '
        Me.TextBox_N_Enpleado.Location = New System.Drawing.Point(115, 174)
        Me.TextBox_N_Enpleado.Name = "TextBox_N_Enpleado"
        Me.TextBox_N_Enpleado.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_N_Enpleado.TabIndex = 9
        '
        'TextBox_SueldoAum
        '
        Me.TextBox_SueldoAum.Location = New System.Drawing.Point(71, 250)
        Me.TextBox_SueldoAum.Name = "TextBox_SueldoAum"
        Me.TextBox_SueldoAum.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_SueldoAum.TabIndex = 10
        '
        'Button_Calcular
        '
        Me.Button_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Calcular.Location = New System.Drawing.Point(33, 302)
        Me.Button_Calcular.Name = "Button_Calcular"
        Me.Button_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Button_Calcular.TabIndex = 11
        Me.Button_Calcular.Text = "Calcular"
        Me.Button_Calcular.UseVisualStyleBackColor = True
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Limpiar.Location = New System.Drawing.Point(203, 302)
        Me.Button_Limpiar.Name = "Button_Limpiar"
        Me.Button_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Limpiar.TabIndex = 12
        Me.Button_Limpiar.Text = "Limpiar"
        Me.Button_Limpiar.UseVisualStyleBackColor = True
        '
        'ListBox_Sueldo
        '
        Me.ListBox_Sueldo.FormattingEnabled = True
        Me.ListBox_Sueldo.Location = New System.Drawing.Point(276, 123)
        Me.ListBox_Sueldo.Name = "ListBox_Sueldo"
        Me.ListBox_Sueldo.Size = New System.Drawing.Size(189, 147)
        Me.ListBox_Sueldo.TabIndex = 13
        '
        'ComboBox_Departamento
        '
        Me.ComboBox_Departamento.FormattingEnabled = True
        Me.ComboBox_Departamento.Items.AddRange(New Object() {"Departamento", "Tecnologia ", "Programacion", "Produccion"})
        Me.ComboBox_Departamento.Location = New System.Drawing.Point(115, 134)
        Me.ComboBox_Departamento.Name = "ComboBox_Departamento"
        Me.ComboBox_Departamento.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_Departamento.TabIndex = 14
        Me.ComboBox_Departamento.Text = "Departamento"
        '
        'PictureBox_Carita1
        '
        Me.PictureBox_Carita1.Image = CType(resources.GetObject("PictureBox_Carita1.Image"), System.Drawing.Image)
        Me.PictureBox_Carita1.Location = New System.Drawing.Point(276, 12)
        Me.PictureBox_Carita1.Name = "PictureBox_Carita1"
        Me.PictureBox_Carita1.Size = New System.Drawing.Size(134, 100)
        Me.PictureBox_Carita1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Carita1.TabIndex = 15
        Me.PictureBox_Carita1.TabStop = False
        Me.PictureBox_Carita1.Visible = False
        '
        'PictureBox_Carita2
        '
        Me.PictureBox_Carita2.Image = CType(resources.GetObject("PictureBox_Carita2.Image"), System.Drawing.Image)
        Me.PictureBox_Carita2.Location = New System.Drawing.Point(276, 12)
        Me.PictureBox_Carita2.Name = "PictureBox_Carita2"
        Me.PictureBox_Carita2.Size = New System.Drawing.Size(134, 100)
        Me.PictureBox_Carita2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Carita2.TabIndex = 16
        Me.PictureBox_Carita2.TabStop = False
        Me.PictureBox_Carita2.Visible = False
        '
        'PictureBox_Carita3
        '
        Me.PictureBox_Carita3.Image = CType(resources.GetObject("PictureBox_Carita3.Image"), System.Drawing.Image)
        Me.PictureBox_Carita3.Location = New System.Drawing.Point(276, 12)
        Me.PictureBox_Carita3.Name = "PictureBox_Carita3"
        Me.PictureBox_Carita3.Size = New System.Drawing.Size(134, 100)
        Me.PictureBox_Carita3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Carita3.TabIndex = 17
        Me.PictureBox_Carita3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(477, 346)
        Me.Controls.Add(Me.PictureBox_Carita3)
        Me.Controls.Add(Me.PictureBox_Carita2)
        Me.Controls.Add(Me.PictureBox_Carita1)
        Me.Controls.Add(Me.ComboBox_Departamento)
        Me.Controls.Add(Me.ListBox_Sueldo)
        Me.Controls.Add(Me.Button_Limpiar)
        Me.Controls.Add(Me.Button_Calcular)
        Me.Controls.Add(Me.TextBox_SueldoAum)
        Me.Controls.Add(Me.TextBox_N_Enpleado)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.TextBox_Sueldo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Close)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox_Carita1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Carita2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Carita3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Sueldo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_N_Enpleado As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_SueldoAum As System.Windows.Forms.TextBox
    Friend WithEvents Button_Calcular As System.Windows.Forms.Button
    Friend WithEvents Button_Limpiar As System.Windows.Forms.Button
    Friend WithEvents ListBox_Sueldo As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox_Departamento As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox_Carita1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Carita2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_Carita3 As System.Windows.Forms.PictureBox

End Class
