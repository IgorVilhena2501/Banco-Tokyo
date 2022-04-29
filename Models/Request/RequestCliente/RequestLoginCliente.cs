using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Banco_Toyko.Models.Request.RequestCliente
{
    public class RequestLoginCliente
    {
        [Required(ErrorMessage = "O campo de nome é obrigatorio")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "O nome deve ter 150 a 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de senha é obrigatorio")]
        [StringLength(25, MinimumLength = 8, ErrorMessage = "A senha deve ter entre 25 a 8 caracteres")]
        public string Senha { get; set; }
    }
}
