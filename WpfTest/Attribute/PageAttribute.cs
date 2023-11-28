using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTest.attribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    internal class PageAttribute : Attribute
    {
        public PageAttribute(string Name,string Uri) { 
            this.Name = Name;
            this.Uri = Uri;
        }

        public string ?Name { get; set; }

        public string ?Uri { get; set; }
    }
}
