Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AgregarEventosBotones(Me.Controls)
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
                    lblConfig.Text = el.ConfigElectronica

                    Dim lista = CalcularCuanticos(el.ConfigElectronica)
                    If lista.Count > 0 Then
                        Dim ult = lista(lista.Count - 1)
                        lblN.Text = ult.n
                        lblL.Text = ult.l
                        lblM.Text = ult.m
                        lblS.Text = ult.s
                    End If
                Else
                    lblNombre.Text = "Desconocido"
                    lblSimbolo.Text = ""
                    lblA.Text = ""
                    lblConfig.Text = ""
                    lblN.Text = ""
                    lblL.Text = ""
                    lblM.Text = ""
                    lblS.Text = ""
                End If
            End If
        Catch ex As Exception
            ' Ignorar errores
        End Try
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Hide()
        Form1.Show()  ' Muestra el Form1 existente sin crear uno nuevo
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class
