Module DATOS_ELEMENTOS

    Public Structure Elemento
        Public A As Double
        Public Z As Integer
        Public Nombre As String
        Public Simbolo As String
        Public Valencia As String
        Public ConfigElectronica As String
    End Structure

    Public Elementos As New Dictionary(Of Integer, Elemento)

    Public Sub InicializarElementos()


        Elementos(1) = New Elemento With {
            .A = 1.008,
            .Z = 1,
            .Nombre = "Hidrógeno",
            .Simbolo = "H",
            .Valencia = "1",
            .ConfigElectronica = "1s¹"
        }

        Elementos(2) = New Elemento With {
            .A = 4.0026,
            .Z = 2,
            .Nombre = "Helio",
            .Simbolo = "He",
            .Valencia = "0",
            .ConfigElectronica = "1s²"
        }

        Elementos(3) = New Elemento With {
            .A = 6.94,
            .Z = 3,
            .Nombre = "Litio",
            .Simbolo = "Li",
            .Valencia = "1",
            .ConfigElectronica = "1s² 2s¹"
        }

    End Sub

End Module