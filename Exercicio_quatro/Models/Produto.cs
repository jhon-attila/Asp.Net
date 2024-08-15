using System.ComponentModel.DataAnnotations;

namespace AppQuarta.Models
{
    public class Produto
    {
        [Display(Name = "Cod_Produto")]
        [Range(1, 200, ErrorMessage = "Insira o Codigo do produto")]
        public int Cod_Produto { get; set; }

        [Display(Name = "Validade")]
        [Range(1, 200, ErrorMessage = "Insira a data validade do produto")]
        public DateOnly Validade { get; set; }

        [Display(Name = "Estoque")]
        [Range(1, 200, ErrorMessage = "Insira a quantidade de produto no estoque")]
        public int Estoque { get; set; }

        [Display(Name = "Obs")]
        [Range(1, 200, ErrorMessage = "Insira uma avaliação do produto")]
        public int Obs { get; set; }

        [Display(Name = "Nome")]
        [Range(1, 200, ErrorMessage = "Insira o Nome do produto")]
        public string Nome { get; set; }
    }
}
