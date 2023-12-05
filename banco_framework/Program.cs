using Domain.Model;
using Domain.Enum;
using System.Runtime.CompilerServices;
using Application;
using Application.Extensions;
using Application.Features.Pessoa;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo ao banco Framework");
        Console.WriteLine("Por favor, identifique-se");
        Console.WriteLine("");
        var pessoa = Identificacao();
    }

    static Cliente Identificacao()
    {
        var pessoa = new Cliente();

        Console.WriteLine("Seu número de identificação:");
        pessoa.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Seu nome:");
        pessoa.Nome = Console.ReadLine();

        Console.WriteLine("Seu CPF:");
        var cpf = Console.ReadLine();
        do
        {
            Console.WriteLine("CPF Inválido, informe novamente.");
            cpf = Console.ReadLine();
        } while (!Authenticate.ValidarCpf(cpf));

        pessoa.Cpf = cpf;
        Console.Clear();

        Console.WriteLine($"Como posso ajudar {pessoa.Nome}?");
        Menu(pessoa);

        return pessoa;
    }

    static void Menu(Cliente cliente)
    {
        var sair = false;
        while (!sair)
        {
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Sair");

            Console.Write("Escolha uma opção: ");
            int opcao = 0;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out opcao);

            var calculo = new Calculo();
            Console.WriteLine();
            switch ((OpcoesEnum)opcao)
            {
                case OpcoesEnum.Depósito:
                    Console.Clear();
                    Console.WriteLine("Digite o valor:");
                    float valorDeposito = 0;
                    while (!float.TryParse(Console.ReadLine(), out valorDeposito))
                    {
                        Console.WriteLine("Valor inválido. Digite novamente:");
                    }

                   cliente.AtualizarSaldo(valorDeposito);
                    Console.WriteLine("Saldo atual é " + cliente.Saldo);
                    break;

                case OpcoesEnum.Saque:
                    Console.Clear();
                    Console.WriteLine("Digite o valor:");
                    float valorSaque = 0;
                    while (!float.TryParse(Console.ReadLine(), out valorSaque))
                    {
                        Console.WriteLine("Valor inválido. Digite novamente:");
                    }

                    cliente.AtualizarSaldo(valorSaque, true);
                    Console.WriteLine("Saldo atual é " + cliente.Saldo);
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