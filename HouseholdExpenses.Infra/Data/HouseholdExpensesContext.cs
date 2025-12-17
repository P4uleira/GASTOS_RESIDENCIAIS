using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HouseholdExpenses.Infra.Data
{
    public class HouseholdExpensesContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public HouseholdExpensesContext(DbContextOptions<HouseholdExpensesContext> options) : base(options)
        {
        }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ConnectionStrings:DefaultConnection"));
                optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HouseholdExpensesContext).Assembly);
        }
    }
}
