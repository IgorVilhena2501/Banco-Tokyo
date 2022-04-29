using Banco_Toyko.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Models.Response
{
    public class GenericListResponse <T> : BaseResponse where T: BaseModel
    {
        public List<T> Lista { get; }

        public GenericListResponse(string mensagem, bool sucesso, List<T> lista)
        {
            Mensagem = mensagem;
            Sucesso = sucesso;
            Lista = lista;
        }
    }
}
