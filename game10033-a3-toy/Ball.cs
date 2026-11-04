using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D;

public class Ball
{
    // Variables local to this class
    public float x;
    public float y;

    public void Update()
    {
        Draw.LineColor = Color.Black;
        Draw.LineSize = 3;
        Draw.FillColor = Color.Yellow;
        Draw.Circle(x, y, 30);
        Draw.LineSize = 0;
        Draw.FillColor = Color.Black;
        Draw.Capsule(x - 10, y - 10, x - 10, y, 3);
        Draw.Capsule(x + 10, y - 10, x + 10, y, 3);
        Draw.Rectangle(x - 12, y + 10, 25, 3);
    }
}
