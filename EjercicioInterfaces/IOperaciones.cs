
namespace EjercicioInterfaces
{
    public interface IOperaciones
    {
        double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo);
        double CalcularPerimetroTriangulo(double lado1, double lado2, double lado3);
        double CalcularAreaCuadrado(double lado);
        double CalcularPerimetroCuadrado(double lado);
        double CalcularVolumenCubo(double lado);
    }
}
