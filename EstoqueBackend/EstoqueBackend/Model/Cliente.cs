using System.ComponentModel.DataAnnotations;
using EstoqueBackend.Data.DTOs;

namespace EstoqueBackend.Model
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required] 
        public string Nome { get; set; }

        Cliente() { }

        public Cliente(ClienteDTO clienteDTO)
        {
            CPF = clienteDTO.CPF;
            Nome = clienteDTO.nome;
        }
    }
}
