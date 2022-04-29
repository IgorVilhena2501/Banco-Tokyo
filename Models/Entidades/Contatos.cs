using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Banco_Toyko.Models.Entidades
{
    public class Contatos : BaseModel
    {
        public int MyId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int CPF { get; set; }
        public int Id { get; set; }
    }
}
