using Microsoft.EntityFrameworkCore;

namespace rest_api_udemy.Model.Context
{
    public class MySQLContext: DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options): base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
