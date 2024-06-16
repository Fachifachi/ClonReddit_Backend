using Reddit.Models;

namespace Reddit.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
