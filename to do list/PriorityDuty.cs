using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do_list
{
    public class PriorityDuty:Duty
    {
        public PriorityDuty(string title, string description, DateTime date)
            : base(title, description, date)
        {

        }

        public override Priority Priority { get; set; }

        public override void ShowDuty()
        {
            Console.WriteLine($"duty={Title} \n description={Description}" +
                $" \n date={Date}\n priority={Priority}");
        }
    }
}
