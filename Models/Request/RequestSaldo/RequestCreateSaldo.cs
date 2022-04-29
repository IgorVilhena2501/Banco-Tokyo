using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Models.Request.RequestSaldo
{
    public class RequestCreateSaldo
    {
        public int Id { get; }
        public double Valor { get; }
        public RequestCreateSaldo(int id, double valor)
        {
            Id = id;
            Valor = valor;
        }
    }
}
