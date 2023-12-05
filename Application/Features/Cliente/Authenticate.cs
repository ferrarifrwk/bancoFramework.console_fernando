using CpfCnpjLibrary;

namespace Application.Features.Cliente
{
    public class Authenticate
    {
        public static bool ValidarCpf(string cpf) => Cpf.Validar(cpf);
    }
}
