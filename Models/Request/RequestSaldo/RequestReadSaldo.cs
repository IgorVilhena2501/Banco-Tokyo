using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Models.Request.RequestSaldo
{
    public class RequestReadSaldo
    {
        public int Id { get; }
        public RequestReadSaldo(int id)
        {
            Id = id;
        }
    }
}
