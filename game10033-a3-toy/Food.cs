using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MohawkGame2D
{
    internal class Food
    {
        // Variables local to this class
        // Food position
        public float x;
        public float y;

        public void Update()
        {
            // Draw Food
            Draw.LineColor = Color.Black;
            Draw.LineSize = 3;
            Draw.FillColor = Color.Green;
            Draw.Circle(x, y, 10);
        }
    }
}
