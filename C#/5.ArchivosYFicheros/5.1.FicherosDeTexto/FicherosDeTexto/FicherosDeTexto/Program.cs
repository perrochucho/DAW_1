using System;
using System.Collections.Generic;
using System.IO;

namespace FicherosDeTexto
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
            Console.WriteLine("1- EscribeFicheroNumRandom10");
            Console.WriteLine("2- SumaFicheroInt10");
            Console.WriteLine("3- EscribeFicheroNumrandom");
            Console.WriteLine("4- SumaFicheroInt");
            Console.WriteLine("5- EscribeFicheroTexto");
            Console.WriteLine("6- LeeFicheroTexto");
            Console.WriteLine("7- CopiaFicheroTexto");
            Console.WriteLine("8- InvierteLineasFichero");
            Console.WriteLine("9- InvierteFicheroTexto");
            Console.WriteLine("10- SeparaPalabrasFichero");
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
                Console.WriteLine("1- EscribeFicheroNumRandom10");
                Console.WriteLine("2- SumaFicheroInt10");
                Console.WriteLine("3- EscribeFicheroNumrandom");
                Console.WriteLine("4- SumaFicheroInt");
                Console.WriteLine("5- EscribeFicheroTexto");
                Console.WriteLine("6- LeeFicheroTexto");
                Console.WriteLine("7- CopiaFicheroTexto");
                Console.WriteLine("8- InvierteLineasFichero");
                Console.WriteLine("9- InvierteFicheroTexto");
                Console.WriteLine("10- SeparaPalabrasFichero");
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
                        EscribeFicheroNumRandom10("ejercicio1.txt");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine();
                        Console.WriteLine("La suma de todos los numeros de ese fichero es: " + SumaFicheroInt10("ejercicio1.txt"));
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Dime el numero de numeros que quieres que tenga este fichero");
                        int n = int.Parse(Console.ReadLine());
                        EscribeFicheroNumrandom("ejercicio3.txt", n);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine();
                        Console.WriteLine("La suma de todos los numeros de ese fichero es: " + SumaFicheroInt("ejercicio2.txt"));
                    }
                    break;
                case 5:
                    {
                        EscribeFicheroTexto("EscribeFicheroTexto.txt");
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine();
                        LeeFicheroTexto("EscribeFicheroTexto.txt");
                    }
                    break;
                case 7:
                    {
                        CopiaFicheroTexto("EscribeFicheroTexto.txt", "CopiaFicheroTexto.txt");
                    }
                    break;
                case 8:
                    {
                        InvierteLineasFichero("EscribeFicheroTexto.txt", "InvierteLineasFichero.txt");
                        LeeFicheroTexto("InvierteLineasFichero.txt");
                    }
                    break;
                case 9:
                    {
                        InvierteFicheroTexto("ejercicio1.txt");
                    }
                    break;
                case 10:
                    {
                        SeparaPalabrasFichero("EscribeFicheroTexto.txt", "SeparaPalabrasFichero.txt");
                        LeeFicheroTexto("SeparaPalabrasFichero.txt");
                    }
                    break;
                default:
                    break;
            }
        }
        static void EscribeFicheroNumRandom10(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                int n = r.Next(1, 10);
                sw.WriteLine(n);
            }
            sw.Close();
        }
        static int SumaFicheroInt10(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            int n;
            n = 0;
            while (!sr.EndOfStream)
            {
                n += int.Parse(sr.ReadLine());
            }
            sr.Close();
            return n;
        }
        static void EscribeFicheroNumrandom(string fichero, int n)
        {
            StreamWriter sw = new StreamWriter("ejercicio2.txt");
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int z = r.Next(1, 10);
                sw.WriteLine(z);
            }
            sw.Close();
        }
        static int SumaFicheroInt(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            int n;
            n = 0;
            while (!sr.EndOfStream)
            {
                n += int.Parse(sr.ReadLine());
            }
            sr.Close();
            return n;
        }
        static void EscribeFicheroTexto(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            string addtext = Console.ReadLine();
            while (addtext != "")
            {
                sw.WriteLine(addtext);
                addtext = Console.ReadLine();
            }
            sw.Close();
        }
        static void LeeFicheroTexto(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
        }
        static void CopiaFicheroTexto(string fichero, string fichero2)
        {
            StreamReader sr = new StreamReader(fichero);
            StreamWriter sw = new StreamWriter(fichero2);

            while (!sr.EndOfStream)
            {
                sw.WriteLine(sr.ReadLine());
            }
            sw.Close();
            sr.Close();
        }
        static void InvierteLineasFichero(string fichero, string fichero2)
        {
            StreamReader sr = new StreamReader(fichero);
            StreamWriter sw = new StreamWriter(fichero2);

            while (!sr.EndOfStream)
            {
                sw.WriteLine(InvertirCadena(sr.ReadLine()));
            }
            sr.Close();
            sw.Close();
        }
        static string InvertirCadena(string s)
        {
            string total = "";

            for (int i = s.Length - 1; i > -1; i--)
            {
                total = total + s[i];
            }
            return total;
        }
        static void InvierteFicheroTexto(string fichero)
        {
            List<string> l = StreamToList(fichero);
            StreamWriter sw = new StreamWriter(fichero);
            l.Reverse();

            for (int i = 0; i < l.Count; i++)
            {
                sw.WriteLine(l[i]);
            }
            sw.Close();
        }
        static List<string> StreamToList(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            List<string> l = new List<string>();

            while (!sr.EndOfStream)
            {
                l.Add(sr.ReadLine());
            }
            sr.Close();
            return l;
        }
        static void SeparaPalabrasFichero(string filename1, string filename2)
        {           
            StreamReader sr = new StreamReader(filename1);
            StreamWriter sw = new StreamWriter(filename2);
            string[] s;

            while (!sr.EndOfStream)
            {
                s = sr.ReadLine().Split(' ');

                for (int i = 0; i < s.Length; i++)
                {
                    sw.WriteLine(s[i]);
                }
            }
            sw.Close();
            sr.Close();
        }
    }        
}

