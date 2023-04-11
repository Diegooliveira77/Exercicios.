namespace test.ConsoleApp1
{ /* para que serve o switch :
             * Um padrão relacional (disponível em C# 9.0 e posterior): 
             * para comparar um resultado de expressão com uma constante.
             * Um padrão constante: testa se o resultado de uma expressão 
             * é igual a uma constante.
             vai testar o valor da variavel */

    /*for ( inicia, espressao , incrementa) recomendado quando 
     * sabemos o laço sera executado e o while quando não sabemos sera 
     * executado
     no for o ponto e virgula serve para separar a expressao
    Array armazena as informações como se fossem gavetas */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par ou Impar?");
            Console.WriteLine("Escola P (Par) e I (Impar)");


            int i;
            char escolha;
            escolha = char.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 'I':
                case 'i':
                    Console.WriteLine("\n");

                    for (i = 0; i < 11; i++)
                    {
                        if (i % 2 == 0)
                        Console.BackgroundColor = ConsoleColor.Blue;
                        else 
                            Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(1 + i * 2);
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;

                case 'P':
                case 'p':
                    Console.WriteLine("\n");

                    for (i = 1; i < 11; i++)
                    {
                        if (i % 2 == 0)
                            
                        Console.BackgroundColor= ConsoleColor.DarkBlue;

                        else Console.BackgroundColor = ConsoleColor.Black;

                        Console.WriteLine(0 + i * 2);
                        
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;

                default:
                      if (escolha != 'I' && escolha != 'i'
                          && escolha != 'P' && escolha != 'p');

                    Console.WriteLine("Opção Indisponivel");
                    break;

                    
            }
        }
    }
}