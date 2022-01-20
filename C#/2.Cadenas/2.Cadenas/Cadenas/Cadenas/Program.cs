using System;
using System.Text;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Black;
            int respuesta;
            Console.Clear();
            Console.WriteLine("╔════╗ ");
            Console.WriteLine(" Menú ");
            Console.WriteLine("╚════╝");
            Console.WriteLine();
            Console.WriteLine("█═══════════════════█");
            Console.WriteLine();
            Console.WriteLine("1- Numero Espacios");
            Console.WriteLine("2- NumeroVocales");
            Console.WriteLine("3- EsPalindromo");
            Console.WriteLine("4- Contiene");
            Console.WriteLine("5- RepiteCaracter");
            Console.WriteLine("6- QuitaEspacios");
            Console.WriteLine("7- QuitaEspaciosTrim");
            Console.WriteLine("8- SustituyeCaracter");
            Console.WriteLine("9- CuentaPalabras");
            Console.WriteLine("10- EsNumero");
            Console.WriteLine("11- QuitaCaracter");
            Console.WriteLine("12- QuitaAcentos");
            Console.WriteLine("13- InvierteCadena");
            Console.WriteLine("14- VecesCaracter");
            Console.WriteLine("15- VecesPalabra");
            Console.WriteLine("16- MayusculasPrimera");
            Console.WriteLine("17- SustituyePalabra");
            Console.WriteLine("18- InviertePalabras");
            Console.WriteLine("19- MarcaSubCadena");
            Console.WriteLine("20- QuitaEspaciosSobrantes");
            Console.WriteLine();
            Console.WriteLine("█═══════════════════█");
            Console.WriteLine();
            Console.WriteLine("0- Salir");
            Console.WriteLine();
            Console.WriteLine("Elige una opción");
            respuesta = int.Parse(Console.ReadLine());


            while (respuesta < 0 || respuesta > 20)
            {
                Console.Clear();
                Console.WriteLine("╔════╗ ");
                Console.WriteLine(" Menú ");
                Console.WriteLine("╚════╝");
                Console.WriteLine();
                Console.WriteLine("█═══════════════════█");
                Console.WriteLine();
                Console.WriteLine("1- NumeroEspacios");
                Console.WriteLine("2- NumeroVocales");
                Console.WriteLine("3- EsPalindromo");
                Console.WriteLine("4- Contiene");
                Console.WriteLine("5- RepiteCaracter");
                Console.WriteLine("6- QuitaEspacios");
                Console.WriteLine("7- QuitaEspaciosTrim");
                Console.WriteLine("8- SustituyeCaracter");
                Console.WriteLine("9- CuentaPalabras");
                Console.WriteLine("10- EsNumero");
                Console.WriteLine("11- QuitaCaracter");
                Console.WriteLine("12- QuitaAcentos");
                Console.WriteLine("13- InvierteCadena");
                Console.WriteLine("14- VecesCaracter");
                Console.WriteLine("15- VecesPalabra");
                Console.WriteLine("16- MayusculasPrimera");
                Console.WriteLine("17- SustituyePalabra");
                Console.WriteLine("18- InviertePalabras");
                Console.WriteLine("19- MarcaSubCadena");
                Console.WriteLine("20- QuitaEspaciosSobrantes");                
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
                        string cadena;
                        Console.WriteLine("Introduce una frase");
                        cadena = Console.ReadLine();
                        Console.WriteLine("Esa frase tiene ");
                        Console.Write(NumeroEspacios(cadena));
                        Console.Write(" espacios");

                    }
                    break;
                case 2:
                    {
                        string cadena;
                        Console.WriteLine("Introduce una frase");
                        cadena = Console.ReadLine();
                        Console.WriteLine("Esa frase tiene ");
                        Console.Write(NumeroVocales(cadena));
                        Console.Write(" vocales");

                    }
                    break;
                case 3:
                    {
                        string cadena;
                        Console.WriteLine("Introduce una frase");
                        cadena = Console.ReadLine();
                        if (EsPalindromo(cadena))
                        {
                            Console.WriteLine("Si es palindromo");
                        }
                        else
                        {
                            Console.WriteLine("No es palindromo");
                        }
                    }
                    break;
                case 4:
                    {
                        string cadena;
                        char caracter;
                        Console.WriteLine("Introduce una frase");
                        cadena = Console.ReadLine();
                        Console.WriteLine("Introduce un caracter");
                        caracter = char.Parse(Console.ReadLine());
                        if (Contiene(cadena, caracter))
                        {
                            Console.WriteLine("Lo contiene asies");
                        }
                        else
                        {
                            Console.WriteLine("No lo contiene");
                        }
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Dime un caracter");
                        char caracter = char.Parse(Console.ReadLine());
                        Console.WriteLine("Dime un numero de repeticiones");
                        int repeticiones = int.Parse(Console.ReadLine());
                        Console.WriteLine(RepiteCaracter(caracter, repeticiones));


                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Dime una frase");
                        string cadena = Console.ReadLine();
                        Console.WriteLine(QuitaEspacios(cadena));
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Dime una frase, si es posible con un espacio al principio y otro al final");
                        string cadena = Console.ReadLine();
                        Console.WriteLine(QuitaEspaciosTrim(cadena));
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("Dime una frase ");
                        string cadena = Console.ReadLine();
                        Console.WriteLine("Dime el caracter que quieres reemplazar");
                        char caracter1 = Console.ReadLine()[0];
                        Console.WriteLine("Dime el caracter por el cual lo quieres reemplazar");
                        char caracter2 = Console.ReadLine()[0];
                        Console.WriteLine(SustituyeCaracter(cadena, caracter1, caracter2));
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("Dime una frase");
                        string cadena = Console.ReadLine();
                        Console.Write("Tiene " + (CuentaPalabras(cadena)) + " palabras");
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Dime una frase");
                        string cadena = Console.ReadLine();
                        if (EsNumero(cadena))
                        {
                            Console.WriteLine("Es numero");
                        }
                        else
                        {
                            Console.WriteLine("No es un numero");
                        }
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("Dime una frase");
                        string cadena = Console.ReadLine();
                        Console.WriteLine("Dime el caracter que quieras quitar");
                        char caracter = Console.ReadLine()[0];
                        Console.WriteLine(QuitaCaracter(cadena, caracter));
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("Dime una frase");
                        string cadena = Console.ReadLine();
                        Console.WriteLine(QuitaAcentos(cadena));
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("Dime una frase");
                        string cadena = Console.ReadLine();
                        Console.WriteLine(InvierteCadena(cadena));
                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("Dime una frase");
                        string cadena = Console.ReadLine();
                        Console.WriteLine("Dime un caracter");
                        char caracter = char.Parse(Console.ReadLine());
                        Console.WriteLine("Ese caracter se repite la cantidad de: ");
                        Console.Write(VecesCaracter(cadena, caracter));
                        Console.Write(" veces");
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("Dime una frase");
                        string cadena = Console.ReadLine();
                        Console.WriteLine("Dime una palabra");
                        string palabra = Console.ReadLine();
                        Console.WriteLine("Esa palabra se repite la cantidad de: ");
                        Console.Write(VecesPalabra(cadena, palabra));
                        Console.Write(" veces");
                    }
                    break;
                case 16:
                    {
                        Console.WriteLine("Dime una frase");
                        string cadena = Console.ReadLine();
                        Console.WriteLine(MayusculasPrimera(cadena));
                    }
                    break;
                case 17:
                    {
                        Console.WriteLine("Dime una frase");
                        string cadena = Console.ReadLine();
                        Console.WriteLine("Dime una palabra");
                        string palabra1 = Console.ReadLine();
                        Console.WriteLine("Dime otra palabra");
                        string palabra2 = Console.ReadLine();
                        Console.WriteLine(SustituyePalabra(cadena, palabra1, palabra2)); 
                    }
                    break;
                case 18:
                    {
                        Console.WriteLine("Dime una frase");
                        string cadena = Console.ReadLine();
                        Console.WriteLine(InviertePalabras(cadena));
                    }
                    break;
                case 19:
                    {
                        Console.WriteLine("Dime una frase");
                        string cadena = Console.ReadLine();
                        Console.WriteLine("Dime otra frase");
                        string cadena2 = Console.ReadLine();
                        Console.WriteLine(MarcaSubCadena(cadena, cadena2));
                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("Dime una frase, pon muchos espacios");
                        string cadena = Console.ReadLine();
                        Console.WriteLine(QuitaEspaciosSobrantes(cadena));
                    }
                    break;
                default:
                    {
                        Console.WriteLine("╔══════════════════════════════╗");
                        Console.WriteLine("Gracias por usar el Eladio-menú");
                        Console.WriteLine("╚══════════════════════════════╝");
                    }
                    break;
            }


        }
        static void Apuntes(string s)
        {

            #region StringBuilder

            //StringBuilder sb = new StringBuilder();
            //sb.Append("P");
            //for (i = 1; i < s2.Length; i++)
            //{
            //    sb.Append(s2[i]);
            //}

            //string s4 = sb.ToString();
            //Console.WriteLine(s4);

            #endregion

            #region Funciones integradas
            //Funciones integradas de cadenas

            //s.Substring
            //s.Contains
            //s.EndsWith

            //s.StartsWith
            //s.IndexOf
            //s.LastIndexOf
            //s.Insert
            //s.Remove
            //s.PadLeft
            //s.PadRight
            //s.Replace
            //s.Substring
            //s.ToLower
            //s.ToUpper
            //s.Trim
            //s.TrimStart
            //s.TrimEnd
            //s.Split
            //String.Join
            #endregion

            #region Index/LastIndex
            //Nota: 7/10 Es interesante

            //s.indexOf
            //s.LastIndexOf

            //---------------------------------------------------------

            //Explicacion Principal

            // Devuelve la posicion de lo que dices 
            //Si no está devuelve -1

            //string s6 = "pepino";
            //Console.WriteLine(s2.IndexOf('x'));

            //---------------------------------------------------------

            //No entiendo esto del todo

            //string s2 = "mi pepino es divino";

            //Console.WriteLine(s2.IndexOf('p'));
            //int pos = s2.IndexOf('p');

            //int post = s2.IndexOf("es");
            //int posi = s2.IndexOf('i', pos);
            //Console.WriteLine(posi);

            //---------------------------------------------------------

            #endregion

            #region Insert/Remove 
            //Nota: 8/10 me ha gustado

            //Aqui lo que hago es coger la string s7 que es patata y le quito la posicion 
            //string s7 = "patata";
            //Console.WriteLine(s7);
            //s7 = s7.Remove(0, 1); //quita "1" elemento a partir de la posicion "0"
            //s7 = s7.Insert(0, "P"); //Inserta "P" a partir de la posicion "0"
            //Console.WriteLine(s7);

            //int[] a = { 1, 2, 3, 4 };

            #endregion

            #region SubString
            //Nota: 9.5/10 Esta bastante guapa 

            //Recorta una cadena, desde X posicion, una cantidad X

            //string cosa = "camaleón";

            //Console.WriteLine(cosa.Substring(0,4)); //A partir de la posicion 0, escribe 4 posiciones
            //Console.WriteLine(cosa.Substring(4, 4)); //A partir de la posicion 4, escribe 4 posicoones
            //Console.WriteLine(cosa.Substring(5)); //A partir de la posicion 5, escribe todas

            //string cosa2 = cosa.Substring(0, 4) + "X" + cosa.Substring(4); //crea una nueva variable que es igual a 
            //Console.WriteLine(cosa2);                                      //Las 4 posiciones a partir del 0, "X"
            //                                                               //y el resto de 
            //                                                               //Posiciones hasta que acaba            

            #endregion

            #region Replace
            //Nota: 7.5/10 Me flipa pero parece peligrosa
            //string cosa3 = "patata";

            //cosa3 = cosa3.Replace('p', 'P');
            //Console.WriteLine(cosa3);

            #endregion

            #region Trim
            //Nota: 5.5/10 Me parece aburrida pero se ve que funciona bien 
            //string cosa4 = "      patata      ";
            //Console.WriteLine(">" + cosa4.TrimStart() + "<");
            //Console.WriteLine(">" + cosa4.TrimStart() + "<");
            //Console.WriteLine(">" + cosa4.TrimStart() + "<");

            #endregion

            #region ToUpper/ToLower

            //Nota: 5/10 Simple pero parece entretenida

            //string cosa5 = "patata TOMATE";
            //Console.WriteLine(cosa5);
            //Console.WriteLine(cosa5.ToUpper());
            //Console.WriteLine(cosa5.ToLower());

            //Y ahora para una letra solamente

            //string cosa6 = "patata TOMATE";
            //string cosa7 = Char.ToUpper(cosa6[0]) + cosa6.Substring(1);
            //Console.WriteLine(cosa7);

            #endregion

            #region PadLeft/PadRight
            //Nota: 4.5/10 Tiene utilidad pero personalmente no me gusta

            //Console.WriteLine("232,57 $".PadLeft(11)); //Mete espacios hasta un maximo de 11 para que todos esten alineados
            //Console.WriteLine("1920,74 $".PadLeft(11));
            //Console.WriteLine("1,2 $".PadLeft(11));
            //Console.WriteLine("232,57 $".PadLeft(11));
            //Console.WriteLine("232,57 $".PadLeft(11));

            #endregion

            #region Split/Join
            //Nota: 8 / 10 Complicado pero interesante
            //string estoyhartoya = "hola don pepito hola don jose";

            //string[] palabras = estoyhartoya.Split(" "); //Esto crea un array de string y cada vez que se encuentra un
            //                                             //espacio añade un valor al string
            //                                             //de forma que crea un string con 6 valores como se ve arriba
            //Console.WriteLine(estoyhartoya);

            //for (int i = 0; i < palabras.Length; i++)
            //{
            //    Console.WriteLine(palabras[i]);
            //}

            //Console.WriteLine(palabras[2][0]);           //Escribe de la posicion 2 del array (pepito) la letra en primera pos

            //palabras[2] = "juanito";

            //string s16 = string.Join(' ', palabras);
            //Console.WriteLine(s16);

            #endregion

            #region Maniobras For

            //Maniobras con los For
            //int i, cont = 1;
            //string s13 = "patata";
            //string s14 = "";

            //for (i = 0; i < s13.Length; i++) //Esto es un bucle que pasa por el string s13 que es patata y cuando la
            //                                 //posicion i sea desigual a A no se que pasa
            //{
            //    if (s13[i] != 'a')
            //    {
            //        s14 = s14 + s13[i];
            //    }
            //    else
            //    {
            //        s14 = s14 + cont;
            //        cont++;
            //    }
            //}
            //Console.WriteLine(s13);
            //Console.WriteLine(s14);

            //s14 = QuitaLetraA(s13);

            //static string QuitaLetraA(string s20)
            //{
            //    int i;
            //    string s2 = "";
            //    for (i = 0; i < s20.Length; i++)
            //    {
            //        if (s20[i] != 'a')
            //        {
            //            s2 = s2 + s2[i];
            //        }
            //    }
            //    return s2;


            #endregion

        }

        static int NumeroEspacios(string cadena)
        {
            int espacios;
            espacios = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')
                {
                    espacios++;
                }
            }
            return espacios;
        }
        static int NumeroVocales(string cadena)
        {
            int i, voc = 0;
            i = 0;
            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u')
                {
                    voc++;
                }
            }
            return voc;
        }
        static bool EsPalindromo(string cadena)
        {
            int i, j;
            for (i = 0, j = cadena.Length - 1; i < j; i++, j--)
            {
                if (cadena[i] == cadena[j])
                {
                    return true;
                }
            }
            return false;
        }
        static bool Contiene(string cadena, char caracter)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == caracter)
                {
                    return true;
                }
            }
            return false;
        }
        static string RepiteCaracter(char caracter, int repeticiones)
        {
            string cadena;
            cadena = "";
            for (int i = 0; i < repeticiones; i++)
            {
                cadena = cadena + caracter;
            }
            return cadena;
        }

        static string QuitaEspacios(string cadena)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')
                {
                    cadena = cadena.Remove(i, 1);
                }
            }
            return cadena;
        }
        static string QuitaEspaciosTrim(string cadena)
        {
            int contador = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')
                {
                    cadena = cadena.Remove(i, 1);
                    i--;
                    contador++;

                }
                else
                {
                    break;
                }

            }
            for (int c = cadena.Length - 1; c >= 0; c--)
            {
                if (cadena[c] == ' ')
                {
                    cadena = cadena.Remove(c, 1);
                    contador++;

                }
                else
                {
                    break;
                }

            }
            Console.WriteLine();
            Console.WriteLine("He eliminado un total de " + contador + " espacios");
            return cadena;
        }
        static string SustituyeCaracter(string cadena, char caracter1, char caracter2)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == caracter1)
                {
                    cadena = cadena.Remove(i, 1);
                    cadena = cadena.Insert(i, caracter2.ToString());
                }
            }
            return cadena;
        }
        static int CuentaPalabras(string cadena)
        {
            int palabras = 0;
            cadena = " " + cadena;
            for (int i = 0; i < cadena.Length - 1; i++)
            {
                if (cadena[i] == ' ' && cadena[i + 1] != ' ')
                {
                    palabras = palabras + 1;
                }
            }
            return palabras;
        }

        static bool EsNumero(string cadena)
        {
            int contador;
            contador = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (char.IsDigit(cadena[i]))
                {
                    contador++;
                }

            }
            if (contador == cadena.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string QuitaCaracter(string cadena, char caracter)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == caracter)
                {
                    cadena = cadena.Remove(i, 1);
                }
            }
            return cadena;
        }
        static string QuitaAcentos(string cadena)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == 'á')
                {
                    cadena = cadena.Remove(i, 1);
                    cadena = cadena.Insert(i, "a");
                }
                if (cadena[i] == 'é')
                {
                    cadena = cadena.Remove(i, 1);
                    cadena = cadena.Insert(i, "e");
                }
                if (cadena[i] == 'í')
                {
                    cadena = cadena.Remove(i, 1);
                    cadena = cadena.Insert(i, "i");
                }
                if (cadena[i] == 'ó')
                {
                    cadena = cadena.Remove(i, 1);
                    cadena = cadena.Insert(i, "o");
                }
                if (cadena[i] == 'ú')
                {
                    cadena = cadena.Remove(i, 1);
                    cadena = cadena.Insert(i, "u");
                }
            }
            return cadena;
        }
        static string InvierteCadena(string cadena)
        {
            string temp = "";
            for (int c = cadena.Length - 1; c > -1; c--)
            {
                temp = temp + cadena[c];
            }
            cadena = temp;
            return cadena;
        }
        static int VecesCaracter(string cadena, char caracter)
        {
            int repeticiones;
            repeticiones = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == caracter)
                {
                    repeticiones = repeticiones + 1;
                }
            }
            return repeticiones;
        }
        static int VecesPalabra(string cadena, string palabra)
        {
            string nombre = "";
            int cont = 0;


            for (int i = 0; i < cadena.Length; i++)
            {
                char caracter = cadena[i];
                nombre = nombre + caracter;

                if (nombre.Contains(palabra) || nombre.Contains(palabra))
                {
                    cont++;
                    nombre = "";
                }
            }
                return cont;
        }
        static string MayusculasPrimera(string cadena)
        {
            cadena = ' ' + cadena;
            char mayuscula;
            for (int i = 0; i < cadena.Length - 1; i++)
            {
                if (cadena[i] != ' ' && cadena[i - 1] == ' ')
                {
                    mayuscula = char.ToUpper(cadena[i]);
                    cadena = cadena.Remove(i,1);
                    cadena = cadena.Insert(i, mayuscula.ToString());
                }
            }
            cadena = cadena.Remove(0, 1);
            return cadena;
        }
        static string SustituyePalabra(string cadena, string palabra1, string palabra2)
        {
            string[] cadena2;
            cadena2 = cadena.Split(" ");
            for (int i = 0; i < cadena2.Length; i++)
            {
                if (cadena2[i] == palabra1)
                {
                    cadena2[i] = palabra2;
                }
            }
            string cadenafinal = string.Join(" ", cadena2);
        return cadenafinal;
        }
        static string InviertePalabras(string cadena)
        {
            string[] cadena2;
            cadena2 = cadena.Split(" ");
            for (int i = 0; i < cadena2.Length; i++)
            {
                cadena2[i] = InvierteCadena(cadena2[i]);
            }            
            string cadenafinal = string.Join(" ", cadena2);            
            return cadenafinal;
        }
        static string MarcaSubCadena(string cadena, string cadena2)
        {
            string subcadena = "*" + cadena2.Substring(1);
            for (int i = 0; i < cadena.Length; i++)
            {
                cadena = cadena.Replace(cadena2, subcadena);
            }
            return cadena;
        }
        static string QuitaEspaciosSobrantes(string cadena)
        {
            string cadena2;
            cadena2 = "";
            cadena = QuitaEspaciosTrim(cadena);
            for (int i = 0; i < cadena.Length; i++)
            {
                cadena = cadena.Replace("  ", " ");
                cadena2 = cadena;
            }
            return cadena2;
        }
    }
}


