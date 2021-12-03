using System;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.ViewModels
{
    public class CustomerViewModel 
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Erro")]
        [MaxLength(80)]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Erro")]
        [MaxLength(160, ErrorMessage = "Caracteres erro")]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Erro")]
        [MaxLength(20, ErrorMessage = "Caracteres erro")]
        [Display(Name = "CPF")]
        public string Document { get;  set; }

        [Required(ErrorMessage = "Erro")]
        [MaxLength(20, ErrorMessage = "Caracteres erro")]
        [Display(Name = "Telefone")]
        public string Phone { get; set; }
    }
}
