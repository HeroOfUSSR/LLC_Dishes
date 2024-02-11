using System;
using System.Collections.Generic;

namespace LLC._Dishes
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int IdRole { get; set; }
        public string Title { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
