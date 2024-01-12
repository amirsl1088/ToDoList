using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do_list
{
    public abstract class Duty:IPriority
    {
        public Duty(string title,string description,DateTime date)
        {
            Title = title;
            Description = description;
            Date = date;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public abstract Priority Priority { get; set; }

        public abstract void ShowDuty();
       
    }
}
