using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.StrategyKata
{
    public class Fly : IMoveBehavior
    {
        public void Move(IUnit unit)
        {
            unit.Position += 10;
        }
    }
}
