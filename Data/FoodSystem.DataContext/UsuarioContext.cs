using System.Data.Entity;

namespace FoodSystem.DataContext
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext():base(@"Data Source=.\sql2017; Initial Catalog=FoodSystem;user id=SadSupport;password=AP$br1.0")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Entity<Model.Usuario>().ToTable("Usuario");
            
        }
        public DbSet<Model.Usuario> Usuario { get; set; }
    }
}
