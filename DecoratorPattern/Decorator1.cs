using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Decorator1 : MovebleDecorator
    {
        public Decorator1(Moveble moveble)
            : base(moveble.Name + "с турбонаддувом", moveble) { }

        public override int GetSpeed()
        {
            return moveble.GetSpeed() + 10;
        }
    }
}
