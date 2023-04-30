using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project_For_Monthly_03.Models
{
    public class Publisher 
    {
        public Publisher() { }
        public Publisher(int id, string name)
        {
            this.Id = id;
            this.Name = name;

        }
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name}";
        }
    }
}
