Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarElementos()
    End Sub
    Private Sub BotonElemento_Click(sender As Object, e As EventArgs) Handles _
          Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click,
          Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click

        Dim btn As Button = CType(sender, Button)
        Dim z As Integer = Integer.Parse(btn.Name.Replace("Button", ""))

        If Elementos.ContainsKey(z) Then
            Dim el = Elementos(z)
            lblNombre.Text = el.Nombre
            lblSimbolo.Text = el.Simbolo
            lblA.Text = el.A.ToString()
            lblValencia.Text = el.Valencia
            lblConfig.Text = el.ConfigElectronica
        Else
            lblNombre.Text = "Desconocido"
            lblSimbolo.Text = ""
            lblA.Text = ""
            lblValencia.Text = ""
            lblConfig.Text = ""
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblValencia.Click

    End Sub
End Class