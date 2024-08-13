using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator_Wydarzeń.Model
{
    public class Event
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }

        public Event(string title, string description, string date, string type, string priority) { 
            Title = title;
            Description = description;  
            Date = date;
            Type = type;
            Priority = priority;
        }
    }
}
