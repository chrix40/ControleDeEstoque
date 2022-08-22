using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleEstoque.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o usuário. ")] // Apresenta a mensagem campo obrigatório
        [Display(Name = "Login: ")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Informe a senha. ")]  
        [DataType(DataType.Password)]
        [Display(Name = "Senha: ")]
        public string Senha { get; set; }

        [Display(Name = "Lembrar Me: ")]
        public bool LembrarMe { get; set; }
    }
}