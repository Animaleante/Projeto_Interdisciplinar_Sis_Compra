using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Interdisciplinar_Sis_Compra.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}