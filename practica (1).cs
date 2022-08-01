using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicaa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio #1

            int hora, minutos, segundos;
            Console.WriteLine("Ingrese las horas: ");
            hora = int.Parse(Console.ReadLine());


            minutos = hora * 60;
            segundos = minutos * 60;

            Console.WriteLine("La cantidad de horas es de: " + hora);
            Console.WriteLine("La cantidad de minutos es de: " + minutos);
            Console.WriteLine("La cantidad de segunods es de: " + segundos);

            // Ejercicio #2

            int a, b, c, p, h;
            Console.WriteLine("Ingrese la base del triángulo: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo: ");
            Console.WriteLine("Ingrese el valor de c: ");
            c = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());

            a = b * h;
            p = a + b + c;
            Console.WriteLine("El área del triángulo es de: " + a + "y el perimetro es de: " + p);

            // Ejercicio #3

            double r, hh, area, volumen;
            r = float.Parse(Console.ReadLine());
            hh = float.Parse(Console.ReadLine());
            area = float.Parse(Console.ReadLine());
            area = (2 * 3.14) * (r * (h + r));
            volumen = 3.1416 * (r * r) * hh;

            Console.WriteLine("");
            Console.WriteLine("El area es igual: " + area + " y el volumen es de: " + volumen);

            // Ejercicio #4
            Console.Write("ingrese el primer valor: \n");
            float Primero = float.Parse(Console.ReadLine());

            Console.Write("ingrese la altura: \n");
            float segundo = float.Parse(Console.ReadLine());

            float suma = Primero + segundo;
            float resta = Primero - segundo;
            float division = Primero / segundo;
            float multi = Primero * segundo;

            Console.Write("la suma es de: " + suma + ", la resta es de: " + resta + ", la division es de: " + division + ", la multiplicacion es de: " + multi);

            ///ejercicio 5

            Console.Write("ingrese su nombre: \n");
            string nombre = Console.ReadLine();

            Console.Write("ingrese su edad: \n");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("ingrese el peso: \n");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("ingrese la estatura: \n");
            float estatura = float.Parse(Console.ReadLine());

            Console.Write("tipo de sangre: \n");
            string TipoDeSangre = Console.ReadLine();

            Console.Write("--resumen de los datos--\n");
            Console.Write("nombre: " + nombre + " edad: " + edad + " peso: " + peso + " estatura: " + estatura + " tipo de sangre: " + TipoDeSangre);
            Console.Read();
        }
    }
}