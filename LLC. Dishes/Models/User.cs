﻿using System;
using System.Collections.Generic;

namespace LLC._Dishes
{
    public partial class User
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Fio { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual Role Role { get; set; } = null!;
    }
}
