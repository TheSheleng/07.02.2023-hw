using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace website
{
    public class WebSite
    {
        public string name;
        public string url;
        public string title;
        public string description;

        public string Name { get => name; set => name = value; }
        public string Url { get => url; set => url = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name: {name}");
            sb.AppendLine($"URL:  {url}");
            sb.AppendLine($"Title: {title}");
            sb.AppendLine($"Description: {description}");

            return sb.ToString();
        }
    }
}
