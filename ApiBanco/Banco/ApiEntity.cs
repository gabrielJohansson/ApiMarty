namespace Api.DB.Banco
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Api.Models;

    public partial class ApiEntity : DbContext
    {
        public ApiEntity()
            : base("name=ApiEntity")
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
