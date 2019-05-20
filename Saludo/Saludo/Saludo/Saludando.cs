namespace Saludo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Saludando
    {
        static void Main(string[] args)
        {
            string nombre = " "; // Declaramos la cadena que almacenará el nombre.
            string cadena = " "; // Declaramos una cadena..
            Console.WriteLine("Buenos días. ¿Como te llamas?"); // Muestra mensa en pantalla.
            Console.WriteLine("--------------------------------------------------------------\n");
            nombre = Console.ReadLine(); // Espara que se escriba una linea en pantalla y se presione enter.
            Console.WriteLine("\n--------------------------------------------------------------");
            Console.WriteLine("Hola {0}", nombre); // Muestra mensaje en pantalla adicionando la cadena pedida.
            Console.WriteLine("¿Qué me cuentas de interesante?"); // Muestra mensa en pantalla.
            Console.WriteLine("--------------------------------------------------------------\n");
            cadena = Console.ReadLine(); // Espara que se escriba una linea en pantalla y se presione enter.
            Console.WriteLine("\n--------------------------------------------------------------");
            Console.WriteLine("La verdad que \" {0} \" me parece muy interesante. Gracias {1}", cadena, nombre); // Muestra mensaje en pantalla adicionando la cadena pedida.
            Console.WriteLine("Mucho gusto " + nombre + ". Es todo un placer haberte conocido."); // Muestra mensaje.
            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadKey(); // Espera que se presione una tecla.
        }
    }
}