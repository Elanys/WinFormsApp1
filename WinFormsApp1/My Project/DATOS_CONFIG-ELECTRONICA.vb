Module Cuanticos

    Public Class Cuantico
        Public Property n As Integer
        Public Property l As Integer
        Public Property m As Integer
        Public Property s As String
    End Class

    Public Function CalcularCuanticos(config As String, z As Integer) As List(Of Cuantico)
        Dim lista As New List(Of Cuantico)
        Dim partes = System.Text.RegularExpressions.Regex.Matches(config, "(\d)([spdf])([\u00B9\u00B2\u00B3\u2074-\u2079])")

        If partes.Count = 0 Then Return lista
        Dim ultimo = partes(partes.Count - 1)

        Dim n As Integer = CInt(ultimo.Groups(1).Value)
        Dim letra As Char = ultimo.Groups(2).Value(0)
        Dim super As Char = ultimo.Groups(3).Value(0)

        Dim electrones As Integer
        Select Case super
            Case "¹"c : electrones = 1
            Case "²"c : electrones = 2
            Case "³"c : electrones = 3
            Case "⁴"c : electrones = 4
            Case "⁵"c : electrones = 5
            Case "⁶"c : electrones = 6
            Case "⁷"c : electrones = 7
            Case "⁸"c : electrones = 8
            Case "⁹"c : electrones = 9
            Case Else : electrones = 0
        End Select

        Dim l As Integer
        Select Case letra
            Case "s"c : l = 0
            Case "p"c : l = 1
            Case "d"c : l = 2
            Case "f"c : l = 3
            Case Else : l = 0
        End Select

        Dim m As Integer = 0
        Dim spin As String = "+1/2"

        ' --- Excepciones para lantánidos y actínidos parcialmente llenos ---
        Dim excepcionF As Boolean = False
        Select Case z
            ' Ho, Er, Tm, Yb
            Case 66 : m = -1 : spin = "+1/2" : excepcionF = True
            Case 67 : m = 0 : spin = "+1/2" : excepcionF = True
            Case 68 : m = 1 : spin = "+1/2" : excepcionF = True
            Case 69 : m = 2 : spin = "+1/2" : excepcionF = True
            Case 70 : m = 3 : spin = "+1/2" : excepcionF = True
            ' Cf, Es, Fm, Md, No
            Case 98 : m = -3 : spin = "+1/2" : excepcionF = True
            Case 99 : m = -2 : spin = "+1/2" : excepcionF = True
            Case 100 : m = -1 : spin = "+1/2" : excepcionF = True
            Case 101 : m = 0 : spin = "+1/2" : excepcionF = True
            Case 102 : m = 1 : spin = "+1/2" : excepcionF = True
        End Select

        ' Si no es excepción, aplica cálculo general
        If Not excepcionF Then
            Select Case letra
                Case "s"c
                    m = 0
                    spin = If(electrones Mod 2 = 1, "+1/2", "-1/2")
                Case "p"c
                    If electrones <= 3 Then
                        m = -1 + (electrones - 1)
                        spin = "+1/2"
                    Else
                        m = -1 + (electrones - 4)
                        spin = "-1/2"
                    End If
                Case "d"c
                    If electrones <= 5 Then
                        m = -2 + (electrones - 1)
                        spin = "+1/2"
                    Else
                        m = -2 + (electrones - 6)
                        spin = "-1/2"
                    End If
                Case "f"c
                    If electrones <= 7 Then
                        m = -3 + (electrones - 1)
                        spin = "+1/2"
                    Else
                        m = -3 + (electrones - 8)
                        spin = "-1/2"
                    End If
            End Select
        End If

        lista.Add(New Cuantico With {.n = n, .l = l, .m = m, .s = spin})
        Return lista
    End Function

End Module