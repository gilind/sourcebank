using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeltaEngine.Core;
using DeltaEngine.Platforms;

namespace Breakout
{
    public class MyGame : Runner<Time>
    {
        private readonly Window window;
        private readonly MyCar myCar;

        public MyGame(MyCar car, Window window)
        {
            this.window = window;
            myCar = car;
        }

        public void Run(Time first)
        {
            window.Title = first.Fps + " - " + first.Milliseconds;
        }
    }
}
