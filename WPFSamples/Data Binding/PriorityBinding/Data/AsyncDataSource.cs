using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PriorityBinding.Data
{
    public class AsyncDataSource
    {
        private string _slowerDp;
        private string _slowestDp;
        public string FastDp { get; set; }

        public string SlowerDp
        {
            get
            {
                // This simulates a lengthy time before the
                // data being bound to is actualy available.
                Thread.Sleep(3000);
                return _slowerDp;
            }
            set { _slowerDp = value; }
        }

        public string SlowestDp
        {
            get
            {
                // This simulates a lengthy time before the
                // data being bound to is actualy available.
                Thread.Sleep(5000);
                return _slowestDp;
            }
            set { _slowestDp = value; }
        }
    }
}
