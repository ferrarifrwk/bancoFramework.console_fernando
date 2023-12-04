using Domain.Model;
using Domain.Enum;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo ao banco Framework");
        Console.WriteLine("Por favor, identifique-se");
        Console.WriteLine("");
        var pessoa = Identificacao();
        Menu();
    }

    static Pessoa Identificacao()
    {
        var pessoa = new Pessoa();

        Console.WriteLine("Seu número de identificação:");
        pessoa.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Seu nome:");
        pessoa.Nome = Console.ReadLine();

        Console.WriteLine("Seu CPF:");
        pessoa.Cpf = Console.ReadLine();
        Console.Clear();

        Console.WriteLine($"Como posso ajudar {pessoa.Nome}?");
        return pessoa;
    }

    static void Menu()
    {
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Sair");

            Console.Write("Escolha uma opção: ");
            int opcao = 0;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out opcao);
           
            Console.WriteLine();
            switch ((OpcoesEnum)opcao)
            {
                case OpcoesEnum.Depósito:
                    Console.WriteLine(nameof(OpcoesEnum.Depósito));
                    break;

                case OpcoesEnum.Saque:
                    Console.WriteLine(nameof(OpcoesEnum.Saque));
                    break;

                case OpcoesEnum.Sair:
                    sair = true;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine();
        }
    }
}