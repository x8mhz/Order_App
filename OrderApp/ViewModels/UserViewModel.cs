using System;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public Guid Id { get; private set; }

        [Required(ErrorMessage = "Erro")]
        [MaxLength(100, ErrorMessage = "Erro")]
        [Display(Name = "Nome de usuário")]
        public string Username { get; private set; }

        [Required(ErrorMessage = "Erro")]
        [MaxLength (100, ErrorMessage = "Erro")]
        [Display (Name = "E-mail")]
        public string Email { get; private set; }

        [Required(ErrorMessage = "Erro")]
        [MaxLength(20, ErrorMessage = "Erro")]
        [Display (Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; private set; }

        [Required(ErrorMessage = "Erro")]
        [Display(Name = "Ativo")]
        public bool Active { get; private set; }

    }
}
