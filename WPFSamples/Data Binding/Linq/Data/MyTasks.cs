using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Linq.Data
{
    public class MyTasks : ObservableCollection<MyTask>
    {
        public MyTasks()
        {
            Add(new MyTask("Groceries", "Pick up Groceries and Detergent", 2, TaskType.Home));
            Add(new MyTask("Laundry", "Do my Laundry", 2, TaskType.Home));
            Add(new MyTask("Email", "Email clients", 1, TaskType.Work));
            Add(new MyTask("Clean", "Clean my office", 3, TaskType.Work));
            Add(new MyTask("Dinner", "Get ready for family reunion", 1, TaskType.Home));
            Add(new MyTask("Proposals", "Review new budget proposals", 2, TaskType.Work));
        }
    }
}
