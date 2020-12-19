using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Data
{
    public class MyTask : INotifyPropertyChanged
    {
        private string _description;
        private string _name;
        private int _priority;
        private TaskType _type;

        public MyTask()
        {
        }

        public MyTask(string name, string description, int priority, TaskType type)
        {
            _name = name;
            _description = description;
            _priority = priority;
            _type = type;
        }


        public string TaskName
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                NotifyPropertyChanged();
            }
        }

        public int Priority
        {
            get { return _priority; }
            set
            {
                _priority = value;
                NotifyPropertyChanged();
            }
        }

        public TaskType TaskType
        {
            get { return _type; }
            set
            {
                _type = value;
                NotifyPropertyChanged();
            }
        }


        public override string ToString() => _name;

        public event PropertyChangedEventHandler PropertyChanged;


        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
