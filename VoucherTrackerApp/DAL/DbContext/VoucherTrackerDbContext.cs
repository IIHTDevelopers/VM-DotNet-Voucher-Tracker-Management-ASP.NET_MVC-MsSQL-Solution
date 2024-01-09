
using VoucherTrackerApp.Models;
using System.Data.Entity;

namespace VoucherTrackerApp.DAL
{
    public class VoucherTrackerDbContext : DbContext
    {
        public VoucherTrackerDbContext()
            : base("name=DefaultConnection")
        {
        }
        public DbSet<Voucher> Vouchers { get; set; }
    }
}