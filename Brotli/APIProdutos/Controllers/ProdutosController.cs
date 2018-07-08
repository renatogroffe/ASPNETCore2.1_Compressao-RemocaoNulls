using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using APIProdutos.Models;

namespace APIProdutos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            List<Produto> produtos = new List<Produto>();

            Produto prod;
            for (int i = 1; i <= 100; i++)
            {
                prod = new Produto();
                prod.CodProduto = i.ToString("0000");
                prod.NomeProduto = string.Format("PRODUTO {0:0000}", i);
                prod.Preco = i / 10.0;

                produtos.Add(prod);
            }

            return produtos;
        }
    }
}