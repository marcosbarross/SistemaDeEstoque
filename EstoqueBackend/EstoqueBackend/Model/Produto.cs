using System.ComponentModel.DataAnnotations;
using EstoqueBackend.Data.DTOs;

namespace EstoqueBackend.Model
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public int QuantidadeRestante { get; set; }
        
        public Produto() { }
        public Produto(ProdutoDTO produtoDTO) 

        {
            Id = produtoDTO.Id;
            Nome = produtoDTO.Nome;
            Descricao = produtoDTO.Descricao;
            Preco = produtoDTO.Preco;
            QuantidadeRestante = produtoDTO.QuantidadeRestante;
        }
    }
}
