using ControlePonto.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ControlePonto.Data
{
    internal class ControlePontoDbContext : DbContext
    {
        public ControlePontoDbContext() : base()
        {

        }

        public DbSet<Cargo> Cargos {  get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Importa o arquivo de configuração Json
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appconfig.json", false, true);

            //Compila as configurações
            IConfigurationRoot configuracao = builder.Build();

            //Pega a string de conexão da configuração
            var stringDeConexao = configuracao.GetConnectionString("ConexaoPadrao");

            //Adiciona a string à configuração do DbContext
            optionsBuilder.UseMySql(stringDeConexao, ServerVersion.AutoDetect(stringDeConexao));

        }
    }
}
