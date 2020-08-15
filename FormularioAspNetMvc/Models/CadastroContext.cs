using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FormularioAspNetMvc.Models
{
    public class CadastroContext : DbContext
    {
        public CadastroContext() : base("DbCadastroPessoas")
        {
            Database.SetInitializer<CadastroContext>(
                new CreateDatabaseIfNotExists<CadastroContext>());
            Database.Initialize(false);
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}