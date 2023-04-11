namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Combustivel combustivel = new Combustivel();

            Console.Write("Digite a quilometragem(km) inicial: ");
            combustivel.inicio = double.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem(km) final: ");
            combustivel.final = double.Parse(Console.ReadLine());

            Console.Write("Digite o consumo de combustível em litros(l): ");
            combustivel.consumo = double.Parse(Console.ReadLine());

            double distancia = combustivel.inicio - combustivel.final;
            double consumoPorKm = distancia / combustivel.consumo;

            Console.WriteLine($"O consumo de combustível por km foi de: {consumoPorKm.ToString("F2")} litros/km");
            Console.ReadLine();
        }
    }
}