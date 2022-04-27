using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator.DataAccess.Entities
{
    public class Payment : EntityBase
    {
        public int PaymentCategoryId { get; set; }
        public PaymentCategory PaymentCategory { get; set; }

        [Required]
       [MaxLength(250)]         
        public string Title { get; set; }
       
        
        [Required]
        public double Amount { get; set; }
        public int DateOfAddId { get; set; }    
        public DateOfAdd DateOfAdd { get; set; }
    }
}
