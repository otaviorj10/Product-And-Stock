using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductStock.Models.Produto;

namespace ProductStock.Models
{
    public class ProductStockContext : DbContext
    {
        public ProductStockContext (DbContextOptions<ProductStockContext> options)
            : base(options)
        {
        }

        public DbSet<ProductStock.Models.Produto.Produto> Produto { get; set; }
    }
}
