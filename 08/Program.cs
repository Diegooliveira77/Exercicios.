namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oleo oleo = new Oleo();
            Console.WriteLine("Digite a altura da lata em cm: ");
            oleo.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o raio da lata em cm: ");
            oleo.raio = double.Parse(Console.ReadLine());

            oleo.volume = Math.PI * oleo.raio * oleo.raio * oleo.altura;

            Console.WriteLine($"O volume da lata é {oleo.volume:F2} centímetros cúbicos.");
        }
    }
}