using Kalkulator.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator.DataAccess
{
    public class PaymentsStorageContext : DbContext

    {
        public PaymentsStorageContext(DbContextOptions<PaymentsStorageContext> opt) : base(opt)
        {

        }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentCategory> PaymentsCategory { get; set; }
        public DbSet<DateOfAdd> DateOfAdd { get; set; }
    }
}
