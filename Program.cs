using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operacion operacion = new Operacion();

            //Validando que el formato de los atributos sean numeros
            try
            {
                Console.Write("Ingrese el primer numero para las operaciones:");
                operacion.Numero1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo numero para las operaciones:");
                operacion.Numero2 = Convert.ToDouble(Console.ReadLine());

                if (operacion.Numero2 != 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("El resultado de las operaciones es:");
                    operacion.Imprimir();

                }
                else
                {
                    Console.WriteLine("El segundo numero no puede ser un 0 por una de las operaciones");
                }


            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

        }
    }
}
