# Formulario
Ambiente 
Para realização deste artigo foram utilizadas as seguintes ferramentas/softwares, que você pode realizar o download no site da Microsoft:
Visual Studio 2017 Community
SQL Server  2017
SQL Server Management Studio


O projeto foi desenvolvido na plataforma asp.net MVC com o .Net framework 4.6.1, Entity framework na versão 6.2.0 e BootStrap 3.3.7.

O intuito do projeto é realizar um cadastro social.

Criação do projeto 


Primeiramente crie um novo projeto do tipo “Console Aplication” no visual studio e dê um nome ao projeto.

Após a criação do projeto é necessario adicionar o pacote entity framework, para adicionar basta selecionar a opção Gerenciador pacotes NuGet, clicando em cima do projeto criado, com botão esquerdo do mouse, procurar pelo pacote “Entity framework” é instalar.

Após instalado, clicar em cima do projeto com o botão esquerdo do mouse é adicionar três classe colocando os seguintes nomes: Pessoa, Sexo, EstadoCivil.

As modificações de ser realizadas nas  classes “Pessoa.cs”, ”Sexo.cs” e ”EstadoCivil.cs” conforme o anexo 'Formulario.zip'
O próximo passo é adicionarmos um nova classe do tipo “DbContext”, que é essencial para o Entity Framework, adicione a nova classe dando o nome de CadastroContext a pós feito isso a classe deve ficar dessa forma

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


A “CadastroContext” está herdando da classe “DbContext” do namespace System.Data.Entity.

Foi criado uma propriedade “DbSet” para cada uma das classe do modelo.
Após modificarmos a classe, devemos inserir no “Web.config” localizado na aba de “Gerenciamento de Soluções” o seguinte condigo.

<connectionStrings>
    <add name="DbCadastroPessoas" connectionString="Data Source=Nome do caminho do seu SQlServer; Initial Catalog=DbCadastroPessoas; Integrated Security=True;" providerName="System.Data.SqlClient" />
  </connectionStrings>

O “Data Source” deve conter o caminho do Sql local do SQL Server  2017 

Com nossa classe de contexto e o caminho da connectionStrings criadas, vamos habilitar o “Migrations”

Para fazer isso, digitamos no “Console Gerenciador de Pacote” o comando “Enable-Migrations”, Após isso, é necessário executar o comando para adicionar ao Migrations.
Após comando “Enable-Migrations”, foi gerado uma pasta no projeto chamada “Migrations” que conterá todos os arquivos com as especificações de modificações.

Após isso e necessário executar o comando para adicionar as migrações. Para fazer isso basta executar o comando “Add-Migrations Inicial” que adicionara o arquivo correspondente a modificação.
Por fim, devemos executar o comando “Updata-Database”, este comando cria a nossa base de dados.

Conclusão

Espero que este artigo tenha contribuido para ajudar na sua compreensão sobre projeto realizados com as tecnologias citadas acima.

https://github.com/Italosantosgit 







