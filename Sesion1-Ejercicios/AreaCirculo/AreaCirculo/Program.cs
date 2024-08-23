namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double resultado;

            Console.WriteLine("Digite el radio del circulo: ");
            radio = float.Parse(Console.ReadLine());

            resultado = Math.PI * Math.Pow(2, radio);
            Console.WriteLine($"El area del circulo es {resultado}");
        }
    }
}
