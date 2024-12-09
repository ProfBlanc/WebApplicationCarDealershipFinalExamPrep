using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationCarDealershipFinalExamPrep.Models;

namespace WebApplicationCarDealershipFinalExamPrep.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<PaymentInfo> PaymentInfo { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
