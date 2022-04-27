using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator.DataAccess.Entities
{
    public class PaymentCategory : EntityBase
    {
        [Required]
        [MaxLength(250)]
        public String CategoryName { get; set; }
        

        public List<Payment> Payments { get; set; } 
       

    }
}
