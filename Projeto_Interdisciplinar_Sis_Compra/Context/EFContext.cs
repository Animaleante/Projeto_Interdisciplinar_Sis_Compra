using Projeto_Interdisciplinar_Sis_Compra.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto_Interdisciplinar_Sis_Compra.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("DbString") {
            Database.SetInitializer<EFContext>(new DropCreateDatabaseIfModelChanges<EFContext>());
        }

        //public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        //public DbSet<Compra> Compras { get; set; }
        //public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        //public DbSet<Produto> Produtos { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }

    }
}