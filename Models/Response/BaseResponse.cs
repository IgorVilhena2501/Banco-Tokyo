using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Models.Response
{
    public abstract class BaseResponse
    {
        public string Mensagem { get; set; }
        public bool Sucesso { get; set; }
    }
}
