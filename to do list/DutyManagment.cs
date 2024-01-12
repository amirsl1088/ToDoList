using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do_list
{
    public static class DutyManagment
    {
        public static List<PriorityDuty> _tasks = new();
        public static void AddDuty(string title,string description,DateTime date,int type)
        {
            var duty = new PriorityDuty(title, description, date);
            if (type == 1)
            {
                duty.Priority = Priority.high;
                _tasks.Add(duty);
            }
            if (type == 2)
            {
                duty.Priority = Priority.medium;
                _tasks.Add(duty);
            }
            if (type == 3)
            {
                duty.Priority = Priority.low;
                _tasks.Add(duty);
            }
        }
        public static List<PriorityDuty> GetDuty()
        {
            return _tasks;
        }
        public static void ReamoveDuty(string name)
        {
            var duty = _tasks.FirstOrDefault(_ => _.Title == name);
            if(duty is null)
            {
                throw new Exception("wrong duty");
            }
            _tasks.Remove(duty);
        }
    }
}
