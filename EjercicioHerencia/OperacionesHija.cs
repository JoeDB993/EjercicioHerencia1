

namespace EjercicioHerencia
{
    public class OperacionesHija : Operaciones
    {
        // Método para imprimir los resultados de las operaciones
        public void Imprimir(double lado)
        {
            Console.WriteLine($"El área del cuadrado con lado {lado} es igual a: {CalcularAreaCuadrado(lado)}");
            Console.WriteLine($"El perímetro del cuadrado con lado {lado} es igual a: {CalcularPerimetroCuadrado(lado)}");
            Console.WriteLine($"El volumen del cubo con lado {lado} es igual a: {CalcularVolumenCubo(lado)}");
        }
    }
}
