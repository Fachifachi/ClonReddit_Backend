using System;
using System.Collections.Generic;
using Reddit.Models;

namespace Reddit.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistracion { get; set; }
        public DateTime FechaCumpleanios { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
