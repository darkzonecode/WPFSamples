using DataTemplatingIntro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DataTemplatingIntro.TemplateSelectors
{
    public class MyTaskListDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null && item is MyTask)
            {
                MyTask taskitem = item as MyTask;

                if (taskitem.Priority == 1)
                    return
                        element.FindResource("ImportantTaskTemplate") as DataTemplate;
                else
                    return
                        element.FindResource("MyTaskTemplate") as DataTemplate;
            }

            return null;
        }
    }
}
