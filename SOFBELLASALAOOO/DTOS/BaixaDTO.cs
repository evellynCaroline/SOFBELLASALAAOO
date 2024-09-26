using System.ComponentModel.DataAnnotations;

namespace SOFBELLASALAOOO.DTOS
{
    public class Baixa_automatica
    {
        
            [Required]
            [StringLength(255, ErrorMessage = "A descrição não pode exceder 255 caracteres.")]
            public string Descricao { get; set; }  // Descrição da baixa

            [Required]
            public int Servico { get; set; }  // Serviço relacionado (pode ser um ID ou outra referência)

            [Required]
            public bool ConfirmarQuantidadeAoFinalizar { get; set; }  // Confirmar quantidade ao finalizar

            [Required]
            public bool PermitirAlterarProduto { get; set; }  // Permitir alteração do produto
    }
}



