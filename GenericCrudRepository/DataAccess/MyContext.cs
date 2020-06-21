using GenericCrudRepository.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericCrudRepository.DataAccess
{
    public class MyContext : DbContext
    {
        public MyContext() {}

        public MyContext(DbContextOptions<MyContext> options): base(options) {}

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Animal> Animals { get; set; }
    }
}
