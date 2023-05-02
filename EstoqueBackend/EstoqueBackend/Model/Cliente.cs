using System.ComponentModel.DataAnnotations;

namespace EstoqueBackend.Model
{
    public class Cliente
    {
        [Key]
        public int CPF { get; set; }
        [Required] 
        public string Name { get; set; }
    }
}
