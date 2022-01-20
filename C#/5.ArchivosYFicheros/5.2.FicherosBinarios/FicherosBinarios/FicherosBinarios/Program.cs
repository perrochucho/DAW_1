using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FicherosBinarios
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
            Console.WriteLine("1- EscribeFichero1_100");
            Console.WriteLine("2- LeeFicheroInt100");
            Console.WriteLine("3- EscribeFicheroIntAleatorio");
            Console.WriteLine("4- EscribeFicheroIntAleatorioPro");
            Console.WriteLine("5- LeeFicheroInt");
            Console.WriteLine("6- SumaFicheroInt");
            Console.WriteLine("7- LeeFicheroIntLista");
            Console.WriteLine("8- EscribeFicheroIntLista");
            Console.WriteLine("9- OrdenaFicheroInt");
            Console.WriteLine("10- SeparaFicheroInt");
            Console.WriteLine("11- InvierteFicheroInt");
            Console.WriteLine();
            Console.WriteLine("█═══════════════════█");
            Console.WriteLine();
            Console.WriteLine("0- Salir");
            Console.WriteLine();
            Console.WriteLine("Elige una opción");
            int respuesta = int.Parse(Console.ReadLine());

            while (respuesta < 0 || respuesta > 11)
            {
                Console.Clear();
                Console.WriteLine("╔════╗ ");
                Console.WriteLine(" Menú ");
                Console.WriteLine("╚════╝");
                Console.WriteLine();
                Console.WriteLine("█═══════════════════█");
                Console.WriteLine();
                Console.WriteLine("1- EscribeFichero1_100");
                Console.WriteLine("2- LeeFicheroInt100");
                Console.WriteLine("3- EscribeFicheroIntAleatorio");
                Console.WriteLine("4- EscribeFicheroIntAleatorioPro");
                Console.WriteLine("5- LeeFicheroInt");
                Console.WriteLine("6- SumaFicheroInt");
                Console.WriteLine("7- LeeFicheroIntLista");
                Console.WriteLine("8- EscribeFicheroIntLista");
                Console.WriteLine("9- OrdenaFicheroInt");
                Console.WriteLine("10- SeparaFicheroInt");
                Console.WriteLine("11- InvierteFicheroInt");
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
                        EscribeFichero1_100("datos01.bin");
                    }
                    break;
                case 2:
                    {
                        
                        LeeFicheroInt100("datos01.bin");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Cuántos números aleatorios quieres que tenga?");
                        int n = int.Parse(Console.ReadLine());
                        EscribeFicheroIntAleatorio("datos02.bin", n);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Cuántos números aleatorios quieres que tenga?");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Cual va a ser el valor mínimo de los numeros aleatorios?");
                        int min = int.Parse(Console.ReadLine());
                        Console.WriteLine("Y el máximo?");
                        int max = int.Parse(Console.ReadLine());
                        EscribeFicheroIntAleatorioPro("datos02.bin", n, min, max);

                    }
                    break;
                case 5:
                    {
                        LeeFicheroInt("datos02.bin");
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("La suma de todos los valores de ese fichero es: " + SumaFicheroInt("datos02.bin")); 
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Estos son los valores del fichero metidos en una lista: ");
                        EscribeListaInt(LeeFicheroIntLista("datos02.bin"));
                    }
                    break;
                case 8:
                    {
                        List<int> l = new List<int>();
                        l.Add(1);
                        l.Add(4);
                        l.Add(2);
                        l.Add(3);
                        l.Add(5);
                        EscribeFicheroIntLista("datos02.bin", l);
                        LeeFicheroInt("datos02.bin");
                    }
                    break;
                case 9:
                    {
                        OrdenaFicheroInt("datos02.bin", "datos03.bin");
                        Console.WriteLine();
                        LeeFicheroInt("datos03.bin");

                    }
                    break;
                case 10:
                    {
                        SeparaFicheroInt("datos02.bin");
                        Console.WriteLine();
                        Console.WriteLine("Estos son los positivos: ");
                        LeeFicheroInt("datos02.binpositivos");
                        Console.WriteLine("Estos son los negativos: ");
                        LeeFicheroInt("datos02.binnegativos");
                    }
                    break;
                case 11:
                    {
                        LeeFicheroInt("datos02.bin");
                        Console.WriteLine("Lo invertimos y: ");
                        InvierteFicheroInt("datos02.bin");
                        LeeFicheroInt("datos02.bin");
                    }
                    break;
                default:
                    break;
            }
        }
        static void EscribeFichero1_100 (string ficherobin)
        {
            FileStream fs = new FileStream(ficherobin, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 1; i <= 100; i++)
            {
                bw.Write(i);
            }

            bw.Close();
            fs.Close();
        }
        static void LeeFicheroInt100 (string ficherobin)
        {
            FileStream fs = new FileStream(ficherobin, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(br.ReadInt32());
            }

            br.Close();
            fs.Close();
        }
        static void EscribeFicheroIntAleatorio (string ficherobin, int n)
        {
            FileStream fs = new FileStream(ficherobin, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                int random = r.Next(1, 100);
                bw.Write(random);
            }
            bw.Close();
            fs.Close();
        }
        static void EscribeFicheroIntAleatorioPro (string ficherobin, int n, int min, int max)
        {
            FileStream fs = new FileStream(ficherobin, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                int random = r.Next(min, max);
                bw.Write(random);
            }

            bw.Close();
            fs.Close();
        }
        static void LeeFicheroInt (string ficherobin)
        {
            FileStream fs = new FileStream(ficherobin, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Console.WriteLine(br.ReadInt32());
            }

            br.Close();
            fs.Close();
        }
        static int SumaFicheroInt (string ficherobin)
        {
            FileStream fs = new FileStream(ficherobin, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int suma;
            suma = 0;
            while (fs.Position < fs.Length)
            {
                suma = suma + br.ReadInt32();
            }

            br.Close();
            fs.Close();

            return suma;
        }
        static List<int> LeeFicheroIntLista (string ficherobin)
        {

            FileStream fs = new FileStream(ficherobin, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            List<int> l = new List<int>();

            while (fs.Position < fs.Length)
            {
                l.Add(br.ReadInt32());
            }

            br.Close();
            fs.Close();

            return l;
        }
        static void EscribeListaInt(List<int> l)
        {
            Console.Write("< ");
            for (int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i] + " ");
            }
            Console.WriteLine(">");
        }
        static void EscribeFicheroIntLista(string ficherobin, List<int> l)
        {
            FileStream fs = new FileStream(ficherobin, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            int i = 0;

            while (i < l.Count)
            {                
                bw.Write(l[i]);
                i++;
            }

            bw.Close();
            fs.Close();
        }
        static void OrdenaFicheroInt (string ficherobin, string ficherobin2)
        {
            FileStream fs = new FileStream(ficherobin, FileMode.Open);  // < 1 3 2 4 5>
            BinaryReader br = new BinaryReader(fs);
            List<int> l = new List<int>();
            while (fs.Position < fs.Length)
            {
                l.Add(br.ReadInt32());
            }
            br.Close();
            fs.Close();
            OrdenaListaSeleccion(l);
            FileStream fr = new FileStream(ficherobin2, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fr);
            for (int i = 0; i < l.Count; i++)
            {
                bw.Write(l[i]);
            }
            bw.Close();
            fr.Close();

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
        static void SeparaFicheroInt (string ficherobin)
        {
            FileStream fs = new FileStream(ficherobin, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            List<int> lnegativo = new List<int>();
            List<int> lpositivo = new List<int>();

            while (fs.Position < fs.Length)
            {
                int n = br.ReadInt32();

                if (n < 0)
                {
                    lnegativo.Add(n);
                }
                else
                {
                    lpositivo.Add(n);
                }
            }

            br.Close();
            fs.Close();

            EscribeFicheroIntLista(ficherobin + "positivos ", lpositivo);
            EscribeFicheroIntLista(ficherobin + "negativos ", lnegativo);

        }
        static void InvierteFicheroInt (string ficherobin)
        {
            FileStream fs = new FileStream(ficherobin, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            List<int> l = new List<int>();
            while (fs.Position < fs.Length)
            {
                l.Add(br.ReadInt32());
            }
            l.Reverse();
            br.Close();
            fs.Close();

            FileStream fs2 = new FileStream(ficherobin, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs2);


            for (int i = 0; i < l.Count; i++)
            {
                bw.Write(l[i]);
            }

            bw.Close();
            fs2.Close();                        
        }
    }
}
