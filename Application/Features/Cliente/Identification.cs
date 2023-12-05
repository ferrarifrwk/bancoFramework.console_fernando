using Domain.Dto;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cliente
{
    public class Identification
    {
        public static ClienteDto Identicate()
        {
            var cliente = new ClienteDto();

            Console.WriteLine("Seu número de identificação:");
            if (!int.TryParse(Console.ReadLine(), out int id) || id < 0)
            {
                id = -1; // Set to -1 if parsing fails
                cliente.errorMessages.Add("Identificador não é válido");
            }
            cliente.Id = id;

            Console.WriteLine("Seu nome:");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Seu CPF:");-1
            cliente.Cpf = Console.ReadLine();
            if (!Authenticate.ValidarCpf(cliente.Cpf))
            {
                cliente.errorMessages.Add("CPF digitado não é válido");
            }

            Console.WriteLine("Seu saldo inicial:");
            if (!float.TryParse(Console.ReadLine(), out float saldo) || saldo <= 0)
            {
                saldo = -1f; // Set to -1 if parsing fails
                cliente.errorMessages.Add("Saldo não é válido");
            }
            cliente.Saldo = saldo;

            Console.Clear();
            return cliente;
        }
    }
}
