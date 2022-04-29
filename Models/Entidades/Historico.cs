using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Models.Entidades
{
    public class Historico : BaseModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int CPF { get; set; }
        public string MeuNome { get; set; }
        public string MeuSobrenome { get; set; }
        public int MeuId { get; set; }
        public DateTime Data { get; set; }
        public double Valor{ get; set; }
    }
}
