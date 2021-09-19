using five_practice.core;
using five_practice.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace five_practice.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProductRepository productRepository;
        public List<Producto> productosPorCategoria { get; set; }
        public List<Producto> productosMayoresDe3000YMenoresDe5000 { get; set; }
        public List<Categoria> NombresDeCategorias { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IProductRepository productRepository)
        {
            _logger = logger;
            this.productRepository = productRepository;
        }

        public void OnGet()
        {
            this.productosPorCategoria = productRepository.getProductsByCategory().ToList();
            this.productosMayoresDe3000YMenoresDe5000 = productRepository.getProductshigher3000AndLess5000().ToList();
            this.NombresDeCategorias = productRepository.getCategoryName().ToList();
        }
    }
}
