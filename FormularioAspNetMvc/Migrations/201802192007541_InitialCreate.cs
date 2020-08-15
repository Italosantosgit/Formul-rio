namespace FormularioAspNetMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        CPF = c.String(nullable: false, maxLength: 128),
                        Nome = c.String(nullable: false, maxLength: 100),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.Int(nullable: false),
                        EstadoCivil = c.Int(nullable: false),
                        Estado = c.String(nullable: false),
                        Cidade = c.String(nullable: false, maxLength: 50),
                        Logradouro = c.String(nullable: false, maxLength: 100),
                        NumeroEndereco = c.String(nullable: false, maxLength: 10),
                        ComplementoEndereco = c.String(maxLength: 50),
                        Renda = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CPF);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoas");
        }
    }
}
