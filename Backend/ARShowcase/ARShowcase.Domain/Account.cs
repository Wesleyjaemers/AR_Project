using System;
using System.Collections.Generic;
using System.Text;

namespace ARShowcase.Domain
{
    public class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<Model> ModelList { get; set; }

    }
}
