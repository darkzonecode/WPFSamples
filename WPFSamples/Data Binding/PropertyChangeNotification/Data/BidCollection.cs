using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Timers;

namespace PropertyChangeNotification.Data
{
    public class BidCollection : ObservableCollection<Bid>
    {
        private readonly Bid _item1 = new Bid("Perseus Vase", 24.95M);
        private readonly Bid _item2 = new Bid("Hercules Statue", (decimal)16.05);
        private readonly Bid _item3 = new Bid("Odysseus Painting", (decimal)100.0);

        public BidCollection()
        {
            Add(_item1);
            Add(_item2);
            Add(_item3);
            CreateTimer();
        }

        private void CreateTimer()
        {
            var timer = new Timer
            {
                Enabled = true,
                Interval = 2000
            };
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _item1.BidItemPrice += 1.25M;
            _item2.BidItemPrice += 2.45M;
            _item3.BidItemPrice += 10.55M;
        }
    }
}
