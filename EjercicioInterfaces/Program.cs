namespace EjercicioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar datos al usuario
            Console.WriteLine("Ingrese la base del triángulo:");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo:");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el primer lado del triángulo:");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo lado del triángulo:");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer lado del triángulo:");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el lado del cuadrado y del cubo:");
            double lado = Convert.ToDouble(Console.ReadLine());

            // Crear instancia de OperacionesMatematicas
            OperacionesMatematicas operaciones = new OperacionesMatematicas(baseTriangulo, alturaTriangulo, lado1, lado2, lado3, lado);

            // Imprimir resultados
            operaciones.Imprimir();
        }
    }
}