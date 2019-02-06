namespace AFDEmpFlix.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppContext : DbContext
    {
        public AppContext()
            : base("name=AppContext")
        {
        }

        public virtual DbSet<Movie> Movies { get; set; }
    }
}