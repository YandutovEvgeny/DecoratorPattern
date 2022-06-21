using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Car : Moveble
    {
        public Car() : base("Машина") { }
        public override int GetSpeed()
        {
            return 120;
        }
    }
}
