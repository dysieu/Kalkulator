using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator.DataAccess.Entities
{
    public class DateOfAdd : EntityBase
    {
        [Required]
        DataType AddTime { get; set; }
        int week;
        int month;
        public List<Payment> payments { get; set; }
        
    }
}
