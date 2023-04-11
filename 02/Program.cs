namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();

            Console.WriteLine("Entre com a temperatura em fahrenheit: ");
            temperatura.Fahrenheit = double.Parse(Console.ReadLine());

            
            Console.WriteLine("Temperatura convertida em celsius: " + temperatura.Celsius.ToString("F2"));
        }
    }
}