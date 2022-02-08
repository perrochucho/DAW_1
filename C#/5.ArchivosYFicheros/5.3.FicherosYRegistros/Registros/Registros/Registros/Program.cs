using System;
using System.Collections.Generic;

namespace Registros
{
    class Program
    {        
        public class Coche
        {
            public string matricula;
            public string marca;
            public string modelo;
            public bool esElectrico;
            public int NumeroKilometros;
        }
        static void Main(string[] args)
        {
            Coche c = new Coche();

            c.matricula = "8745BCD";
            c.marca = "Fiat";
            c.modelo = "500";
            c.esElectrico = false;
            c.NumeroKilometros = 200000;

            Coche c2 = new Coche();

            c2.matricula = "9879PPK";
            c2.marca = "Rover";
            c2.modelo = "400";
            c2.esElectrico = false;
            c2.NumeroKilometros = 256787;

            List<Coche> l = new List<Coche>();
            l.Add(c);
            l.Add(c2);

            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i].marca + " " + l[i].modelo);
            }

        }

        public class Posicion
        {
            public int fila;
            public int columna;
        }

        
    }
}
