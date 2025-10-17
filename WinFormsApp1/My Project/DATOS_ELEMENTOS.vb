Module DATOS_ELEMENTOS

    Public Structure Elemento
        Public A As Double
        Public Z As Integer
        Public Nombre As String
        Public Simbolo As String
        Public Valencia As String
        Public ConfigElectronica As String
        Public PuntoDeEbullicion As String
        Public PuntoDeFusion As String
        Public densidad As String
        Public EstadoFisico As String
        Public Descubrimiento As String
        Public EnergiaIonizacion As String
        Public Dureza As String
        Public Conductividad As String
        Public Abundancia As String
        Public Descripcion As String
    End Structure

    Public Elementos As New Dictionary(Of Integer, Elemento)

    Public Sub InicializarElementos()

        Elementos(1) = New Elemento With {
            .A = 1.008,
            .Z = 1,
            .Nombre = "Hidrógeno",
            .Simbolo = "H",
            .Valencia = "1",
            .ConfigElectronica = "1s¹",
            .PuntoDeEbullicion = "-252.87 °C",
            .PuntoDeFusion = "-259.16 °C",
            .densidad = "0.0899 kg/m³",
            .EstadoFisico = "Gas",
            .Descubrimiento = "1766, Henry Cavendish",
            .EnergiaIonizacion = "13.598 eV",
            .Dureza = "No aplica",
            .Conductividad = "Baja",
            .Abundancia = "~75% del universo",
            .Descripcion = "El hidrógeno es el elemento más ligero y abundante del universo, esencial en la formación de estrellas y agua."
        }
        Elementos(2) = New Elemento With {
            .A = 4.002602,
            .Z = 2,
            .Nombre = "Helio",
            .Simbolo = "He",
            .Valencia = "0",
            .ConfigElectronica = "1s²",
            .PuntoDeEbullicion = "-268.93 °C",
            .PuntoDeFusion = "-272.20 °C",
            .densidad = "0.1786 kg/m³",
            .EstadoFisico = "Gas",
            .Descubrimiento = "1895, Sir William Ramsay",
            .EnergiaIonizacion = "24.5874 eV",
            .Dureza = "No aplica",
            .Conductividad = "Muy baja",
            .Abundancia = "Muy escaso en la corteza terrestre",
            .Descripcion = "El helio es un gas noble, inerte y ligero usado en criogenia y como gas de protección."
        }
        Elementos(3) = New Elemento With {
            .A = 6.94,
            .Z = 3,
            .Nombre = "Litio",
            .Simbolo = "Li",
            .Valencia = "1",
            .ConfigElectronica = "[He] 2s¹",
            .PuntoDeEbullicion = "1342 °C",
            .PuntoDeFusion = "180.54 °C",
            .densidad = "534 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1817, Johan August Arfwedson",
            .EnergiaIonizacion = "5.3917 eV",
            .Dureza = "No aplica",
            .Conductividad = "Buena",
            .Abundancia = "0.002 %",
            .Descripcion = "El litio es un metal alcalino suave y plateado, utilizado en baterías y en medicina."
        }
        Elementos(4) = New Elemento With {
            .A = 9.0122,
            .Z = 4,
            .Nombre = "Berilio",
            .Simbolo = "Be",
            .Valencia = "2",
            .ConfigElectronica = "[He] 2s²",
            .PuntoDeEbullicion = "2470 °C",
            .PuntoDeFusion = "1287 °C",
            .densidad = "1850 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1798, Louis-Nicolas Vauquelin",
            .EnergiaIonizacion = "9.3227 eV",
            .Dureza = "No aplica",
            .Conductividad = "Buena",
            .Abundancia = "0.0007 %",
            .Descripcion = "El berilio es un metal alcalino térreo que es ligero y tiene una alta dureza."
        }
        Elementos(5) = New Elemento With {
            .A = 10.81,
            .Z = 5,
            .Nombre = "Boro",
            .Simbolo = "B",
            .Valencia = "3",
            .ConfigElectronica = "[He] 2s² 2p¹",
            .PuntoDeEbullicion = "4000 °C",
            .PuntoDeFusion = "2076 °C",
            .densidad = "2340 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1808, Sir Humphry Davy",
            .EnergiaIonizacion = "8.298 eV",
            .Dureza = "No aplica",
            .Conductividad = "Buena",
            .Abundancia = "0.001 %",
            .Descripcion = "El boro es un elemento no metálico, esencial en la industria del vidrio y cerámica."
        }
        Elementos(6) = New Elemento With {
            .A = 12.011,
            .Z = 6,
            .Nombre = "Carbono",
            .Simbolo = "C",
            .Valencia = "4",
            .ConfigElectronica = "[He] 2s² 2p²",
            .PuntoDeEbullicion = "4827 °C",
            .PuntoDeFusion = "3550 °C",
            .densidad = "2267 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "Antigüedad",
            .EnergiaIonizacion = "11.2603 eV",
            .Dureza = "No aplica",
            .Conductividad = "Variable",
            .Abundancia = "0.02 %",
            .Descripcion = "El carbono es un no metal esencial para la vida, formando la base de la química orgánica."
        }
        Elementos(7) = New Elemento With {
            .A = 14.007,
            .Z = 7,
            .Nombre = "Nitrógeno",
            .Simbolo = "N",
            .Valencia = "3, 5",
            .ConfigElectronica = "[He] 2s² 2p³",
            .PuntoDeEbullicion = "-195.79 °C",
            .PuntoDeFusion = "-210.00 °C",
            .densidad = "1.2506 kg/m³",
            .EstadoFisico = "Gas",
            .Descubrimiento = "1772, Daniel Rutherford",
            .EnergiaIonizacion = "14.5341 eV",
            .Dureza = "No aplica",
            .Conductividad = "Muy baja",
            .Abundancia = "78% del aire",
            .Descripcion = "El nitrógeno es un gas incoloro e inodoro que forma parte del aire y es esencial para la vida."
        }
        Elementos(8) = New Elemento With {
            .A = 15.999,
            .Z = 8,
            .Nombre = "Oxígeno",
            .Simbolo = "O",
            .Valencia = "2",
            .ConfigElectronica = "[He] 2s² 2p⁴",
            .PuntoDeEbullicion = "-182.96 °C",
            .PuntoDeFusion = "-218.79 °C",
            .densidad = "1.429 kg/m³",
            .EstadoFisico = "Gas",
            .Descubrimiento = "1774, Joseph Priestley",
            .EnergiaIonizacion = "13.6181 eV",
            .Dureza = "No aplica",
            .Conductividad = "Baja",
            .Abundancia = "21% del aire",
            .Descripcion = "El oxígeno es un gas vital para la respiración de la mayoría de los seres vivos y es altamente reactivo."
        }
        Elementos(9) = New Elemento With {
            .A = 18.998403163,
            .Z = 9,
            .Nombre = "Flúor",
            .Simbolo = "F",
            .Valencia = "1",
            .ConfigElectronica = "[He] 2s² 2p⁵",
            .PuntoDeEbullicion = "-188.11 °C",
            .PuntoDeFusion = "-219.67 °C",
            .densidad = "1.696 kg/m³",
            .EstadoFisico = "Gas",
            .Descubrimiento = "1886, Henri Moissan",
            .EnergiaIonizacion = "17.4228 eV",
            .Dureza = "No aplica",
            .Conductividad = "Baja",
            .Abundancia = "0.00007 %",
            .Descripcion = "El flúor es un gas tóxico y reactivo, utilizado en la fabricación de ácido fluorhídrico y en la industria nuclear."
        }
        Elementos(10) = New Elemento With {
            .A = 20.1797,
            .Z = 10,
            .Nombre = "Neón",
            .Simbolo = "Ne",
            .Valencia = "0",
            .ConfigElectronica = "[He] 2s² 2p⁶",
            .PuntoDeEbullicion = "-246.08 °C",
            .PuntoDeFusion = "-248.59 °C",
            .densidad = "0.9002 kg/m³",
            .EstadoFisico = "Gas",
            .Descubrimiento = "1898, William Ramsay y Morris Travers",
            .EnergiaIonizacion = "21.5645 eV",
            .Dureza = "No aplica",
            .Conductividad = "Extremadamente baja",
            .Abundancia = "Muy escaso en la corteza terrestre",
            .Descripcion = "El neón es un gas noble, incoloro e inodoro, utilizado en señales de neón y como indicador en tubos electrónicos."
        }
        Elementos(11) = New Elemento With {
            .A = 22.98976928,
            .Z = 11,
            .Nombre = "Sodio",
            .Simbolo = "Na",
            .Valencia = "1",
            .ConfigElectronica = "[Ne] 3s¹",
            .PuntoDeEbullicion = "883 °C",
            .PuntoDeFusion = "97.79 °C",
            .densidad = "968 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1807, Humphry Davy",
            .EnergiaIonizacion = "5.1391 eV",
            .Dureza = "0.5",
            .Conductividad = "Buena",
            .Abundancia = "2.6% en la corteza terrestre",
            .Descripcion = "El sodio es un metal alcalino blando y plateado, fundamental en la biología celular y en la industria química."
        }
        Elementos(12) = New Elemento With {
            .A = 24.305,
            .Z = 12,
            .Nombre = "Magnesio",
            .Simbolo = "Mg",
            .Valencia = "2",
            .ConfigElectronica = "[Ne] 3s²",
            .PuntoDeEbullicion = "1090 °C",
            .PuntoDeFusion = "650 °C",
            .densidad = "1738 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1808, Humphry Davy",
            .EnergiaIonizacion = "7.6462 eV",
            .Dureza = "2.0",
            .Conductividad = "Buena",
            .Abundancia = "2.0% en la corteza terrestre",
            .Descripcion = "El magnesio es un metal ligero y resistente a la corrosión, utilizado en aleaciones y fuegos artificiales."
        }
        Elementos(13) = New Elemento With {
            .A = 26.9815385,
            .Z = 13,
            .Nombre = "Aluminio",
            .Simbolo = "Al",
            .Valencia = "3",
            .ConfigElectronica = "[Ne] 3s² 3p¹",
            .PuntoDeEbullicion = "2519 °C",
            .PuntoDeFusion = "660.32 °C",
            .densidad = "2700 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1825, Hans Christian Ørsted",
            .EnergiaIonizacion = "5.9858 eV",
            .Dureza = "2.75",
            .Conductividad = "Buena",
            .Abundancia = "8.1% en la corteza terrestre",
            .Descripcion = "El aluminio es un metal ligero, dúctil y maleable, ampliamente utilizado en construcción y envases."
        }
        Elementos(14) = New Elemento With {
            .A = 28.085,
            .Z = 14,
            .Nombre = "Silicio",
            .Simbolo = "Si",
            .Valencia = "4",
            .ConfigElectronica = "[Ne] 3s² 3p²",
            .PuntoDeEbullicion = "2900 °C",
            .PuntoDeFusion = "1414 °C",
            .densidad = "2329 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1824, Jöns Jakob Berzelius",
            .EnergiaIonizacion = "8.1517 eV",
            .Dureza = "7.0",
            .Conductividad = "Semiconductor",
            .Abundancia = "25.7% en la corteza terrestre",
            .Descripcion = "El silicio es un no metal, semiconductor, utilizado en electrónica y en la fabricación de vidrio."
        }
        Elementos(15) = New Elemento With {
            .A = 30.973761998,
            .Z = 15,
            .Nombre = "Fósforo",
            .Simbolo = "P",
            .Valencia = "3, 5",
            .ConfigElectronica = "[Ne] 3s² 3p³",
            .PuntoDeEbullicion = "280.5 °C",
            .PuntoDeFusion = "44.15 °C",
            .densidad = "1823 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1669, Hennig Brandt",
            .EnergiaIonizacion = "10.4885 eV",
            .Dureza = "1.0",
            .Conductividad = "Variable",
            .Abundancia = "0.06% en la corteza terrestre",
            .Descripcion = "El fósforo es un no metal esencial para la vida, presente en ADN, ARN y ATP."
        }
        Elementos(16) = New Elemento With {
            .A = 32.06,
            .Z = 16,
            .Nombre = "Azufre",
            .Simbolo = "S",
            .Valencia = "2, 4, 6",
            .ConfigElectronica = "[Ne] 3s² 3p⁴",
            .PuntoDeEbullicion = "444.6 °C",
            .PuntoDeFusion = "115.21 °C",
            .densidad = "2070 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "Antigüedad",
            .EnergiaIonizacion = "10.3608 eV",
            .Dureza = "3.0",
            .Conductividad = "No metal",
            .Abundancia = "0.03% en la corteza terrestre",
            .Descripcion = "El azufre es un no metal, esencial en la química orgánica y en la formación de ácidos."
        }
        Elementos(17) = New Elemento With {
            .A = 35.45,
            .Z = 17,
            .Nombre = "Cloro",
            .Simbolo = "Cl",
            .Valencia = "1, 3, 5, 7",
            .ConfigElectronica = "[Ne] 3s² 3p⁵",
            .PuntoDeEbullicion = "-34.04 °C",
            .PuntoDeFusion = "-101.5 °C",
            .densidad = "3.214 kg/m³",
            .EstadoFisico = "Gas",
            .Descubrimiento = "1774, Carl Wilhelm Scheele",
            .EnergiaIonizacion = "12.9676 eV",
            .Dureza = "No aplica",
            .Conductividad = "Baja",
            .Abundancia = "0.0002 %",
            .Descripcion = "El cloro es un gas tóxico y corrosivo, utilizado en desinfección y en la fabricación de productos químicos."
        }
        Elementos(18) = New Elemento With {
            .A = 39.948,
            .Z = 18,
            .Nombre = "Argón",
            .Simbolo = "Ar",
            .Valencia = "0",
            .ConfigElectronica = "[Ne] 3s² 3p⁶",
            .PuntoDeEbullicion = "-185.8 °C",
            .PuntoDeFusion = "-189.34 °C",
            .densidad = "1.784 kg/m³",
            .EstadoFisico = "Gas",
            .Descubrimiento = "1894, Lord Rayleigh y Sir William Ramsay",
            .EnergiaIonizacion = "15.7596 eV",
            .Dureza = "No aplica",
            .Conductividad = "Extremadamente baja",
            .Abundancia = "0.0007 %",
            .Descripcion = "El argón es un gas noble, incoloro e inodoro, utilizado en iluminación y como gas de protección en soldadura."
        }
        Elementos(19) = New Elemento With {
            .A = 39.0983,
            .Z = 19,
            .Nombre = "Potasio",
            .Simbolo = "K",
            .Valencia = "1",
            .ConfigElectronica = "[Ar] 4s¹",
            .PuntoDeEbullicion = "759 °C",
            .PuntoDeFusion = "63.38 °C",
            .densidad = "862 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1807, Sir Humphry Davy",
            .EnergiaIonizacion = "4.3407 eV",
            .Dureza = "0.4",
            .Conductividad = "Buena",
            .Abundancia = "2.4% en la corteza terrestre",
            .Descripcion = "El potasio es un metal alcalino blando, esencial en biología celular y en la industria química."
        }
        Elementos(20) = New Elemento With {
            .A = 40.078,
            .Z = 20,
            .Nombre = "Calcio",
            .Simbolo = "Ca",
            .Valencia = "2",
            .ConfigElectronica = "[Ar] 4s²",
            .PuntoDeEbullicion = "1484 °C",
            .PuntoDeFusion = "842 °C",
            .densidad = "1550 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1808, Sir Humphry Davy",
            .EnergiaIonizacion = "6.1132 eV",
            .Dureza = "1.75",
            .Conductividad = "Buena",
            .Abundancia = "3.6% en la corteza terrestre",
            .Descripcion = "El calcio es un mineral esencial para los seres vivos, formando parte de huesos y dientes."
        }
        Elementos(21) = New Elemento With {
            .A = 44.955908,
            .Z = 21,
            .Nombre = "Escandio",
            .Simbolo = "Sc",
            .Valencia = "3",
            .ConfigElectronica = "[Ar] 3d¹ 4s²",
            .PuntoDeEbullicion = "2836 °C",
            .PuntoDeFusion = "1541 °C",
            .densidad = "2985 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1879, Lars Fredrik Nilson",
            .EnergiaIonizacion = "6.5615 eV",
            .Dureza = "No aplica",
            .Conductividad = "Buena",
            .Abundancia = "0.002 %",
            .Descripcion = "El escandio es un metal de transición, utilizado en aleaciones y en la fabricación de luces fluorescentes."
        }
        Elementos(22) = New Elemento With {
            .A = 47.867,
            .Z = 22,
            .Nombre = "Titanio",
            .Simbolo = "Ti",
            .Valencia = "2, 3, 4",
            .ConfigElectronica = "[Ar] 3d² 4s²",
            .PuntoDeEbullicion = "3287 °C",
            .PuntoDeFusion = "1668 °C",
            .densidad = "4506 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1791, William Gregor",
            .EnergiaIonizacion = "6.8281 eV",
            .Dureza = "6.0",
            .Conductividad = "Buena",
            .Abundancia = "0.57% en la corteza terrestre",
            .Descripcion = "El titanio es un metal fuerte y ligero, resistente a la corrosión, usado en aleaciones y en medicina."
        }
        Elementos(23) = New Elemento With {
            .A = 50.9415,
            .Z = 23,
            .Nombre = "Vanadio",
            .Simbolo = "V",
            .Valencia = "2, 3, 4, 5",
            .ConfigElectronica = "[Ar] 3d³ 4s²",
            .PuntoDeEbullicion = "3407 °C",
            .PuntoDeFusion = "1910 °C",
            .densidad = "6110 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1801, Andrés Manuel del Río",
            .EnergiaIonizacion = "6.7462 eV",
            .Dureza = "No aplica",
            .Conductividad = "Buena",
            .Abundancia = "0.018 %",
            .Descripcion = "El vanadio es un metal de transición, utilizado en aleaciones de acero y en la fabricación de catalizadores."
        }
        Elementos(24) = New Elemento With {
            .A = 51.9961,
            .Z = 24,
            .Nombre = "Cromo",
            .Simbolo = "Cr",
            .Valencia = "2, 3, 6",
            .ConfigElectronica = "[Ar] 3d⁵ 4s¹",
            .PuntoDeEbullicion = "2671 °C",
            .PuntoDeFusion = "1907 °C",
            .densidad = "7190 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1797, Johann Lukas Al wein",
            .EnergiaIonizacion = "6.7665 eV",
            .Dureza = "8.5",
            .Conductividad = "Buena",
            .Abundancia = "0.014 %",
            .Descripcion = "El cromo es un metal de transición brillante y duro, utilizado en aleaciones y recubrimientos."
        }
        Elementos(25) = New Elemento With {
            .A = 54.938044,
            .Z = 25,
            .Nombre = "Manganeso",
            .Simbolo = "Mn",
            .Valencia = "2, 3, 4, 6, 7",
            .ConfigElectronica = "[Ar] 3d⁵ 4s²",
            .PuntoDeEbullicion = "2061 °C",
            .PuntoDeFusion = "1246 °C",
            .densidad = "7440 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1774, Johan Gottlieb Gahn",
            .EnergiaIonizacion = "7.434 eV",
            .Dureza = "6.0",
            .Conductividad = "Buena",
            .Abundancia = "0.1% en la corteza terrestre",
            .Descripcion = "El manganeso es un metal de transición, utilizado en la fabricación de acero y en la industria química."
        }
        Elementos(26) = New Elemento With {
            .A = 55.845,
            .Z = 26,
            .Nombre = "Hierro",
            .Simbolo = "Fe",
            .Valencia = "2, 3",
            .ConfigElectronica = "[Ar] 3d⁶ 4s²",
            .PuntoDeEbullicion = "2862 °C",
            .PuntoDeFusion = "1538 °C",
            .densidad = "7874 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "Antigüedad",
            .EnergiaIonizacion = "7.9024 eV",
            .Dureza = "4.0",
            .Conductividad = "Buena",
            .Abundancia = "5.0% en la corteza terrestre",
            .Descripcion = "El hierro es un metal de transición, esencial en la fabricación de acero y en procesos biológicos."
        }
        Elementos(27) = New Elemento With {
            .A = 58.933194,
            .Z = 27,
            .Nombre = "Cobalto",
            .Simbolo = "Co",
            .Valencia = "2, 3",
            .ConfigElectronica = "[Ar] 3d⁷ 4s²",
            .PuntoDeEbullicion = "2927 °C",
            .PuntoDeFusion = "1495 °C",
            .densidad = "8900 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1735, Georg Brandt",
            .EnergiaIonizacion = "7.8604 eV",
            .Dureza = "5.0",
            .Conductividad = "Buena",
            .Abundancia = "0.0026% en la corteza terrestre",
            .Descripcion = "El cobalto es un metal de transición, utilizado en imanes, aleaciones y en la industria nuclear."
        }
        Elementos(28) = New Elemento With {
            .A = 58.6934,
            .Z = 28,
            .Nombre = "Níquel",
            .Simbolo = "Ni",
            .Valencia = "2, 3",
            .ConfigElectronica = "[Ar] 3d⁸ 4s²",
            .PuntoDeEbullicion = "2730 °C",
            .PuntoDeFusion = "1455 °C",
            .densidad = "8908 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1751, Axel Fredrik Cronstedt",
            .EnergiaIonizacion = "7.6368 eV",
            .Dureza = "4.0",
            .Conductividad = "Buena",
            .Abundancia = "0.008% en la corteza terrestre",
            .Descripcion = "El níquel es un metal de transición, resistente a la corrosión, utilizado en monedas y baterías."
        }
        Elementos(29) = New Elemento With {
            .A = 63.546,
            .Z = 29,
            .Nombre = "Cobre",
            .Simbolo = "Cu",
            .Valencia = "1, 2",
            .ConfigElectronica = "[Ar] 3d¹⁰ 4s¹",
            .PuntoDeEbullicion = "2562 °C",
            .PuntoDeFusion = "1084.62 °C",
            .densidad = "8960 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "Antigüedad",
            .EnergiaIonizacion = "7.7264 eV",
            .Dureza = "2.5",
            .Conductividad = "Excelente",
            .Abundancia = "0.0068% en la corteza terrestre",
            .Descripcion = "El cobre es un metal de transición, utilizado ampliamente en electricidad, plomería y fabricación de aleaciones."
        }
        Elementos(30) = New Elemento With {
            .A = 65.38,
            .Z = 30,
            .Nombre = "Zinc",
            .Simbolo = "Zn",
            .Valencia = "2",
            .ConfigElectronica = "[Ar] 3d¹⁰ 4s²",
            .PuntoDeEbullicion = "907 °C",
            .PuntoDeFusion = "419.53 °C",
            .densidad = "7140 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1746, Andreas Marggraf",
            .EnergiaIonizacion = "9.3942 eV",
            .Dureza = "2.5",
            .Conductividad = "Buena",
            .Abundancia = "0.0075% en la corteza terrestre",
            .Descripcion = "El zinc es un metal de transición, utilizado principalmente en galvanizado y en la fabricación de aleaciones."
        }
        Elementos(31) = New Elemento With {
            .A = 69.723,
            .Z = 31,
            .Nombre = "Galio",
            .Simbolo = "Ga",
            .Valencia = "3",
            .ConfigElectronica = "[Ar] 3d¹⁰ 4s² 4p¹",
            .PuntoDeEbullicion = "2403 °C",
            .PuntoDeFusion = "29.76 °C",
            .densidad = "5907 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1875, Paul Émile Lecoq de Boisbaudran",
            .EnergiaIonizacion = "5.999 eV",
            .Dureza = "1.5",
            .Conductividad = "Buena",
            .Abundancia = "0.0007% en la corteza terrestre",
            .Descripcion = "El galio es un metal blando y pegajoso que se funde cerca de la temperatura ambiente, utilizado en termómetros y semiconductores."
        }
        Elementos(32) = New Elemento With {
            .A = 72.63,
            .Z = 32,
            .Nombre = "Germanio",
            .Simbolo = "Ge",
            .Valencia = "2, 4",
            .ConfigElectronica = "[Ar] 3d¹⁰ 4s² 4p²",
            .PuntoDeEbullicion = "2833 °C",
            .PuntoDeFusion = "938.25 °C",
            .densidad = "5323 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1886, Clemens Winkler",
            .EnergiaIonizacion = "7.8994 eV",
            .Dureza = "5.5",
            .Conductividad = "Semiconductor",
            .Abundancia = "0.0015% en la corteza terrestre",
            .Descripcion = "El germanio es un semiconductor utilizado en electrónica, óptica y en la fabricación de fibra óptica."
        }
        Elementos(33) = New Elemento With {
            .A = 74.921595,
            .Z = 33,
            .Nombre = "Arsénico",
            .Simbolo = "As",
            .Valencia = "3, 5",
            .ConfigElectronica = "[Ar] 3d¹⁰ 4s² 4p³",
            .PuntoDeEbullicion = "613 °C (sublima)",
            .PuntoDeFusion = "817 °C (a presión alta)",
            .densidad = "5730 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1250 a.C., en China",
            .EnergiaIonizacion = "9.815 eV",
            .Dureza = "3.5",
            .Conductividad = "Variable",
            .Abundancia = "0.0009% en la corteza terrestre",
            .Descripcion = "El arsénico es un metaloide, utilizado en aleaciones, semiconductores y insecticidas."
        }
        Elementos(34) = New Elemento With {
            .A = 78.971,
            .Z = 34,
            .Nombre = "Selenio",
            .Simbolo = "Se",
            .Valencia = "−2, 2, 4, 6",
            .ConfigElectronica = "[Ar] 3d¹⁰ 4s² 4p⁴",
            .PuntoDeEbullicion = "685 °C",
            .PuntoDeFusion = "221 °C",
            .densidad = "4790 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1817, Jöns Jakob Berzelius y Heinrich Rose",
            .EnergiaIonizacion = "9.7524 eV",
            .Dureza = "No aplica",
            .Conductividad = "Variable",
            .Abundancia = "0.00015% en la corteza terrestre",
            .Descripcion = "El selenio es un no metal, utilizado en rectificadores, fotocopiadoras y como aditivo en acero inoxidable."
        }
        Elementos(35) = New Elemento With {
            .A = 79.904,
            .Z = 35,
            .Nombre = "Bromo",
            .Simbolo = "Br",
            .Valencia = "−1, 1, 3, 5, 7",
            .ConfigElectronica = "[Ar] 3d¹⁰ 4s² 4p⁵",
            .PuntoDeEbullicion = "58.8 °C",
            .PuntoDeFusion = "−7.2 °C",
            .densidad = "3120 kg/m³",
            .EstadoFisico = "Líquido",
            .Descubrimiento = "1826, Antoine Jérôme Balard",
            .EnergiaIonizacion = "11.813 eV",
            .Dureza = "No aplica",
            .Conductividad = "Baja",
            .Abundancia = "0.0002% en la corteza terrestre",
            .Descripcion = "El bromo es un no metal, utilizado en la fabricación de productos químicos, pesticidas y como disolvente."
        }
        Elementos(36) = New Elemento With {
            .A = 83.798,
            .Z = 36,
            .Nombre = "Kriptón",
            .Simbolo = "Kr",
            .Valencia = "0",
            .ConfigElectronica = "[Ar] 3d¹⁰ 4s² 4p⁶",
            .PuntoDeEbullicion = "−153.22 °C",
            .PuntoDeFusion = "−157.36 °C",
            .densidad = "3.749 kg/m³",
            .EstadoFisico = "Gas",
            .Descubrimiento = "1898, William Ramsay y Morris Travers",
            .EnergiaIonizacion = "24.991 eV",
            .Dureza = "No aplica",
            .Conductividad = "Muy baja",
            .Abundancia = "0.0001% en la corteza terrestre",
            .Descripcion = "El kriptón es un gas noble, utilizado en iluminación, láseres y como medio de aislamiento."
        }
        Elementos(37) = New Elemento With {
            .A = 85.4678,
            .Z = 37,
            .Nombre = "Rubidio",
            .Simbolo = "Rb",
            .Valencia = "1",
            .ConfigElectronica = "[Kr] 5s¹",
            .PuntoDeEbullicion = "688 °C",
            .PuntoDeFusion = "39.31 °C",
            .densidad = "1532 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1861, Robert Bunsen y Gustav Kirchhoff",
            .EnergiaIonizacion = "4.1771 eV",
            .Dureza = "0.3",
            .Conductividad = "Buena",
            .Abundancia = "0.0007% en la corteza terrestre",
            .Descripcion = "El rubidio es un metal alcalino blando, utilizado en investigaciones químicas y en la fabricación de bombas de vacío."
        }
        Elementos(38) = New Elemento With {
            .A = 87.62,
            .Z = 38,
            .Nombre = "Estroncio",
            .Simbolo = "Sr",
            .Valencia = "2",
            .ConfigElectronica = "[Kr] 5s²",
            .PuntoDeEbullicion = "1382 °C",
            .PuntoDeFusion = "777 °C",
            .densidad = "2630 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1790, William Cruickshank",
            .EnergiaIonizacion = "5.693 eV",
            .Dureza = "1.5",
            .Conductividad = "Buena",
            .Abundancia = "0.0004% en la corteza terrestre",
            .Descripcion = "El estroncio es un metal alcalino terrestre, utilizado en pirotecnia y en la fabricación de imanes."
        }
        Elementos(39) = New Elemento With {
            .A = 88.90584,
            .Z = 39,
            .Nombre = "Itrio",
            .Simbolo = "Y",
            .Valencia = "3",
            .ConfigElectronica = "[Kr] 4d¹ 5s²",
            .PuntoDeEbullicion = "3338 °C",
            .PuntoDeFusion = "1526 °C",
            .densidad = "4472 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1794, Johan Gadolin",
            .EnergiaIonizacion = "6.2177 eV",
            .Dureza = "No aplica",
            .Conductividad = "Buena",
            .Abundancia = "0.003% en la corteza terrestre",
            .Descripcion = "El itrío es un metal de transición, utilizado en la fabricación de superconductores y en la industria de pantallas fluorescentes."
        }
        Elementos(40) = New Elemento With {
            .A = 91.224,
            .Z = 40,
            .Nombre = "Zirconio",
            .Simbolo = "Zr",
            .Valencia = "4",
            .ConfigElectronica = "[Kr] 4d² 5s²",
            .PuntoDeEbullicion = "4377 °C",
            .PuntoDeFusion = "1855 °C",
            .densidad = "6505 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1789, Martin Heinrich Klaproth",
            .EnergiaIonizacion = "6.6339 eV",
            .Dureza = "6.5",
            .Conductividad = "Buena",
            .Abundancia = "0.014% en la corteza terrestre",
            .Descripcion = "El zirconio es un metal de transición, resistente a la corrosión, utilizado en la fabricación de cerámicas y en medicina."
        }
        Elementos(41) = New Elemento With {
            .A = 92.91,
            .Z = 41,
            .Nombre = "Niobio",
            .Simbolo = "Nb",
            .Valencia = "3, 5",
            .ConfigElectronica = "[Kr] 4d⁴ 5s¹",
            .PuntoDeEbullicion = "4744 °C",
            .PuntoDeFusion = "2477 °C",
            .densidad = "8570 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1801, Charles Hatchett",
            .EnergiaIonizacion = "6.7594 eV",
            .Dureza = "Niobio",
            .Conductividad = "Buena",
            .Abundancia = "0.0007% en la corteza terrestre",
            .Descripcion = "El niobio es un metal de transición, utilizado en aleaciones especiales y en la fabricación de superconectores."
        }
        Elementos(42) = New Elemento With {
            .A = 95.95,
            .Z = 42,
            .Nombre = "Molibdeno",
            .Simbolo = "Mo",
            .Valencia = "2, 3, 4, 6",
            .ConfigElectronica = "[Kr] 4d⁵ 5s¹",
            .PuntoDeEbullicion = "4639 °C",
            .PuntoDeFusion = "2623 °C",
            .densidad = "10220 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1778, Carl Wilhelm Scheele",
            .EnergiaIonizacion = "7.0924 eV",
            .Dureza = "5.5",
            .Conductividad = "Buena",
            .Abundancia = "0.0002% en la corteza terrestre",
            .Descripcion = "El molibdeno es un metal de transición, utilizado en la fabricación de aceros especiales y en lubricantes."
        }
        Elementos(43) = New Elemento With {
            .A = 98,
            .Z = 43,
            .Nombre = "Tecnecio",
            .Simbolo = "Tc",
            .Valencia = "4, 6, 7",
            .ConfigElectronica = "[Kr] 4d⁵ 5s²",
            .PuntoDeEbullicion = "4265 °C",
            .PuntoDeFusion = "2157 °C",
            .densidad = "11500 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1937, Carlo Perrier y Emilio Segrè",
            .EnergiaIonizacion = "6.6239 eV",
            .Dureza = "No aplica",
            .Conductividad = "Variable",
            .Abundancia = "No tiene isotopía estable",
            .Descripcion = "El tecnecio es un elemento radiactivo, utilizado en medicina nuclear y en investigación."
        }
        Elementos(44) = New Elemento With {
    .A = 101.07, .Z = 44, .Nombre = "Rutenio", .Simbolo = "Ru", .Valencia = "2, 3, 4, 6, 8", .ConfigElectronica = "[Kr] 4d⁷ 5s¹", .PuntoDeEbullicion = "4150 °C", .PuntoDeFusion = "2334 °C", .densidad = "12370 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1844, Karl Ernst Claus", .EnergiaIonizacion = "7.3605 eV", .Dureza = "Alta", .Conductividad = "Buena", .Abundancia = "Muy rara en la corteza terrestre", .Descripcion = "El rutenio es un metal de transición del grupo del platino, usado en contactos eléctricos y aleaciones especiales."
}
        Elementos(45) = New Elemento With {
    .A = 102.91, .Z = 45, .Nombre = "Rodio", .Simbolo = "Rh", .Valencia = "3", .ConfigElectronica = "[Kr] 4d⁸ 5s¹", .PuntoDeEbullicion = "3968 °C", .PuntoDeFusion = "1964 °C", .densidad = "12450 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1803, William Hyde Wollaston", .EnergiaIonizacion = "7.4589 eV", .Dureza = "Alta", .Conductividad = "Buena", .Abundancia = "Muy rara en la corteza terrestre", .Descripcion = "El rodio es un metal precioso, muy resistente a la corrosión, usado en catalizadores y joyería."
}
        Elementos(46) = New Elemento With {
    .A = 106.42, .Z = 46, .Nombre = "Paladio", .Simbolo = "Pd", .Valencia = "2, 4", .ConfigElectronica = "[Kr] 4d¹⁰", .PuntoDeEbullicion = "2963 °C", .PuntoDeFusion = "1554.9 °C", .densidad = "12023 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1803, William Hyde Wollaston", .EnergiaIonizacion = "8.3369 eV", .Dureza = "Media", .Conductividad = "Buena", .Abundancia = "Muy rara en la corteza terrestre", .Descripcion = "El paladio es un metal del grupo del platino, usado en catalizadores y electrónica."
}
        Elementos(47) = New Elemento With {
    .A = 107.87, .Z = 47, .Nombre = "Plata", .Simbolo = "Ag", .Valencia = "1", .ConfigElectronica = "[Kr] 4d¹⁰ 5s¹", .PuntoDeEbullicion = "2162 °C", .PuntoDeFusion = "961.78 °C", .densidad = "10490 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "Antigüedad", .EnergiaIonizacion = "7.5762 eV", .Dureza = "Blanda", .Conductividad = "Excelente", .Abundancia = "0.075 ppm en la corteza terrestre", .Descripcion = "La plata es un metal precioso, excelente conductor eléctrico, usado en joyería y electrónica."
}
        Elementos(48) = New Elemento With {
    .A = 112.41, .Z = 48, .Nombre = "Cadmio", .Simbolo = "Cd", .Valencia = "2", .ConfigElectronica = "[Kr] 4d¹⁰ 5s²", .PuntoDeEbullicion = "767 °C", .PuntoDeFusion = "321.07 °C", .densidad = "8650 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1817, Friedrich Stromeyer", .EnergiaIonizacion = "8.9938 eV", .Dureza = "Blanda", .Conductividad = "Buena", .Abundancia = "0.1 ppm en la corteza terrestre", .Descripcion = "El cadmio es un metal tóxico, usado en baterías y recubrimientos."
}
        Elementos(49) = New Elemento With {
    .A = 114.82, .Z = 49, .Nombre = "Indio", .Simbolo = "In", .Valencia = "1, 3", .ConfigElectronica = "[Kr] 4d¹⁰ 5s² 5p¹", .PuntoDeEbullicion = "2072 °C", .PuntoDeFusion = "156.6 °C", .densidad = "7300 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1863, Ferdinand Reich y Theodor Richter", .EnergiaIonizacion = "5.7864 eV", .Dureza = "Blanda", .Conductividad = "Buena", .Abundancia = "0.25 ppm en la corteza terrestre", .Descripcion = "El indio es un metal blando, usado en pantallas y semiconductores."
}
        Elementos(50) = New Elemento With {
    .A = 118.71, .Z = 50, .Nombre = "Estaño", .Simbolo = "Sn", .Valencia = "2, 4", .ConfigElectronica = "[Kr] 4d¹⁰ 5s² 5p²", .PuntoDeEbullicion = "2602 °C", .PuntoDeFusion = "231.93 °C", .densidad = "7287 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "Antigüedad", .EnergiaIonizacion = "7.3439 eV", .Dureza = "Blanda", .Conductividad = "Buena", .Abundancia = "2.2 ppm en la corteza terrestre", .Descripcion = "El estaño es un metal maleable, usado en soldaduras y recubrimientos."
}
        Elementos(51) = New Elemento With {
    .A = 121.76, .Z = 51, .Nombre = "Antimonio", .Simbolo = "Sb", .Valencia = "3, 5", .ConfigElectronica = "[Kr] 4d¹⁰ 5s² 5p³", .PuntoDeEbullicion = "1750 °C", .PuntoDeFusion = "630.63 °C", .densidad = "6690 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "Antigüedad", .EnergiaIonizacion = "8.6084 eV", .Dureza = "Media", .Conductividad = "Semimetálica", .Abundancia = "0.2 ppm en la corteza terrestre", .Descripcion = "El antimonio es un metaloide usado en aleaciones y retardantes de llama."
}
        Elementos(52) = New Elemento With {
    .A = 127.6, .Z = 52, .Nombre = "Telurio", .Simbolo = "Te", .Valencia = "2, 4, 6", .ConfigElectronica = "[Kr] 4d¹⁰ 5s² 5p⁴", .PuntoDeEbullicion = "988 °C", .PuntoDeFusion = "449.51 °C", .densidad = "6230 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1782, Franz-Joseph Müller von Reichenstein", .EnergiaIonizacion = "9.0096 eV", .Dureza = "Media", .Conductividad = "Semimetálica", .Abundancia = "0.001 ppm en la corteza terrestre", .Descripcion = "El telurio es un metaloide raro, usado en aleaciones y semiconductores."
}
        Elementos(53) = New Elemento With {
    .A = 126.9, .Z = 53, .Nombre = "Yodo", .Simbolo = "I", .Valencia = "1, 3, 5, 7", .ConfigElectronica = "[Kr] 4d¹⁰ 5s² 5p⁵", .PuntoDeEbullicion = "184.3 °C", .PuntoDeFusion = "113.7 °C", .densidad = "4930 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1811, Bernard Courtois", .EnergiaIonizacion = "10.4513 eV", .Dureza = "Media", .Conductividad = "Aislante", .Abundancia = "0.45 ppm en la corteza terrestre", .Descripcion = "El yodo es un halógeno esencial para la vida, usado en medicina y desinfectantes."
}
        Elementos(54) = New Elemento With {
    .A = 131.29, .Z = 54, .Nombre = "Xenón", .Simbolo = "Xe", .Valencia = "0, 2, 4, 6, 8", .ConfigElectronica = "[Kr] 4d¹⁰ 5s² 5p⁶", .PuntoDeEbullicion = "-108.12 °C", .PuntoDeFusion = "-111.79 °C", .densidad = "5.894 kg/m³", .EstadoFisico = "Gas", .Descubrimiento = "1898, William Ramsay y Morris Travers", .EnergiaIonizacion = "12.1298 eV", .Dureza = "No aplica", .Conductividad = "Muy baja", .Abundancia = "0.0000087% atmósfera", .Descripcion = "El xenón es un gas noble, usado en lámparas y anestesia."
}
        Elementos(55) = New Elemento With {
    .A = 132.91, .Z = 55, .Nombre = "Cesio", .Simbolo = "Cs", .Valencia = "1", .ConfigElectronica = "[Xe] 6s¹", .PuntoDeEbullicion = "671 °C", .PuntoDeFusion = "28.44 °C", .densidad = "1879 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1860, Robert Bunsen y Gustav Kirchhoff", .EnergiaIonizacion = "3.8939 eV", .Dureza = "Blanda", .Conductividad = "Buena", .Abundancia = "3 ppm en la corteza terrestre", .Descripcion = "El cesio es un metal alcalino muy reactivo, usado en relojes atómicos."
}
        Elementos(56) = New Elemento With {
    .A = 137.33, .Z = 56, .Nombre = "Bario", .Simbolo = "Ba", .Valencia = "2", .ConfigElectronica = "[Xe] 6s²", .PuntoDeEbullicion = "1897 °C", .PuntoDeFusion = "727 °C", .densidad = "3500 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1808, Sir Humphry Davy", .EnergiaIonizacion = "5.2117 eV", .Dureza = "Blanda", .Conductividad = "Buena", .Abundancia = "425 ppm en la corteza terrestre", .Descripcion = "El bario es un metal alcalinotérreo, usado en fuegos artificiales y radiología."
}
        Elementos(57) = New Elemento With {
    .A = 138.91, .Z = 57, .Nombre = "Lantano", .Simbolo = "La", .Valencia = "3", .ConfigElectronica = "[Xe] 5d¹ 6s²", .PuntoDeEbullicion = "3464 °C", .PuntoDeFusion = "920 °C", .densidad = "6150 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1839, Carl Gustaf Mosander", .EnergiaIonizacion = "5.5769 eV", .Dureza = "Media", .Conductividad = "Buena", .Abundancia = "39 ppm en la corteza terrestre", .Descripcion = "El lantano es un lantánido, usado en lentes y baterías recargables."
}
        Elementos(58) = New Elemento With {
    .A = 140.12, .Z = 58, .Nombre = "Cerio", .Simbolo = "Ce", .Valencia = "3, 4", .ConfigElectronica = "[Xe] 4f¹ 5d¹ 6s²", .PuntoDeEbullicion = "3426 °C", .PuntoDeFusion = "798 °C", .densidad = "6720 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1803, Jöns Jacob Berzelius", .EnergiaIonizacion = "5.5387 eV", .Dureza = "Media", .Conductividad = "Buena", .Abundancia = "66 ppm en la corteza terrestre", .Descripcion = "El cerio es un lantánido, usado en catalizadores y pulimentos."
}
        Elementos(59) = New Elemento With {
    .A = 140.91, .Z = 59, .Nombre = "Praseodimio", .Simbolo = "Pr", .Valencia = "3, 4", .ConfigElectronica = "[Xe] 4f³ 6s²", .PuntoDeEbullicion = "3127 °C", .PuntoDeFusion = "931 °C", .densidad = "6730 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1885, Carl Auer von Welsbach", .EnergiaIonizacion = "5.473 eV", .Dureza = "Media", .Conductividad = "Buena", .Abundancia = "9.5 ppm en la corteza terrestre", .Descripcion = "El praseodimio es un lantánido, usado en imanes y vidrios especiales."
}
        Elementos(60) = New Elemento With {
    .A = 144.24, .Z = 60, .Nombre = "Neodimio", .Simbolo = "Nd", .Valencia = "2, 3", .ConfigElectronica = "[Xe] 4f⁴ 6s²", .PuntoDeEbullicion = "3074 °C", .PuntoDeFusion = "1024 °C", .densidad = "7240 kg/m³", .EstadoFisico = "Sólido", .Descubrimiento = "1885, Carl Auer von Welsbach", .EnergiaIonizacion = "5.525 eV", .Dureza = "Media", .Conductividad = "Buena", .Abundancia = "41.5 ppm en la corteza terrestre", .Descripcion = "El neodimio es un lantánido, usado en imanes potentes y láseres."
}
        Elementos(61) = New Elemento With {
            .A = 145,
            .Z = 61,
            .Nombre = "Prometio",
            .Simbolo = "Pm",
            .Valencia = "3",
            .ConfigElectronica = "[Xe] 4f⁵ 6s²",
            .PuntoDeEbullicion = "3000 °C",
            .PuntoDeFusion = "1100 °C",
            .densidad = "7400 kg/m³"
        }

        Elementos(62) = New Elemento With {
            .A = 150.36,
            .Z = 62,
            .Nombre = "Samario",
            .Simbolo = "Sm",
            .Valencia = "2, 3",
            .ConfigElectronica = "[Xe] 4f⁶ 6s²",
            .PuntoDeEbullicion = "1794 °C",
            .PuntoDeFusion = "1072 °C",
            .densidad = "7310 kg/m³"
        }

        Elementos(63) = New Elemento With {
            .A = 151.96,
            .Z = 63,
            .Nombre = "Europio",
            .Simbolo = "Eu",
            .Valencia = "2, 3",
            .ConfigElectronica = "[Xe] 4f⁷ 6s²",
            .PuntoDeEbullicion = "1529 °C",
            .PuntoDeFusion = "822 °C",
            .densidad = "5240 kg/m³"
        }

        Elementos(64) = New Elemento With {
            .A = 157.25,
            .Z = 64,
            .Nombre = "Gadolinio",
            .Simbolo = "Gd",
            .Valencia = "3",
            .ConfigElectronica = "[Xe] 4f⁷ 5d¹ 6s²",
            .PuntoDeEbullicion = "3273 °C",
            .PuntoDeFusion = "1313 °C",
            .densidad = "7900 kg/m³"
        }

        Elementos(65) = New Elemento With {
            .A = 158.93,
            .Z = 65,
            .Nombre = "Terbio",
            .Simbolo = "Tb",
            .Valencia = "3, 4",
            .ConfigElectronica = "[Xe] 4f⁹ 6s²",
            .PuntoDeEbullicion = "3503 °C",
            .PuntoDeFusion = "1356 °C",
            .densidad = "8200 kg/m³"
        }

        Elementos(66) = New Elemento With {
            .A = 162.5,
            .Z = 66,
            .Nombre = "Disprosio",
            .Simbolo = "Dy",
            .Valencia = "3",
            .ConfigElectronica = "[Xe] 4f¹⁰ 6s²",
            .PuntoDeEbullicion = "2567 °C",
            .PuntoDeFusion = "1412 °C",
            .densidad = "8500 kg/m³"
        }

        Elementos(67) = New Elemento With {
            .A = 164.93,
            .Z = 67,
            .Nombre = "Holmio",
            .Simbolo = "Ho",
            .Valencia = "3",
            .ConfigElectronica = "[Xe] 4f¹¹ 6s²",
            .PuntoDeEbullicion = "2700 °C",
            .PuntoDeFusion = "1474 °C",
            .densidad = "8790 kg/m³"
        }

        Elementos(68) = New Elemento With {
            .A = 167.26,
            .Z = 68,
            .Nombre = "Erbio",
            .Simbolo = "Er",
            .Valencia = "3",
            .ConfigElectronica = "[Xe] 4f¹² 6s²",
            .PuntoDeEbullicion = "2868 °C",
            .PuntoDeFusion = "1529 °C",
            .densidad = "9060 kg/m³"
        }

        Elementos(69) = New Elemento With {
            .A = 168.93,
            .Z = 69,
            .Nombre = "Tulio",
            .Simbolo = "Tm",
            .Valencia = "2, 3",
            .ConfigElectronica = "[Xe] 4f¹³ 6s²",
            .PuntoDeEbullicion = "1950 °C",
            .PuntoDeFusion = "1545 °C",
            .densidad = "9320 kg/m³"
        }

        Elementos(70) = New Elemento With {
            .A = 173.04,
            .Z = 70,
            .Nombre = "Iterbio",
            .Simbolo = "Yb",
            .Valencia = "2, 3",
            .ConfigElectronica = "[Xe] 4f¹⁴ 6s²",
            .PuntoDeEbullicion = "1196 °C",
            .PuntoDeFusion = "824 °C",
            .densidad = "6270 kg/m³"
        }

        Elementos(71) = New Elemento With {
            .A = 174.97,
            .Z = 71,
            .Nombre = "Lutecio",
            .Simbolo = "Lu",
            .Valencia = "3",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d¹ 6s²",
            .PuntoDeEbullicion = "3402 °C",
            .PuntoDeFusion = "1663 °C",
            .densidad = "9400 kg/m³"
}

        Elementos(72) = New Elemento With {
            .A = 178.49,
            .Z = 72,
            .Nombre = "Hafnio",
            .Simbolo = "Hf",
            .Valencia = "4",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d² 6s²",
            .PuntoDeEbullicion = "5400 °C",
            .PuntoDeFusion = "2233 °C",
            .densidad = "13310 kg/m³"
        }

        Elementos(73) = New Elemento With {
            .A = 180.95,
            .Z = 73,
            .Nombre = "Tantalio",
            .Simbolo = "Ta",
            .Valencia = "5",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d³ 6s²",
            .PuntoDeEbullicion = "5458 °C",
            .PuntoDeFusion = "3017 °C",
            .densidad = "16650 kg/m³"
}

        Elementos(74) = New Elemento With {
            .A = 183.84,
            .Z = 74,
            .Nombre = "Wolframio",
            .Simbolo = "W",
            .Valencia = "4, 6",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d⁴ 6s²",
            .PuntoDeEbullicion = "5555 °C",
            .PuntoDeFusion = "3422 °C",
            .densidad = "19300 kg/m³"
}

        Elementos(75) = New Elemento With {
            .A = 186.21,
            .Z = 75,
            .Nombre = "Renio",
            .Simbolo = "Re",
            .Valencia = "4, 6, 7",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d⁵ 6s²",
            .PuntoDeEbullicion = "5596 °C",
            .PuntoDeFusion = "3186 °C",
            .densidad = "21100 kg/m³"
}

        Elementos(76) = New Elemento With {
            .A = 190.23,
            .Z = 76,
            .Nombre = "Osmio",
            .Simbolo = "Os",
            .Valencia = "2, 3, 4, 6, 8",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d⁶ 6s²",
            .PuntoDeEbullicion = "5027 °C",
            .PuntoDeFusion = "3045 °C",
            .densidad = "22570 kg/m³"
}

        Elementos(77) = New Elemento With {
            .A = 192.22,
            .Z = 77,
            .Nombre = "Iridio",
            .Simbolo = "Ir",
            .Valencia = "3, 4",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d⁷ 6s²",
            .PuntoDeEbullicion = "4130 °C",
            .PuntoDeFusion = "2446 °C",
            .densidad = "22650 kg/m³"
}

        Elementos(78) = New Elemento With {
            .A = 195.08,
            .Z = 78,
            .Nombre = "Platino",
            .Simbolo = "Pt",
            .Valencia = "2, 4",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d⁹ 6s¹",
            .PuntoDeEbullicion = "3825 °C",
            .PuntoDeFusion = "1768.3 °C",
            .densidad = "21450 kg/m³"
}

        Elementos(79) = New Elemento With {
            .A = 196.97,
            .Z = 79,
            .Nombre = "Oro",
            .Simbolo = "Au",
            .Valencia = "1, 3",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d¹⁰ 6s¹",
            .PuntoDeEbullicion = "2856 °C",
            .PuntoDeFusion = "1064.18 °C",
            .densidad = "19300 kg/m³"
}

        Elementos(80) = New Elemento With {
            .A = 200.59,
            .Z = 80,
            .Nombre = "Mercurio",
            .Simbolo = "Hg",
            .Valencia = "1, 2",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d¹⁰ 6s²",
            .PuntoDeEbullicion = "356.73 °C",
            .PuntoDeFusion = "-38.83 °C",
            .densidad = "13534 kg/m³"
}
        Elementos(81) = New Elemento With {
            .A = 204.38,
            .Z = 81,
            .Nombre = "Talio",
            .Simbolo = "Tl",
            .Valencia = "1, 3",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d¹⁰ 6s² 6p¹",
            .PuntoDeEbullicion = "1457 °C",
            .PuntoDeFusion = "304 °C",
            .densidad = "11850 kg/m³"
        }

        Elementos(82) = New Elemento With {
            .A = 207.2,
            .Z = 82,
            .Nombre = "Plomo",
            .Simbolo = "Pb",
            .Valencia = "2, 4",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d¹⁰ 6s² 6p²",
            .PuntoDeEbullicion = "1749 °C",
            .PuntoDeFusion = "327.46 °C",
            .densidad = "11340 kg/m³"
        }

        Elementos(83) = New Elemento With {
            .A = 208.98,
            .Z = 83,
            .Nombre = "Bismuto",
            .Simbolo = "Bi",
            .Valencia = "3, 5",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d¹⁰ 6s² 6p³",
            .PuntoDeEbullicion = "1560 °C",
            .PuntoDeFusion = "271.5 °C",
            .densidad = "9800 kg/m³"
        }

        Elementos(84) = New Elemento With {
            .A = 209,
            .Z = 84,
            .Nombre = "Polonio",
            .Simbolo = "Po",
            .Valencia = "2, 4, 6",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d¹⁰ 6s² 6p⁴",
            .PuntoDeEbullicion = "962 °C",
            .PuntoDeFusion = "254 °C",
            .densidad = "9600 kg/m³"
        }

        Elementos(85) = New Elemento With {
            .A = 210,
            .Z = 85,
            .Nombre = "Astato",
            .Simbolo = "At",
            .Valencia = "1, 3, 5, 7",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d¹⁰ 6s² 6p⁵",
            .PuntoDeEbullicion = "337 °C",
            .PuntoDeFusion = "302 °C",
            .densidad = "7100 kg/m³"
        }

        Elementos(86) = New Elemento With {
            .A = 222,
            .Z = 86,
            .Nombre = "Radón",
            .Simbolo = "Rn",
            .Valencia = "0, 2",
            .ConfigElectronica = "[Xe] 4f¹⁴ 5d¹⁰ 6s² 6p⁶",
            .PuntoDeEbullicion = "-61.7 °C",
            .PuntoDeFusion = "-71 °C",
            .densidad = "9.73 kg/m³"
        }

        Elementos(87) = New Elemento With {
            .A = 223,
            .Z = 87,
            .Nombre = "Francio",
            .Simbolo = "Fr",
            .Valencia = "1",
            .ConfigElectronica = "[Rn] 7s¹",
            .PuntoDeEbullicion = "677 °C",
            .PuntoDeFusion = "27 °C",
            .densidad = "1670 kg/m³"
        }

        Elementos(88) = New Elemento With {
            .A = 226,
            .Z = 88,
            .Nombre = "Radio",
            .Simbolo = "Ra",
            .Valencia = "2",
            .ConfigElectronica = "[Rn] 7s²",
            .PuntoDeEbullicion = "1737 °C",
            .PuntoDeFusion = "700 °C",
            .densidad = "5300 kg/m³"
        }

        Elementos(89) = New Elemento With {
            .A = 227,
            .Z = 89,
            .Nombre = "Actinio",
            .Simbolo = "Ac",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 6d¹ 7s²",
            .PuntoDeEbullicion = "3200 °C",
            .PuntoDeFusion = "1050 °C",
            .densidad = "10720 kg/m³"
        }

        Elementos(90) = New Elemento With {
            .A = 232.04,
            .Z = 90,
            .Nombre = "Torio",
            .Simbolo = "Th",
            .Valencia = "4",
            .ConfigElectronica = "[Rn] 6d² 7s²",
            .PuntoDeEbullicion = "4820 °C",
            .PuntoDeFusion = "1750 °C",
            .densidad = "11720 kg/m³"
        }
        Elementos(91) = New Elemento With {
            .A = 231.04,
            .Z = 91,
            .Nombre = "Protactinio",
            .Simbolo = "Pa",
            .Valencia = "4, 5",
            .ConfigElectronica = "[Rn] 5f² 6d¹ 7s²",
            .PuntoDeEbullicion = "4000 °C",
            .PuntoDeFusion = "1572 °C",
            .densidad = "15300 kg/m³"
}

        Elementos(92) = New Elemento With {
            .A = 238.03,
            .Z = 92,
            .Nombre = "Uranio",
            .Simbolo = "U",
            .Valencia = "3, 4, 5, 6",
            .ConfigElectronica = "[Rn] 5f³ 6d¹ 7s²",
            .PuntoDeEbullicion = "4131 °C",
            .PuntoDeFusion = "1132 °C",
            .densidad = "18950 kg/m³"
}

        Elementos(93) = New Elemento With {
            .A = 237,
            .Z = 93,
            .Nombre = "Neptunio",
            .Simbolo = "Np",
            .Valencia = "3, 4, 5, 6, 7",
            .ConfigElectronica = "[Rn] 5f⁴ 6d¹ 7s²",
            .PuntoDeEbullicion = "3902 °C",
            .PuntoDeFusion = "640 °C",
            .densidad = "20450 kg/m³"
}

        Elementos(94) = New Elemento With {
            .A = 244,
            .Z = 94,
            .Nombre = "Plutonio",
            .Simbolo = "Pu",
            .Valencia = "3, 4, 5, 6",
            .ConfigElectronica = "[Rn] 5f⁶ 7s²",
            .PuntoDeEbullicion = "3235 °C",
            .PuntoDeFusion = "639.4 °C",
            .densidad = "19800 kg/m³"
}

        Elementos(95) = New Elemento With {
            .A = 243,
            .Z = 95,
            .Nombre = "Americio",
            .Simbolo = "Am",
            .Valencia = "3, 4",
            .ConfigElectronica = "[Rn] 5f⁷ 7s²",
            .PuntoDeEbullicion = "2607 °C",
            .PuntoDeFusion = "1176 °C",
            .densidad = "13000 kg/m³"
}

        Elementos(96) = New Elemento With {
            .A = 247,
            .Z = 96,
            .Nombre = "Curio",
            .Simbolo = "Cm",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 5f⁷ 6d¹ 7s²",
            .PuntoDeEbullicion = "3110 °C",
            .PuntoDeFusion = "1340 °C",
            .densidad = "13600 kg/m³"
}

        Elementos(97) = New Elemento With {
            .A = 247,
            .Z = 97,
            .Nombre = "Berkelio",
            .Simbolo = "Bk",
            .Valencia = "3, 4",
            .ConfigElectronica = "[Rn] 5f⁹ 7s²",
            .PuntoDeEbullicion = "2627 °C",
            .PuntoDeFusion = "1259 °C",
            .densidad = "14400 kg/m³"
}

        Elementos(98) = New Elemento With {
            .A = 251,
            .Z = 98,
            .Nombre = "Californio",
            .Simbolo = "Cf",
            .Valencia = "3, 4",
            .ConfigElectronica = "[Rn] 5f¹⁰ 7s²",
            .PuntoDeEbullicion = "900 °C",
            .PuntoDeFusion = "900 °C",
            .densidad = "15100 kg/m³"
}

        Elementos(99) = New Elemento With {
            .A = 252,
            .Z = 99,
            .Nombre = "Einstenio",
            .Simbolo = "Es",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 5f¹¹ 7s²",
            .PuntoDeEbullicion = "1130 °C",
            .PuntoDeFusion = "860 °C",
            .densidad = "16000 kg/m³"
}

        Elementos(100) = New Elemento With {
            .A = 257,
            .Z = 100,
            .Nombre = "Fermio",
            .Simbolo = "Fm",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 5f¹² 7s²",
            .PuntoDeEbullicion = "1527 °C",
            .PuntoDeFusion = "1527 °C",
            .densidad = "18500 kg/m³"
}
        Elementos(101) = New Elemento With {
            .A = 258,
            .Z = 101,
            .Nombre = "Mendelevio",
            .Simbolo = "Md",
            .Valencia = "2, 3",
            .ConfigElectronica = "[Rn] 5f¹³ 7s²",
            .PuntoDeEbullicion = "1100 °C",
            .PuntoDeFusion = "827 °C",
            .densidad = "23200 kg/m³"
}

        Elementos(102) = New Elemento With {
            .A = 259,
            .Z = 102,
            .Nombre = "Nobelio",
            .Simbolo = "No",
            .Valencia = "2, 3",
            .ConfigElectronica = "[Rn] 5f¹⁴ 7s²",
            .PuntoDeEbullicion = "827 °C",
            .PuntoDeFusion = "827 °C",
            .densidad = "22000 kg/m³"
}

        Elementos(103) = New Elemento With {
            .A = 262,
            .Z = 103,
            .Nombre = "Lawrencio",
            .Simbolo = "Lr",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 5f¹⁴ 7s² 7p¹",
            .PuntoDeEbullicion = "1627 °C",
            .PuntoDeFusion = "1627 °C",
            .densidad = "14700 kg/m³"
}

        Elementos(104) = New Elemento With {
            .A = 267,
            .Z = 104,
            .Nombre = "Rutherfordio",
            .Simbolo = "Rf",
            .Valencia = "4",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d² 7s²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "23000 kg/m³"
}

        Elementos(105) = New Elemento With {
            .A = 268,
            .Z = 105,
            .Nombre = "Dubnio",
            .Simbolo = "Db",
            .Valencia = "5",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d³ 7s²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "28600 kg/m³"
}

        Elementos(106) = New Elemento With {
            .A = 271,
            .Z = 106,
            .Nombre = "Seaborgio",
            .Simbolo = "Sg",
            .Valencia = "6",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d⁴ 7s²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "35200 kg/m³"
}

        Elementos(107) = New Elemento With {
            .A = 270,
            .Z = 107,
            .Nombre = "Bohrio",
            .Simbolo = "Bh",
            .Valencia = "7",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d⁵ 7s²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "36200 kg/m³"
}

        Elementos(108) = New Elemento With {
            .A = 277,
            .Z = 108,
            .Nombre = "Hassio",
            .Simbolo = "Hs",
            .Valencia = "8",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d⁶ 7s²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "40700 kg/m³"
}

        Elementos(109) = New Elemento With {
            .A = 276,
            .Z = 109,
            .Nombre = "Meitnerio",
            .Simbolo = "Mt",
            .Valencia = "Unknown",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d⁷ 7s²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown"
}

        Elementos(110) = New Elemento With {
            .A = 281,
            .Z = 110,
            .Nombre = "Darmstadio",
            .Simbolo = "Ds",
            .Valencia = "Unknown",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d⁸ 7s²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown"
}

        Elementos(111) = New Elemento With {
            .A = 282,
            .Z = 111,
            .Nombre = "Roentgenio",
            .Simbolo = "Rg",
            .Valencia = "Unknown",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d⁹ 7s²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown"
}

        Elementos(112) = New Elemento With {
            .A = 285,
            .Z = 112,
            .Nombre = "Copernicio",
            .Simbolo = "Cn",
            .Valencia = "2",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d¹⁰ 7s²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "14000 kg/m³"
}

        Elementos(113) = New Elemento With {
            .A = 286,
            .Z = 113,
            .Nombre = "Nihonio",
            .Simbolo = "Nh",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d¹⁰ 7s² 7p¹",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown"
}

        Elementos(114) = New Elemento With {
            .A = 289,
            .Z = 114,
            .Nombre = "Flerovio",
            .Simbolo = "Fl",
            .Valencia = "4",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d¹⁰ 7s² 7p²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown"
}

        Elementos(115) = New Elemento With {
            .A = 288,
            .Z = 115,
            .Nombre = "Moscovio",
            .Simbolo = "Mc",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d¹⁰ 7s² 7p³",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown"
}

        Elementos(116) = New Elemento With {
            .A = 293,
            .Z = 116,
            .Nombre = "Livermorio",
            .Simbolo = "Lv",
            .Valencia = "4",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d¹⁰ 7s² 7p⁴",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown"
}

        Elementos(117) = New Elemento With {
            .A = 294,
            .Z = 117,
            .Nombre = "Tenesino",
            .Simbolo = "Ts",
            .Valencia = "1",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d¹⁰ 7s² 7p⁵",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown"
}

        Elementos(118) = New Elemento With {
            .A = 294,
            .Z = 118,
            .Nombre = "Oganesón",
            .Simbolo = "Og",
            .Valencia = "0",
            .ConfigElectronica = "[Rn] 5f¹⁴ 6d¹⁰ 7s² 7p⁶",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown"
}



    End Sub

End Module