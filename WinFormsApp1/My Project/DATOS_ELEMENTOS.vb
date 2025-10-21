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
    .Descripcion = "El hidrógeno es el elemento más ligero y abundante del universo. Se encuentra principalmente en estrellas y planetas, y es esencial para la formación de agua y compuestos orgánicos. Su versatilidad química lo hace clave en numerosos procesos industriales y energéticos."
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
    .Descripcion = "El helio es un gas noble, inerte y muy ligero. Es usado en criogenia, iluminación y como gas protector en procesos industriales. Su estabilidad química y baja densidad lo hacen ideal para globos y mezclas respiratorias."
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
    .Descripcion = "El litio es un metal alcalino muy reactivo, usado en baterías recargables, aleaciones y productos farmacéuticos. Su baja densidad y alta reactividad lo hacen importante en aplicaciones energéticas."
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
    .Descubrimiento = "1798, Louis Nicolas Vauquelin",
    .EnergiaIonizacion = "9.3227 eV",
    .Dureza = "Dura",
    .Conductividad = "Buena",
    .Abundancia = "0.0002 %",
    .Descripcion = "El berilio es un metal ligero y duro con alta conductividad térmica y eléctrica. Se utiliza en aleaciones especiales y componentes aeroespaciales debido a su rigidez y estabilidad dimensional."
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
    .Descubrimiento = "1808, Humphry Davy",
    .EnergiaIonizacion = "8.298 eV",
    .Dureza = "Muy dura",
    .Conductividad = "Moderada",
    .Abundancia = "0.001 %",
    .Descripcion = "El boro es un metaloide con propiedades únicas, usado en vidrio resistente, detergentes y semiconductores. Su estructura cristalina le da dureza y estabilidad química."
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
    .densidad = "2260 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "Conocido desde la antigüedad",
    .EnergiaIonizacion = "11.2603 eV",
    .Dureza = "Duro",
    .Conductividad = "Variable",
    .Abundancia = "0.02 %",
    .Descripcion = "El carbono es esencial para toda la química orgánica y la vida. Forma estructuras como diamante y grafito, mostrando propiedades únicas de dureza, conductividad y estabilidad química."
}

        Elementos(7) = New Elemento With {
    .A = 14.007,
    .Z = 7,
    .Nombre = "Nitrógeno",
    .Simbolo = "N",
    .Valencia = "3",
    .ConfigElectronica = "[He] 2s² 2p³",
    .PuntoDeEbullicion = "-195.79 °C",
    .PuntoDeFusion = "-210 °C",
    .densidad = "1.251 kg/m³",
    .EstadoFisico = "Gas",
    .Descubrimiento = "1772, Daniel Rutherford",
    .EnergiaIonizacion = "14.5341 eV",
    .Dureza = "No aplica",
    .Conductividad = "Baja",
    .Abundancia = "78 % de la atmósfera",
    .Descripcion = "El nitrógeno es un gas diatómico abundante en la atmósfera terrestre. Es esencial para la síntesis de aminoácidos, proteínas y ácidos nucleicos, siendo clave en los ciclos biogeoquímicos."
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
    .Abundancia = "21 % de la atmósfera",
    .Descripcion = "El oxígeno es un gas esencial para la respiración de organismos aerobios y para la combustión. Forma moléculas diatómicas y participa en numerosos compuestos químicos vitales."
}

        Elementos(9) = New Elemento With {
    .A = 18.998,
    .Z = 9,
    .Nombre = "Flúor",
    .Simbolo = "F",
    .Valencia = "1",
    .ConfigElectronica = "[He] 2s² 2p⁵",
    .PuntoDeEbullicion = "-188.11 °C",
    .PuntoDeFusion = "-219.62 °C",
    .densidad = "1.696 kg/m³",
    .EstadoFisico = "Gas",
    .Descubrimiento = "1886, Henri Moissan",
    .EnergiaIonizacion = "17.4228 eV",
    .Dureza = "No aplica",
    .Conductividad = "Muy baja",
    .Abundancia = "0.054 %",
    .Descripcion = "El flúor es un halógeno extremadamente reactivo. Se utiliza en la fabricación de compuestos químicos, teflón, dentífricos y en la industria nuclear."
}

        Elementos(10) = New Elemento With {
    .A = 20.18,
    .Z = 10,
    .Nombre = "Neón",
    .Simbolo = "Ne",
    .Valencia = "0",
    .ConfigElectronica = "[He] 2s² 2p⁶",
    .PuntoDeEbullicion = "-246.08 °C",
    .PuntoDeFusion = "-248.59 °C",
    .densidad = "0.9002 kg/m³",
    .EstadoFisico = "Gas",
    .Descubrimiento = "1898, Sir William Ramsay",
    .EnergiaIonizacion = "21.5645 eV",
    .Dureza = "No aplica",
    .Conductividad = "Muy baja",
    .Abundancia = "0.0018 %",
    .Descripcion = "El neón es un gas noble, inerte y luminoso, usado en iluminación, letreros y señales. Su estabilidad química lo hace ideal para aplicaciones de señalización."
}




        Elementos(11) = New Elemento With {
            .A = 22.99,
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
            .Dureza = "Blanda",
            .Conductividad = "Alta",
            .Abundancia = "2.6 %",
            .Descripcion = "El sodio es un metal alcalino altamente reactivo. Forma parte de la sal común (NaCl) y es esencial para el equilibrio osmótico y la transmisión nerviosa en organismos vivos."
        }

        Elementos(12) = New Elemento With {
            .A = 24.305,
            .Z = 12,
            .Nombre = "Magnesio",
            .Simbolo = "Mg",
            .Valencia = "2",
            .ConfigElectronica = "[Ne] 3s²",
            .PuntoDeEbullicion = "1091 °C",
            .PuntoDeFusion = "650 °C",
            .densidad = "1738 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1755, Joseph Black",
            .EnergiaIonizacion = "7.6462 eV",
            .Dureza = "Media",
            .Conductividad = "Buena",
            .Abundancia = "2.3 %",
            .Descripcion = "El magnesio es un metal ligero y esencial para procesos biológicos. Se usa en aleaciones, pirotecnia y suplementos alimenticios por su importancia en el metabolismo celular."
        }

        Elementos(13) = New Elemento With {
            .A = 26.982,
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
            .Dureza = "Media",
            .Conductividad = "Alta",
            .Abundancia = "8.1 %",
            .Descripcion = "El aluminio es un metal ligero, maleable y resistente a la corrosión. Es muy usado en transporte, construcción y empaques gracias a su durabilidad y conductividad."
        }

        Elementos(14) = New Elemento With {
            .A = 28.085,
            .Z = 14,
            .Nombre = "Silicio",
            .Simbolo = "Si",
            .Valencia = "4",
            .ConfigElectronica = "[Ne] 3s² 3p²",
            .PuntoDeEbullicion = "2355 °C",
            .PuntoDeFusion = "1414 °C",
            .densidad = "2330 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1824, Jöns Jacob Berzelius",
            .EnergiaIonizacion = "8.1517 eV",
            .Dureza = "Dura",
            .Conductividad = "Semiconductora",
            .Abundancia = "27.7 %",
            .Descripcion = "El silicio es un metaloide fundamental en la industria electrónica y de la computación. También forma parte de minerales y compuestos como la arena de cuarzo."
        }

        Elementos(15) = New Elemento With {
            .A = 30.974,
            .Z = 15,
            .Nombre = "Fósforo",
            .Simbolo = "P",
            .Valencia = "3, 5",
            .ConfigElectronica = "[Ne] 3s² 3p³",
            .PuntoDeEbullicion = "280.5 °C",
            .PuntoDeFusion = "44.15 °C",
            .densidad = "1823 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1669, Hennig Brand",
            .EnergiaIonizacion = "10.4867 eV",
            .Dureza = "Media",
            .Conductividad = "Baja",
            .Abundancia = "0.1 %",
            .Descripcion = "El fósforo es un elemento esencial para la vida, presente en el ADN, huesos y dientes. Se utiliza en fertilizantes, cerillas y productos químicos industriales."
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
            .Descubrimiento = "Conocido desde la antigüedad",
            .EnergiaIonizacion = "10.36 eV",
            .Dureza = "Media",
            .Conductividad = "Baja",
            .Abundancia = "0.042 %",
            .Descripcion = "El azufre es un no metal amarillo usado en la fabricación de ácido sulfúrico, pólvora, fertilizantes y medicamentos. Es esencial en proteínas y procesos biológicos."
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
            .densidad = "3.21 kg/m³",
            .EstadoFisico = "Gas",
            .Descubrimiento = "1774, Carl Wilhelm Scheele",
            .EnergiaIonizacion = "12.9676 eV",
            .Dureza = "No aplica",
            .Conductividad = "Muy baja",
            .Abundancia = "0.017 %",
            .Descripcion = "El cloro es un gas verde amarillento altamente reactivo, usado como desinfectante y en la producción de plásticos como el PVC. Es vital para el tratamiento de agua potable."
        }

        Elementos(18) = New Elemento With {
            .A = 39.948,
            .Z = 18,
            .Nombre = "Argón",
            .Simbolo = "Ar",
            .Valencia = "0",
            .ConfigElectronica = "[Ne] 3s² 3p⁶",
            .PuntoDeEbullicion = "-185.8 °C",
            .PuntoDeFusion = "-189.4 °C",
            .densidad = "1.784 kg/m³",
            .EstadoFisico = "Gas",
            .Descubrimiento = "1894, Lord Rayleigh y William Ramsay",
            .EnergiaIonizacion = "15.7596 eV",
            .Dureza = "No aplica",
            .Conductividad = "Muy baja",
            .Abundancia = "0.934 % del aire",
            .Descripcion = "El argón es un gas noble inerte, empleado como atmósfera protectora en soldaduras y bombillas. Su estabilidad lo hace ideal en ambientes donde se requiere ausencia de reacciones químicas."
        }

        Elementos(19) = New Elemento With {
            .A = 39.098,
            .Z = 19,
            .Nombre = "Potasio",
            .Simbolo = "K",
            .Valencia = "1",
            .ConfigElectronica = "[Ar] 4s¹",
            .PuntoDeEbullicion = "759 °C",
            .PuntoDeFusion = "63.5 °C",
            .densidad = "856 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1807, Humphry Davy",
            .EnergiaIonizacion = "4.3407 eV",
            .Dureza = "Blanda",
            .Conductividad = "Alta",
            .Abundancia = "2.1 %",
            .Descripcion = "El potasio es un metal alcalino blando, esencial para la función nerviosa y muscular. Reacciona violentamente con agua y forma sales vitales para los seres vivos."
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
            .Descubrimiento = "1808, Humphry Davy",
            .EnergiaIonizacion = "6.1132 eV",
            .Dureza = "Media",
            .Conductividad = "Buena",
            .Abundancia = "4.1 %",
            .Descripcion = "El calcio es un metal alcalinotérreo esencial para huesos, dientes y procesos celulares. Se encuentra en minerales como la caliza y el yeso."
        }

        Elementos(21) = New Elemento With {
            .A = 44.956,
            .Z = 21,
            .Nombre = "Escandio",
            .Simbolo = "Sc",
            .Valencia = "3",
            .ConfigElectronica = "[Ar] 4s² 3d¹",
            .PuntoDeEbullicion = "2836 °C",
            .PuntoDeFusion = "1541 °C",
            .densidad = "2985 kg/m³",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1879, Lars Fredrik Nilson",
            .EnergiaIonizacion = "6.5615 eV",
            .Dureza = "Alta",
            .Conductividad = "Buena",
            .Abundancia = "0.0026 %",
            .Descripcion = "El escandio es un metal de transición ligero usado en aleaciones aeroespaciales y lámparas de alta intensidad. Mejora la resistencia y ligereza de materiales industriales."
        }

        Elementos(22) = New Elemento With {
    .A = 47.867,
    .Z = 22,
    .Nombre = "Titanio",
    .Simbolo = "Ti",
    .Valencia = "2, 3, 4",
    .ConfigElectronica = "[Ar] 4s² 3d²",
    .PuntoDeEbullicion = "3287 °C",
    .PuntoDeFusion = "1668 °C",
    .densidad = "4507 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1791, William Gregor",
    .EnergiaIonizacion = "6.8281 eV",
    .Dureza = "Alta",
    .Conductividad = "Media",
    .Abundancia = "0.44 %",
    .Descripcion = "El titanio es un metal de transición fuerte, ligero y resistente a la corrosión. Se usa en aviones, implantes médicos y aleaciones avanzadas debido a su gran durabilidad y baja densidad."
}

        Elementos(23) = New Elemento With {
    .A = 50.942,
    .Z = 23,
    .Nombre = "Vanadio",
    .Simbolo = "V",
    .Valencia = "2, 3, 4, 5",
    .ConfigElectronica = "[Ar] 4s² 3d³",
    .PuntoDeEbullicion = "3407 °C",
    .PuntoDeFusion = "1910 °C",
    .densidad = "6110 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1801, Andrés Manuel del Río",
    .EnergiaIonizacion = "6.7462 eV",
    .Dureza = "Alta",
    .Conductividad = "Media",
    .Abundancia = "0.019 %",
    .Descripcion = "El vanadio es un metal resistente que mejora la dureza de aceros y aleaciones. Se utiliza en herramientas, turbinas y baterías de flujo redox por su capacidad de oxidación múltiple."
}

        Elementos(24) = New Elemento With {
    .A = 51.996,
    .Z = 24,
    .Nombre = "Cromo",
    .Simbolo = "Cr",
    .Valencia = "2, 3, 6",
    .ConfigElectronica = "[Ar] 4s¹ 3d⁵",
    .PuntoDeEbullicion = "2671 °C",
    .PuntoDeFusion = "1907 °C",
    .densidad = "7190 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1797, Louis Nicolas Vauquelin",
    .EnergiaIonizacion = "6.7665 eV",
    .Dureza = "Alta",
    .Conductividad = "Buena",
    .Abundancia = "0.035 %",
    .Descripcion = "El cromo es un metal brillante resistente a la corrosión y al desgaste. Se utiliza en recubrimientos, aceros inoxidables y pigmentos por su estabilidad y dureza excepcionales."
}

        Elementos(25) = New Elemento With {
    .A = 54.938,
    .Z = 25,
    .Nombre = "Manganeso",
    .Simbolo = "Mn",
    .Valencia = "2, 3, 4, 6, 7",
    .ConfigElectronica = "[Ar] 4s² 3d⁵",
    .PuntoDeEbullicion = "2061 °C",
    .PuntoDeFusion = "1246 °C",
    .densidad = "7440 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1774, Johan Gottlieb Gahn",
    .EnergiaIonizacion = "7.434 eV",
    .Dureza = "Alta",
    .Conductividad = "Media",
    .Abundancia = "0.1 %",
    .Descripcion = "El manganeso es esencial en la producción de acero y pilas alcalinas. También cumple un papel biológico en enzimas antioxidantes y procesos metabólicos."
}

        Elementos(26) = New Elemento With {
    .A = 55.845,
    .Z = 26,
    .Nombre = "Hierro",
    .Simbolo = "Fe",
    .Valencia = "2, 3",
    .ConfigElectronica = "[Ar] 4s² 3d⁶",
    .PuntoDeEbullicion = "2862 °C",
    .PuntoDeFusion = "1538 °C",
    .densidad = "7874 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "Conocido desde la antigüedad",
    .EnergiaIonizacion = "7.9024 eV",
    .Dureza = "Alta",
    .Conductividad = "Buena",
    .Abundancia = "5.0 %",
    .Descripcion = "El hierro es uno de los metales más importantes para la humanidad. Forma el núcleo terrestre, aleaciones estructurales y es esencial en la hemoglobina de la sangre."
}

        Elementos(27) = New Elemento With {
    .A = 58.933,
    .Z = 27,
    .Nombre = "Cobalto",
    .Simbolo = "Co",
    .Valencia = "2, 3",
    .ConfigElectronica = "[Ar] 4s² 3d⁷",
    .PuntoDeEbullicion = "2927 °C",
    .PuntoDeFusion = "1495 °C",
    .densidad = "8900 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1735, Georg Brandt",
    .EnergiaIonizacion = "7.881 eV",
    .Dureza = "Alta",
    .Conductividad = "Buena",
    .Abundancia = "0.003 %",
    .Descripcion = "El cobalto es un metal ferromagnético usado en imanes, baterías de litio y pigmentos azules. Es esencial en la vitamina B12 y en procesos biológicos de mamíferos."
}

        Elementos(28) = New Elemento With {
    .A = 58.693,
    .Z = 28,
    .Nombre = "Níquel",
    .Simbolo = "Ni",
    .Valencia = "2, 3",
    .ConfigElectronica = "[Ar] 4s² 3d⁸",
    .PuntoDeEbullicion = "2732 °C",
    .PuntoDeFusion = "1455 °C",
    .densidad = "8908 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1751, Axel Fredrik Cronstedt",
    .EnergiaIonizacion = "7.6398 eV",
    .Dureza = "Alta",
    .Conductividad = "Alta",
    .Abundancia = "0.008 %",
    .Descripcion = "El níquel es un metal de transición brillante y resistente a la corrosión. Se utiliza en monedas, acero inoxidable, baterías recargables y catalizadores industriales."
}

        Elementos(29) = New Elemento With {
    .A = 63.546,
    .Z = 29,
    .Nombre = "Cobre",
    .Simbolo = "Cu",
    .Valencia = "1, 2",
    .ConfigElectronica = "[Ar] 4s¹ 3d¹⁰",
    .PuntoDeEbullicion = "2562 °C",
    .PuntoDeFusion = "1084.62 °C",
    .densidad = "8960 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "Conocido desde la antigüedad",
    .EnergiaIonizacion = "7.7264 eV",
    .Dureza = "Media",
    .Conductividad = "Muy alta",
    .Abundancia = "0.0068 %",
    .Descripcion = "El cobre es un excelente conductor eléctrico y térmico. Es esencial en cables, motores y monedas, y también en enzimas biológicas de organismos vivos."
}

        Elementos(30) = New Elemento With {
    .A = 65.38,
    .Z = 30,
    .Nombre = "Zinc",
    .Simbolo = "Zn",
    .Valencia = "2",
    .ConfigElectronica = "[Ar] 4s² 3d¹⁰",
    .PuntoDeEbullicion = "907 °C",
    .PuntoDeFusion = "419.53 °C",
    .densidad = "7140 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1746, Andreas Marggraf",
    .EnergiaIonizacion = "9.3942 eV",
    .Dureza = "Media",
    .Conductividad = "Buena",
    .Abundancia = "0.0075 %",
    .Descripcion = "El zinc es un metal esencial para la salud y se usa para galvanizar acero, formar aleaciones como el latón y producir pilas eléctricas. Es vital para el sistema inmunológico."
}


        Elementos(31) = New Elemento With {
    .A = 69.723,
    .Z = 31,
    .Nombre = "Galio",
    .Simbolo = "Ga",
    .Valencia = "3",
    .ConfigElectronica = "[Ar] 4s² 3d¹⁰ 4p¹",
    .PuntoDeEbullicion = "2403 °C",
    .PuntoDeFusion = "29.76 °C",
    .densidad = "5904 kg/m³",
    .EstadoFisico = "Sólido (líquido a temperatura ambiente)",
    .Descubrimiento = "1875, Paul Émile Lecoq de Boisbaudran",
    .EnergiaIonizacion = "5.999 eV",
    .Dureza = "1.5 (Mohs)",
    .Conductividad = "Moderada",
    .Abundancia = "19 ppm en la corteza terrestre",
    .Descripcion = "El galio es un metal de bajo punto de fusión que puede derretirse en la mano. Se emplea en semiconductores, diodos emisores de luz y sistemas electrónicos. Su estabilidad térmica lo hace valioso en aplicaciones de alta precisión."
}

        Elementos(32) = New Elemento With {
    .A = 72.63,
    .Z = 32,
    .Nombre = "Germanio",
    .Simbolo = "Ge",
    .Valencia = "4",
    .ConfigElectronica = "[Ar] 4s² 3d¹⁰ 4p²",
    .PuntoDeEbullicion = "2833 °C",
    .PuntoDeFusion = "938.25 °C",
    .densidad = "5323 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1886, Clemens Winkler",
    .EnergiaIonizacion = "7.899 eV",
    .Dureza = "6.0 (Mohs)",
    .Conductividad = "Semiconductor",
    .Abundancia = "1.5 ppm en la corteza terrestre",
    .Descripcion = "El germanio es un metaloide esencial en la industria de semiconductores y la fibra óptica. Su capacidad de conducción controlada lo convierte en un componente crítico en transistores y dispositivos de comunicación óptica."
}

        Elementos(33) = New Elemento With {
    .A = 74.9216,
    .Z = 33,
    .Nombre = "Arsénico",
    .Simbolo = "As",
    .Valencia = "3, 5",
    .ConfigElectronica = "[Ar] 4s² 3d¹⁰ 4p³",
    .PuntoDeEbullicion = "613 °C (sublimación)",
    .PuntoDeFusion = "817 °C (presión alta)",
    .densidad = "5730 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "Antigüedad",
    .EnergiaIonizacion = "9.815 eV",
    .Dureza = "3.5 (Mohs)",
    .Conductividad = "Moderada",
    .Abundancia = "1.8 ppm en la corteza terrestre",
    .Descripcion = "El arsénico es un metaloide tóxico utilizado en aleaciones, semiconductores y pesticidas. A pesar de su toxicidad, tiene aplicaciones tecnológicas importantes en la fabricación de componentes electrónicos especializados."
}

        Elementos(34) = New Elemento With {
    .A = 78.971,
    .Z = 34,
    .Nombre = "Selenio",
    .Simbolo = "Se",
    .Valencia = "−2, +4, +6",
    .ConfigElectronica = "[Ar] 4s² 3d¹⁰ 4p⁴",
    .PuntoDeEbullicion = "685 °C",
    .PuntoDeFusion = "221 °C",
    .densidad = "4819 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1817, Jöns Jakob Berzelius",
    .EnergiaIonizacion = "9.752 eV",
    .Dureza = "2.0 (Mohs)",
    .Conductividad = "Fotoconductor",
    .Abundancia = "0.05 ppm en la corteza terrestre",
    .Descripcion = "El selenio es un no metal con propiedades fotoconductoras y semiconductoras. Es esencial para el metabolismo humano y se utiliza en paneles solares, fotocopiadoras y dispositivos electrónicos sensibles a la luz."
}

        Elementos(35) = New Elemento With {
    .A = 79.904,
    .Z = 35,
    .Nombre = "Bromo",
    .Simbolo = "Br",
    .Valencia = "−1, +1, +3, +5, +7",
    .ConfigElectronica = "[Ar] 4s² 3d¹⁰ 4p⁵",
    .PuntoDeEbullicion = "58.8 °C",
    .PuntoDeFusion = "−7.2 °C",
    .densidad = "3120 kg/m³",
    .EstadoFisico = "Líquido",
    .Descubrimiento = "1826, Antoine Balard",
    .EnergiaIonizacion = "11.814 eV",
    .Dureza = "No aplica",
    .Conductividad = "No conductor",
    .Abundancia = "2.4 ppm en la corteza terrestre",
    .Descripcion = "El bromo es un halógeno líquido de color marrón rojizo y olor penetrante. Es muy reactivo y se emplea en retardantes de llama, productos farmacéuticos y procesos de purificación industrial."
}

        Elementos(36) = New Elemento With {
    .A = 83.798,
    .Z = 36,
    .Nombre = "Kriptón",
    .Simbolo = "Kr",
    .Valencia = "0",
    .ConfigElectronica = "[Ar] 4s² 3d¹⁰ 4p⁶",
    .PuntoDeEbullicion = "−153.4 °C",
    .PuntoDeFusion = "−157.4 °C",
    .densidad = "3.749 kg/m³",
    .EstadoFisico = "Gas",
    .Descubrimiento = "1898, William Ramsay y Morris Travers",
    .EnergiaIonizacion = "14.000 eV",
    .Dureza = "No aplica",
    .Conductividad = "Baja",
    .Abundancia = "1 ppm en la atmósfera",
    .Descripcion = "El kriptón es un gas noble incoloro y estable utilizado en iluminación de alta intensidad, láseres y mediciones de precisión. Su inercia química lo hace ideal para ambientes donde se requiere una atmósfera controlada."
}


        Elementos(37) = New Elemento With {
    .A = 85.4678,
    .Z = 37,
    .Nombre = "Rubidio",
    .Simbolo = "Rb",
    .Valencia = "1",
    .ConfigElectronica = "[Kr] 5s¹",
    .PuntoDeEbullicion = "688 °C",
    .PuntoDeFusion = "39.3 °C",
    .densidad = "1532 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1861, Robert Bunsen y Gustav Kirchhoff",
    .EnergiaIonizacion = "4.177 eV",
    .Dureza = "0.3 (Mohs)",
    .Conductividad = "Alta",
    .Abundancia = "90 ppm en la corteza terrestre",
    .Descripcion = "El rubidio es un metal alcalino blando y muy reactivo que se inflama espontáneamente al contacto con el aire. Se utiliza en celdas fotoeléctricas, relojes atómicos y aplicaciones de investigación científica avanzada."
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
    .Descubrimiento = "1790, Adair Crawford",
    .EnergiaIonizacion = "5.695 eV",
    .Dureza = "1.5 (Mohs)",
    .Conductividad = "Alta",
    .Abundancia = "370 ppm en la corteza terrestre",
    .Descripcion = "El estroncio es un metal alcalinotérreo que produce un color rojo brillante en los fuegos artificiales. También se emplea en imanes de ferrita, pirotecnia, y antiguamente en tubos de rayos catódicos."
}

        Elementos(39) = New Elemento With {
    .A = 88.9059,
    .Z = 39,
    .Nombre = "Itrio",
    .Simbolo = "Y",
    .Valencia = "3",
    .ConfigElectronica = "[Kr] 5s² 4d¹",
    .PuntoDeEbullicion = "3338 °C",
    .PuntoDeFusion = "1526 °C",
    .densidad = "4472 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1794, Johan Gadolin",
    .EnergiaIonizacion = "6.217 eV",
    .Dureza = "4.0 (Mohs)",
    .Conductividad = "Alta",
    .Abundancia = "33 ppm en la corteza terrestre",
    .Descripcion = "El itrio es un metal de transición plateado utilizado en láseres, materiales superconductores y fósforos para pantallas LED. Posee propiedades químicas similares a las de los lantánidos."
}

        Elementos(40) = New Elemento With {
    .A = 91.224,
    .Z = 40,
    .Nombre = "Circonio",
    .Simbolo = "Zr",
    .Valencia = "4",
    .ConfigElectronica = "[Kr] 5s² 4d²",
    .PuntoDeEbullicion = "4377 °C",
    .PuntoDeFusion = "1855 °C",
    .densidad = "6505 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1789, Martin Heinrich Klaproth",
    .EnergiaIonizacion = "6.634 eV",
    .Dureza = "5.0 (Mohs)",
    .Conductividad = "Alta",
    .Abundancia = "165 ppm en la corteza terrestre",
    .Descripcion = "El circonio es un metal resistente a la corrosión ampliamente usado en reactores nucleares debido a su baja absorción de neutrones. También se aplica en cerámicas, cuchillas quirúrgicas y recubrimientos protectores."
}

        Elementos(41) = New Elemento With {
    .A = 92.9064,
    .Z = 41,
    .Nombre = "Niobio",
    .Simbolo = "Nb",
    .Valencia = "5",
    .ConfigElectronica = "[Kr] 5s¹ 4d⁴",
    .PuntoDeEbullicion = "4744 °C",
    .PuntoDeFusion = "2477 °C",
    .densidad = "8570 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1801, Charles Hatchett",
    .EnergiaIonizacion = "6.7589 eV",
    .Dureza = "6.0 (Mohs)",
    .Conductividad = "Alta",
    .Abundancia = "20 ppm en la corteza terrestre",
    .Descripcion = "El niobio es un metal de transición maleable y resistente a la corrosión, usado en aleaciones superconductoras, turbinas y componentes aeroespaciales. Su alta conductividad lo hace ideal para imanes superconductores."
}

        Elementos(42) = New Elemento With {
    .A = 95.95,
    .Z = 42,
    .Nombre = "Molibdeno",
    .Simbolo = "Mo",
    .Valencia = "6",
    .ConfigElectronica = "[Kr] 5s¹ 4d⁵",
    .PuntoDeEbullicion = "4639 °C",
    .PuntoDeFusion = "2623 °C",
    .densidad = "10280 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1778, Carl Wilhelm Scheele",
    .EnergiaIonizacion = "7.092 eV",
    .Dureza = "5.5 (Mohs)",
    .Conductividad = "Alta",
    .Abundancia = "1.2 ppm en la corteza terrestre",
    .Descripcion = "El molibdeno es un metal gris plateado esencial para la vida enzimática y ampliamente usado en aceros especiales y catalizadores. Resiste altas temperaturas sin oxidarse fácilmente."
}

        Elementos(43) = New Elemento With {
    .A = 98.0,
    .Z = 43,
    .Nombre = "Tecnecio",
    .Simbolo = "Tc",
    .Valencia = "7",
    .ConfigElectronica = "[Kr] 5s² 4d⁵",
    .PuntoDeEbullicion = "4265 °C",
    .PuntoDeFusion = "2157 °C",
    .densidad = "11500 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1937, Carlo Perrier y Emilio Segrè",
    .EnergiaIonizacion = "7.28 eV",
    .Dureza = "No aplica",
    .Conductividad = "Alta",
    .Abundancia = "Sintético (trazas naturales)",
    .Descripcion = "El tecnecio fue el primer elemento producido artificialmente. Es radiactivo y se utiliza en medicina nuclear para el diagnóstico por imágenes del flujo sanguíneo y el funcionamiento de órganos."
}

        Elementos(44) = New Elemento With {
    .A = 101.07,
    .Z = 44,
    .Nombre = "Rutenio",
    .Simbolo = "Ru",
    .Valencia = "4",
    .ConfigElectronica = "[Kr] 5s¹ 4d⁷",
    .PuntoDeEbullicion = "4150 °C",
    .PuntoDeFusion = "2334 °C",
    .densidad = "12370 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1844, Karl Ernst Claus",
    .EnergiaIonizacion = "7.361 eV",
    .Dureza = "6.5 (Mohs)",
    .Conductividad = "Alta",
    .Abundancia = "0.001 ppm en la corteza terrestre",
    .Descripcion = "El rutenio es un metal del grupo del platino, muy resistente a la corrosión. Se usa en contactos eléctricos, aleaciones de platino y como catalizador en procesos industriales."
}

        Elementos(45) = New Elemento With {
    .A = 102.9055,
    .Z = 45,
    .Nombre = "Rodio",
    .Simbolo = "Rh",
    .Valencia = "3",
    .ConfigElectronica = "[Kr] 5s¹ 4d⁸",
    .PuntoDeEbullicion = "3695 °C",
    .PuntoDeFusion = "1964 °C",
    .densidad = "12410 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1803, William Hyde Wollaston",
    .EnergiaIonizacion = "7.4589 eV",
    .Dureza = "6.0 (Mohs)",
    .Conductividad = "Alta",
    .Abundancia = "0.001 ppm en la corteza terrestre",
    .Descripcion = "El rodio es un metal extremadamente valioso y reflectante, utilizado en catalizadores automotrices, recubrimientos de joyería y componentes ópticos de alta precisión."
}

        Elementos(46) = New Elemento With {
    .A = 106.42,
    .Z = 46,
    .Nombre = "Paladio",
    .Simbolo = "Pd",
    .Valencia = "2",
    .ConfigElectronica = "[Kr] 4d¹⁰",
    .PuntoDeEbullicion = "2963 °C",
    .PuntoDeFusion = "1555 °C",
    .densidad = "12023 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1803, William Hyde Wollaston",
    .EnergiaIonizacion = "8.3369 eV",
    .Dureza = "4.75 (Mohs)",
    .Conductividad = "Alta",
    .Abundancia = "0.015 ppm en la corteza terrestre",
    .Descripcion = "El paladio es un metal del grupo del platino, muy apreciado por su capacidad para absorber hidrógeno y su uso en catalizadores, electrónica, relojería y joyería de lujo."
}

        Elementos(47) = New Elemento With {
    .A = 107.8682,
    .Z = 47,
    .Nombre = "Plata",
    .Simbolo = "Ag",
    .Valencia = "1",
    .ConfigElectronica = "[Kr] 5s¹ 4d¹⁰",
    .PuntoDeEbullicion = "2162 °C",
    .PuntoDeFusion = "961.8 °C",
    .densidad = "10490 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "Antigüedad",
    .EnergiaIonizacion = "7.5762 eV",
    .Dureza = "2.5–3 (Mohs)",
    .Conductividad = "Muy alta",
    .Abundancia = "0.075 ppm en la corteza terrestre",
    .Descripcion = "La plata es un metal de transición brillante, con la mayor conductividad eléctrica y térmica de todos los elementos. Se usa en electrónica, joyería, fotografía y monedas debido a su maleabilidad y brillo."
}

        Elementos(48) = New Elemento With {
    .A = 112.414,
    .Z = 48,
    .Nombre = "Cadmio",
    .Simbolo = "Cd",
    .Valencia = "2",
    .ConfigElectronica = "[Kr] 5s² 4d¹⁰",
    .PuntoDeEbullicion = "767 °C",
    .PuntoDeFusion = "321 °C",
    .densidad = "8650 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1817, Friedrich Stromeyer",
    .EnergiaIonizacion = "8.9938 eV",
    .Dureza = "2.0 (Mohs)",
    .Conductividad = "Alta",
    .Abundancia = "0.1 ppm en la corteza terrestre",
    .Descripcion = "El cadmio es un metal blando, dúctil y tóxico, utilizado en baterías de níquel-cadmio, pigmentos y recubrimientos anticorrosivos. Aunque útil industrialmente, su exposición prolongada es peligrosa para la salud y el ambiente."
}

        Elementos(49) = New Elemento With {
    .A = 114.82,
    .Z = 49,
    .Nombre = "Indio",
    .Simbolo = "In",
    .Valencia = "3",
    .ConfigElectronica = "[Kr] 5s² 4d¹⁰ 5p¹",
    .PuntoDeEbullicion = "2072 °C",
    .PuntoDeFusion = "156.6 °C",
    .densidad = "7310 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1863, Ferdinand Reich y Hieronymus Richter",
    .EnergiaIonizacion = "5.786 eV",
    .Dureza = "Blanda",
    .Conductividad = "Alta",
    .Abundancia = "Muy baja en la corteza terrestre",
    .Descripcion = "El indio es un metal blando y maleable utilizado ampliamente en pantallas LCD, semiconductores y recubrimientos conductores debido a su excelente conductividad eléctrica y transparencia óptica."
}

        Elementos(50) = New Elemento With {
    .A = 118.71,
    .Z = 50,
    .Nombre = "Estaño",
    .Simbolo = "Sn",
    .Valencia = "2, 4",
    .ConfigElectronica = "[Kr] 5s² 4d¹⁰ 5p²",
    .PuntoDeEbullicion = "2602 °C",
    .PuntoDeFusion = "231.9 °C",
    .densidad = "7310 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "Antigüedad",
    .EnergiaIonizacion = "7.343 eV",
    .Dureza = "Media",
    .Conductividad = "Buena",
    .Abundancia = "0.00022% en la corteza terrestre",
    .Descripcion = "El estaño es un metal plateado utilizado desde la antigüedad en aleaciones como el bronce. Es resistente a la corrosión, lo que lo hace ideal para recubrimientos y soldaduras electrónicas."
}

        Elementos(51) = New Elemento With {
    .A = 121.76,
    .Z = 51,
    .Nombre = "Antimonio",
    .Simbolo = "Sb",
    .Valencia = "3, 5",
    .ConfigElectronica = "[Kr] 5s² 4d¹⁰ 5p³",
    .PuntoDeEbullicion = "1587 °C",
    .PuntoDeFusion = "630.6 °C",
    .densidad = "6690 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "Antigüedad",
    .EnergiaIonizacion = "8.608 eV",
    .Dureza = "Alta",
    .Conductividad = "Media",
    .Abundancia = "0.00002% en la corteza terrestre",
    .Descripcion = "El antimonio es un metaloide brillante y frágil usado en aleaciones para endurecer metales y en retardantes de llama. También se utiliza en la industria electrónica y en baterías."
}

        Elementos(52) = New Elemento With {
    .A = 127.6,
    .Z = 52,
    .Nombre = "Telurio",
    .Simbolo = "Te",
    .Valencia = "2, 4, 6",
    .ConfigElectronica = "[Kr] 5s² 4d¹⁰ 5p⁴",
    .PuntoDeEbullicion = "988 °C",
    .PuntoDeFusion = "449.5 °C",
    .densidad = "6240 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1782, Franz-Joseph Müller von Reichenstein",
    .EnergiaIonizacion = "9.009 eV",
    .Dureza = "Media",
    .Conductividad = "Semiconductora",
    .Abundancia = "Extremadamente rara",
    .Descripcion = "El telurio es un metaloide de color plateado usado en aleaciones, paneles solares y dispositivos termoeléctricos por sus propiedades semiconductoras y su capacidad para conducir calor y electricidad."
}

        Elementos(53) = New Elemento With {
    .A = 126.9,
    .Z = 53,
    .Nombre = "Yodo",
    .Simbolo = "I",
    .Valencia = "1, 5, 7",
    .ConfigElectronica = "[Kr] 5s² 4d¹⁰ 5p⁵",
    .PuntoDeEbullicion = "184.3 °C",
    .PuntoDeFusion = "113.7 °C",
    .densidad = "4930 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1811, Bernard Courtois",
    .EnergiaIonizacion = "10.451 eV",
    .Dureza = "Baja",
    .Conductividad = "Baja",
    .Abundancia = "Muy baja en la corteza terrestre",
    .Descripcion = "El yodo es un halógeno esencial para la vida, necesario en la producción de hormonas tiroideas. También se usa como antiséptico y en compuestos radiológicos."
}

        Elementos(54) = New Elemento With {
    .A = 131.29,
    .Z = 54,
    .Nombre = "Xenón",
    .Simbolo = "Xe",
    .Valencia = "2, 4, 6, 8",
    .ConfigElectronica = "[Kr] 5s² 4d¹⁰ 5p⁶",
    .PuntoDeEbullicion = "-108.1 °C",
    .PuntoDeFusion = "-111.8 °C",
    .densidad = "5.894 kg/m³",
    .EstadoFisico = "Gas",
    .Descubrimiento = "1898, William Ramsay y Morris Travers",
    .EnergiaIonizacion = "12.130 eV",
    .Dureza = "No aplica",
    .Conductividad = "Muy baja",
    .Abundancia = "Extremadamente baja en la atmósfera",
    .Descripcion = "El xenón es un gas noble incoloro e inodoro, empleado en lámparas de destello, anestesia y propulsión iónica espacial gracias a su estabilidad y densidad."
}

        Elementos(55) = New Elemento With {
    .A = 132.91,
    .Z = 55,
    .Nombre = "Cesio",
    .Simbolo = "Cs",
    .Valencia = "1",
    .ConfigElectronica = "[Xe] 6s¹",
    .PuntoDeEbullicion = "671 °C",
    .PuntoDeFusion = "28.4 °C",
    .densidad = "1870 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1860, Robert Bunsen y Gustav Kirchhoff",
    .EnergiaIonizacion = "3.893 eV",
    .Dureza = "Blanda",
    .Conductividad = "Alta",
    .Abundancia = "Muy baja",
    .Descripcion = "El cesio es un metal alcalino extremadamente reactivo y de bajo punto de fusión. Se usa en relojes atómicos, tubos fotoeléctricos y en sistemas de propulsión espacial."
}

        Elementos(56) = New Elemento With {
    .A = 137.33,
    .Z = 56,
    .Nombre = "Bario",
    .Simbolo = "Ba",
    .Valencia = "2",
    .ConfigElectronica = "[Xe] 6s²",
    .PuntoDeEbullicion = "1640 °C",
    .PuntoDeFusion = "727 °C",
    .densidad = "3510 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1774, Carl Wilhelm Scheele",
    .EnergiaIonizacion = "5.212 eV",
    .Dureza = "Media",
    .Conductividad = "Alta",
    .Abundancia = "0.042% en la corteza terrestre",
    .Descripcion = "El bario es un metal alcalinotérreo plateado, reactivo con el agua y el aire. Sus compuestos se emplean en radiografías, fuegos artificiales y cerámicas eléctricas."
}

        Elementos(57) = New Elemento With {
    .A = 138.91,
    .Z = 57,
    .Nombre = "Lantano",
    .Simbolo = "La",
    .Valencia = "3",
    .ConfigElectronica = "[Xe] 6s² 5d¹",
    .PuntoDeEbullicion = "3464 °C",
    .PuntoDeFusion = "920 °C",
    .densidad = "6146 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1839, Carl Mosander",
    .EnergiaIonizacion = "5.577 eV",
    .Dureza = "Media",
    .Conductividad = "Buena",
    .Abundancia = "0.0034% en la corteza terrestre",
    .Descripcion = "El lantano es el primero de los lantánidos. Se utiliza en vidrios ópticos, electrodos y catalizadores. Es maleable y mejora la capacidad de almacenamiento de hidrógeno en aleaciones."
}

        Elementos(58) = New Elemento With {
    .A = 140.12,
    .Z = 58,
    .Nombre = "Cerio",
    .Simbolo = "Ce",
    .Valencia = "3, 4",
    .ConfigElectronica = "[Xe] 6s² 4f¹ 5d¹",
    .PuntoDeEbullicion = "3360 °C",
    .PuntoDeFusion = "795 °C",
    .densidad = "6770 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1803, Martin Klaproth",
    .EnergiaIonizacion = "5.539 eV",
    .Dureza = "Media",
    .Conductividad = "Buena",
    .Abundancia = "0.0046% en la corteza terrestre",
    .Descripcion = "El cerio es el lantánido más abundante y tiene una notable capacidad para almacenar oxígeno, lo que lo hace vital en catalizadores automotrices y vidrios pulidos de alta calidad."
}


        Elementos(59) = New Elemento With {
    .A = 140.91,
    .Z = 59,
    .Nombre = "Praseodimio",
    .Simbolo = "Pr",
    .Valencia = "3, 4",
    .ConfigElectronica = "[Xe] 6s² 4f³",
    .PuntoDeEbullicion = "3290 °C",
    .PuntoDeFusion = "931 °C",
    .densidad = "6640 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1885, Carl Auer von Welsbach",
    .EnergiaIonizacion = "5.464 eV",
    .Dureza = "Media",
    .Conductividad = "Buena",
    .Abundancia = "0.00086% en la corteza terrestre",
    .Descripcion = "El praseodimio es un metal raro de color plateado verdoso, usado en imanes de alta potencia, aleaciones aeronáuticas y vidrios de protección ocular para soldadores."
}

        Elementos(60) = New Elemento With {
    .A = 144.24,
    .Z = 60,
    .Nombre = "Neodimio",
    .Simbolo = "Nd",
    .Valencia = "3",
    .ConfigElectronica = "[Xe] 6s² 4f⁴",
    .PuntoDeEbullicion = "3074 °C",
    .PuntoDeFusion = "1024 °C",
    .densidad = "7000 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1885, Carl Auer von Welsbach",
    .EnergiaIonizacion = "5.525 eV",
    .Dureza = "Media",
    .Conductividad = "Buena",
    .Abundancia = "0.0033% en la corteza terrestre",
    .Descripcion = "El neodimio es un metal de tierras raras usado en la fabricación de los imanes permanentes más potentes del mundo, empleados en motores eléctricos y dispositivos electrónicos."
}

        Elementos(61) = New Elemento With {
    .A = 145.0,
    .Z = 61,
    .Nombre = "Prometio",
    .Simbolo = "Pm",
    .Valencia = "3",
    .ConfigElectronica = "[Xe] 6s² 4f⁵",
    .PuntoDeEbullicion = "3000 °C (aprox.)",
    .PuntoDeFusion = "1100 °C (aprox.)",
    .densidad = "7260 kg/m³",
    .EstadoFisico = "Sólido radiactivo",
    .Descubrimiento = "1945, Jacob A. Marinsky, Lawrence E. Glendenin y Charles D. Coryell",
    .EnergiaIonizacion = "5.582 eV",
    .Dureza = "Media",
    .Conductividad = "Buena",
    .Abundancia = "No natural, producido artificialmente",
    .Descripcion = "El prometio es un elemento radiactivo raro que no se encuentra en la Tierra en cantidades significativas. Se utiliza en baterías nucleares y dispositivos que requieren fuentes de radiación controlada."
}

        Elementos(62) = New Elemento With {
    .A = 150.36,
    .Z = 62,
    .Nombre = "Samario",
    .Simbolo = "Sm",
    .Valencia = "2, 3",
    .ConfigElectronica = "[Xe] 6s² 4f⁶",
    .PuntoDeEbullicion = "1900 °C",
    .PuntoDeFusion = "1072 °C",
    .densidad = "7350 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1879, Paul Émile Lecoq de Boisbaudran",
    .EnergiaIonizacion = "5.644 eV",
    .Dureza = "Media",
    .Conductividad = "Buena",
    .Abundancia = "0.0006% en la corteza terrestre",
    .Descripcion = "El samario es una tierra rara utilizada en imanes permanentes resistentes a altas temperaturas y en reactores nucleares como absorbedor de neutrones."
}

        Elementos(63) = New Elemento With {
    .A = 151.96,
    .Z = 63,
    .Nombre = "Europio",
    .Simbolo = "Eu",
    .Valencia = "2, 3",
    .ConfigElectronica = "[Xe] 6s² 4f⁷",
    .PuntoDeEbullicion = "1529 °C",
    .PuntoDeFusion = "826 °C",
    .densidad = "5240 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1901, Eugène-Anatole Demarçay",
    .EnergiaIonizacion = "5.670 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "0.00018% en la corteza terrestre",
    .Descripcion = "El europio es un metal blando de brillo plateado usado en pantallas de televisión, LED y dispositivos fluorescentes por su capacidad de emitir luz roja intensa."
}

        Elementos(64) = New Elemento With {
    .A = 157.25,
    .Z = 64,
    .Nombre = "Gadolinio",
    .Simbolo = "Gd",
    .Valencia = "3",
    .ConfigElectronica = "[Xe] 6s² 4f⁷ 5d¹",
    .PuntoDeEbullicion = "3273 °C",
    .PuntoDeFusion = "1313 °C",
    .densidad = "7900 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1880, Jean Charles Galissard de Marignac",
    .EnergiaIonizacion = "6.150 eV",
    .Dureza = "Media",
    .Conductividad = "Buena",
    .Abundancia = "0.00052% en la corteza terrestre",
    .Descripcion = "El gadolinio posee fuertes propiedades magnéticas y se utiliza en resonancias magnéticas (RMN), reactores nucleares y materiales magnetocalóricos."
}

        Elementos(65) = New Elemento With {
    .A = 158.93,
    .Z = 65,
    .Nombre = "Terbio",
    .Simbolo = "Tb",
    .Valencia = "3, 4",
    .ConfigElectronica = "[Xe] 6s² 4f⁹",
    .PuntoDeEbullicion = "3230 °C",
    .PuntoDeFusion = "1356 °C",
    .densidad = "8220 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1843, Carl Mosander",
    .EnergiaIonizacion = "5.864 eV",
    .Dureza = "Media",
    .Conductividad = "Media",
    .Abundancia = "0.0001% en la corteza terrestre",
    .Descripcion = "El terbio es un elemento brillante utilizado en fósforos verdes de pantallas y lámparas, así como en imanes y materiales magneto-ópticos."
}

        Elementos(66) = New Elemento With {
    .A = 162.5,
    .Z = 66,
    .Nombre = "Disprosio",
    .Simbolo = "Dy",
    .Valencia = "3",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁰",
    .PuntoDeEbullicion = "2567 °C",
    .PuntoDeFusion = "1407 °C",
    .densidad = "8550 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1886, Paul Émile Lecoq de Boisbaudran",
    .EnergiaIonizacion = "5.939 eV",
    .Dureza = "Alta",
    .Conductividad = "Buena",
    .Abundancia = "0.00062% en la corteza terrestre",
    .Descripcion = "El disprosio se utiliza en imanes de alta resistencia térmica y en barras de control de reactores nucleares debido a su capacidad para absorber neutrones."
}

        Elementos(67) = New Elemento With {
    .A = 164.93,
    .Z = 67,
    .Nombre = "Holmio",
    .Simbolo = "Ho",
    .Valencia = "3",
    .ConfigElectronica = "[Xe] 6s² 4f¹¹",
    .PuntoDeEbullicion = "2700 °C",
    .PuntoDeFusion = "1461 °C",
    .densidad = "8790 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1878, Marc Delafontaine y Jacques-Louis Soret",
    .EnergiaIonizacion = "6.022 eV",
    .Dureza = "Media",
    .Conductividad = "Buena",
    .Abundancia = "0.00012% en la corteza terrestre",
    .Descripcion = "El holmio posee el mayor momento magnético de todos los elementos naturales y se usa en imanes especializados, láseres médicos y materiales ópticos avanzados."
}

        Elementos(68) = New Elemento With {
    .A = 167.26,
    .Z = 68,
    .Nombre = "Erbio",
    .Simbolo = "Er",
    .Valencia = "3",
    .ConfigElectronica = "[Xe] 6s² 4f¹²",
    .PuntoDeEbullicion = "2868 °C",
    .PuntoDeFusion = "1529 °C",
    .densidad = "9066 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1843, Carl Mosander",
    .EnergiaIonizacion = "6.108 eV",
    .Dureza = "Media",
    .Conductividad = "Buena",
    .Abundancia = "0.0003% en la corteza terrestre",
    .Descripcion = "El erbio se usa en fibras ópticas, amplificadores láser y materiales de color rosado para vidrios y cerámicas. Posee excelentes propiedades ópticas y magnéticas."
}

        Elementos(69) = New Elemento With {
    .A = 168.93,
    .Z = 69,
    .Nombre = "Tulio",
    .Simbolo = "Tm",
    .Valencia = "3",
    .ConfigElectronica = "[Xe] 6s² 4f¹³",
    .PuntoDeEbullicion = "1950 °C",
    .PuntoDeFusion = "1545 °C",
    .densidad = "9320 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1879, Per Teodor Cleve",
    .EnergiaIonizacion = "6.184 eV",
    .Dureza = "Media",
    .Conductividad = "Buena",
    .Abundancia = "0.000063% en la corteza terrestre",
    .Descripcion = "El tulio es un metal raro utilizado en láseres sólidos y en fuentes de radiación en dispositivos médicos. Es relativamente estable y de baja reactividad química."
}

        Elementos(70) = New Elemento With {
    .A = 173.05,
    .Z = 70,
    .Nombre = "Iterbio",
    .Simbolo = "Yb",
    .Valencia = "2, 3",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴",
    .PuntoDeEbullicion = "1196 °C",
    .PuntoDeFusion = "824 °C",
    .densidad = "6580 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1878, Jean Charles Galissard de Marignac",
    .EnergiaIonizacion = "6.254 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "0.0003% en la corteza terrestre",
    .Descripcion = "El iterbio es utilizado en aleaciones de metales y en láseres de estado sólido. Presenta una gran estabilidad química y propiedades ópticas interesantes."
}

        Elementos(71) = New Elemento With {
    .A = 174.97,
    .Z = 71,
    .Nombre = "Lutecio",
    .Simbolo = "Lu",
    .Valencia = "3",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d¹",
    .PuntoDeEbullicion = "3402 °C",
    .PuntoDeFusion = "1663 °C",
    .densidad = "9400 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1907, Georges Urbain",
    .EnergiaIonizacion = "5.425 eV",
    .Dureza = "Alta",
    .Conductividad = "Buena",
    .Abundancia = "0.00012% en la corteza terrestre",
    .Descripcion = "El lutecio es el más pesado de los lantánidos. Se utiliza en catalizadores de refinación de petróleo y en investigación científica avanzada. Posee propiedades magnéticas y ópticas únicas."
}

        Elementos(72) = New Elemento With {
    .A = 178.49,
    .Z = 72,
    .Nombre = "Hafnio",
    .Simbolo = "Hf",
    .Valencia = "4",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d²",
    .PuntoDeEbullicion = "4876 °C",
    .PuntoDeFusion = "2233 °C",
    .densidad = "13310 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1923, Dirk Coster y George de Hevesy",
    .EnergiaIonizacion = "6.825 eV",
    .Dureza = "Alta",
    .Conductividad = "Buena",
    .Abundancia = "0.0013% en la corteza terrestre",
    .Descripcion = "El hafnio es un metal resistente a la corrosión y se emplea en aleaciones para reactores nucleares, filamentos de lámparas y componentes electrónicos de alta temperatura."
}

        Elementos(73) = New Elemento With {
    .A = 180.95,
    .Z = 73,
    .Nombre = "Tantalio",
    .Simbolo = "Ta",
    .Valencia = "5",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d³",
    .PuntoDeEbullicion = "5458 °C",
    .PuntoDeFusion = "3017 °C",
    .densidad = "16650 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1802, Anders Ekeberg",
    .EnergiaIonizacion = "7.89 eV",
    .Dureza = "Alta",
    .Conductividad = "Buena",
    .Abundancia = "0.0012% en la corteza terrestre",
    .Descripcion = "El tantalio es altamente resistente a la corrosión y se utiliza en condensadores electrónicos, implantes médicos y componentes de alta resistencia química."
}

        Elementos(74) = New Elemento With {
    .A = 183.84,
    .Z = 74,
    .Nombre = "Wolframio",
    .Simbolo = "W",
    .Valencia = "6",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d⁴",
    .PuntoDeEbullicion = "5555 °C",
    .PuntoDeFusion = "3422 °C",
    .densidad = "19300 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1783, Juan José y Fausto Elhuyar",
    .EnergiaIonizacion = "7.98 eV",
    .Dureza = "Muy alta",
    .Conductividad = "Buena",
    .Abundancia = "0.00011% en la corteza terrestre",
    .Descripcion = "El wolframio o tungsteno es un metal muy duro con el punto de fusión más alto de los metales. Se emplea en filamentos de lámparas, herramientas de corte y aleaciones resistentes al calor."
}

        Elementos(75) = New Elemento With {
    .A = 180.95,
    .Z = 75,
    .Nombre = "Renio",
    .Simbolo = "Re",
    .Valencia = "7",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d⁵",
    .PuntoDeEbullicion = "5596 °C",
    .PuntoDeFusion = "3186 °C",
    .densidad = "21020 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1925, Walter Noddack, Ida Tacke y Otto Berg",
    .EnergiaIonizacion = "7.88 eV",
    .Dureza = "Muy alta",
    .Conductividad = "Buena",
    .Abundancia = "0.0000004% en la corteza terrestre",
    .Descripcion = "El renio es un metal raro extremadamente resistente al calor, usado en superaleaciones para motores a reacción y filamentos eléctricos especiales."
}

        Elementos(76) = New Elemento With {
    .A = 190.23,
    .Z = 76,
    .Nombre = "Osmio",
    .Simbolo = "Os",
    .Valencia = "4",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d⁶",
    .PuntoDeEbullicion = "5012 °C",
    .PuntoDeFusion = "3045 °C",
    .densidad = "22590 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1803, Smithson Tennant",
    .EnergiaIonizacion = "8.7 eV",
    .Dureza = "Muy alta",
    .Conductividad = "Buena",
    .Abundancia = "0.000001% en la corteza terrestre",
    .Descripcion = "El osmio es el metal más denso, usado en puntas de plumas, contactos eléctricos y aleaciones de alta resistencia a la abrasión. Es muy resistente a la corrosión."
}

        Elementos(77) = New Elemento With {
    .A = 192.22,
    .Z = 77,
    .Nombre = "Iridio",
    .Simbolo = "Ir",
    .Valencia = "3, 4",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d⁷",
    .PuntoDeEbullicion = "4130 °C",
    .PuntoDeFusion = "2466 °C",
    .densidad = "22450 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1803, Smithson Tennant",
    .EnergiaIonizacion = "9.1 eV",
    .Dureza = "Muy alta",
    .Conductividad = "Buena",
    .Abundancia = "0.000001% en la corteza terrestre",
    .Descripcion = "El iridio es extremadamente resistente a la corrosión y se utiliza en contactos eléctricos, bujías y aleaciones de alta durabilidad."
}

        Elementos(78) = New Elemento With {
    .A = 195.08,
    .Z = 78,
    .Nombre = "Platino",
    .Simbolo = "Pt",
    .Valencia = "2, 4",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d⁹",
    .PuntoDeEbullicion = "3825 °C",
    .PuntoDeFusion = "1768 °C",
    .densidad = "21450 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1735, Antonio de Ulloa",
    .EnergiaIonizacion = "8.96 eV",
    .Dureza = "Alta",
    .Conductividad = "Buena",
    .Abundancia = "0.000005% en la corteza terrestre",
    .Descripcion = "El platino es un metal noble, altamente resistente a la corrosión y químicamente estable, utilizado en joyería, catalizadores automotrices y equipos químicos de precisión."
}


        Elementos(79) = New Elemento With {
    .A = 196.97,
    .Z = 79,
    .Nombre = "Oro",
    .Simbolo = "Au",
    .Valencia = "1, 3",
    .ConfigElectronica = "[Xe] 6s¹ 4f¹⁴ 5d¹⁰",
    .PuntoDeEbullicion = "2856 °C",
    .PuntoDeFusion = "1064 °C",
    .densidad = "19300 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "Antigüedad",
    .EnergiaIonizacion = "9.23 eV",
    .Dureza = "Blanda",
    .Conductividad = "Excelente",
    .Abundancia = "0.003 ppm en la corteza terrestre",
    .Descripcion = "El oro es un metal noble extremadamente resistente a la corrosión y altamente maleable. Se utiliza en joyería, electrónica de precisión, monedas y como estándar monetario histórico."
}

        Elementos(80) = New Elemento With {
    .A = 200.59,
    .Z = 80,
    .Nombre = "Mercurio",
    .Simbolo = "Hg",
    .Valencia = "1, 2",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d¹⁰",
    .PuntoDeEbullicion = "356.7 °C",
    .PuntoDeFusion = "-38.83 °C",
    .densidad = "13534 kg/m³",
    .EstadoFisico = "Líquido",
    .Descubrimiento = "Antigüedad",
    .EnergiaIonizacion = "10.44 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "0.08 ppm en la corteza terrestre",
    .Descripcion = "El mercurio es un metal líquido a temperatura ambiente, usado históricamente en termómetros, barómetros y amalgamas dentales. Es tóxico y requiere manipulación cuidadosa."
}

        Elementos(81) = New Elemento With {
    .A = 204.38,
    .Z = 81,
    .Nombre = "Talio",
    .Simbolo = "Tl",
    .Valencia = "1, 3",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d¹⁰ 6p¹",
    .PuntoDeEbullicion = "1473 °C",
    .PuntoDeFusion = "304 °C",
    .densidad = "11850 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1861, William Crookes",
    .EnergiaIonizacion = "6.11 eV",
    .Dureza = "Blanda",
    .Conductividad = "Moderada",
    .Abundancia = "0.7 ppm en la corteza terrestre",
    .Descripcion = "El talio es un metal tóxico y blando, utilizado en detectores de rayos infrarrojos y electrónica. Su manipulación requiere extrema precaución debido a su toxicidad."
}

        Elementos(82) = New Elemento With {
    .A = 207.2,
    .Z = 82,
    .Nombre = "Plomo",
    .Simbolo = "Pb",
    .Valencia = "2, 4",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d¹⁰ 6p²",
    .PuntoDeEbullicion = "1749 °C",
    .PuntoDeFusion = "327.5 °C",
    .densidad = "11340 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "Antigüedad",
    .EnergiaIonizacion = "7.42 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "14 ppm en la corteza terrestre",
    .Descripcion = "El plomo es un metal pesado, maleable y tóxico. Ha sido usado en tuberías, pinturas y baterías, pero su uso está regulado debido a efectos adversos sobre la salud."
}

        Elementos(83) = New Elemento With {
    .A = 208.98,
    .Z = 83,
    .Nombre = "Bismuto",
    .Simbolo = "Bi",
    .Valencia = "3, 5",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d¹⁰ 6p³",
    .PuntoDeEbullicion = "1564 °C",
    .PuntoDeFusion = "271.5 °C",
    .densidad = "9800 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "Antigüedad",
    .EnergiaIonizacion = "7.29 eV",
    .Dureza = "Blanda",
    .Conductividad = "Baja",
    .Abundancia = "2 ppm en la corteza terrestre",
    .Descripcion = "El bismuto es un metal pesado, frágil y no tóxico. Se utiliza en aleaciones de bajo punto de fusión, cosméticos, medicamentos y fusibles eléctricos."
}

        Elementos(84) = New Elemento With {
    .A = 209,
    .Z = 84,
    .Nombre = "Polonio",
    .Simbolo = "Po",
    .Valencia = "2, 4, 6",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d¹⁰ 6p⁴",
    .PuntoDeEbullicion = "962 °C",
    .PuntoDeFusion = "254 °C",
    .densidad = "9670 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1898, Marie y Pierre Curie",
    .EnergiaIonizacion = "8.42 eV",
    .Dureza = "Blanda",
    .Conductividad = "Baja",
    .Abundancia = "Extremadamente raro",
    .Descripcion = "El polonio es un elemento radioactivo extremadamente raro. Su manipulación requiere instalaciones especiales. Se utiliza en investigaciones nucleares y como fuente de calor en generadores termonucleares."
}

        Elementos(85) = New Elemento With {
    .A = 210,
    .Z = 85,
    .Nombre = "Astato",
    .Simbolo = "At",
    .Valencia = "1, 3, 5, 7",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d¹⁰ 6p⁵",
    .PuntoDeEbullicion = "337 °C",
    .PuntoDeFusion = "302 °C",
    .densidad = "7000 kg/m³ (estimada)",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1940, Dale Corson, Kenneth MacKenzie, Emilio Segrè",
    .EnergiaIonizacion = "9.32 eV",
    .Dureza = "Blanda",
    .Conductividad = "Baja",
    .Abundancia = "Extremadamente raro",
    .Descripcion = "El astato es un halógeno radioactivo muy raro. Se forma naturalmente en trazas y se utiliza solo en estudios científicos especializados debido a su alta radiactividad."
}

        Elementos(86) = New Elemento With {
    .A = 222,
    .Z = 86,
    .Nombre = "Radón",
    .Simbolo = "Rn",
    .Valencia = "0",
    .ConfigElectronica = "[Xe] 6s² 4f¹⁴ 5d¹⁰ 6p⁶",
    .PuntoDeEbullicion = "-61.7 °C",
    .PuntoDeFusion = "-71 °C",
    .densidad = "9.73 kg/m³ (gas)",
    .EstadoFisico = "Gas",
    .Descubrimiento = "1900, Friedrich Dorn",
    .EnergiaIonizacion = "10.75 eV",
    .Dureza = "No aplica",
    .Conductividad = "No aplica",
    .Abundancia = "Extremadamente raro",
    .Descripcion = "El radón es un gas noble radioactivo. Se encuentra en suelos y aguas subterráneas, y es importante en estudios ambientales por su riesgo para la salud humana."
}

        Elementos(87) = New Elemento With {
    .A = 223,
    .Z = 87,
    .Nombre = "Francio",
    .Simbolo = "Fr",
    .Valencia = "1",
    .ConfigElectronica = "[Rn] 7s¹",
    .PuntoDeEbullicion = "950 °C (estimada)",
    .PuntoDeFusion = "27 °C",
    .densidad = "16700 kg/m³ (estimada)",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1939, Marguerite Perey",
    .EnergiaIonizacion = "4.07 eV",
    .Dureza = "Blanda",
    .Conductividad = "Desconocida",
    .Abundancia = "Extremadamente raro",
    .Descripcion = "El francio es un metal alcalino radioactivo extremadamente raro. Se encuentra solo en trazas en la naturaleza y su estudio está limitado a investigaciones especializadas."
}

        Elementos(88) = New Elemento With {
    .A = 226,
    .Z = 88,
    .Nombre = "Radio",
    .Simbolo = "Ra",
    .Valencia = "2",
    .ConfigElectronica = "[Rn] 7s²",
    .PuntoDeEbullicion = "1413 °C",
    .PuntoDeFusion = "700 °C",
    .densidad = "5000 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1898, Pierre y Marie Curie",
    .EnergiaIonizacion = "5.28 eV",
    .Dureza = "Blanda",
    .Conductividad = "Baja",
    .Abundancia = "Extremadamente raro",
    .Descripcion = "El radio es un metal alcalinotérreo radioactivo. Se utilizó históricamente en pintura luminosa y actualmente se estudia en aplicaciones médicas y nucleares, bajo estrictas medidas de seguridad."
}

        Elementos(89) = New Elemento With {
    .A = 227,
    .Z = 89,
    .Nombre = "Actinio",
    .Simbolo = "Ac",
    .Valencia = "3",
    .ConfigElectronica = "[Rn] 7s² 6d¹",
    .PuntoDeEbullicion = "3200 °C",
    .PuntoDeFusion = "1050 °C",
    .densidad = "10070 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1899, André-Louis Debierne",
    .EnergiaIonizacion = "5.17 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "Extremadamente raro",
    .Descripcion = "El actinio es un metal radioactivo del grupo de los actínidos. Es altamente radiactivo y se utiliza en investigaciones nucleares y fuentes de neutrones."
}

        Elementos(90) = New Elemento With {
    .A = 232.04,
    .Z = 90,
    .Nombre = "Torio",
    .Simbolo = "Th",
    .Valencia = "4",
    .ConfigElectronica = "[Rn] 7s² 6d²",
    .PuntoDeEbullicion = "4788 °C",
    .PuntoDeFusion = "1750 °C",
    .densidad = "11350 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1829, Jöns Jacob Berzelius",
    .EnergiaIonizacion = "6.31 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "3 ppm en la corteza terrestre",
    .Descripcion = "El torio es un metal radiactivo que se estudia como combustible nuclear y en aplicaciones de alta temperatura. Presenta baja reactividad química relativa."
}

        Elementos(91) = New Elemento With {
    .A = 231.04,
    .Z = 91,
    .Nombre = "Protactinio",
    .Simbolo = "Pa",
    .Valencia = "5",
    .ConfigElectronica = "[Rn] 7s² 5f² 6d¹",
    .PuntoDeEbullicion = "4273 °C",
    .PuntoDeFusion = "1572 °C",
    .densidad = "15400 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1913, Kasimir Fajans y Oswald Helmuth Göhring",
    .EnergiaIonizacion = "5.89 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "Extremadamente raro",
    .Descripcion = "El protactinio es un metal radiactivo, muy raro y costoso de obtener. Se utiliza principalmente en investigación nuclear y en estudios sobre la química de los actínidos."
}

        Elementos(92) = New Elemento With {
    .A = 238.03,
    .Z = 92,
    .Nombre = "Uranio",
    .Simbolo = "U",
    .Valencia = "3, 4, 6",
    .ConfigElectronica = "[Rn] 7s² 5f³ 6d¹",
    .PuntoDeEbullicion = "4131 °C",
    .PuntoDeFusion = "1132 °C",
    .densidad = "18950 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1789, Martin Heinrich Klaproth",
    .EnergiaIonizacion = "6.2 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "2.7 ppm en la corteza terrestre",
    .Descripcion = "El uranio es un metal pesado radiactivo, utilizado en reactores nucleares y armas nucleares. Presenta alta densidad y es químicamente reactivo con ácidos y oxígeno."
}

        Elementos(93) = New Elemento With {
    .A = 237,
    .Z = 93,
    .Nombre = "Neptunio",
    .Simbolo = "Np",
    .Valencia = "3, 4, 5, 6, 7",
    .ConfigElectronica = "[Rn] 7s² 5f⁴ 6d¹",
    .PuntoDeEbullicion = "4175 °C",
    .PuntoDeFusion = "640 °C",
    .densidad = "20450 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1940, Edwin McMillan y Philip H. Abelson",
    .EnergiaIonizacion = "6.27 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "Sintético",
    .Descripcion = "El neptunio es un actínido radiactivo producido artificialmente. Se utiliza en investigaciones nucleares y como precursor para la síntesis de plutonio y otros elementos pesados."
}

        Elementos(94) = New Elemento With {
    .A = 244,
    .Z = 94,
    .Nombre = "Plutonio",
    .Simbolo = "Pu",
    .Valencia = "3, 4, 5, 6",
    .ConfigElectronica = "[Rn] 7s² 5f⁶",
    .PuntoDeEbullicion = "3230 °C",
    .PuntoDeFusion = "639.5 °C",
    .densidad = "19800 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1940, Glenn T. Seaborg y Edwin McMillan",
    .EnergiaIonizacion = "6.06 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "Sintético",
    .Descripcion = "El plutonio es un actínido altamente radiactivo, utilizado en reactores nucleares y armas nucleares. Su manejo requiere extrema precaución y protocolos de seguridad nucleares estrictos."
}

        Elementos(95) = New Elemento With {
    .A = 243,
    .Z = 95,
    .Nombre = "Americio",
    .Simbolo = "Am",
    .Valencia = "3, 4",
    .ConfigElectronica = "[Rn] 7s² 5f⁷ 6d⁰",
    .PuntoDeEbullicion = "2607 °C",
    .PuntoDeFusion = "1176 °C",
    .densidad = "12200 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1944, Glenn T. Seaborg, Ralph A. James y Leon O. Morgan",
    .EnergiaIonizacion = "5.97 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "Sintético",
    .Descripcion = "El americio es un actínido radiactivo, producido artificialmente. Se utiliza en detectores de humo y en aplicaciones de investigación nuclear debido a su radioactividad controlada."
}

        Elementos(96) = New Elemento With {
    .A = 247,
    .Z = 96,
    .Nombre = "Curio",
    .Simbolo = "Cm",
    .Valencia = "3, 4",
    .ConfigElectronica = "[Rn] 7s² 5f⁷ 6d¹",
    .PuntoDeEbullicion = "3383 °C",
    .PuntoDeFusion = "1340 °C",
    .densidad = "13150 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1944, Glenn T. Seaborg, Albert Ghiorso y Ralph A. James",
    .EnergiaIonizacion = "5.99 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "Sintético",
    .Descripcion = "El curio es un actínido sintético y radiactivo. Se utiliza principalmente en investigación científica y en fuentes de neutrones portátiles."
}

        Elementos(97) = New Elemento With {
    .A = 247,
    .Z = 97,
    .Nombre = "Berkelio",
    .Simbolo = "Bk",
    .Valencia = "3, 4",
    .ConfigElectronica = "[Rn] 7s² 5f⁹",
    .PuntoDeEbullicion = "Unknown",
    .PuntoDeFusion = "986 °C",
    .densidad = "14300 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1949, Albert Ghiorso y colaboradores",
    .EnergiaIonizacion = "6.23 eV",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "Sintético",
    .Descripcion = "El berkelio es un actínido sintético y radiactivo, producido en laboratorios. Se usa únicamente en investigación científica debido a su radiactividad y escasa disponibilidad."
}

        Elementos(98) = New Elemento With {
    .A = 251,
    .Z = 98,
    .Nombre = "Californio",
    .Simbolo = "Cf",
    .Valencia = "3, 2",
    .ConfigElectronica = "[Rn] 7s² 5f¹⁰",
    .PuntoDeEbullicion = "Unknown",
    .PuntoDeFusion = "900 °C",
    .densidad = "15100 kg/m³",
    .EstadoFisico = "Sólido",
    .Descubrimiento = "1950, Albert Ghiorso y colaboradores",
    .EnergiaIonizacion = "Unknown",
    .Dureza = "Blanda",
    .Conductividad = "Media",
    .Abundancia = "Sintético",
    .Descripcion = "El californio es un actínido radiactivo sintético. Se produce en aceleradores de partículas y se utiliza en investigación científica y aplicaciones nucleares especializadas."
}

        Elementos(99) = New Elemento With {
            .A = 252,
            .Z = 99,
            .Nombre = "Einsteinio",
            .Simbolo = "Es",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 7s² 5f¹¹",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "860 °C",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1952, Albert Ghiorso y colaboradores",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El einsteinio es un actínido sintético altamente radiactivo, producido en laboratorios. No tiene aplicaciones comerciales y se usa principalmente en investigación nuclear."
        }

        Elementos(100) = New Elemento With {
            .A = 257,
            .Z = 100,
            .Nombre = "Fermio",
            .Simbolo = "Fm",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 7s² 5f¹²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "1527 °C",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1952, Albert Ghiorso y colaboradores",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El fermio es un elemento transuránico sintético. Debido a su extrema radioactividad, se utiliza únicamente en estudios científicos de laboratorios de alta seguridad."
        }

        Elementos(101) = New Elemento With {
            .A = 258,
            .Z = 101,
            .Nombre = "Mendelevio",
            .Simbolo = "Md",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 7s² 5f¹³",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "827 °C",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1955, Albert Ghiorso y colaboradores",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El mendelevio es un actínido sintético radiactivo producido artificialmente. Su uso está limitado a investigaciones científicas y experimentos nucleares."
        }

        Elementos(102) = New Elemento With {
            .A = 259,
            .Z = 102,
            .Nombre = "Nobelio",
            .Simbolo = "No",
            .Valencia = "2, 3",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "827 °C",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1966, Georgy Flerov y colaboradores",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El nobelio es un elemento transuránico sintético, altamente radiactivo, utilizado únicamente en estudios científicos. No tiene aplicaciones comerciales."
        }

        Elementos(103) = New Elemento With {
            .A = 262,
            .Z = 103,
            .Nombre = "Lawrencio",
            .Simbolo = "Lr",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d¹",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "1627 °C",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1961, Albert Ghiorso y colaboradores",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El lawrencio es un actínido sintético, muy radiactivo y producido en laboratorios especializados. Su investigación contribuye al estudio de los elementos más pesados."
        }

        Elementos(104) = New Elemento With {
            .A = 267,
            .Z = 104,
            .Nombre = "Rutherfordio",
            .Simbolo = "Rf",
            .Valencia = "4",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1964, Georgy Flerov y colaboradores",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El rutherfordio es un elemento sintético de la serie de transactínidos, extremadamente radiactivo y producido únicamente en laboratorios de investigación avanzada."
        }

        Elementos(105) = New Elemento With {
            .A = 268,
            .Z = 105,
            .Nombre = "Dubnio",
            .Simbolo = "Db",
            .Valencia = "5",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d³",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1967, Georgy Flerov y colaboradores",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El dubnio es un transactínido sintético, radiactivo y extremadamente inestable. Su estudio se limita a experimentos de laboratorio en física nuclear."
        }

        Elementos(106) = New Elemento With {
            .A = 271,
            .Z = 106,
            .Nombre = "Seaborgio",
            .Simbolo = "Sg",
            .Valencia = "6",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d⁴",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1974, Albert Ghiorso y colaboradores",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El seaborgio es un elemento transuránico sintético, muy inestable y radiactivo. Su investigación permite explorar propiedades de los elementos más pesados de la tabla periódica."
        }

        Elementos(107) = New Elemento With {
            .A = 270,
            .Z = 107,
            .Nombre = "Bohrio",
            .Simbolo = "Bh",
            .Valencia = "7",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d⁵",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1976, Gesellschaft für Schwerionenforschung",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El bohrio es un elemento sintético extremadamente radiactivo, sin aplicaciones comerciales, usado únicamente en estudios de laboratorio sobre transactínidos."
        }

        Elementos(108) = New Elemento With {
            .A = 277,
            .Z = 108,
            .Nombre = "Hassio",
            .Simbolo = "Hs",
            .Valencia = "8",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d⁶",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1984, Gesellschaft für Schwerionenforschung",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El hassio es un elemento transuránico sintético. Altamente radiactivo, se produce solo en experimentos de laboratorio y no tiene aplicaciones comerciales."
        }

        Elementos(109) = New Elemento With {
            .A = 276,
            .Z = 109,
            .Nombre = "Meitnerio",
            .Simbolo = "Mt",
            .Valencia = "8",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d⁷",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1982, Gesellschaft für Schwerionenforschung",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El meitnerio es un elemento sintético altamente radiactivo, utilizado únicamente en experimentos científicos de laboratorios nucleares."
        }

        Elementos(110) = New Elemento With {
            .A = 281,
            .Z = 110,
            .Nombre = "Darmstadtio",
            .Simbolo = "Ds",
            .Valencia = "8",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d⁸",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1994, Gesellschaft für Schwerionenforschung",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El darmstadtio es un elemento transactínido sintético, extremadamente inestable y radiactivo. Su estudio está limitado a laboratorios de investigación avanzada."
        }

        Elementos(111) = New Elemento With {
            .A = 282,
            .Z = 111,
            .Nombre = "Roentgenio",
            .Simbolo = "Rg",
            .Valencia = "1, 3",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d⁹",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1994, Gesellschaft für Schwerionenforschung",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El roentgenio es un elemento sintético de los transactínidos, altamente inestable y radiactivo, usado exclusivamente para investigación científica."
        }

        Elementos(112) = New Elemento With {
            .A = 285,
            .Z = 112,
            .Nombre = "Copernicio",
            .Simbolo = "Cn",
            .Valencia = "2",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d¹⁰",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1996, Gesellschaft für Schwerionenforschung",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El copernicio es un elemento transactínido sintético, extremadamente radiactivo y producido solo en laboratorios. Se utiliza en investigaciones científicas."
        }

        Elementos(113) = New Elemento With {
            .A = 286,
            .Z = 113,
            .Nombre = "Nihonio",
            .Simbolo = "Nh",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d¹⁰ 7p¹",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "2004, RIKEN",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El nihonio es un elemento sintético radiactivo. Su existencia y propiedades se estudian en laboratorios especializados en Japón."
        }

        Elementos(114) = New Elemento With {
            .A = 289,
            .Z = 114,
            .Nombre = "Flerovio",
            .Simbolo = "Fl",
            .Valencia = "4",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d¹⁰ 7p²",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "1998, Flerov Laboratory",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El flerovio es un elemento sintético, radiactivo y extremadamente inestable, producido en laboratorios especializados para estudios de la química de los transactínidos."
        }

        Elementos(115) = New Elemento With {
            .A = 288,
            .Z = 115,
            .Nombre = "Moscovio",
            .Simbolo = "Mc",
            .Valencia = "3",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d¹⁰ 7p³",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "2003, Joint Institute for Nuclear Research",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El moscovio es un elemento sintético radiactivo, producido únicamente en laboratorios para investigación avanzada en química y física nuclear."
        }

        Elementos(116) = New Elemento With {
            .A = 289,
            .Z = 116,
            .Nombre = "Livermorio",
            .Simbolo = "Lv",
            .Valencia = "2",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d¹⁰ 7p⁴",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "2000, Joint Institute for Nuclear Research",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El livermorio es un elemento sintético, altamente inestable y radiactivo, utilizado exclusivamente en laboratorios de investigación nuclear avanzada."
        }

        Elementos(117) = New Elemento With {
            .A = 293,
            .Z = 117,
            .Nombre = "Tenesino",
            .Simbolo = "Ts",
            .Valencia = "1",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d¹⁰ 7p⁵",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "2010, Joint Institute for Nuclear Research",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El tenesino es un elemento superpesado sintético, muy radiactivo e inestable, producido solo en laboratorios para investigaciones de química y física nuclear."
        }

        Elementos(118) = New Elemento With {
            .A = 294,
            .Z = 118,
            .Nombre = "Oganesón",
            .Simbolo = "Og",
            .Valencia = "0",
            .ConfigElectronica = "[Rn] 7s² 5f¹⁴ 6d¹⁰ 7p⁶",
            .PuntoDeEbullicion = "Unknown",
            .PuntoDeFusion = "Unknown",
            .densidad = "Unknown",
            .EstadoFisico = "Sólido",
            .Descubrimiento = "2002, Joint Institute for Nuclear Research",
            .EnergiaIonizacion = "Unknown",
            .Dureza = "Blanda",
            .Conductividad = "Media",
            .Abundancia = "Sintético",
            .Descripcion = "El oganesón es un elemento sintético superpesado. Altamente inestable, radiactivo y producido únicamente en laboratorios, se estudia para entender las propiedades de los elementos transactínidos."
        }




    End Sub

End Module