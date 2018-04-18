namespace BancoApi.Banco
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity3")
        {
        }

        public virtual DbSet<Pessoas> Pessoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoas>()
                .Property(e => e.Nome_Pessoa)
                .IsUnicode(false);
        }
    }
}
