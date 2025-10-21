Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AgregarEventosBotones(Me.Controls)
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
        AgregarEfectoElevacion(Me.Controls)
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
                    Dim lista = CalcularCuanticos(el.ConfigElectronica, el.Z)
                    If lista.Count > 0 Then
                        Dim ult = lista(lista.Count - 1)
                        lblN.Text = ult.n
                        lblL.Text = ult.l
                        lblM.Text = ult.m
                        lblS.Text = ult.s
                    End If
                End If



            Else
                ' Limpiar labels si no existe el elemento
                lblNombre.Text = "Desconocido"
                lblSimbolo.Text = ""
                lblA.Text = ""
                lblConfig.Text = ""
                lblN.Text = ""
                lblL.Text = ""
                lblM.Text = ""
                lblS.Text = ""
            End If
            lblNombre.BackColor = btn.BackColor
            lblNombre.ForeColor = btn.ForeColor
        Catch ex As Exception
            ' Ignorar errores
        End Try
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        For i = 1 To 100 Step 10
            Me.Opacity = (100 - i) / 100
            Application.DoEvents()
            Threading.Thread.Sleep(10)
        Next

        ' Mostrar el otro form
        Form1.Show()
        Me.Hide()

        ' Restaurar opacidad para cuando se vuelva a mostrar
        Me.Opacity = 1
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
        Application.Exit()
    End Sub
    Private Sub AgregarEfectoElevacion(ctrls As Control.ControlCollection)
        For Each ctrl As Control In ctrls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)

                ' --- Al presionar el botón ---
                AddHandler btn.MouseDown, Sub()
                                              btn.Top -= 3 ' se levanta 3 píxeles
                                              btn.FlatAppearance.BorderSize = 2
                                              btn.FlatAppearance.BorderColor = Color.DodgerBlue
                                          End Sub

                ' --- Al soltar el botón ---
                AddHandler btn.MouseUp, Sub()
                                            btn.Top += 3 ' vuelve a su posición
                                            btn.FlatAppearance.BorderSize = 1
                                            btn.FlatAppearance.BorderColor = Color.Gray
                                        End Sub
            End If

            ' Si hay controles dentro, aplicar también
            If ctrl.HasChildren Then
                AgregarEfectoElevacion(ctrl.Controls)
            End If
        Next
    End Sub


End Class