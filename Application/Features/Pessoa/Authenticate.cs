using CpfCnpjLibrary;

namespace Application.Features.Pessoa
{
    public class Authenticate
    {
        public static bool ValidarCpf(string cpf) => Cpf.Validar(cpf);
    }
}
