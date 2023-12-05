using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    public static class ClienteExtension
    {
        public static void AtualizarSaldo(this Cliente cliente, float valor, bool saque = false)
        {
            if (saque)
                cliente.Saldo -= valor;
            else
                cliente.Saldo += valor;
        }
    }
}
