
using Microsoft.EntityFrameworkCore;

namespace APIMinima
{
    public class TodoDb(DbContextOptions<TodoDb> options) : DbContext(options)
    {
        public DbSet<Todo> Todos => Set<Todo>();

    }
}
