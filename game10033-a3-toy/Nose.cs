using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MohawkGame2D
{
    internal class Nose
    {
        // Variables local to this class
        // Nose position
        public float x;
        public float y;

        public void Update()
        {
            // Draw Nose
            Draw.LineColor = Color.Black;
            Draw.LineSize = 2;
            Draw.FillColor = Color.Yellow;
            Draw.Ellipse(x, y, 10, 12);
        }
    }
}
