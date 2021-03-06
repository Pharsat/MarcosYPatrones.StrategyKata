﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.StrategyKata
{
    public class Viking : IUnit
    {
        public Viking()
        {
            _moveStrategy = new Walk();
        }

        private IMoveBehavior _moveStrategy;

        public int Position { get; set; }

        public void SetMoveBehavior(IMoveBehavior moveStrategy)
        {
            _moveStrategy = moveStrategy;
        }

        public void StartMoving()
        {
            _moveStrategy.Move(this);
            Console.WriteLine();
            Console.WriteLine($"Position: {Position}");
        }
    }
}
