using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class MovebleDecorator : Moveble
    {
        protected Moveble moveble;

        public MovebleDecorator(string name, Moveble moveble) : base(name)
        {
            this.moveble = moveble;
        }
    }
}
