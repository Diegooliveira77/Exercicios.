namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario = new Salario();

            Console.Write("Digite o salário do vendedor: ");
            salario.salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas do vendedor: ");
            salario.totalVendas = double.Parse(Console.ReadLine());

            Console.Write("Digite a comissão a ser aplicada sobre as vendas (em %): ");
            salario.comissao = double.Parse(Console.ReadLine());

            salario.salarioTotal = salario.salarioBase + (salario.totalVendas * (salario.comissao * salario.salarioBase / 100));

            Console.WriteLine("O salário total do vendedor é: R$ {0:N2}", +salario.salarioTotal);
        }
    }
}