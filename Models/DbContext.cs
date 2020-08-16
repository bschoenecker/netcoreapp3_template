using Microsoft.EntityFrameworkCore;

namespace netcoreapp3_template.Models {
    public class netcoreapp3Context: DbContext {
        public netcoreapp3Context(DbContextOptions<netcoreapp3Context> options) : base(options){}

        //public DbSet<model here> model {get; set;}
    }
}