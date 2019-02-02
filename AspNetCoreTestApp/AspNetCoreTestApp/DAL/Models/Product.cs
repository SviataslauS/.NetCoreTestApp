using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTestApp.Database.Models
{
    public class Product : IHasIdentity
    {
        [Key]
        public int ProductId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Unit { get; set; }

        [NotMapped]
        public int Id { get => ProductId; }
    }
}
