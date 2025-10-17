Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarElementos()
        AgregarEventosBotones(Me.Controls)
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
        Application.Exit()
    End Sub

    Private Sub AgregarEventosBotones(ctrls As Control.ControlCollection)
        For Each ctrl As Control In ctrls
            If TypeOf ctrl Is Button Then
                AddHandler CType(ctrl, Button).Click, AddressOf BotonElemento_Click
            End If

            If ctrl.HasChildren Then
                AgregarEventosBotones(ctrl.Controls)
            End If
        Next
    End Sub

    Private Sub BotonElemento_Click(sender As Object, e As EventArgs)
        Try
            Dim btn As Button = CType(sender, Button)
            Dim numeroStr As String = System.Text.RegularExpressions.Regex.Replace(btn.Name, "[^\d]", "")
            Dim z As Integer

            If Integer.TryParse(numeroStr, z) Then
                If Elementos.ContainsKey(z) Then
                    Dim el = Elementos(z)
                    lblZ.Text = el.Z.ToString()
                    lblNombre.Text = el.Nombre
                    lblSimbolo.Text = el.Simbolo
                    lblA.Text = el.A.ToString()
                    lblValencia.Text = el.Valencia
                    lblConfig.Text = el.ConfigElectronica
                    lblPuntoE.Text = el.PuntoDeEbullicion
                    lblPuntoF.Text = el.PuntoDeFusion
                    lblDensidad.Text = el.densidad
                Else
                    lblNombre.Text = "Desconocido"
                    lblSimbolo.Text = ""
                    lblA.Text = ""
                    lblValencia.Text = ""
                    lblConfig.Text = ""
                    lblPuntoE.Text = ""
                    lblPuntoF.Text = ""
                    lblDensidad.Text = ""
                End If

                lblNombre.BackColor = btn.BackColor
                lblNombre.ForeColor = btn.ForeColor
            End If
        Catch ex As Exception
            ' Ignorar cualquier error para que no se bloquee
        End Try
    End Sub

    Private Sub btnAbrirForm2_Click(sender As Object, e As EventArgs) Handles btnAbrirForm2.Click
        Dim f2 As New Form2()
        f2.Show()
        Me.Hide()
    End Sub
End Class