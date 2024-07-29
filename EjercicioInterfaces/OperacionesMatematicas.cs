using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class OperacionesMatematicas : IOperaciones
    {
        private double baseTriangulo;
        private double alturaTriangulo;
        private double lado1;
        private double lado2;
        private double lado3;
        private double lado;

        public OperacionesMatematicas(double baseTriangulo, double alturaTriangulo, double lado1, double lado2, double lado3, double lado)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            this.lado = lado;
        }

        public double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }

        public double CalcularPerimetroTriangulo(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 + lado3;
        }

        public double CalcularAreaCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public double CalcularPerimetroCuadrado(double lado)
        {
            return 4 * lado;
        }

        public double CalcularVolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }

        public void Imprimir()
        {
            Console.WriteLine("Área del triángulo: " + CalcularAreaTriangulo(baseTriangulo, alturaTriangulo));
            Console.WriteLine("Perímetro del triángulo: " + CalcularPerimetroTriangulo(lado1, lado2, lado3));
            Console.WriteLine("Área del cuadrado: " + CalcularAreaCuadrado(lado));
            Console.WriteLine("Perímetro del cuadrado: " + CalcularPerimetroCuadrado(lado));
            Console.WriteLine("Volumen del cubo: " + CalcularVolumenCubo(lado));
        }
    }
}
