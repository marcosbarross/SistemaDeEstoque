using System.ComponentModel.DataAnnotations;

namespace EstoqueBackend.Model
{
    public class Produto
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        [Required]
        public int? Preco { get; set; }
        [Required]
        public int? QuantidadeRestante { get; set; }
    }
}
