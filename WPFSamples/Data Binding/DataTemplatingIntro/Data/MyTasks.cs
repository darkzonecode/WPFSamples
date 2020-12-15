using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DataTemplatingIntro.Data
{
    public class MyTasks : ObservableCollection<MyTask>
    {
        public MyTasks()
        {
            Add(new MyTask("Groceries", "Pick up Groceries and Detergent", 2, MyTaskType.Home));
            Add(new MyTask("Laundry", "Do my Laundry", 2, MyTaskType.Home));
            Add(new MyTask("Email", "Email clients", 1, MyTaskType.Work));
            Add(new MyTask("Clean", "Clean my office", 3, MyTaskType.Work));
            Add(new MyTask("Dinner", "Get ready for family reunion", 1, MyTaskType.Home));
            Add(new MyTask("Proposals", "Review new budget proposals", 2, MyTaskType.Work));
        }
    }
}
