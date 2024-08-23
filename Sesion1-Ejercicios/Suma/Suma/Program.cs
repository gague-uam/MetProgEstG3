namespace Suma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma;
            Console.WriteLine("Digite el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            suma = num1 + num2;
            Console.WriteLine($"La suma de los dos numeros es: {suma}" );
        }
    }
}
