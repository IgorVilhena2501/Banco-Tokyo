using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Models.Request.RequestContatos
{
    public class RequestReadContatos
    {
        public int Id { get; }
        public RequestReadContatos(int id)
        {
            Id = id;
        }
    }
}
