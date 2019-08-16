namespace COMP123_S2019_A5_SectionAExample.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DollarComputer : DbContext
    {
        public DollarComputer()
            : base("name=DollarComputerConnection")
        {
        }

        public virtual DbSet<Product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
