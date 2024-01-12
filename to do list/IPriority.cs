using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do_list
{
    public interface IPriority
    {
        Priority Priority { get; set; }
    }
    public enum Priority
    {
        high,medium,low
    }
}
