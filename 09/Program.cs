namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            aluno.nota1 = 6;
            aluno.nota2 = 4;
            aluno.peso1 = 10;
            aluno.peso2 = 9;

            Console.WriteLine($"A média harmônica das notas é: {aluno.CalcularMediaHarmonica():F2}");
            Console.WriteLine($"A média ponderada das notas é: {aluno.CalcularMediaPonderada():F2}");
        }
    }
}