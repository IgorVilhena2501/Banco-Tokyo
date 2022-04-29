using Banco_Toyko.Models.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Banco_Toyko.Models.Models
{
    public class Cliente : BaseModel
    {
        public int Identificador { get; set; }


        [Required(ErrorMessage = "O campo de nome é obrigatorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 a 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "o campo do sobrenome é obrigatorio")]
        [StringLength(200, MinimumLength =3, ErrorMessage = "O sobrenome deve ter entre 3 a 200 caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O campo de CPF é obrigatorio")]
        public int CPF { get; set; }

        [Required(ErrorMessage = "O campo da idade é obrigatorio")]
        [Range(18, 118)]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O campo de senha é obrigatorio")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "A senha deve ter entre 8 a 20 caracteres")]
        public string Senha { get; set; }
    }
}
