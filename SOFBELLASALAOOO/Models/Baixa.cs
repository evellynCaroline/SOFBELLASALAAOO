namespace SOFBELLASALAOOO.Models
{
    public class Baixa
    {
       
            public string Descricao { get; set; }                       // Descrição da baixa
            public int Servico { get; set; }                            // Servico relacionado (int para representar, mas pode ser um objeto de outra classe)
            public bool ConfirmarQuantidadeAoFinalizar { get; set; }    // Se a quantidade deve ser confirmada ao finalizar
            public bool PermitirAlterarProduto { get; set; }            // Se permite alterar o produto

            // Construtor para facilitar a inicialização
            public Baixa(string descricao, int servico, bool confirmarQuantidadeAoFinalizar, bool permitirAlterarProduto)
            {
                Descricao = descricao;
                Servico = servico;
                ConfirmarQuantidadeAoFinalizar = confirmarQuantidadeAoFinalizar;
                PermitirAlterarProduto = permitirAlterarProduto;
            }

            // Método para representar o objeto Baixa como string (para depuração ou logs)
            public override string ToString()
            {
                return $"Descrição: {Descricao}, Serviço: {Servico}, Confirmar Quantidade: {ConfirmarQuantidadeAoFinalizar}, " +
                       $"Permitir Alterar Produto: {PermitirAlterarProduto}";
            }
        }
    }



