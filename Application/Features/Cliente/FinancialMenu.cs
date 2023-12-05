using Application.Extensions;
using Domain.Dto;
using Domain.Enum;

namespace Application.Features.Cliente
{
    public class FinancialMenu
    {
        public static void Menu(ref ClienteDto cliente)
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
}
