using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Game
    {
        // Variables
        // foodx and foody place the food in a random position
        int foodx = Random.Integer(801);
        int foody = Random.Integer(601);
        
        // Classes
        Food food = new Food();
        Ball ball = new Ball();
        public void Setup()
        {
            Window.SetSize(800, 600);
        }

        public void Update()
        {
            // Window settings
            Window.SetTitle("Mr. Ball");
            Window.ClearBackground(Color.OffWhite);

            // Ball movement
            ball.x = Input.GetMouseX();
            ball.y = Input.GetMouseY();
            // Food spawning
            food.x = foodx;
            food.y = foody;

            if (ball.x != food.x)
            {
                foodx = Random.Integer(801);
                foody = Random.Integer(601);
                food.x = foodx;
                food.y = foody;
            }
            else
            {
                food.x = ball.x;
                food.y = ball.y;
            }

            // Class updates
            ball.Update();
            food.Update();
        }
    }

}
