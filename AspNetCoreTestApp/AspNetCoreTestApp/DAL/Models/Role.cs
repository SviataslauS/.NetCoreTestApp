using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTestApp.Database.Models
{
    public class Role : IHasIdentity
    {
        [Key]
        public int RoleId { get; set; }
        public string Title { get; set; }

        [NotMapped]
        public int Id { get => RoleId; }
    }
}
