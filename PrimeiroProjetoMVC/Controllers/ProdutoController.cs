using Microsoft.AspNetCore.Mvc;
using PrimeiroProjetoMVC.Models;

namespace PrimeiroProjetoMVC.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            var produtos = ObterProdutos();
            return View(produtos);
        }

        private List<Produto> ObterProdutos()
        {
            return new List<Produto>
            {
                new Produto { Id = 1, Nome = "Coca cola", Preco = 8.99m },
                new Produto { Id = 2, Nome = "Pepsi cola", Preco = 6.97m },
                new Produto { Id = 3, Nome = "Fruki cola", Preco = 5.29m },
                new Produto { Id = 4, Nome = "Fanta", Preco = 6.49m },
                new Produto { Id = 5, Nome = "Sprite", Preco = 6.49m },
                new Produto { Id = 6, Nome = "Kuat", Preco = 6.39m }
            };
        }
    }
}
