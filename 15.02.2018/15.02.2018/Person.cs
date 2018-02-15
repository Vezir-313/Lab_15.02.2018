using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._02._2018
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        private int _money { get; set; }

        public int money
        {
            get
            {
                if (_money > 50)
                {
                    return 50;
                }
                else
                {
                    return _money;
                };
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    _money = value;
                }
                else
                {
                    _money = 0;
                }
            }
        }
    }
}
