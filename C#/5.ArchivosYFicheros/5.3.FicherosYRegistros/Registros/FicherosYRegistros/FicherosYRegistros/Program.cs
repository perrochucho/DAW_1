using System;
using System.Collections.Generic;
using System.IO;

namespace FicherosYRegistros
{
    class Program
    {
        public class FichaAlumno
        {
            public string nombre;
            public int edad;
            public double calificacion;
        }

        static void Main(string[] args)
        {            
            List<FichaAlumno> listaAlumnos = new List<FichaAlumno>();            
            int respuesta = 1;
            while (respuesta != 0)
            {
                Console.Clear();
                Console.WriteLine("Eladio te da la bienvenida a:");
                Console.WriteLine();
                Console.WriteLine("     RELACION DE EJERCICIOS DE FICHEROS");
                Console.WriteLine("                    Parte III");
                Console.WriteLine();
                Console.WriteLine("     ---------FICHEROS Y REGISTROS---------");
                Console.WriteLine();
                Console.WriteLine("Introduce a continuación el numero que quieres");
                Console.WriteLine();
                Console.WriteLine("1- LeeAlumnoLista");
                Console.WriteLine("2- ImprimeListaAlumnos");
                Console.WriteLine("3- EscribeFicheroAlumnosBinario");
                Console.WriteLine("4- LeeFicheroAlumnosBinario");
                Console.WriteLine("5- EscribeFicheroAlumnosTexto");
                Console.WriteLine("6- LeeFicheroAlumnosTexto");
                Console.WriteLine("7- EscribeFicheroAlumnosCSV");
                Console.WriteLine("8- LeeFicheroAlumnosCSV");
                Console.WriteLine();
                Console.WriteLine("Introduce un 0 en cualquier momento para salir del menú");

                respuesta = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Numero introducido: " + respuesta);


                switch (respuesta)
                {
                    case 1:
                        {
                            LeeAlumnoLista(listaAlumnos);
                        }
                        break;
                    case 2:
                        {
                            ImprimeListaAlumnos(listaAlumnos);
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Has terminado ya? Introduce cualquier cosa para finalizar");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        {
                            EscribeFicheroAlumnosBinario(listaAlumnos, "ficherobin.bin");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Has terminado ya? Introduce cualquier cosa para finalizar");
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        {
                            LeeFicheroAlumnosBinario(listaAlumnos, "ficherobin.bin");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Has terminado ya? Introduce cualquier cosa para finalizar");
                            Console.ReadLine();
                        }
                        break;
                    case 5:
                        {
                            EscribeFicheroAlumnosTexto(listaAlumnos, "ficherotexto.txt");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Has terminado ya? Introduce cualquier cosa para finalizar");
                            Console.ReadLine();
                        }
                        break;
                    case 6:
                        {
                            LeeFicheroAlumnosTexto(listaAlumnos, "ficherotexto.txt");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Has terminado ya? Introduce cualquier cosa para finalizar");
                            Console.ReadLine();
                        }
                        break;
                    case 7:
                        {
                            EscribeFicheroAlumnosCSV(listaAlumnos, "ficherocsv.csv");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Has terminado ya? Introduce cualquier cosa para finalizar");
                            Console.ReadLine();
                        }
                        break;
                    case 8:
                        {
                            LeeFicheroAlumnosCSV(listaAlumnos, "ficherocsv.csv");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Has terminado ya? Introduce cualquier cosa para finalizar");
                            Console.ReadLine();
                        }
                        break;                        
                    default:
                        break;

                }
                while (respuesta < 0 || respuesta > 8)
                {
                    Console.Clear();
                    Console.WriteLine("Eladio te da la bienvenida a:");
                    Console.WriteLine();
                    Console.WriteLine("     RELACION DE EJERCICIOS DE FICHEROS");
                    Console.WriteLine("                    Parte III");
                    Console.WriteLine();
                    Console.WriteLine("     ---------FICHEROS Y REGISTROS---------");
                    Console.WriteLine();
                    Console.WriteLine("Introduce a continuación el numero que quieres");
                    Console.WriteLine();
                    Console.WriteLine("1- LeeAlumnoLista");
                    Console.WriteLine("2- ImprimeListaAlumnos");
                    Console.WriteLine("3- EscribeFicheroAlumnosBinario");
                    Console.WriteLine("4- LeeFicheroAlumnosBinario");
                    Console.WriteLine("5- EscribeFicheroAlumnosTexto");
                    Console.WriteLine("6- LeeFicheroAlumnosTexto");
                    Console.WriteLine("7- EscribeFichero");
                    Console.WriteLine("8- LeeFicheroAlumnosCSV");
                    Console.WriteLine();
                    Console.WriteLine("Introduce un 0 en cualquier momento para salir del menú");                    

                    respuesta = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Numero introducido: " + respuesta);
                    Console.WriteLine();
                }
            }
        }
        static void LeeAlumnoLista (List<FichaAlumno> l)
        {
            FichaAlumno f = new FichaAlumno();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Introduce el nombre del Alumno");
            f.nombre = Console.ReadLine();
            Console.WriteLine("Introduce la edad");
            f.edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce su calificación");
            f.calificacion = double.Parse(Console.ReadLine());
            l.Add(f);
        }
        static void ImprimeListaAlumnos (List<FichaAlumno> listaAlumnos)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nombre                         Edad          Calificación");
            Console.WriteLine("=======================       =====         ============");
            for (int i = 0; i < listaAlumnos.Count; i++)
            {                
                Console.WriteLine(listaAlumnos[i].nombre.PadRight(33) + listaAlumnos[i].edad.ToString().PadRight(12) + listaAlumnos[i].calificacion.ToString().PadRight(4));
            }            
        }
        static void EscribeFicheroAlumnosBinario (List<FichaAlumno> listaAlumnos, string ficherobin)
        {
            FileStream fs = new FileStream(ficherobin, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(listaAlumnos.Count);

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                bw.Write(listaAlumnos[i].nombre);
                bw.Write(listaAlumnos[i].edad);
                bw.Write(listaAlumnos[i].calificacion);
            }
            bw.Close();
            fs.Close();            
        }
        static void LeeFicheroAlumnosBinario (List<FichaAlumno> listaAlumnos, string ficherobin)
        {
            listaAlumnos.Clear();            
            FileStream fs = new FileStream(ficherobin, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            br.ReadInt32();
            while (fs.Position < fs.Length)
            {
                FichaAlumno f2 = new FichaAlumno();
                f2.nombre = br.ReadString();
                f2.edad = br.ReadInt32();
                f2.calificacion = br.ReadDouble();
                listaAlumnos.Add(f2);
            }
            br.Close();
            fs.Close();
        }
        static void EscribeFicheroAlumnosTexto (List<FichaAlumno> listaAlumnos, string ficherotexto)
        {
            //FileStream fs = new FileStream(ficherotexto, FileMode.Create);
            StreamWriter sw = new StreamWriter(ficherotexto);
            sw.WriteLine(listaAlumnos.Count);

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                sw.WriteLine(listaAlumnos[i].nombre);
                sw.WriteLine(listaAlumnos[i].edad);
                sw.WriteLine(listaAlumnos[i].calificacion);
            }
            sw.Close();
            //fs.Close();
        }
        static void LeeFicheroAlumnosTexto (List<FichaAlumno> listaAlumnos, string ficherotexto)
        {            
            listaAlumnos.Clear();            
            StreamReader sr = new StreamReader(ficherotexto);            
            int numeroRegistros = int.Parse(sr.ReadLine());
            for (int i = 0; i < numeroRegistros; i++)
            {
                FichaAlumno f2 = new FichaAlumno();
                f2.nombre = sr.ReadLine();
                f2.edad = int.Parse(sr.ReadLine());
                f2.calificacion = double.Parse(sr.ReadLine());
                listaAlumnos.Add(f2);
            }
            sr.Close();
        }
        static void EscribeFicheroAlumnosCSV (List<FichaAlumno> listaAlumnos, string ficherocsv)
        {
            StreamWriter sw = new StreamWriter(ficherocsv);
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                sw.WriteLine($"{listaAlumnos[i].nombre};{listaAlumnos[i].edad};{listaAlumnos[i].calificacion}");
            }
            sw.Close();
        }
        static void LeeFicheroAlumnosCSV (List<FichaAlumno> listaAlumnos, string ficherocsv)
        {
            listaAlumnos.Clear();
            StreamReader sr = new StreamReader(ficherocsv);
            FichaAlumno listaAlumnostemp;
            //for (int i = 0; i < listaAlumnos.Count; i++)
            //{
            //    listaAlumnos[i].nombre = sr.ReadLine();
            //    listaAlumnos[i].edad = int.Parse(sr.ReadLine());
            //    listaAlumnos[i].calificacion = double.Parse(sr.ReadLine());
            //}
            while (!sr.EndOfStream)
            {
                listaAlumnostemp = new FichaAlumno();
                listaAlumnostemp.nombre = sr.ReadLine();
                listaAlumnostemp.edad = int.Parse(sr.ReadLine());
                listaAlumnostemp.calificacion = double.Parse(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
