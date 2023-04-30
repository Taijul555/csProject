using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project_For_Monthly_03.Models
{
    public class Book 
    {
        public Book() { }
        public Book(int id, string title, int publisherId)
        {
            this.Id = id;
            this.Title = title;
            this.PublisherId = publisherId;

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublisherId { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Title} Pub. Id: {PublisherId}";
        }
    }
}
