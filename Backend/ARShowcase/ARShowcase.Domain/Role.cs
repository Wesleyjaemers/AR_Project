using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ARShowcase.Domain
{
    public class Role: IdentityRole<int>
    {
        public static class Constants
        {
            public const string Admin = "Admin";
            public const string UserAccount = "UserAccount";
        }
    }
}
