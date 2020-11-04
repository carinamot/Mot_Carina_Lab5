using Microsoft.EntityFrameworkCore;


namespace Mot_Carina_Lab5.Models
{
    public class ExpenseContext: DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options): base(options)
        {
        }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
    }
}
