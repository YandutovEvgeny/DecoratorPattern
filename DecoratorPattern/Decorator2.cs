using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Decorator2 : MovebleDecorator
    {
        public Decorator2(Moveble moveble) : base(moveble.Name + " с двумя турбинами", moveble) { }

        public override int GetSpeed()
        {
            return moveble.GetSpeed() + 50;
        }
    }
}
