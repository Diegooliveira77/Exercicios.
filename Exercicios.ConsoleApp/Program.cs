namespace Exercicios.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa caixa = new Caixa();


            Console.Write("Digite o comprimento da caixa em metros: ");
            caixa.comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a largura da caixa em metros: ");
            caixa.largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da caixa em metros: ");
            caixa.altura = Convert.ToDouble(Console.ReadLine());

            

            Console.WriteLine("O volume da caixa é: " + caixa.volume + " metros cúbicos.");
        }
    }
}