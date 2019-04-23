using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica1GitHub.Clases
{
    public class LeerA
    {
        public static List<string> LeerArchivo()
        {
            string[] lineas = new string[] { };
            List<string> numeros = new List<string>();


            using (StreamReader file = new StreamReader("Multiplos10GitHub.txt"))

            {
                string linea;
                while ((linea = file.ReadLine()) != null)
                {
                    lineas = linea.Split();
                    foreach (string num in lineas)
                    {
                        // Console.WriteLine(num);
                        numeros.Add(num);
                    }
                }


                return numeros;

            }




        }
    }
}
