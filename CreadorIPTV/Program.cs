using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreadorIPTV
{
    class Program
    {
        //Creamos el contador para distinguir un canal de otro
        public static int contador;
        //Creamos el archivo donde se guardaran nuestros canales
        public static StreamWriter archivo;

        static void Main(string[] args)
        {
            //Iniciamos el contador
            contador = 0;

            //Creamos el archivo donde se guardaran nuestros canales y no lo cerramos hasta terminar
            archivo = new StreamWriter("Lista.txt");

            //Le agregamos el encabezado de la lista
            archivo.WriteLine("[Tocom_URL_LIST]");

            //Mostramos un mensaje de que inicia el programa
            Console.WriteLine("Iniciando...");
            Console.WriteLine();

            //Prevenimos un posible error
            try
            {
                //Creamos la variable que alojara la linea
                string line;

                //Pasamos la URL de el archivo al constructor del StreamReader
                StreamReader sr = new StreamReader("IPTV.txt");

                //Leemos la primera linea de texto
                line = sr.ReadLine();

                //Repetimos el proceso hasta el final del archivo
                while(line != null)
                {
                    //Si la linea comienza con http la guardamos en un string con la forma del IPTV channel
                    if (line.Contains("http") && !line.ToLower().Contains("youtube"))
                    {
                        AgregarCanal(line);
                    }

                    //Escribimos la linea que acabamos de leer
                    Console.WriteLine(line);

                    //Leemos la proxima linea
                    line = sr.ReadLine();

                    //Limpiamos la pantalla
                    Console.Clear();
                }

                //Una vez que ya leimos todas las lineas cerramos el archivo
                sr.Close();

                //Ahora que ya leimos todo el archivo cerramos el archivo resultante  con la lista pronta para la canalera
                archivo.Close();

                Console.ForegroundColor = ConsoleColor.Green;
                //Mostramos un mensaje de que ya leimos el archivo
                Console.WriteLine("Ya quedo pronto, copiamos y pegamos el archivo (lista) en el pendrive y listo");
                Console.ReadKey();
            }
            catch(Exception unError)
            {
                Console.WriteLine("Un error ha ocurrido..." + unError.Message);
                Console.ReadKey();
            }
        }

        public static void AgregarCanal(string RutaCanal)
        {
            try
            {
                //Agregamos el canal
                archivo.WriteLine("NAME= Canal " + contador + "; URL=" + RutaCanal + ";");

                //Sumamos uno al canal para distinguirlo del siguiente
                contador++;
            }
            catch(Exception unError)
            {
                Console.WriteLine("Algo salio mal..." + unError.Message);
                Console.ReadKey();
            }
        }
    }
}
