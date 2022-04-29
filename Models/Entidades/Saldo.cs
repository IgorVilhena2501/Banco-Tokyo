using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Toyko.Models.Entidades
{
    public class Saldo : BaseModel
    {
        public int Id { get; set; }
        public double Valor { get; set; }
    }
}
