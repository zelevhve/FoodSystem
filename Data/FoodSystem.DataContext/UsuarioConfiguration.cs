using System.Data.Entity.ModelConfiguration;

namespace FoodSystem.DataContext
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Model.Usuario>
    {
        public UsuarioConfiguration()
        {
            this.Property(p => p.Code)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
