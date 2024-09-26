using System.ComponentModel.DataAnnotations;

namespace SOFBELLASALAOOO.DTOS
{
    public class ProdutoDTO
    {
       
            [Required]
            [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
            public string Nome { get; set; }  // Nome do produto

            [Required]
            public int Unidade { get; set; }  // Unidade do produto

            [StringLength(500, ErrorMessage = "A descrição não pode exceder 500 caracteres.")]
            public string Descricao { get; set; }  // Descrição do produto

            [Required]
            [StringLength(13, ErrorMessage = "O código de barras deve ter 13 dígitos.")]
            public string CodigoBarras { get; set; }  // Código de barras do produto

            [Required]
            [StringLength(50, ErrorMessage = "A categoria não pode exceder 50 caracteres.")]
            public string Categoria { get; set; }  // Categoria do produto

            [Required]
            [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que 0.")]
            public double Preco { get; set; }  // Preço de venda do produto

            [Required]
            [Range(0.01, double.MaxValue, ErrorMessage = "O preço de custo deve ser maior que 0.")]
            public double PrecoCusto { get; set; }  // Preço de custo do produto

            [Required]
            [Range(0, 100, ErrorMessage = "A comissão deve estar entre 0 e 100%.")]
            public double Comissao { get; set; }  // Comissão associada ao produto
        }
    }

