using EjercicioHerencia;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la longitud del lado del cuadrado/cubo:");
        double lado = Convert.ToDouble(Console.ReadLine());

        OperacionesHija operacionesHija = new OperacionesHija();
        operacionesHija.Imprimir(lado);

        
    }
}