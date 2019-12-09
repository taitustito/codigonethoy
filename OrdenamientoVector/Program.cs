using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OrdenamientoVector
{
    class Program
    {
      
        private string[] nombre;
        public void Cargar()
        {
            nombre = new string[] { "Facundo", "Jose", "Ariel", "Gabriel", "Milagros", "Jesus" };

        }

        public void Ordenar()
        {
            for (int k = 0; k < nombre.Length; k++)
            {
                for (int f = 0; f < nombre.Length - 1 - k; f++)
                {
                    if (nombre[f].CompareTo(nombre[f + 1]) > 0)
                    {
                        string aux;
                        aux = nombre[f];
                        nombre[f] = nombre[f + 1];
                        nombre[f + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Los nombres ordenados en forma alfabéticamente");
            for (int f = 0; f < nombre.Length; f++)
            {
                Console.WriteLine(nombre[f]);
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Cargar();
            pv.Ordenar();
            pv.Imprimir();
        }
    }
}
