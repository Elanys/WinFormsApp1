Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarElementos()
        AgregarEventosBotones(Me.Controls)
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub AgregarEventosBotones(ctrls As Control.ControlCollection)
        For Each ctrl As Control In ctrls
            If TypeOf ctrl Is Button Then
                AddHandler CType(ctrl, Button).Click, AddressOf BotonElemento_Click
            End If
            ' Si el control tiene hijos (ej: Panel, GroupBox), recorrerlos también
            If ctrl.HasChildren Then
                AgregarEventosBotones(ctrl.Controls)
            End If
        Next
    End Sub
    Private Sub BotonElemento_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim z As Integer = Integer.Parse(System.Text.RegularExpressions.Regex.Replace(btn.Name, "[^\d]", ""))
        lblNombre.BackColor = btn.BackColor
        lblNombre.ForeColor = btn.ForeColor

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
    End Sub

End Class