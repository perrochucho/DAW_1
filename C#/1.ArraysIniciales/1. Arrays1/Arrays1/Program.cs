using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta;
            Console.Clear();
            Console.WriteLine("╔════╗ ");
            Console.WriteLine(" Menú ");
            Console.WriteLine("╚════╝");
            Console.WriteLine();
            Console.WriteLine("█═══════════════════█");
            Console.WriteLine();
            Console.WriteLine("1- Escribe Array5");
            Console.WriteLine("2- EscribeArray");
            Console.WriteLine("3- LeeArray5");
            Console.WriteLine("4- LeeArray");
            Console.WriteLine("5- PonCeros5");
            Console.WriteLine("6- PonCeros");
            Console.WriteLine("7- SumaArrays5");
            Console.WriteLine("8- SumaArray");
            Console.WriteLine("9- MediaArray5");
            Console.WriteLine("10- MediaArray");
            Console.WriteLine("11- RellenaEnOrden");
            Console.WriteLine("12- RellenaEnOrdenDesc");
            Console.WriteLine("13- RellenaAleatorio");
            Console.WriteLine("14- EstaOrdenado");
            Console.WriteLine("15- NumeroImpares");
            Console.WriteLine("16- MinArray");
            Console.WriteLine("17- MaxArray");
            Console.WriteLine("18- NumeroAprobados");
            Console.WriteLine("19- PorEncimaDe");
            Console.WriteLine("20- CuantosCeros");
            Console.WriteLine("21- CopiaArray");
            Console.WriteLine("22- CopiaArrayInvertido");
            Console.WriteLine("23- SumaArrys");
            Console.WriteLine("24- Resta, multiplica y divide Arrays");
            Console.WriteLine("25- InvierteArray");
            Console.WriteLine("26- ComparaArrays");
            Console.WriteLine("27- PonNotasArray");
            Console.WriteLine("28- ConcatenaArrays55");
            Console.WriteLine("29- ConcatenaArrays");
            Console.WriteLine("30- Contiene");
            Console.WriteLine("31- ConcatenaArraysPro");
            Console.WriteLine("32- CopiaArrayPro");
            Console.WriteLine("33- InsertaEnArray");
            Console.WriteLine("34- BorraDeArray");
            Console.WriteLine("35- EliminaUnElementoDeArray");
            Console.WriteLine("36- EliminaElementosArray");
            Console.WriteLine("37- InsertaArrayEnArray");
            Console.WriteLine("38- SubArray");
            Console.WriteLine("39- RecortaArray");
            Console.WriteLine("40- OrdenaBurbuja");
            Console.WriteLine();
            Console.WriteLine("█═══════════════════█");
            Console.WriteLine();
            Console.WriteLine("0- Salir");
            Console.WriteLine();
            Console.WriteLine("Elige una opción");
            respuesta = int.Parse(Console.ReadLine());

            while (respuesta < 0 || respuesta > 40)
            {
                Console.Clear();
                Console.WriteLine("╔════╗ ");
                Console.WriteLine(" Menú ");
                Console.WriteLine("╚════╝");
                Console.WriteLine();
                Console.WriteLine("█═══════════════════█");
                Console.WriteLine();
                Console.WriteLine("1- Escribe Array5");
                Console.WriteLine("2- EscribeArray");
                Console.WriteLine("3- LeeArray5");
                Console.WriteLine("4- LeeArray");
                Console.WriteLine("5- PonCeros5");
                Console.WriteLine("6- PonCeros");
                Console.WriteLine("7- SumaArrays5");
                Console.WriteLine("8- SumaArray");
                Console.WriteLine("9- MediaArray5");
                Console.WriteLine("10- MediaArray");
                Console.WriteLine("11- RellenaEnOrden");
                Console.WriteLine("12- RellenaEnOrdenDesc");
                Console.WriteLine("13- RellenaAleatorio");
                Console.WriteLine("14- EstaOrdenado");
                Console.WriteLine("15- NumeroImpares");
                Console.WriteLine("16- MinArray");
                Console.WriteLine("17- MaxArray");
                Console.WriteLine("18- NumeroAprobados");
                Console.WriteLine("19- PorEncimaDe");
                Console.WriteLine("20- CuantosCeros");
                Console.WriteLine("21- CopiaArray");
                Console.WriteLine("22- CopiaArrayInvertido");
                Console.WriteLine("23- SumaArrys");
                Console.WriteLine("24- Resta, multiplica y divide Arrays");
                Console.WriteLine("25- InvierteArray");
                Console.WriteLine("26- ComparaArrays");
                Console.WriteLine();
                Console.WriteLine("█═══════════════════█");
                Console.WriteLine();
                Console.WriteLine("0- Salir");
                Console.WriteLine();
                Console.WriteLine("Elige una opción");
                respuesta = int.Parse(Console.ReadLine());
            }

            switch (respuesta)
            {
                case 1:
                    {
                        Random r = new Random();
                        int n1 = r.Next(1, 100 + 1);
                        int n2 = r.Next(1, 100 + 1);
                        int n3 = r.Next(1, 100 + 1);
                        int n4 = r.Next(1, 100 + 1);
                        int n5 = r.Next(1, 100 + 1);
                        int[] a = { n1, n2, n3, n4, n5 };
                        Console.WriteLine();
                        escribeArrays5(a);
                        Console.WriteLine();
                        Console.WriteLine("Los valores de este array han sido generados aleatoriamente");

                    }
                    break;
                case 2:
                    {
                        int[] a = { 1, 2, 3 };
                        escribeArray(a);
                    }
                    break;
                case 3:
                    {

                        int[] a = new int[5];
                        LeeArray5(a);
                        escribeArrays5(a);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Introduce el tamaño del Array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        LeeArray(a);
                        escribeArray(a);
                    }
                    break;
                case 5:
                    {
                        int[] a = { 2, 3, 4, 5, 6 };
                        escribeArrays5(a);
                        PonCeros5(a);
                        escribeArrays5(a);
                    }
                    break;
                case 6:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        escribeArray(a);
                        PonCeros(a);
                        Console.WriteLine();
                        escribeArray(a);
                    }
                    break;
                case 7:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        escribeArrays5(a);
                        Console.Write("La suma de todos los valores de este array es: ");
                        Console.Write(SumaArray5(a));
                    }
                    break;
                case 8:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        escribeArray(a);
                        Console.Write(" La suma de valores de este array es ");
                        Console.Write(SumaArray(a));
                    }
                    break;
                case 9:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        escribeArray(a);
                        Console.Write(" La media de valores de este array es ");
                        Console.Write(MediaArray5(a));
                    }
                    break;
                case 10:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        escribeArray(a);
                        Console.Write(" La media de valores de este array es ");
                        Console.Write(MediaArray(a));
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("Introduce el tamaño del Array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        RellenaEnOrden(a);
                        escribeArray(a);
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("Introduce el tamaño del Array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        RellenaEnOrdenDesc(a);
                        escribeArray(a);
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("Introduce el tamaño del Array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        RellenaAleatorio(a);
                        escribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Los valores de este array han sido generados aleatoriamente");
                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("Introduce el tamaño del Array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        LeeArray(a);
                        escribeArray(a);
                        Console.WriteLine(EstaOrdenado(a));
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("Introduce el tamaño del Array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        LeeArray(a);
                        escribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine("El numero de impares es: ");
                        Console.WriteLine(NumeroImpares(a));
                    }
                    break;
                case 16:
                    {
                        Console.WriteLine("Introduce el tamaño del Array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        LeeArray(a);
                        escribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine("El numero minimo de ese array es ");
                        Console.WriteLine(MinArray(a));
                    }
                    break;
                case 17:
                    {
                        Console.WriteLine("Introduce el tamaño del Array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        LeeArray(a);
                        escribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine("El numero maximo de ese array es ");
                        Console.WriteLine(MaxArray(a));
                    }
                    break;
                case 18:
                    {
                        Console.WriteLine("Introduce el tamaño del Array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        LeeArray(a);
                        escribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine("El numero de aprobados en ese array es ");
                        Console.WriteLine(NumeroAprobados(a));
                    }
                    break;
                case 19:
                    {
                        int b;
                        Console.WriteLine("Introduce el tamaño del Array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        Console.WriteLine("Introduce el valor maximo que quieras");
                        b = int.Parse(Console.ReadLine());
                        LeeArray(a);
                        escribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine("El numero de valores superiores al que me has dicho es de ");
                        Console.WriteLine(PorEncimaDe(a, b));
                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("Introduce el tamaño del Array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        LeeArray(a);
                        escribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine("El numero de ceros de ese array es de ");
                        Console.WriteLine(CuantosCeros(a));
                    }
                    break;
                case 21:
                    {
                        Console.WriteLine("Introduceme el length de array1");
                        int length = int.Parse(Console.ReadLine());
                        int[] array1 = new int[length];
                        LeeArray(array1);
                        Console.WriteLine();
                        escribeArray(array1);
                        Console.WriteLine();
                        Console.WriteLine("Introduceme el length array2");
                        int length2 = int.Parse(Console.ReadLine());
                        int[] array2 = new int[length2];
                        LeeArray(array2);
                        Console.WriteLine();
                        escribeArray(array2);
                        if (CopiaArray(array1, array2))
                        {
                            Console.Write("<-- Segundo Array");
                            Console.WriteLine();
                            escribeArray(array2);
                            Console.Write("<-- Segundo Array después de la transformación");
                        }

                    }
                    break;
                case 22:
                    {
                        Console.WriteLine("Introduceme el length de array1");
                        int length = int.Parse(Console.ReadLine());
                        int[] array1 = new int[length];
                        LeeArray(array1);
                        Console.WriteLine();
                        escribeArray(array1);
                        Console.WriteLine();
                        Console.WriteLine("Introduceme el length array2");
                        int length2 = int.Parse(Console.ReadLine());
                        int[] array2 = new int[length2];
                        LeeArray(array2);
                        if (CopiaArrayInvertido(array1, array2))
                        {
                            escribeArray(array2);
                            Console.Write("<-- Segundo Array");
                            CopiaArrayInvertido(array1, array2);
                            Console.WriteLine();
                            escribeArray(array2);
                            Console.Write("<-- Segundo Array después de la transformación");
                        }
                    }
                    break;
                case 23:
                    {
                        Console.WriteLine("Introduceme el length de array1");
                        int length = int.Parse(Console.ReadLine());
                        int[] array1 = new int[length];
                        LeeArray(array1);
                        Console.WriteLine();
                        escribeArray(array1);
                        Console.WriteLine();
                        Console.WriteLine("Introduceme el length array2");
                        int length2 = int.Parse(Console.ReadLine());
                        int[] array2 = new int[length2];
                        int[] array3 = new int[length];
                        LeeArray(array2);
                        escribeArray(array2);
                        Console.WriteLine();
                        if (SumaArrays(array1, array2, array3))
                        {
                            escribeArray(array3);
                            Console.Write(" <-- Este es el tercer array, la suma de los dos primeros");
                        }


                    }
                    break;
                case 24:
                    {
                        string opcion;
                        Console.WriteLine("Quieres restar, multiplicar, o dividir?");
                        opcion = Console.ReadLine();
                        if (opcion == "restar")
                        {
                            Console.WriteLine("Introduceme el length de array1");
                            int length = int.Parse(Console.ReadLine());
                            int[] array1 = new int[length];
                            LeeArray(array1);
                            escribeArray(array1);
                            Console.WriteLine("Introduceme el length array2");
                            int length2 = int.Parse(Console.ReadLine());
                            int[] array2 = new int[length2];
                            int[] array3 = new int[length];
                            LeeArray(array2);
                            escribeArray(array2);
                            Console.WriteLine();
                            Console.Write("La resta vendria a ser: ");
                            RestaArrays(array1, array2, array3);
                            escribeArray(array3);
                        }
                        if (opcion == "multiplicar")
                        {
                            Console.WriteLine("Introduceme el length de array1");
                            int length = int.Parse(Console.ReadLine());
                            int[] array1 = new int[length];
                            LeeArray(array1);
                            escribeArray(array1);
                            Console.WriteLine("Introduceme el length array2");
                            int length2 = int.Parse(Console.ReadLine());
                            int[] array2 = new int[length2];
                            int[] array3 = new int[length];
                            LeeArray(array2);
                            escribeArray(array2);
                            Console.WriteLine();
                            Console.Write("La multiplicacion vendria a ser: ");
                            MultiplicaArrays(array1, array2, array3);
                            escribeArray(array3);
                        }
                        if (opcion == "dividir")
                        {
                            Console.WriteLine("Introduceme el length de array1");
                            int length = int.Parse(Console.ReadLine());
                            int[] array1 = new int[length];
                            LeeArray(array1);
                            escribeArray(array1);
                            Console.WriteLine("Introduceme el length array2");
                            int length2 = int.Parse(Console.ReadLine());
                            int[] array2 = new int[length2];
                            int[] array3 = new int[length];
                            LeeArray(array2);
                            escribeArray(array2);
                            Console.WriteLine();
                            Console.Write("La división vendria a ser: ");
                            DivideArrays(array1, array2, array3);
                            escribeArray(array3);
                        }
                    }
                    break;
                case 25:
                    {
                        Console.WriteLine("Introduceme el length de array");
                        int length = int.Parse(Console.ReadLine());
                        int[] array1 = new int[length];
                        LeeArray(array1);
                        Console.WriteLine();
                        escribeArray(array1);
                        Console.WriteLine("Lo invierto con la función y...");
                        InvierteArray(array1);
                        escribeArray(array1);
                    }
                    break;
                case 26:
                    {
                        Console.WriteLine("Introduceme el length de array1");
                        int length = int.Parse(Console.ReadLine());
                        int[] array1 = new int[length];
                        LeeArray(array1);
                        Console.WriteLine();
                        escribeArray(array1);
                        Console.WriteLine();
                        Console.WriteLine("Introduceme el length array2");
                        int length2 = int.Parse(Console.ReadLine());
                        int[] array2 = new int[length2];
                        LeeArray(array2);
                        Console.WriteLine();
                        escribeArray(array2);
                        if (ComparaArrays(array1, array2))
                        {
                            Console.WriteLine("Son iguales");
                        }
                        else
                        {
                            Console.WriteLine("No son iguales");
                        }
                    }
                    break;
                case 27:
                    {
                        Console.WriteLine("Introduceme el length de array1");
                        int length = int.Parse(Console.ReadLine());
                        double[] array1 = new double[length];
                        bool[] arraybool = new bool[length];
                        LeeArrayDouble(array1);
                        PonNotasArray(array1, arraybool);
                        EscribeArrayDouble(array1);
                        EscribeArrayBool(arraybool);
                    }
                    break;
                case 28:
                    {
                        Console.WriteLine("Introduce los valores del array1, tienen que ser 5 ehh");
                        int[] array1 = new int[5];
                        LeeArray5(array1);
                        Console.WriteLine("Introduce los valores del array2, tienen que ser 5 ehh");
                        int[] array2 = new int[5];
                        LeeArray5(array2);
                        int[] array3 = new int[10];
                        ConcatenaArrays55(array1, array2, array3);
                        escribeArray(array3);
                    }
                    break;
                case 29:
                    {
                        Console.WriteLine("Introduce el tamaño del array1");
                        int length = int.Parse(Console.ReadLine());
                        int[] array1 = new int[length];
                        LeeArray(array1);
                        Console.WriteLine("Introduce el tamaño del array2");
                        int length2 = int.Parse(Console.ReadLine());
                        int[] array2 = new int[length2];
                        LeeArray(array2);
                        int[] array3 = new int[length + length2];
                        ConcatenaArrays(array1, array2, array3);
                        escribeArray(array3);
                    }
                    break;
                case 30:
                    {
                        Console.WriteLine("Introduce el tamaño del array");
                        int length = int.Parse(Console.ReadLine());
                        int[] array1 = new int[length];
                        LeeArray(array1);
                        Console.WriteLine("Dime el numero que quieres que te compruebe si está o no");
                        int impostor = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (Contiene(array1, impostor))
                        {
                            Console.WriteLine("Lo contiene");
                        }
                        else
                        {
                            Console.WriteLine("No lo contiene");
                        }
                        break;
                    }
                case 31:
                    {
                        Console.WriteLine("Introduce el tamaño del array1");
                        int length = int.Parse(Console.ReadLine());
                        int[] array1 = new int[length];
                        LeeArray(array1);
                        Console.WriteLine("Introduce el tamaño del array2");
                        int length2 = int.Parse(Console.ReadLine());
                        int[] array2 = new int[length2];
                        LeeArray(array2);
                        escribeArray(ConcatenaArraysPro(array1, array2));
                    }
                    break;
                case 32:
                    {
                        Console.WriteLine("Introduce el tamaño del array1");
                        int length = int.Parse(Console.ReadLine());
                        int[] array1 = new int[length];
                        LeeArray(array1);
                        Console.WriteLine("Muchas gracias");
                        Console.WriteLine();
                        escribeArray(CopiaArrayPro(array1));
                        Console.Write("<- Este es el array que se ha creado");
                    }
                    break;
                case 33:
                    {
                        int[] array1 = { 1, 2, 3, 4, 6 };
                        escribeArray(array1);

                        int valor, posicion;

                        Console.WriteLine("Dime el número");
                        valor = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dime la posición");
                        posicion = int.Parse(Console.ReadLine());

                        InsertaEnArray(ref array1, valor, posicion);
                        escribeArray(array1);
                    }
                    break;
                case 34:
                    {
                        int[] array1 = { 3, 5, 7, 9, 12 };
                        escribeArray(array1);

                        int valor;

                        Console.WriteLine("Dime la posición a eliminar");
                        valor = int.Parse(Console.ReadLine());
                        if (valor > array1.Length)
                        {
                            Console.WriteLine("Error, esa posicion no existe en tal array");
                            break;
                        }

                        BorraDeArray(ref array1, valor);
                        escribeArray(array1);
                    }
                    break;
                case 35:
                    {
                        int[] array1 = { 2, 4, 6, 8, 10, 12, 14 };
                        Console.WriteLine("Dime el valor que quieres eliminar");
                        Console.WriteLine();
                        escribeArray(array1);
                        int valor = int.Parse(Console.ReadLine());
                        Elimina1ElementoArray(ref array1, valor);
                        escribeArray(array1);
                    }
                    break;
                case 36:
                    {
                        int[] array1 = { 1, 2, 2, 3, 3, 3, 5, 5, 5, 5 };
                        Console.WriteLine("Dime el valor que quieres eliminar");
                        Console.WriteLine();
                        escribeArray(array1);
                        int valor = int.Parse(Console.ReadLine());
                        EliminaElementosArray(ref array1, valor);
                        escribeArray(array1);
                    }
                    break;
                case 37:
                    {
                        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                        escribeArray(array1);
                        Console.WriteLine("Dime la longitud del array2");
                        int length2;
                        length2 = int.Parse(Console.ReadLine());
                        int[] array2 = new int[length2];
                        LeeArray(array2);
                        Console.WriteLine("Dime una posicion en la que quieras insertar ese array");
                        int posicion = int.Parse(Console.ReadLine());
                        InsertaArrayEnArray(ref array1, array2, posicion);
                        escribeArray(array1);
                    }
                    break;
                case 38:
                    {
                        int[] array1 = { 2, 4, 6, 8, 10, 12, 14, 16 };
                        escribeArray(array1);
                        Console.WriteLine("Introduce la posicion 1 ");
                        int posicion1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la posicion 2 ");
                        int posicion2 = int.Parse(Console.ReadLine());
                        escribeArray(SubArray(array1, posicion1, posicion2));
                    }
                    break;
                case 39:
                    {
                        int[] array1 = { 2, 4, 6, 8, 10, 12, 14, 16 };
                        escribeArray(array1);
                        Console.WriteLine("Introduce la posicion 1 ");
                        int posicion1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la posicion 2 ");
                        int posicion2 = int.Parse(Console.ReadLine());
                        RecortaArray(ref array1, posicion1, posicion2);
                        escribeArray(array1);
                    }
                    break;
                case 40:
                    {
                        int[] array1 = { 3, 9, 4, 6, 8, 1 };
                        escribeArray(array1);
                        OrdenaBurbuja(array1);
                        escribeArray(array1);
                    }
                    break;
                default:
                    Console.WriteLine("╔══════════════════════════════╗");
                    Console.WriteLine("Gracias por usar el Eladio-menú");
                    Console.WriteLine("╚══════════════════════════════╝");
                    break;

            }




        }

        static void escribeArray(int[] array)
        //Escribe un array del tamaño que sea, pero los valores se escriben en el código,
        //no en la consola
        {
            int i;
            if (array.Length > 0)
            {
                Console.Write("[");
                for (i = 0; i < array.Length - 1; i++)
                {
                    Console.Write(array[i] + ", ");
                }
                Console.Write(array[array.Length - 1]);
                Console.Write("]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        static void escribeArrays5(int[] array)
        {
            //Escribe un array de 5 elementos, ni 1 mas ni 1 menos
            Console.Write("[");
            for (int i = 0; i < 4; i++)
            {

                Console.Write(array[i] + ", ");
            }
            Console.WriteLine(array[4] + "]");
        }

        static void LeeArray5(int[] array)
        {
            //Lee 5 numeros introducidos por consola y se los aplica a un array, que luego imrpime 
            //por pantalla
            int i;
            Console.WriteLine("Dime los elementos del array de tamaño 5");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Dime el elemento " + i + " : ");
                array[i] = int.Parse(Console.ReadLine());
            }


        }

        static void LeeArray(int[] array)
        {
            //Escribe un array de cualquier tamaño, tanto el tamaño como
            //los valores de cada posición del array son introducidos por el usuario 
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Introduce el valor " + i + " : ");
                array[i] = int.Parse(Console.ReadLine());
            }

        }

        static void PonCeros5(int[] array)
        {
            //Cambia los valores de un array de tamaño 5 por ceros
            for (int i = 0; i < 5; i++)
            {
                array[i] = 0;
            }

        }
        static void PonCeros(int[] array)
        {
            //Cambia los valores de un array de cualquier tamaño por ceros
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        static int SumaArray5(int[] array)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma = suma + array[i];
            }
            return suma;

        }
        static int SumaArray(int[] array)
        {
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma = suma + array[i];
            }
            return suma;
        }

        static double MediaArray5(int[] array)
        {
            double suma = 0;
            double media = 0;
            for (int i = 0; i < 5; i++)
            {
                suma = suma + array[i];
                media = suma / 5;
            }
            return media;

        }
        static double MediaArray(int[] array)
        {
            double suma = 0;
            double media = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma = suma + array[i];
                media = suma / array.Length;
            }
            return media;
        }
        static void RellenaEnOrden(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1 + i;
            }
        }
        static void RellenaEnOrdenDesc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array.Length - i;
            }
        }

        static void RellenaAleatorio(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Random r = new Random();
                array[i] = r.Next(1, 10 + 1);
            }
        }

        static bool EstaOrdenado(int[] array)
        {
            int errores;
            errores = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                while (array[i] > array[i + 1])
                {
                    errores++;
                    break; // opcional
                }
            }

            if (errores > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static int NumeroImpares(int[] array)
        {
            int n;
            n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    n++;
                }
            }
            return n;
        }

        static int MinArray(int[] array)
        {
            int min;
            min = array[1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static int MaxArray(int[] array)
        {
            int max;
            max = array[1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static int NumeroAprobados(int[] array)
        {
            int ap;
            ap = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 5)
                {
                    ap++;
                }
            }
            return ap;
        }
        static int PorEncimaDe(int[] array, int b)
        {
            int cont;
            cont = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= b)
                {
                    cont++;
                }
            }
            return cont;
        }
        static int CuantosCeros(int[] array)
        {
            int cont;
            cont = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] / 1 == 0)
                {
                    cont++;
                }
            }
            return cont;
        }
        static bool CopiaArray(int[] array1, int[] array2)
        {
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array2[i] = array1[i];
                }
                //Console.WriteLine();
                //Console.Write("Se ha copiado el contenido del primer array en el segundo");
                //Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine();
                Console.Write("Los Arrays no eran iguales, error");
                return false;
            }
        }
        static bool CopiaArrayInvertido(int[] array1, int[] array2)
        {
            if (array1.Length == array2.Length)
            {
                int cont;
                cont = array1.Length - 1;
                for (int i = 0; i < array1.Length; i++)
                {
                    array2[i] = array1[cont];
                    cont--;
                }
                return true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Los Arrays no eran iguales, el array2 se ha quedado igual");
                Console.WriteLine();
                return false;
            }
        }
        static bool SumaArrays(int[] array1, int[] array2, int[] array3)
        {
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array3[i] = array1[i] + array2[i];
                }
                return true;
            }
            else
            {
                Console.WriteLine("No se ha sumado nada, los arrays no eran del mismo tamaño");
                return false;
            }
        }
        static bool RestaArrays(int[] array1, int[] array2, int[] array3)
        {
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array3[i] = array1[i] - array2[i];
                }
                return true;
            }
            else
            {
                Console.WriteLine("No se ha restado nada, los arrays no eran del mismo tamaño");
                return false;
            }
        }
        static bool MultiplicaArrays(int[] array1, int[] array2, int[] array3)
        {
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array3[i] = array1[i] * array2[i];
                }
                return true;
            }
            else
            {
                Console.WriteLine("No se ha multiplicado nada, los arrays no eran del mismo tamaño");
                return false;
            }
        }
        static bool DivideArrays(int[] array1, int[] array2, int[] array3)
        {
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array3[i] = array1[i] / array2[i];
                }
                return true;
            }
            else
            {
                Console.WriteLine("No se ha dividido nada, los arrays no eran del mismo tamaño");
                return false;
            }
        }
        static void InvierteArray(int[] array1)
        {
            int temp, cont;
            temp = 0;
            cont = array1.Length - 1;
            for (int i = 0; i < array1.Length / 2; i++)
            {
                temp = array1[i];
                array1[i] = array1[cont];
                array1[cont] = temp;
                cont--;
            }


            //Metodo alternativo con while

            //int temp, cont, i;
            //cont = array1.Length - 1;
            //temp = 0;            
            //i = 0;
            //while (i < cont)
            //{
            //    temp = array1[i];
            //    array1[i] = array1[cont];
            //    array1[cont] = temp;

            //    i++;
            //    cont--;
            //}
        }
        static bool ComparaArrays(int[] array1, int[] array2)
        {
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = array2[i];
                }
                return true;
            }
            return false;
        }

        static void PonNotasArray(double[] array1, bool[] arraybool)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] >= 5)
                {
                    arraybool[i] = true;
                }
                else
                {
                    arraybool[i] = false;
                }
            }
        }

        static void EscribeArrayDouble(double[] array1)
        {
            int i;
            if (array1.Length > 0)
            {
                Console.Write("[");
                for (i = 0; i < array1.Length - 1; i++)
                {
                    Console.Write(array1[i] + ", ");
                }
                Console.Write(array1[array1.Length - 1]);
                Console.Write("]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
        static void LeeArrayDouble(double[] array1)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Introduce el valor " + i + " : ");
                array1[i] = double.Parse(Console.ReadLine());
            }
        }
        static void EscribeArrayBool(bool[] arraybool)
        {
            for (int i = 0; i < arraybool.Length; i++)
            {
                if (arraybool.Length > 0)
                {
                    Console.Write("[");
                    for (i = 0; i < arraybool.Length - 1; i++)
                    {
                        Console.Write(arraybool[i] + ", ");
                    }
                    Console.Write(arraybool[arraybool.Length - 1]);
                    Console.Write("]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
        }
        static void ConcatenaArrays55(int[] array1, int[] array2, int[] array3)
        {
            int otrocontador = 0;
            for (int i = 0; i < 5; i++)
            {
                array3[i] = array1[i];
            }
            for (int cont = 5; cont < array3.Length; cont++)
            {
                array3[cont] = array2[otrocontador];
                otrocontador++;
            }
        }
        static void ConcatenaArrays(int[] array1, int[] array2, int[] array3)
        {
            int otrocontador = 0;
            if (array3.Length == (array1.Length + array2.Length))
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array3[i] = array1[i];
                }
                for (int cont = array1.Length; cont < array3.Length; cont++)
                {
                    array3[cont] = array2[otrocontador];
                    otrocontador++;
                }
            }
            else
            {
                Console.WriteLine("No se han cumplido las condiciones que he especificado");
            }
        }
        static bool Contiene(int[] array1, int impostor)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == impostor)
                {
                    return true;
                }

            }
            return false;
        }
        static int[] ConcatenaArraysPro(int[] array1, int[] array2)
        {
            int otrocontador = 0;
            int lengthcomb = array1.Length + array2.Length;
            int[] array3 = new int[lengthcomb];
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i];
            }
            for (int cont = array1.Length; cont < array3.Length; cont++)
            {
                array3[cont] = array2[otrocontador];
                otrocontador++;
            }
            return array3;
        }
        static int[] CopiaArrayPro(int[] array1)
        {
            int length2 = array1.Length;
            int[] array2 = new int[length2];
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }
            return array2;
        }
        static void InsertaEnArray(ref int[] array1, int valor, int posicion)
        {
            int newsize = array1.Length + 1;
            Array.Resize(ref array1, newsize); //Estas dos lineas aumentan la longitud del array
            for (int i = newsize - 1; i > posicion; i--) //i es igual al tamaño + 1, mientras sea menor que posicion 
                                                         // introducida por teclado, resta
            {
                array1[i] = array1[i - 1];              //mientras es menor que posicion itroducida por teclado, 
                                                        //la posicion del contador, que va bajando, es igual a la posicion
                                                        //anterior a la que hay en el contador
            }

            array1[posicion] = valor;

        }
        static void BorraDeArray(ref int[] array1, int posicion)
        {
            int newsize;
            for (int i = posicion; i < array1.Length - 1; i++)
            {
                array1[i] = array1[i + 1];

            }
            newsize = array1.Length - 1;
            Array.Resize(ref array1, newsize);
        }
        static void Elimina1ElementoArray(ref int[] array1, int valor)
        {
            int i, j;
            j = 0;
            for (i = 0; i < array1.Length; i++)
            {
                if (array1[i] == valor)
                {
                    j = j + 1;
                }
                else
                {
                    array1[i - j] = array1[i];
                }
            }
            Array.Resize(ref array1, array1.Length - 1);

        }
        static void EliminaElementosArray(ref int[] array1, int valor)
        {
            int i, j;
            j = 0;
            for (i = 0; i < array1.Length; i++)
            {
                if (array1[i] == valor)
                {
                    j++;
                }
                else
                {
                    array1[i - j] = array1[i];
                }
            }
            int newsize = j;
            Array.Resize(ref array1, array1.Length - newsize);
        }
        static void InsertaArrayEnArray(ref int[] array1, int[] array2, int posicion)
        {
            int newsize = array1.Length + array2.Length;
            Array.Resize(ref array1, newsize);
            for (int i = newsize - 1; i > posicion; i--)
            {
                if (i - array2.Length < 0)
                {
                    break;
                }
                array1[i] = array1[i - array2.Length];

            }

            for (int c = 0; c < array2.Length; c++)
            {
                array1[posicion] = array2[c];
                posicion++;
            }

        }
        static int[] SubArray(int[] array1, int posicion1, int posicion2)
        {
            int newsize;
            newsize = posicion2 - posicion1;
            int[] array2 = new int[newsize + 1];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[posicion1 + i];
            }
            return array2;
        }
        static void RecortaArray(ref int[] array1, int posicion1, int posicion2)
        {
            int newsize;
            newsize = posicion2 - posicion1;
            for (int i = 0; i < newsize + 1; i++)
            {
                array1[i] = array1[posicion1 + i];
            }
            Array.Resize(ref array1, newsize + 1);
        }
        static void OrdenaBurbuja(int[] array1)
        {
            int temp;

            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int cont = 0; cont < array1.Length - 1; cont++)
                {
                    if (array1[cont] > array1[cont + 1])
                    {
                        temp = array1[cont + 1];
                        array1[cont + 1] = array1[cont];
                        array1[cont] = temp;
                    }
                }
            }
        }
    }
}


