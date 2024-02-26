using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D myImage;
        private Rectangle heroRectangle = new Rectangle(628, 302, 32, 64);
        private SpriteFont fantasy;
        private Vector2 readOut = new Vector2(10, 10);
        

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
           // _graphics.IsFullScreen = false;
           // _graphics.PreferredBackBufferWidth = 640;
           // _graphics.PreferredBackBufferHeight = 480;
           // _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            myImage = Content.Load<Texture2D>("hyptosis");
            fantasy = Content.Load<SpriteFont>("fantasy");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            
            _spriteBatch.Begin();
            _spriteBatch.Draw(myImage, new Vector2(300, 300), heroRectangle, Color.White);
            _spriteBatch.DrawString(fantasy, "Hello World", readOut, Color.Black);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
