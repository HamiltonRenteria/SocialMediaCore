using System;
using System.Collections.Generic;

namespace SocialMediaCore.Core.Entities
{
    public partial class User
    {
        public User()
        {
            Coments = new HashSet<Coment>();
            Posts = new HashSet<Post>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }
        public string Telephone { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Coment> Coments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
