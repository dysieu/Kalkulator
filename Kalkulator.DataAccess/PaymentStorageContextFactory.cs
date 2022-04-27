using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator.DataAccess
{
    internal class PaymentStorageContextFactory : IDesignTimeDbContextFactory<PaymentsStorageContext>
    {
        public PaymentsStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PaymentsStorageContext>();
            optionsBuilder.UseSqlServer("Data Source =.\\SQLEXPRESS; Initial Catalog = PaymentsStorage; Integrated Security = True");
        return new PaymentsStorageContext(optionsBuilder.Options);
        }
    }
}
