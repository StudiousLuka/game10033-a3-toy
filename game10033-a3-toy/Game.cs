using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Game
    {
        Food food = new Food();
        Ball ball = new Ball();
        public void Setup()
        {
            Window.SetSize(800, 600);
        }

        public void Update()
        {
            Window.SetTitle("Mr. Ball");
            Window.ClearBackground(Color.OffWhite);

            // Food spawning
            food.x = 100;
            food.y = 100;

            // Ball movement
            ball.x = Input.GetMouseX();
            ball.y = Input.GetMouseY();


            // Class updates
            food.Update();
            ball.Update();
        }
    }

}
