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
using Projet_2._0.Menus;

namespace Projet_2._0
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        //public Player2 player2;
        public Casper casperr;
        //Decors decors;
        SpriteFont fontdebug;
        ScreenManager screenmanager;
        GameType gameState;
        static Game1 game;
        MouseState mouseState;
        public Camera camera;
        public Res res;

        public static string test;

        internal bool IsFullScreen
        {
            get { return graphics.IsFullScreen; }
            set
            {
                graphics.IsFullScreen = value;
                graphics.ApplyChanges();
            }
        }

        public static Game1 GetGame()
        {
            if (game == null)
                game = new Game1();
            return game;
        }

        public Game1()
        {

            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            double ScreenWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            double ScreenHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            graphics.PreferredBackBufferWidth = Convert.ToInt32(ScreenWidth);
            graphics.PreferredBackBufferHeight = Convert.ToInt32(ScreenHeight);
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //gametime = new GameTime();
            IsMouseVisible = true;
            //res = new Res();
            //camera = new Camera(GraphicsDevice.Viewport);
            gameState = GameType.Menu_Base_Type;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Content_Manager.getInstance().LoadTextures(Content);
            fontdebug = Content.Load<SpriteFont>("Fontdebug");
            SoundManager.LoadContent(Content);
            MediaPlayer.Play(SoundManager.menu);
            MediaPlayer.IsRepeating = true;
            screenmanager = new ScreenManager(gameState, this);
            camera = screenmanager.camera;
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            mouseState = Mouse.GetState();
            // Allows the game to exit

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            //casper.update(gameTime);
            screenmanager.update(gameTime);
            //camera.update(gameTime, casperr);
            // TODO: Add your update logic here
            base.Update(gameTime);
        }


        //posTest = "" + screenmanager.casper.Position.X + " " + screenmanager.casper.Position.Y;
        public string posClient()
        {
            gameState = GameType.Menu_Play_Solo_world1_lvl1;
            if (gameState == GameType.Menu_Play_Solo_world1_lvl1)
            {
                test = "1";// +screenmanager.casper.Position.X + "8" + screenmanager.casper.Position.Y;
            }
            else
            {
                test = "error";
            }
            return test;
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, camera.transform);
            screenmanager.Draw(spriteBatch);
            if (IsMouseVisible)
            {
                spriteBatch.DrawString(fontdebug, Convert.ToString(camera.centre.X), new Vector2(camera.centre.X + 200, camera.centre.Y + 10), Color.Green);
                spriteBatch.DrawString(fontdebug, Convert.ToString(camera.centre.Y), new Vector2(camera.centre.X + 200, camera.centre.Y + 40), Color.Green);

                spriteBatch.DrawString(fontdebug, Convert.ToString(mouseState.X), new Vector2(camera.centre.X + 100, camera.centre.Y + 10), Color.White);
                spriteBatch.DrawString(fontdebug, Convert.ToString(mouseState.Y), new Vector2(camera.centre.X + 100, camera.centre.Y + 40), Color.White);
            }
            //decors.Draw(spriteBatch);
            //spriteBatch.DrawString(fontdebug, Convert.ToString(casperr.getVelocity().X), new Vector2(camera.centre.X + 10 , camera.centre.Y + 10 ), Color.Red);
            //spriteBatch.DrawString(fontdebug, Convert.ToString(casperr.getVelocity().Y), new Vector2(camera.centre.X + 10, camera.centre.Y + 25), Color.Red);
            //spriteBatch.DrawString(fontdebug, Convert.ToString(casperr.getPosition().X), new Vector2(camera.centre.X + 10, camera.centre.Y + 40), Color.Red);
            //spriteBatch.DrawString(fontdebug, Convert.ToString(casperr.getPosition().Y), new Vector2(camera.centre.X + 10, camera.centre.Y + 55), Color.Red);
            //spriteBatch.DrawString(fontdebug, Convert.ToString(casperr.hasJumped), new Vector2(camera.centre.X + 10, camera.centre.Y + 70), Color.Red);
            //spriteBatch.DrawString(fontdebug, Convert.ToString(screenmanager.respawn), new Vector2(camera.centre.X + 10, camera.centre.Y + 70), Color.Red);

            //casper.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

