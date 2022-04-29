using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Banco_Toyko.Models.Request.RequestCliente
{
    public class RequestCreateCliente
    {
        public int Identificador { get; set; }
        
        [Required(ErrorMessage = "O campo de nome é obrigatorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome de ver ter entre 3 a 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de Sobrenome é obrigatorio")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O sobrenome de ver ter entre 3 a 100 caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O campo de CPF é obrigatorio")]
        public int CPF { get; set; }

        [Required(ErrorMessage = "O campo da idade é obrigatoria")]
        [Range(18,118, ErrorMessage = "Somente pessoas acima de 18 anos podem criar uma conta")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O campo de senha é obrigatorio")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "A senha de ter entre 8 a 20 caracteres")]
        public string Senha { get; set; }
    }
}
