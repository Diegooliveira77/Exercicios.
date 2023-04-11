namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();

            Console.Write("Digite a temperatura em graus Celsius: ");
            temperatura.celsius = Convert.ToDouble(Console.ReadLine());

            temperatura.fahrenheit = (temperatura.celsius * 9 / 5) + 32;
            Console.WriteLine("A temperatura em graus Fahrenheit é: " + temperatura.fahrenheit.ToString("F2") + "°F.");
        }
    }
}