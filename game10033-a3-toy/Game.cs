using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Game
    {
        // Variables
        // nosex and nosey place the nose in a random position
        int nosex = Random.Integer(801);
        int nosey = Random.Integer(601);

        float timer = 0;
        
        // Classes
        Nose nose = new Nose();
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

            timer += Time.DeltaTime;

            // Ball movement
            ball.x = Input.GetMouseX();
            ball.y = Input.GetMouseY();
            // nose spawning
            nose.x = nosex;
            nose.y = nosey;

            if (timer >= 0.75 && ball.x != nose.x)
            {
                nosex = Random.Integer(801);
                nosey = Random.Integer(601);
                nose.x = nosex;
                nose.y = nosey;

                timer = 0;
            }
            else if (ball.x == nose.x)
            {
                nose.x = ball.x;
                nose.y = ball.y;
            }

            // Class updates
            ball.Update();
            nose.Update();
        }
    }

}
