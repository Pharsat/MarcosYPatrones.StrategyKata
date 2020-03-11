using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.StrategyKata
{
    public interface IMoveBehavior
    {
        void Move(IUnit unit);
    }
}
