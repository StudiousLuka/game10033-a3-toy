using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Game
    {
        Ball ball = new Ball();
        public void Setup()
        {
            Window.SetSize(800, 600);
        }

        public void Update()
        {
            Window.SetTitle("Ball Program");
            Window.ClearBackground(Color.OffWhite);

            ball.x = 400;
            ball.y = 300;

            ball.Update();
        }
    }

}
