using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender.Domen.Entity
{
    public class User
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool IsRegistered { get; set; }
    }
}
