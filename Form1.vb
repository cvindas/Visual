Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "cristianvindas" And TextBox2.Text = "123456" Then
            MsgBox("correcto", , "login exitoso")
            Form2.Show()
            Me.Visible = False
        Else
            MsgBox("error")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If MsgBox("¿Desea salir de la Aplicacion?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
