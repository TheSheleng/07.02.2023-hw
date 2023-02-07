using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    public class Shop
    {
        public string name;
        public string address;
        public string telephone;
        public string email;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name: {name}");
            sb.AppendLine($"Address: {address}");
            sb.AppendLine($"Telephone: {telephone}");
            sb.AppendLine($"Email: {email}");

            return sb.ToString();
        }
    }
}
