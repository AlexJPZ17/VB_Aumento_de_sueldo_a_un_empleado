Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Close()

    End Sub
    Private Sub Calcular()
        Dim cod As Integer
        Dim aumento, salariosn, salario As Double
        Dim nombre, depmt As String

        nombre = TextBox_Nombre.Text
        depmt = ComboBox_Departamento.SelectedItem
        cod = Convert.ToInt32(TextBox_N_Enpleado.Text)
        salariosn = Convert.ToDouble(TextBox_Sueldo.Text)

        If (salariosn < 1500) Then
            aumento = salariosn * 0.5
            salario = aumento + salariosn
            TextBox_SueldoAum.Text = salario.ToString()

            TextBox_Sueldo.Text = ""
            TextBox_Nombre.Text = ""
            ComboBox_Departamento.SelectedItem = "Departamento"
            TextBox_N_Enpleado.Text = ""


            ListBox_Sueldo.Items.Add("Empleado reconocido como: " & nombre)
            ListBox_Sueldo.Items.Add("Del departamento de: " & depmt)

            ListBox_Sueldo.Items.Add("Con numero de empleado: " & cod)
            PictureBox_Carita3.Visible = False
            PictureBox_Carita1.Visible = True

        Else
            PictureBox_Carita3.Visible = False
            PictureBox_Carita1.Visible = False
            PictureBox_Carita2.Visible = True
            MessageBox.Show(nombre + " no se le puede aumentar el salario ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub Button_Calcular_Click(sender As Object, e As EventArgs) Handles Button_Calcular.Click
        Calcular()
    End Sub

    Private Sub Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        PictureBox_Carita1.Visible = False
        PictureBox_Carita2.Visible = False
        PictureBox_Carita3.Visible = True
        TextBox_Nombre.Text = ""
        TextBox_N_Enpleado.Text = ""
        TextBox_Sueldo.Text = ""
        TextBox_SueldoAum.Text = ""
        ListBox_Sueldo.Items.Clear()
    End Sub


End Class
