using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MonoApp
{
    public class MyGame : Game
    {

        private GraphicsDeviceManager graphics;

        public MyGame()
        {

            // unused - but needs to be initialised to work
            graphics = new GraphicsDeviceManager(this);

            string message = Greeter.SayHello("world");
            Console.WriteLine(message);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }
    }
}
