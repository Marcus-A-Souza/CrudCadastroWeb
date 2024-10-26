using System.ComponentModel.DataAnnotations;

namespace CrudCadastroWeb.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [StringLength(11, ErrorMessage = "O CPF deve ter 11 caracteres.")]
        [RegularExpression(@"\d{11}", ErrorMessage = "CPF deve conter apenas números.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo RG é obrigatório.")]
        public string RG { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        public string Endereco { get; set; }
    }
}
