using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChordnomiconWebApplication
{
    class Interval
    {
        public Interval(int _intervalValue, string _name)
        {
            intervalValue = _intervalValue;
            name = _name;
        }
        private int intervalValue;
        private string name;
        public int getIntervalValue() { return intervalValue; }
        public string getName() { return name; }
    }
}
