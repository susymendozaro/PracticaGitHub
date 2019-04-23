using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1GitHub.Clases
{
    class Multiplos10
    {
        public static void Separar()
        {
            List<string> lines = new List<string>();
            lines = LeerA.LeerArchivo();
            int multiplos = 0;

            foreach (string line in lines)
            {


                bool isMultiple = int.Parse(line) % 10 == 0;
                if (isMultiple == true)
                {
                    Console.WriteLine("Multiplo de diez: " + line);
                }
                multiplos = multiplos + Convert.ToInt32(isMultiple);




            }
            Console.WriteLine("Estos numeros son multiplos: " + multiplos);

        }
    }
}
