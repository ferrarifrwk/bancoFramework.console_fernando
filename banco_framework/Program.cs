using Application.Features.Cliente;

internal class Program
{
    private static void Main(string[] args)
    {
        MensagemInicial();
        var cliente = Identification.Identicate();
        do
        {
            foreach (var item in cliente.errorMessages)
                Console.WriteLine(item);

            Console.ReadKey();
            MensagemInicial();

            cliente = Identification.Identicate();
        }while(cliente.errorMessages.Count > 0);

        FinancialMenu.Menu(ref cliente);
    }

    private static void MensagemInicial()
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo ao banco Framework");
        Console.WriteLine("Por favor, identifique-se");
        Console.WriteLine("");
    }
}