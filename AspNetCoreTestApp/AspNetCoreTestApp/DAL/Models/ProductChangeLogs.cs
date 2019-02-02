using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTestApp.Database.Models
{
    public class ProductChangeLogs
    {
        [Key]
        public int LogId { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public DateTime ChangeDate { get; set; }
        public string Column { get; set; }
        public string NewValue { get; set; }
    }
}
