using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sismf_web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o Usuário:")] //Mensagem para cada campo exigindo dados.
        [Display(Name = "Usuário: ")]
        public string Usuario { get; set;  }

        [Required(ErrorMessage = "Informe a Senha:")] //Mensagem para cada campo exigindo dados.
        [DataType(DataType.Password)]
        [Display(Name = "Senha: ")]
        public string Senha { get; set; }

        [Display(Name = "Lembrar-me!")]
        public bool LembrarMe { get; set; }
    }
}