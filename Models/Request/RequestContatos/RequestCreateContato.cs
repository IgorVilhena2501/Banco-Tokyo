using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Models.Request.RequestContatos
{
    public class RequestCreateContato
    {
        public int Id { get; }
        public int MyId { get;  }
        public string Nome { get; }
        public string Sobrenome { get;}
        public int CPF { get;}
        public RequestCreateContato(int myid, string nome, string sobrenome, int cpf, int id)
        {
            Id = Id;
            MyId = myid;
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
        }
    }
}
