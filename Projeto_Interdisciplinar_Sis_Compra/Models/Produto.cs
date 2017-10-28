using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Interdisciplinar_Sis_Compra.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoBase { get; set; }
        public Categoria categoria { get; set; }
        public Fabricante fabricante { get; set; }

    }
}