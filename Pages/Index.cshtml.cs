using Desarrollo_web_ASP.NET_Core_Practica_5.Entities;
using Desarrollo_web_ASP.NET_Core_Practica_5.Repositoty;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desarrollo_web_ASP.NET_Core_Practica_5.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ProductoRepository _productoRepository;
        public List<Producto> ejercio1 { get; set; }
        public List<Producto> ejercio2 { get; set; }
        public List<string> ejercio3 { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ProductoRepository productoRepository)
        {
            _logger = logger;
            _productoRepository = productoRepository;
        }

        public void OnGet()
        {
            this.ejercio1 = this._productoRepository.GetProductosByCategoriaId(1);
            this.ejercio2 = this._productoRepository.GetProductsSortedByDescendingPrice();
            this.ejercio3 = this._productoRepository.GetNameCategories();
        }


    }
}
