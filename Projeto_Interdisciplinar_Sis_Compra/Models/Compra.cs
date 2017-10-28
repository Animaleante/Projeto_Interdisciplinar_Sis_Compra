using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Interdisciplinar_Sis_Compra.Models
{
    public class Compra
    {
        public Produto produto { get; set; }
        public double Desconto { get; set; }
        public double PrecoFinal { get; set; }
    }
}