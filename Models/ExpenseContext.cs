using Microsoft.EntityFrameworkCore;
using Mot_Carina_Lab5.Models;


namespace Mot_Carina_Lab5.Models
{
    public class ExpenseContext: DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options): base(options)
        {
        }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
        public DbSet<Budget> Budget { get; set; }

    }
}
