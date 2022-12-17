using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._3._3
{
    public class Contact
    {
        public string Name { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
