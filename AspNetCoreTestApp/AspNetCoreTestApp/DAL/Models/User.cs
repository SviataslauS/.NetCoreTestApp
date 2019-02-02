
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreTestApp.Database.Models
{
    public class User : IHasIdentity
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        [NotMapped]
        public int Id { get => UserId; }
    }
}
