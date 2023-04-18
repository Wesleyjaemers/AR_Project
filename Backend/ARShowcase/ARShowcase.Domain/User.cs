using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ARShowcase.Domain
{
    public class User: IdentityUser<int>
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
