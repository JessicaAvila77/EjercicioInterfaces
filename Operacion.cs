using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Operacion : IOperaciones
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public Operacion() { }

        //Implementando metodos abstractos

        public double Potencia()
        {
            return Math.Pow(Numero1, Numero2);
        }


        public double Logaritmo()
        {
            return Math.Log(Numero1, Numero2);
        }


        public double AreaCuadrado()
        {
            return Numero1 * Numero2;
        }

        public double Modulo()
        {
            return Numero1 % Numero2;
        }

        public double AreaTriangulo()
        {
            return Numero1 * Numero2 / 2;
        }


        public void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine("------Resultado de operaciones---------");
            Console.WriteLine($"{Numero1} elevado a la {Numero2} es: {Potencia()}");
            Console.WriteLine($"El logaritmo de {Numero1} en base {Numero2} es: {Logaritmo()}");
            Console.WriteLine($"El area del cuadrado con base {Numero1} y altura {Numero2} es: {AreaCuadrado()}");
            Console.WriteLine($"El residuo de {Numero1} dividido por {Numero2} es: {Modulo()}");
            Console.WriteLine($"El area de un triangulo donde base = {Numero1} y altura = {Numero2} es: {AreaTriangulo()}");
        }



    }
}
