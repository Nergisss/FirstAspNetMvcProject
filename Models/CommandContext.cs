using Microsoft.EntityFrameworkCore;

namespace OtoparkProje.Models
{
    public class CommandContext: DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options):base(options)
        {

        }
        public DbSet<TodoItem> Items{get;set;}
        
    }
}