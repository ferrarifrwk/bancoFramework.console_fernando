using Application.Features.Cliente;

internal class Program
{
    private static void Main(string[] args)
    {
        StartupMessage();
        var cliente = Identification.Identicate();
        do
        {
            foreach (var item in cliente.errorMessages)
                Console.WriteLine(item);

            Console.ReadKey();
            StartupMessage();

            cliente = Identification.Identicate();
        }while(cliente.errorMessages.Count > 0);

        FinancialMenu.Menu(ref cliente);
    }

    private static void StartupMessage()
    {
        Console.Clear();
        Console.WriteLine("Seja bem vindo ao banco Framework");
        Console.WriteLine("Por favor, identifique-se");
        Console.WriteLine("");
    }
}