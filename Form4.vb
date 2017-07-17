Public Class Form4
    Private Sub AgendaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AgendaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AgendaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Agenda1DataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Agenda1DataSet.Agenda' Puede moverla o quitarla según sea necesario.
        Me.AgendaTableAdapter.Fill(Me.Agenda1DataSet.Agenda)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.AgendaTableAdapter.Editar(CodigoTextBox.Text, CedulaTextBox.Text, NombreTextBox.Text, Primer_apellidoTextBox.Text, Segundo_apellidoTextBox.Text, SexoTextBox.Text, Fecha_nacimientoTextBox.Text, TelefonoTextBox.Text, Correo_electronicoTextBox.Text, CodigoTextBox.Text)
        Me.AgendaTableAdapter.Fill(Me.Agenda1DataSet.Agenda)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.AgendaTableAdapter.FillBy(Agenda1DataSet.Agenda, CodigoTextBox.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class