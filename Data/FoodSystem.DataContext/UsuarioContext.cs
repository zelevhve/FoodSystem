using System.Data.Entity;

namespace FoodSystem.DataContext
{
    public class UsuariosContext : DbContext
    {
        public UsuariosContext():base(@"Data Source=.\sql2017; Initial Catalog=FoodSystem;user id=SadSupport;password=AP$br1.0")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Model.Usuario> Usuario { get; set; }
    }
}
