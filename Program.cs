using System;

internal class Program
{

    //Hecho por: Juan Cruz Perez Porcel.
    //Para: Programación.
    //Hecho en Visual Studio 2022, C#.

    private static void Main()
    {
        short option = 0;

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.Clear();

        Console.Write("Ingrese un número de actividad: ");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        option = short.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;

        Menu(option);
    }

    #region Menu
    static void Menu(short option)
    {
        Console.Clear();
        switch (option)
        {
            case 0:
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("El programa se cerro correctamente.");
                Environment.Exit(0); // Le dice al programa que el proceso se completo con éxito.
                break;
            case 1:
                Actividad_1();
                break;
            case 2:
                Actividad_2();
                break;
            case 3:
                Actividad_3();
                break;
            case 4:
                Actividad_4();
                break;
            case 5:
                Actividad_5();
                break;
            #region Creditos
            case 1998:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine();
                Console.WriteLine("                  **************************************************************");
                Console.WriteLine("                  ******** ESTE PROGRAMA ESTA HECHO EN SU TOTALIDAD POR: *******");
                Console.WriteLine("                  **************************************************************");
                Console.WriteLine("                  ******************* PEREZ PORCEL JUAN CRUZ *******************");
                Console.WriteLine("                  **************************************************************");
                Console.WriteLine("                  ********************** DNI: 41.185.616 ***********************");
                Console.WriteLine("                  **************************************************************");
                Console.WriteLine("                  ************** PARA LA MATERIA DE PROGRAMACIÓN. **************");
                Console.WriteLine("                  **************************************************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Toque una tecla para continuar...");

                break;
            #endregion
            default:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Número erroneo, Por favor intentelo de nuevo.\n");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Ingrese un número de actividad: ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                option = short.Parse(Console.ReadLine());
                Menu(option);
                break;
        }
    }
    #endregion

    #region Actividades

    //Consignas:

    /*1. Desarrollar una aplicación que solicite las calificaciones de alumnos de un curso,
    previamente se debe almacenar nombre del curso y turno. Al finalizar se debe informar la nota
    promedio y asociarlo al nombre del curso registrado (Ejemplo: Primer Año – Turno Mañana –
    Promedio: 7). Se debe permitir que la cantidad de alumnos por curso sea variable.*/
    static void Actividad_1()
    {
        string curso = string.Empty;
        string turno = string.Empty;
        short notas = 0;
        double promedio = 0;

        //Bucle
        bool seguir_Bool = true;
        string continuar_Notas = string.Empty;

        short contador = 0;

        Console.Write("Ingrese el turno: ");
        turno = Console.ReadLine();

        Console.Write("Ingrese el curso: ");
        curso = Console.ReadLine();

        do
        {
            Console.Clear();
            Console.Write("Ingrese las notas: ");
            notas = short.Parse(Console.ReadLine());

            if (contador >= 4)
            {
                Console.Write("Seguir?... Si/no: ");
                continuar_Notas = Console.ReadLine();

                if (continuar_Notas == "no" || continuar_Notas == "No")
                {
                    seguir_Bool = false;
                }
            }
            promedio += notas;

            contador++;

        } while (seguir_Bool);

        promedio /= contador;

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\n{0} – Turno {1} – Promedio: {2}", curso, turno, promedio);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nToque una tecla para continuar...");
        Console.ReadKey();
        Main();
    }

    /*2.- Realizar un sistema para realizar una encuesta para determinar estudiantes de colegios
    públicos y privados. Al finalizar el sistema debe determinar cantidad total de alumnos
    encuestados, cantidad y porcentaje para asistentes a colegios privados y públicos.*/
    static void Actividad_2()
    {
        string nombre = string.Empty;
        string apellido = string.Empty;

        byte opcion = 0; //use byte en el menu, porque son números pequeños y para probarlo. jaja

        double colegioPublico = 0;
        double colegioPrivado = 0;
        int porcentaje = 0;

        bool loop = true;


        do
        {
            Console.WriteLine("Seleccione a que colegio va.\n\n1.Colegio Público.\n2.Colegio Privado.\n\n0.Salir.\n");
            Console.Write("Opción: ");
            opcion = byte.Parse(Console.ReadLine());

            if (opcion != 0)
            {
                Console.Clear();
                Console.Write("Ingrese su nombre: ");
                nombre = Console.ReadLine();
                Console.Clear();
                Console.Write("Ingrese su apellido: ");
                apellido = Console.ReadLine();
            }

            switch (opcion)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Encuesta terminada.");
                    Console.WriteLine("\nPulse cualquier tecla para ver resultados...");
                    Console.ReadKey();
                    loop = !loop;
                    break;

                case 1:
                    Console.Clear();
                    Console.WriteLine("Encuesta enviada, Gracias por su tiempo.");
                    Console.WriteLine("\nPulse cualquier tecla para salir...");
                    Console.ReadKey();
                    colegioPrivado++;
                    porcentaje++;
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Encuesta enviada, Gracias por su tiempo.");
                    Console.WriteLine("\nPulse cualquier tecla para salir...");
                    Console.ReadKey();
                    colegioPublico++;
                    porcentaje++;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Número inválido Intentelo de nuevo.");
                    Console.WriteLine("\nPulse cualquier tecla para salir...");
                    Console.ReadKey();
                    break;
            }

            Console.Clear();

        } while (loop);


        colegioPublico = (colegioPublico > 0 ? (colegioPublico * 100) / porcentaje : 0);
        colegioPrivado = colegioPrivado > 0 ? (colegioPrivado * 100) / porcentaje : 0;

        colegioPublico = Math.Round(colegioPublico, 2, MidpointRounding.AwayFromZero); // Transforma los numeros decimales en 2 digitos, MidPoint... redondea de 0 a 4 y de 6 a 9.
        colegioPrivado = Math.Round(colegioPrivado, 2, MidpointRounding.AwayFromZero); // si es 5 y todos los dígitos restantes son cero o no quedan dígitos, el número más cercano es ambiguo.
                                                                                       // MidpointRounding le permite especificar si la operación de redondeo devuelve el número más cercano a cero o el número par más cercano.

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Según la encuesta este es el resultado:\n\nColegio Público: {0}%.\nColegio Privado: {1}%.\n", colegioPublico, colegioPrivado);

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPulse cualquier tecla para salir...");
        Console.ReadKey();
        Main();
    }

    /*3.- Crear una aplicación que solicite la temperatura diaria promedio para el lapso de una
    semana (7 días). Al finalizar se debe informar cual es la temperatura mínima registrada, cual la
    máxima y a que numero de día corresponde en cada caso.*/
    static void Actividad_3()
    {
        string[] dia = new string[7] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
        float[] grados = new float[7] { 0, 0, 0, 0, 0, 0, 0 };
        float tempMin = 0;
        float tempMax = 0;

        for (int i = 0; i < dia.Length; i++)
        {
            Console.WriteLine("Ingrese la temperatura promedio del día {0} en grados ¨Celcius¨.", dia[i]);
            grados[i] = float.Parse(Console.ReadLine());
            Console.Clear();
        }

        tempMin = grados[0];
        tempMax = grados[0];

        for (int i = 0; i < dia.Length; i++)
        {
            tempMin = tempMin > grados[i] ? tempMin = grados[i] : tempMin;
            tempMax = tempMax < grados[i] ? tempMax = grados[i] : tempMax;
        }

        Console.WriteLine("La temperatura minima es de {0}°C y la maxima es de {1}°C.", tempMin, tempMax);

        Console.WriteLine("\nPulse cualquier tecla para salir...");
        Console.ReadKey();
        Main();

    }

    /*4.- Realizar una aplicación que permita realizar la conversión de monedas DÓLAR y EURO a
    PESO ARGENTINO. En primer lugar se debe solicitar el tipo de moneda origen (Dólar o Euro) y
    la cantidad de la misma, luego se debe mostrar el monto correspondiente en Pesos Argentinos
    y que se presione una tecla para permitir realizar una nueva conversión. Al momento de
    seleccionar la moneda, también se debe brindar una opción para finalizar el programa.*/
    static void Actividad_4()
    {
        const decimal dolar = 146.86m;
        const decimal euro = 284.90m;
        decimal pesosARG = .0m;
        decimal dinero = .0m;
        byte option = 0;
        bool loop = true;

        do
        {
            Console.WriteLine("Conversor de moneda.\n");
            Console.WriteLine("Seleccione el tipo de moneda que desea:\n\n1.Dolar.  Us$1 = ${0}Arg.\n2.Euro.  1Eur = ${1}Arg.\n\n0.Salir.\n\n", dolar, euro);
            option = byte.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Gracias por usar la aplicación.");
                    Console.WriteLine("\nPulse cualquier tecla para salir...");
                    Console.ReadKey();
                    loop = !loop;
                    break;

                case 1:
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad de Dolar que desea convertir a Pesos Argentinos, o ingrese 0 para salir.:\n");
                    Console.Write("Dolares:");
                    dinero = decimal.Parse(Console.ReadLine());

                    Console.Clear();

                    pesosARG = DolarPesos(dinero, dolar);
                   
                    Console.WriteLine(dinero == 0 ? "Volviendo al menú principal." : "Us${0} son ${1}.", dinero, pesosARG);

                    Console.WriteLine("\nPulse cualquier tecla para volver al menú principal");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad de Euros que desea convertir a Pesos Argentinos, o ingrese 0 para salir.:\n");
                    Console.Write("Euros:");
                    dinero = decimal.Parse(Console.ReadLine());

                    Console.Clear();

                    pesosARG = EuroPesos(dinero, euro);

                    Console.WriteLine(dinero == 0 ? "Volviendo al menú principal." : "{0} Euros son ${1}.", dinero, pesosARG);

                    Console.WriteLine("\nPulse cualquier tecla para volver al menú principal");
                    Console.ReadKey();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Número inválido. Intentelo de nuevo.");
                    Console.WriteLine("\nPulse cualquier tecla para volver al inicio...");
                    Console.ReadKey();
                    break;
            }

            Console.Clear();
        } while (loop);

        Main();
    }

    static Decimal DolarPesos(decimal dinero, decimal dolar)
    {
        decimal pesosArg = dinero * dolar;

        return pesosArg;
    }

    static Decimal EuroPesos(decimal dinero, decimal euro)
    {
        decimal pesosArg = dinero * euro;

        return pesosArg;
    }

    /*5.- Desarrolle un programa que permita calcular el FACTORIAL para un número entero
    ingresado por el usuario. EL concepto de factorial para un numero N, es que se obtiene de
    realizar la multiplicación de todos los números entre 1 y N.*/
    static void Actividad_5()
    {
        int nro = 0;
        int result = 1;

        Console.Write("Ingrese un número a factorizar:");
        nro = Int32.Parse(Console.ReadLine());

        Console.Clear();

        for (int i = 1; i <= nro; i++)
        {
            result *= i;
            Console.Write(i == 1 ? "{0}= " : "", nro);
            Console.Write("{0}", result);
            Console.Write(nro == i ? "." : ", ");
        }
        Console.WriteLine("\nPulse cualquier tecla para salir...");
        Console.ReadKey();
        Main();
    }
    #endregion
}