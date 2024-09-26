namespace SOFBELLASALAOOO.Models
{
    public class Produto
    {
            public string Nome { get; set; }               // Nome do produto
            public int Unidade { get; set; }               // Unidade do produto
            public string Descricao { get; set; }          // Descrição do produto
            public string CodigoBarras { get; set; }       // Código de barras do produto
            public string Categoria { get; set; }          // Categoria do produto (simulada como string, pode ser outra classe)
            public double Preco { get; set; }              // Preço de venda do produto
            public double PrecoCusto { get; set; }         // Preço de custo do produto
            public double Comissao { get; set; }           // Comissão associada ao produto

            // Construtor para inicialização rápida
            public Produto(string nome, int unidade, string descricao, string codigoBarras,
                           string categoria, double preco, double precoCusto, double comissao)
            {
                Nome = nome;
                Unidade = unidade;
                Descricao = descricao;
                CodigoBarras = codigoBarras;
                Categoria = categoria;
                Preco = preco;
                PrecoCusto = precoCusto;
                Comissao = comissao;
            }

            // Método para exibir o Produto como string
            public override string ToString()
            {
                return $"Nome: {Nome}, Unidade: {Unidade}, Descrição: {Descricao}, Código de Barras: {CodigoBarras}, " +
                       $"Categoria: {Categoria}, Preço: {Preco}, Preço de Custo: {PrecoCusto}, Comissão: {Comissao}";
            }
        }
    }


