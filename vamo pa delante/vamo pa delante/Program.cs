using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vamo_pa_delante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("estamos ready");
            int prom1, prom2, prom3, prom4, prom5, promedioT;
            string nombre;
            Console.WriteLine("ingrese nombre del alumno");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese primer promedio");
            prom1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segundo promedio");
            prom2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese tercer promedio");
            prom3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese cuarto promedio");
            prom4 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese 5to promedio");
            prom5 = int.Parse(Console.ReadLine());
            promedioT = (prom1 + prom2 + prom3 + prom4 + prom5) / 2;
            if (promedioT > 61)
            {
                Console.WriteLine("pasaste");
            }
            else
            {
                Console.WriteLine("no paste manco");
            }

            Console.ReadKey();

            Console.WriteLine("seleciones su opcion");
            Console.WriteLine("1. resta");
            Console.WriteLine("2. suma");
            Console.WriteLine("3. multiplicacion");
            Console.WriteLine("4. division");

            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese primer numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese 2do numero");
            int num2 = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case (1):
                    int restar = num1 - num2;
                    Console.WriteLine("el resultado es:" + restar);
                    break;
                case (2):
                    int sumar = num1 + num2;
                    Console.WriteLine("el resultado es:" + sumar);
                    break;
                case (3):
                    int multiplicar = num1 * num2;
                    Console.WriteLine("el resultado es:" + multiplicar);
                    break;
                case (4):
                    int dividir = num1 / num2;
                    Console.WriteLine("el resultado es:" + dividir);
                    break;
                default:
                    Console.WriteLine("opcion incorrecta");
                    Console.ReadKey();
                    return;


            }
        }
}
