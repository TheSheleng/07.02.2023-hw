using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazine
{
    public class Magazine
    {
        public string name;
        public string city;
        public string year;
        public string telephone;
        public string email;

        public string Name { get => name; set => name = value; }
        public string City { get => city;set => city = value; }
        public string Tlephone { get => telephone;set => telephone = value; }
        public string Email { get => email;set => email = value; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name: {name}");
            sb.AppendLine($"City: {city}");
            sb.AppendLine($"Ttelephone: {telephone}");
            sb.AppendLine($"Email: {email}");

            return sb.ToString();
        }
    }
}
