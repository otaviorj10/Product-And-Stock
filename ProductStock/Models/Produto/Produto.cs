using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStock.Models.Produto
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CodigoInterno { get; set; }
        public long CodigoDeBarras { get; set; }
        public double PrecoProduto { get; set; }
    }
}
