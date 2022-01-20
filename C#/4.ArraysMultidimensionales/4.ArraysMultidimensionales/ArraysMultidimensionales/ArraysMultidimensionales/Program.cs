using System;

namespace ArraysMultidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("╔════╗ ");
            Console.WriteLine(" Menú ");
            Console.WriteLine("╚════╝");
            Console.WriteLine();
            Console.WriteLine("█═══════════════════█");
            Console.WriteLine();
            Console.WriteLine("1- EscribeArray3x3");
            Console.WriteLine("2- Rellena3x3");
            Console.WriteLine("3- RellenaAleatorio3x3");
            Console.WriteLine("4- SumaArray3x3");
            Console.WriteLine("5- EscribeArrayBi");
            Console.WriteLine("6- RellenaAleatorioBi");
            Console.WriteLine("7- RellenaEnOrdenBi");
            Console.WriteLine("8- SumaArrayBi");
            Console.WriteLine("9- Suma2ArraysBi");
            Console.WriteLine("10- CopiaArrayBi");
            Console.WriteLine("11- CopiaArrayBiPro");
            Console.WriteLine("12- RellenaArrayAjedrez");
            Console.WriteLine("13- RellenaDiagonal");
            Console.WriteLine("14- RellenaX");
            Console.WriteLine("15- RellenaCuadros");
            Console.WriteLine();
            Console.WriteLine("█═══════════════════█");
            Console.WriteLine();
            Console.WriteLine("0- Salir");
            Console.WriteLine();
            Console.WriteLine("Elige una opción");
            int respuesta = int.Parse(Console.ReadLine());

            while (respuesta < 0 || respuesta > 15)
            {
                Console.Clear();
                Console.WriteLine("╔════╗ ");
                Console.WriteLine(" Menú ");
                Console.WriteLine("╚════╝");
                Console.WriteLine();
                Console.WriteLine("█═══════════════════█");
                Console.WriteLine();
                Console.WriteLine("1- EscribeArray3x3");
                Console.WriteLine("2- Rellena3x3");
                Console.WriteLine("3- RellenaAleatorio3x3");
                Console.WriteLine("4- SumaArray3x3");
                Console.WriteLine("5- EscribeArrayBi");
                Console.WriteLine("6- RellenaAleatorioBi");
                Console.WriteLine("7- RellenaEnOrdenBi");
                Console.WriteLine("8- SumaArrayBi");
                Console.WriteLine("9- Suma2ArraysBi");
                Console.WriteLine("10- CopiaArrayBi");
                Console.WriteLine("11- CopiaArrayBiPro");
                Console.WriteLine("12- RellenaArrayAjedrez");
                Console.WriteLine("13- RellenaDiagonal");
                Console.WriteLine("14- RellenaX");
                Console.WriteLine("15- RellenaCuadros");
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
                        int[,] a = new int[3, 3];
                        EscribeArray3x3(a);
                    }
                    break;
                case 2:
                    {
                        int[,] a = new int[3, 3];
                        Rellena3x3(a);
                        EscribeArray3x3(a);
                    }
                    break;
                case 3:
                    {
                        int[,] a = new int[3, 3];
                        RellenaAleatorio3x3(a);
                        EscribeArray3x3(a);
                    }
                    break;
                case 4:
                    {
                        int[,] a = new int[3, 3];
                        RellenaAleatorio3x3(a);
                        EscribeArray3x3(a);
                        Console.WriteLine();
                        Console.WriteLine("La suma de todos es: " + SumaArray3x3(a));
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Introduce la Dimension 1");
                        int d1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Dimension 2");
                        int d2 = int.Parse(Console.ReadLine());
                        int[,] a = new int[d1, d2];
                        //RellenaAleatorioBi(a);
                        EscribeArrayBi(a);
                    }
                    break;
                case 6:
                    {

                        Console.WriteLine("Introduce la Dimension 1");
                        int d1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Dimension 2");
                        int d2 = int.Parse(Console.ReadLine());
                        int[,] a = new int[d1, d2];
                        RellenaAleatorioBi(a);
                        EscribeArrayBi(a);
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Introduce la Dimension 1");
                        int d1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Dimension 2");
                        int d2 = int.Parse(Console.ReadLine());
                        int[,] a = new int[d1, d2];
                        RellenaEnOrdenBi(a);
                        EscribeArrayBi(a);
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("Introduce la Dimension 1");
                        int d1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Dimension 2");
                        int d2 = int.Parse(Console.ReadLine());
                        int[,] a = new int[d1, d2];
                        RellenaAleatorioBi(a);
                        EscribeArrayBi(a);
                        Console.WriteLine(SumaArrayBi(a));
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("Introduce la Dimension 1 (será la de los 2 arrays porque deben ser iguales en tamaño)");
                        int d1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Dimension 2 (será la de los 2 arrays porque deben ser iguales en tamaño)");
                        int d2 = int.Parse(Console.ReadLine());
                        int[,] a = new int[d1, d2];
                        int[,] a2 = new int[d1, d2];
                        RellenaAleatorioBi(a);
                        RellenaAleatorioBi(a2);
                        int[,] a3 = new int[d1, d2];
                        Suma2ArraysBi(a, a2, a3);
                        EscribeArrayBi(a3);
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Introduce la Dimension 1");
                        int d1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Dimension 2");
                        int d2 = int.Parse(Console.ReadLine());
                        int[,] a = new int[d1, d2];
                        int[,] a2 = new int[d1, d2];
                        RellenaAleatorioBi(a);
                        CopiaArrayBi(a, a2);
                        EscribeArrayBi(a2);
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("Introduce la Dimension 1");
                        int d1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Dimension 2");
                        int d2 = int.Parse(Console.ReadLine());
                        int[,] a = new int[d1, d2];
                        RellenaAleatorioBi(a);
                        EscribeArrayBi(CopiaArrayBiPro(a));
                    }
                    break;
                case 12:
                    {
                        int[,] a = new int[8, 8];
                        Console.WriteLine("Este es el array vacio");
                        EscribeArrayBi(a);
                        RellenaArrayAjedrez(a);
                        Console.WriteLine("Este es el array en ajedrez");
                        EscribeArrayBi(a);
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("Introduce la Dimension 1 (recuerda que el array debe ser cuadrado, es decir, las dos dimensiones deben tener el mismo tamaño");
                        int d1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Dimension 2 (recuerda que el array debe ser cuadrado, es decir, las dos dimensiones deben tener el mismo tamaño");
                        int d2 = int.Parse(Console.ReadLine());
                        int[,] a = new int[d1, d2];
                        if (EsCuadrado(a))
                        {
                            RellenaDiagonal(a);
                            EscribeArrayBi(a);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Tiene que ser cuadrado");
                        }
                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("Introduce la Dimension 1 (recuerda que el array debe ser cuadrado, es decir, las dos dimensiones deben tener el mismo tamaño");
                        int d1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Dimension 2 (recuerda que el array debe ser cuadrado, es decir, las dos dimensiones deben tener el mismo tamaño");
                        int d2 = int.Parse(Console.ReadLine());
                        int[,] a = new int[d1, d2];
                        RellenaX(a);
                        EscribeArrayBi(a);
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("Introduce la Dimension 1 (recuerda que el array debe ser cuadrado, es decir, las dos dimensiones deben tener el mismo tamaño");
                        int d1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la Dimension 2 (recuerda que el array debe ser cuadrado, es decir, las dos dimensiones deben tener el mismo tamaño");
                        int d2 = int.Parse(Console.ReadLine());
                        int[,] a = new int[d1, d2];
                        RellenaCuadros(a);
                        EscribeArrayBi(a);
                    }
                    break;
                default:
                    break;

            }

        }
        static void EscribeArray3x3(int[,] a)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");

                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
        static void Rellena3x3(int[,] a)
        {
            int n = 1;
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = n;
                    n++;
                }
            }
        }
        static void RellenaAleatorio3x3(int[,] a)
        {
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int n = r.Next(1, 9);
                    a[i, j] = n;
                }
            }
        }
        static int SumaArray3x3(int[,] a)
        {
            int suma = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma += a[i, j];
                }
            }
            return suma;
        }
        static void EscribeArrayBi(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("[" + " ");
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j].ToString().PadLeft(3) + " ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
        static void RellenaAleatorioBi(int[,] a)
        {
            Random r = new Random();
            int n;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    n = r.Next(1, 9);
                    a[i, j] = n;
                }
            }
        }
        static void RellenaEnOrdenBi(int[,] a)
        {
            int n = 1;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = n;
                    n++;
                }
            }
        }
        static int SumaArrayBi(int[,] a)
        {
            int result;
            result = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    result += a[i, j];
                }
            }
            return result;
        }
        static void Suma2ArraysBi(int[,] a, int[,] a2, int[,] a3)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a3[i, j] = a[i, j] + a2[i, j];
                }
            }
        }
        static void CopiaArrayBi(int[,] a, int[,] a2)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a2[i, j] = a[i, j];
                }
            }
        }
        static int[,] CopiaArrayBiPro(int[,] a)
        {
            int d1 = a.GetLength(0);
            int d2 = a.GetLength(1);
            int[,] a2 = new int[d1, d2];
            for (int i = 0; i < d1; i++)
            {
                for (int j = 0; j < d2; j++)
                {
                    a2[i, j] = a[i, j];
                }
            }
            return a2;
        }
        static void RellenaArrayAjedrez(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = 1;

                    if ((i == 0) || (i % 2 == 0))
                    {
                        a[i, j] = 0;
                        if (j % 2 == 0)
                        {
                            a[i, j] = 1;
                        }
                    }
                    if (i % 2 != 0)
                    {
                        a[i, j] = 0;
                        if (j % 2 != 0)
                        {
                            a[i, j] = 1;
                        }
                    }
                }
            }
        }
        static void RellenaDiagonal(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        if (i < j)
                        {
                            a[i, j] = 2;
                        }
                        else
                        {
                            a[i, j] = 3;
                        }
                    }
                }
            }
        }
        static bool EsCuadrado(int[,] a)
        {
            if (a.GetLength(0) != a.GetLength(1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void RellenaX(int[,] a)
        {
            if (EsCuadrado(a))
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (((i == j) || (i + j) == a.GetLength(0) - 1))
                        {
                            a[i, j] = 1;
                        }
                        else
                        {
                            a[i, j] = 2;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No es cuadrado");
            }
        }
        static void RellenaCuadros(int [,] a)
        {
            int c;
            c = a.GetLength(0) / 2;
            if (a.Length % 2 == 0)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        int d;
                        d = Brujula(i, j, c);
                        a[i, j] = d;
                    }
                }
            }
        }
        static int Brujula(int i, int j, int c)
        {
            int resultado;

            if (i < c)
            {
                if (j < c)
                {
                    resultado = 1;
                }
                else
                {
                    resultado = 2;
                }
            }
            else
            {
                if (j < c)
                {
                    resultado = 3;
                }
                else
                {
                    resultado = 4;
                }
            }

            return resultado;
        }
    }
}


