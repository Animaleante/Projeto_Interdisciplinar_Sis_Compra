using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Interdisciplinar_Sis_Compra.Models
{
    public class Cartao
    {
        public int CartaoId { get; set; }
        public string Nome { get; set; }
        public int NumeroCartao { get; set; }
        public int DigVerificador { get; set; }
        public DateTime Validade { get; set; }
    }
}