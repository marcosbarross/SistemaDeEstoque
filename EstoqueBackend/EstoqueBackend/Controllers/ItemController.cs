using System.Net;
using EstoqueBackend.Data;
using EstoqueBackend.Data.DTOs;
using EstoqueBackend.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace EstoqueBackend.Controllers
{
    [Route("/item")]
    public class ItemController : Controller
    {
        [Route("/AddItem")]
        [HttpPost]
        public IActionResult AddItem([FromBody] ProdutoDTO produtoDTO)
        {
            using (var contexto = new EstoqueContext())
            {
                var produto = new Produto(produtoDTO);
                contexto.Produtos.Add(produto);
                contexto.SaveChanges();
                return Ok();
            }
        }

        [Route("/ComprarItem")]
        [HttpPut]
        public IActionResult ComprarItem([FromBody] ProdutoDTO produtoDTO)
        {
            using (var contexto = new EstoqueContext())
            {
                var produtoExistente = contexto.Produtos.FirstOrDefault(p => p.Nome == produtoDTO.Nome || p.Id == produtoDTO.Id);
                
                if (produtoExistente != null)
                {
                    produtoExistente.QuantidadeRestante -= produtoDTO.QuantidadeComprada;
                    contexto.SaveChanges();
                    return Ok();
                }

                else
                {
                    return BadRequest("Produto não existe");
                }
            }
        }
    }
}
