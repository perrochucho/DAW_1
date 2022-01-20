using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Listas
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
            Console.WriteLine("1- LeeLista");
            Console.WriteLine("2- LeeListaN");
            Console.WriteLine("3- EscribeLista");
            Console.WriteLine("4- EliminaNegativos");
            Console.WriteLine("5- ClasificaNumeros");
            Console.WriteLine("6- EliminaRepetidos");
            Console.WriteLine("7- OrdenaListaSelección");
            Console.WriteLine("8- OrdenaListaInserción");
            Console.WriteLine("9- OrdenaListaPalabras");
            Console.WriteLine("10- OrdenaListaPalabras2");
            Console.WriteLine("11- InsertaArrayEnArrayPro");
            Console.WriteLine("12- SorteoBonoloto");
            Console.WriteLine("13- EliminaRepetidos");
            Console.WriteLine("14- UnionListas");
            Console.WriteLine("15- IntersecciónListas");
            Console.WriteLine("16- DesordenaLista");
            Console.WriteLine("17- ModaLista");
            Console.WriteLine("18- PuntuacionesTrampolin");
            Console.WriteLine();
            Console.WriteLine("█═══════════════════█");
            Console.WriteLine();
            Console.WriteLine("0- Salir");
            Console.WriteLine();
            Console.WriteLine("Elige una opción");
            int respuesta = int.Parse(Console.ReadLine());

            while (respuesta < 0 || respuesta > 18)
            {
                Console.Clear();
                Console.WriteLine("╔════╗ ");
                Console.WriteLine(" Menú ");
                Console.WriteLine("╚════╝");
                Console.WriteLine();
                Console.WriteLine("█═══════════════════█");
                Console.WriteLine();
                Console.WriteLine("1- LeeLista");
                Console.WriteLine("2- LeeListaN");
                Console.WriteLine("3- EscribeLista");
                Console.WriteLine("4- EliminaNegativos");
                Console.WriteLine("5- ClasificaNumeros");
                Console.WriteLine("6- EliminaRepetidos");
                Console.WriteLine("7- OrdenaListaSelección");
                Console.WriteLine("8- OrdenaListaInserción");
                Console.WriteLine("9- OrdenaListaPalabras");
                Console.WriteLine("10- OrdenaListaPalabras2");
                Console.WriteLine("11- InsertaArrayEnArrayPro");
                Console.WriteLine("12- SorteoBonoloto");
                Console.WriteLine("13- EliminaRepetidos");
                Console.WriteLine("14- UnionListas");
                Console.WriteLine("15- IntersecciónListas");
                Console.WriteLine("16- DesordenaLista");
                Console.WriteLine("17- ModaLista");
                Console.WriteLine("18- PuntuacionesTrampolin");
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
                        List<int> l = new List<int>();
                        leeLista(l);
                        EscribeLista(l);
                    }
                    break;
                case 2:
                    {
                        List<int> l = new List<int>();
                        Console.WriteLine("Dime el tamaño de la lista");
                        int count = int.Parse(Console.ReadLine());
                        LeeListaN(l, count);
                        EscribeLista(l);

                    }
                    break;
                case 3:
                    {
                        List<int> l = new List<int>();
                        l.Add(1);
                        l.Add(2);
                        EscribeLista(l);
                    }
                    break;
                case 4:
                    {
                        List<int> l = new List<int>();
                        Console.WriteLine("Dime el tamaño de la lista");
                        int count = int.Parse(Console.ReadLine());
                        LeeListaN(l, count);
                        EscribeLista(l);
                        EliminaNegativos(l);
                        EscribeLista(l);


                    }
                    break;
                case 5:
                    {
                        List<int> l = new List<int>();
                        List<int> l2 = new List<int>();
                        List<int> l3 = new List<int>();
                        Console.WriteLine("Dime el tamaño de la lista");
                        int count = int.Parse(Console.ReadLine());
                        LeeListaN(l,count);
                        EscribeLista(l);
                        ClasificaNumeros(l, l2, l3);
                        Console.Write("Lista 1: ");
                        EscribeLista(l);
                        Console.Write("Lista 2: ");
                        EscribeLista(l2);
                        Console.Write("Lista 3: ");
                        EscribeLista(l3);
                    }
                    break;
                case 6:
                    {
                        List<int> ol = new List<int>();
                        Console.WriteLine("Dime el tamaño de la lista");
                        int count = int.Parse(Console.ReadLine());
                        LeeListaN(ol, count);
                        EscribeLista(ol);
                        EliminaRepetidos(ol);
                        EscribeLista(ol);
                    }
                    break;
                case 7:
                    {
                        List<int> l = new List<int>();
                        Console.WriteLine("Dime el tamaño de la lista");
                        int count = int.Parse(Console.ReadLine());
                        LeeListaN(l, count);
                        OrdenaListaSeleccion(l);
                        EscribeLista(l);
                    }
                    break;
                case 8:
                    {
                        List<int> l = new List<int>();
                        Console.WriteLine("Dime el tamaño de la lista");
                        int count = int.Parse(Console.ReadLine());
                        LeeListaN(l, count);
                        EscribeLista(l);
                        OrdenaListaInsercion(l);
                        EscribeLista(l);
                    }
                    break;
                case 9:
                    {
                        List<string> l = new List<string> {"Hola" ,"muy" ,"buenas" ,"tardes"};
                        EscribeListaString(l);
                        OrdenaListaPalabras(l);
                        EscribeListaString(l);
                    }
                    break;
                case 10:
                    {
                        List<string> l = new List<string> { "Hola", "muy", "buenas", "tardess" };
                        EscribeListaString(l);
                        OrdenaListaPalabras2(l);
                        EscribeListaString(l);
                    }
                    break;
                case 11:
                    {
                        Console.Write("Aqui tienes el primer array");
                        int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        EscribeArray(a1);
                        Console.WriteLine("Introduce una posicion de ese array y meto todas las posiciones a partir de esa en otro array");
                        int position = int.Parse(Console.ReadLine());
                        EscribeArray(InsertaArrayEnArrayPro(a1, position));                        
                    }
                    break;
                case 12:
                    {
                        List<int> l = new List<int>();
                        SorteoBonoloto(l);
                        Console.WriteLine("Los participantes son:");
                        EscribeLista(l);
                        Console.WriteLine("Los ganadores son:");
                        EscribeLista(SorteoBonoloto(l));
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("Introduce el tamaño del array");
                        int length = int.Parse(Console.ReadLine());
                        int[] a = new int[length];
                        int[] b = new int[length];
                        Random r = new Random();
                        for (int i = 0; i < a.Length; i++)
                        {
                            int j = r.Next(1, 9);
                            a[i] = j;
                        }
                            Console.Write("Este es el array que ha salido automáticamente: ");
                            EscribeArray(a);
                            Console.Write("Este es otro array con los mismos valores menos los repetidos: ");
                            EscribeArray(EliminaRepetidos(a, b, length));
                    }
                    break;
                case 14:
                    {
                        List<int> l = new List<int>();
                        List<int> l2 = new List<int>();
                        Random r = new Random();
                        for (int i = 0; i < 5; i++)
                        {
                            int j = r.Next(1, 9);
                            l.Insert(i, j);
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            int j = r.Next(1, 9);
                            l2.Insert(i, j);
                        }
                        Console.WriteLine("Estas son las dos listas primeras");
                        EscribeLista(l);
                        EscribeLista(l2);
                        Console.WriteLine("Esta es la union de las listas");
                        EscribeLista(UnionListas(l, l2));
                    }
                    break;
                case 15:
                    {
                        List<int> l = new List<int>();
                        List<int> l2 = new List<int>();
                        Random r = new Random();
                        for (int i = 0; i < 5; i++)
                        {
                            int j = r.Next(1, 9);
                            l.Insert(i, j);
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            int j = r.Next(1, 9);
                            l2.Insert(i, j);
                        }
                        Console.WriteLine("Estas son las dos listas primeras");
                        EscribeLista(l);
                        EscribeLista(l2);
                        Console.WriteLine("Esta es la interseccion: ");
                        EscribeLista(InterseccionListas(l, l2));
                    }
                    break;
                case 16:
                    {
                        List<int> l = new List<int> { 1, 2, 3, 4 };
                        Console.Write("Lista en orden inicial: ");
                        EscribeLista(l);
                        EscribeLista(DesordenaLista(l));
                    }
                    break;
                case 17:
                    {
                        List<int> l = new List<int> { 1, 1, 1, 4, 5, 6, 7, 8, 9 };
                        Console.WriteLine("Esta es la lista ");
                        EscribeLista(l);
                        Console.WriteLine("El valor mas repetido es: " + ModaLista(l));

                    }
                    break;
                case 18:
                    {
                        List<double> l = new List<double>() { 1, 2, 3, 4, 5, 6, 7,};
                        Console.Write("Las notas son: "); 
                        EscribeListaDouble(l);
                        Console.WriteLine("La puntuacion total es: " + PuntuacionesTrampolin(l));
                    }
                    break;
                default:
                    {
                        Console.WriteLine("╔════════════════════════════════╗");
                        Console.WriteLine(" Gracias por usar el Eladio-menu");
                        Console.WriteLine("╚════════════════════════════════╝");
                    }
                    break;                    
            }

        }
            static void leeLista(List<int> l)
            {
                for (int i = 0; i < l.Count + 1; i++)
                {
                    Console.WriteLine("Introduce la posición " + i + " o un -1 para acabar");
                    int value;
                    value = int.Parse(Console.ReadLine());
                    l.Add(value);
                    if (value == -1)
                    {
                        l.Remove(value);
                        break;
                    }
                }
            }
            static void LeeListaN(List<int> l, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Introduce la posición " + i);
                    int value;
                    value = int.Parse(Console.ReadLine());
                    l.Add(value);
                }
            }
            static void EscribeLista(List<int> l)
            {
                Console.Write("< ");
                for (int i = 0; i < l.Count; i++)
                {
                Console.Write(l[i] + " ");
                }
                Console.WriteLine(">");
            }
            static void EscribeListaDouble(List<double> l)
            {
                Console.Write("< ");
                for (int i = 0; i < l.Count; i++)
                {
                    Console.Write(l[i] + " ");
                }
                Console.WriteLine(">");
            }
        static void EscribeArray(int[] a)
            {
                Console.Write("[ ");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine("]");
            }


        static void EliminaNegativos(List<int> l)
            {
            //ol.RemoveAll(p => p < 0);
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] < 0)
                {
                    l.RemoveAt(i);
                    i--;
                }
            }
            }
        static void ClasificaNumeros(List<int> l, List<int> l2, List<int> l3)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] >= 0)
                {
                    l2.Add(l[i]);                    
                }
                if (l[i] < 0)
                {
                    l3.Add(l[i]);
                }
                l2.Sort();
                l3.Sort();
            }
        }
        static void EliminaRepetidos(List<int> l)
        {
            List<int> l2 = new List<int>();
            for (int i = 0; i < l.Count; i++)
            {
                if (!l2.Contains(l[i]))
                {
                l2.Add(l[i]);                    
                }

            }
            l.Clear();
            for (int i = 0; i < l2.Count; i++)
            {
                l.Add(l2[i]);
            }
        }
        static void OrdenaListaSeleccion(List<int> l)
        {            
            List<int> resultado = new List<int>();

            while (l.Count > 0)
            {
                resultado.Add(l.Min());
                l.Remove(l.Min());
            }
            l.Clear();
            for (int i = 0; i < resultado.Count; i++)
            {
                l.Add(resultado[i]);
            }
        }
        static void OrdenaListaInsercion(List<int> l)
        {
            int n;
            bool insertado;
            List<int> resultado = new List<int>();
            for (int i = 0; i < l.Count; i++)
            {
                n = l[i]; // 20

                insertado = false;
                // 
                for (int j = 0; j < resultado.Count; j++)
                {
                    if (n < resultado[j])
                    {
                        resultado.Insert(j, n);
                        insertado = true;
                        break;
                    }
                }
                if (insertado == false)
                {
                    resultado.Add(n);
                }
            }
            l.Clear();
            l.AddRange(resultado);
        }
        static void OrdenaListaPalabras(List<string> l)
        {
            List<string> resultado = new List<string>();
            l.ToArray();
            while (l.Count > 0)
            {
                string min = l.Min();
                resultado.Add(min);
                l.Remove(min);
            }
            l.Clear();
            l.AddRange(resultado);
        }
        static void OrdenaListaPalabras2(List<string> l)
        {
            List<string> resultado = new List<string>();
            while (l.Count > 0)
            {
                resultado.Add(MinimoDeLista(l));
                l.Remove(MinimoDeLista(l));
            }
            l.AddRange(resultado);

        }
        static string MinimoDeLista(List<string> l)
        {
            string resultado;
            if (l.Count > 0)
            {
                resultado = l[0];
                for (int i = 1; i < l.Count; i++)
                {
                    if (resultado.Length > l[i].Length)
                    {
                        resultado = l[i];
                    }
                }
            }
            else
            {
                resultado = "error";
            }
            return resultado;
        }
    static void EscribeListaString(List<string> l)
        {
            Console.Write("< ");
            for (int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i] + " ");
            }
            Console.WriteLine(">");
        }

        static int[] InsertaArrayEnArrayPro(int[] a1, int position)
        {
            List<int> l = new List<int>();

            l.Add(position);
            for (int i = position; i < a1.Length; i++)
            {
                l.Add(a1[i]);
            }
            int[] a2 = l.ToArray();
            return a2;
        }
        static List<int> SorteoBonoloto (List<int> l)
        {
            for (int i = 0; i <= 49; i++)
            {
                l.Add(i);
            }
            List<int> winners = new List<int>();
            while (winners.Count < 6) // <21 > count = 0
            {
                Random r = new Random(); //Declara numero r aleatorio
                int max = 49; // Declara variable "max = 49"
                int selection = r.Next(0, max); // Entre 1 y 49 (21)
                winners.Add(selection); //añade 21 a la winners
                l.Remove(selection); //quita la posicion 21 (es decir, 21)
                max--;
            }
            return winners;
        }
        static int[] EliminaRepetidos(int[] a, int[] b, int length)
        {            
            List<int> l = new List<int>();
            //for (int i = 0; i < b.length; i++)
            //{
            //    l.add(b[i]);
            //}
            for (int i = 0; i < a.Length; i++)
            {
                if (!l.Contains(a[i]))
                {
                    l.Add(a[i]);
                }
            }
            Array.Resize(ref b, l.Count);
            for (int i = 0; i < l.Count; i++)
            {
                b[i] = l[i];
            }
            return b;
        }
        static List<int> UnionListas (List<int> l, List<int> l2)
        {
            List<int> l3 = new List<int>();
            for (int i = 0; i < l.Count; i++)
            {
                l3.Add(l[i]);                
            }
            for (int i = 0; i < l2.Count; i++)
            {
                l3.Add(l2[i]);
            }
            EliminaRepetidos(l3);
            return l3;
        }
        static List<int> InterseccionListas (List<int> l, List<int> l2)
        {
            List<int> l3 = new List<int>();

            for (int i = 0; i < l.Count; i++)
            {
                if (l.Contains(l[i]) && l2.Contains(l[i]))
                {
                    l3.Add(l[i]);
                }
                
            }
            for (int i = 0; i < l2.Count; i++)
            {
                if (l2.Contains(l[i]) && l.Contains(l2[i]))
                {
                    l3.Add(l[i]);
                }
            }
            EliminaRepetidos(l3);
            return l3;
        }
        static List<int> DesordenaLista(List<int> l)
        {
            List<int> l2 = new List<int>(l.Count);
            while (l.Count > 0)
            {
                Random r = new Random();
                int j = r.Next(0, l.Count);
                l2.Add(l[j]);
                l.RemoveAt(j);
            }
            return l2;
        }
        static int ModaLista(List<int> l)
        {
            List<int> l2 = new List<int>();
            List<int> resultado = new List<int>();
            int value = -1;
            int max;

            for (int i = 0; i < l.Count; i++)
            {
                value = resultado.IndexOf(l[i]);

                if (value != -1)
                {
                    l2[value]++;
                }
                else
                {
                    resultado.Add(l[i]);
                    l2.Add(1);
                }
            }

            max = l2[0];
            value = 0;

            for (int i = 1; i < l2.Count; i++)
            {
                if (l2[i] > max)
                {
                    max = l2[i];
                    value = i;
                }
            }
            return resultado[value];
        }
        static double PuntuacionesTrampolin(List<double> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] < 0)
                {
                    Console.WriteLine("No pueden haber notas negativas");
                    break;
                }
            }
            if (l.Count == 7)
            {
                l.Remove(l.Min());
                l.Remove(l.Min());
                l.Remove(l.Max());
                l.Remove(l.Max());
            }
            else
            {
                Console.WriteLine("Deben haber 7 notas");
            }
            double total = l[0] + l[1] + l[2];
            return total;
        }
    }
}

