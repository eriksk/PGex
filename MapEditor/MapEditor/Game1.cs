using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using PGex.Game;
using MapEditor.UI;
using Gex.Input;
using MapEditor.Utility;
using MapEditor.Tools;

namespace MapEditor
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        GameManager gameManager;
        Gui gui;

        public static SpriteFont font;
        Texture2D cursor;
        List<Tool> tools; 

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            gui = new Gui();
            gui.LoadContent(Content);

            font = Content.Load<SpriteFont>(@"fonts/basic");
            cursor = Content.Load<Texture2D>(@"gfx/cursor");

            tools = new List<Tool>();
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            float time = (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            gui.Update(time);
            
            InputSingleton.I.Update(time);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            spriteBatch.Begin();
            gui.Draw(spriteBatch);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(cursor, new Vector2(InputSingleton.I.MouseState.X, InputSingleton.I.MouseState.Y), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
