using System.ComponentModel.DataAnnotations;

namespace AppQuarta.Models
{
    public class Pessoa
    {
        [Display(Name ="Código")]
        [Range(1,200, ErrorMessage ="O Código deve ser entre 1 e 200")]
        public int Codigo { get; set; }

        [Display(Name ="Nome Completo")]
        [Required(ErrorMessage ="O Nome é Obrigatório")]
        public string NomePessoa { get; set; }

        [Display(Name ="Observação")]
        [Required(ErrorMessage ="A Observação é obrigatória")]
        public string Obs { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Informe um E-mail válido")]
        [Display(Name ="E-mail")]
        [EmailAddress(ErrorMessage ="O E-mail não é válido")]
        public string Email { get; set; }

        [Display(Name ="Login")]
        [Required(ErrorMessage ="O Login é obrigatório")]
        public string login { get; set; }

        [Display(Name ="Senha")]
        [Required(ErrorMessage ="A Senha é obrigatória")]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage ="As senhas devem ser iguais")]
        public string ConfirmaSenha  { get; set; }

    }
}
