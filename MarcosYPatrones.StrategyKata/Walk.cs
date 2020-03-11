using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.StrategyKata
{
    public class Walk : IMoveBehavior
    {
        public void Move(Viking unit)
        {
            unit.Position += 1;
        }
    }
}
