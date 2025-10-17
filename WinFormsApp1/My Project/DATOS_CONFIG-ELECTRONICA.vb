Module DATOS_CONFIG_ELECTRONICA
    Public Structure Cuantico
        Public n As Integer
        Public l As Integer
        Public m As Integer
        Public s As String
    End Structure


    Private Function Letra_a_L(letra As Char) As Integer
        Select Case letra
            Case "s"c : Return 0
            Case "p"c : Return 1
            Case "d"c : Return 2
            Case "f"c : Return 3
            Case Else : Return -1
        End Select
    End Function


    Public Function CalcularCuanticos(config As String) As List(Of Cuantico)
        Dim lista As New List(Of Cuantico)
        Dim partes = config.Split(" "c)

        For Each parte In partes

            Dim match = System.Text.RegularExpressions.Regex.Match(parte, "(\d+)([spdf])([¹²³⁴⁵⁶⁷⁸⁹]+)")
            If Not match.Success Then Continue For

            Dim nivel As Integer = Integer.Parse(match.Groups(1).Value)
            Dim letra As Char = match.Groups(2).Value(0)
            Dim l As Integer = Letra_a_L(letra)
            If l = -1 Then Continue For


            Dim electronesTexto As String = match.Groups(3).Value
            Dim electrones As Integer = 0
            For Each ch In electronesTexto
                Select Case ch
                    Case "¹"c : electrones += 1
                    Case "²"c : electrones += 2
                    Case "³"c : electrones += 3
                    Case "⁴"c : electrones += 4
                    Case "⁵"c : electrones += 5
                    Case "⁶"c : electrones += 6
                    Case "⁷"c : electrones += 7
                    Case "⁸"c : electrones += 8
                    Case "⁹"c : electrones += 9
                End Select
            Next


            For i = 1 To electrones
                Dim m = -l + ((i - 1) Mod (2 * l + 1))
                Dim s = If(i Mod 2 = 0, "-1/2", "+1/2")
                lista.Add(New Cuantico With {.n = nivel, .l = l, .m = m, .s = s})
            Next
        Next

        Return lista
    End Function

End Module