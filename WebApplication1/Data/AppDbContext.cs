using Microsoft.EntityFrameworkCore;

namespace EfCoreLearning.Data
{
    public class AppDbContext : DbContext
    {

        //- DbContextOptions contains configuration info (like which database provider to use — SQL Server, SQLite, etc.)
        //- The : base(options) part passes those options up to the DbContext base class.
        //👉 This is how EF Core knows which database to connect to and how to behave.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //- Defines a DbSet for the Employee entity
        /*- A DbSet<T> represents a table in the database.
        - In this case:
        - Table name: Employees (by convention, plural of the class name).
        - Rows: instances of Employee objects.
        - This property lets you query and save Employee records:
         */
        public DbSet<EfCoreLearning.Models.Employee> Employees { get; set; }
    }
}
