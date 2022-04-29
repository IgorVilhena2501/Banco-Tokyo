using Banco_Toyko.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Models.Response
{
    public class GenericResponse<T> : BaseResponse where T : BaseModel
    {
        public T Obj { get; }
        public GenericResponse(string mensagem, bool sucesso, T obj)
        {
            Mensagem = mensagem;
            Sucesso = sucesso;
            Obj = obj;
        }
    }
}
