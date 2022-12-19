using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EscolaModelo.Dados.Modelos
//https://learn.microsoft.com/pt-br/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/migrations-and-deployment-with-the-entity-framework-in-an-asp-net-mvc-application
{
    public partial class EscolaModeloContext : DbContext
    {
        public EscolaModeloContext(DbContextOptions<EscolaModeloContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot stringDeConexao = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();

            //string  = "Data Source=FABIO_COLLI\\SQLEXPRESS01;Initial Catalog=SEMPAI;Integrated Security=True";
            optionsBuilder.UseSqlServer(stringDeConexao.GetConnectionString("BancoDeDados"));

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Turma> Turma { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>().ToTable("Curso");
            modelBuilder.Entity<Aluno>().ToTable("Aluno");
            modelBuilder.Entity<Turma>().ToTable("Turma");
        }
    }
}
