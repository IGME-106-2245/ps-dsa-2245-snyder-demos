using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading;

namespace MG_Basics_Demo
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D demoImage;
        private Rectangle dogLoc;

        private const int DesiredWidth = 2560;
        private const int DesiredHeight = 1440;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            dogLoc = new Rectangle(200, 200, 200, 200);
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = DesiredWidth;
            _graphics.PreferredBackBufferHeight = DesiredHeight;
            _graphics.ApplyChanges();
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            demoImage = Content.Load<Texture2D>("cool B)");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            dogLoc.X++;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.PeachPuff);

            // TODO: Add your drawing code here

            //Where do we start drawing
            _spriteBatch.Begin();

            // Regular size
            // Positioned at (20, 20) 
            // No color overlay
            

            // Resized to 100 x 100 - must use Rectangle overload
            // Positioned at (500, 300)
            // Red color overlay
            _spriteBatch.Draw(demoImage,
                             dogLoc,
                             Color.PapayaWhip);

            _spriteBatch.Draw(demoImage,
                             new Vector2(DesiredWidth/2 - demoImage.Width/2, 
                             DesiredHeight/2 - demoImage.Height/2),
                             Color.PapayaWhip);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
