using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Models.Request.RequestHistorico
{
    public class RequestReadHistorico
    {
        public int Id { get; }
        public RequestReadHistorico(int id)
        {
            Id = id;
        }
    }
}
