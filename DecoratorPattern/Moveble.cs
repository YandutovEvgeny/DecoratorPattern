using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class Moveble
    {
        public string Name { get; protected set; }
        public abstract int GetSpeed();

        public Moveble(string name)
        {
            Name = name;
        }
    }
}
