Public Class Form1
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()  'cierra la ventana
    End Sub

    Private Sub cambiarfondo_Click(sender As Object, e As EventArgs) Handles cambiarfondo.Click
        'Cambia el color de fondo
        If (ColorDialog1.ShowDialog() = DialogResult.OK) Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub borrarlaimagen_Click(sender As Object, e As EventArgs) Handles borrarlaimagen.Click
        'Elimina la imagen
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Mostrarunaimagen_Click(sender As Object, e As EventArgs) Handles Mostrarunaimagen.Click
        'Abre la imagen que el usuario quiera
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Ajusta la imagen
        If (CheckBox1.Checked) Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    'PAMELA RODRIGUEZ FLORIO
End Class
