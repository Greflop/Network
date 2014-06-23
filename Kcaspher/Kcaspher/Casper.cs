using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using Projet_2._0.Menus;
using Microsoft.Xna.Framework.Input;



namespace Projet_2._0
{
    public class Casper : Animated
    {
        public Texture2D casper;
        public Controls controls;
        public Camera camera;
        public Animation animation;
        public Vector2 previousPosition;
        public GameType gametype;
        public Boolean hasJumped;
        public ParticleEngine particleEngine;
        public HealthPoint healthpoint;
        public List<Rectangle> enemies;

        public Casper(Texture2D casper, Rectangle hitbox) : base(2, casper, hitbox)
        {
            this.casper = casper;
            this.Position = new Vector2(Res.gI().ScaleX(200), Res.gI().ScaleY(925));
            this.Velocity = new Vector2(0,0);
            this.Speed = 0.01f;
            camera = new Camera(Game1.GetGame().GraphicsDevice.Viewport);
            animation = new Animation();
            List<Texture2D> textures = new List<Texture2D>();
            textures.Add(Content_Manager.getInstance().Textures["particule"]);
            particleEngine = new ParticleEngine(textures, new Vector2(Res.gI().ScaleX(400), Res.gI().ScaleY(240)));
            healthpoint = new HealthPoint(13);


        }


        public void update(GameTime gametime, Controls controls, GameType gametype, List<Rectangle> level,IEnumerable<Rectangle> enemies)
        {
            healthpoint.update(this, enemies);
            animation.update(gametime, gametype);
            previousPosition = Position;
            //controls.update(gametime, gametype, this, level);
            hasJumped = controls.getHasJumped();
            Hitbox.X = (int)Position.X;
            Hitbox.Y = (int)Position.Y;
            controls.update(gametime, gametype, this, level);
            previousPosition = Position;
            Position = controls.getPosition();
            Velocity = controls.getVelocity();
            casper = animation.getText(animation.getState(Position, previousPosition),gametype);
            camera.update(gametime, this.Position);
            particleEngine.EmitterLocation = new Vector2(Position.X + this.Hitbox.Width/2, Position.Y + 25) ;
            particleEngine.Update();
        }

        public void Draw(SpriteBatch spritebatch, Color color)
        {

            //spritebatch.DrawString(fontdebug, Convert.ToString(Velocity.X), new Vector2(10, 10), Color.Red);
            //particuleengine.Draw(spritebatch);
            particleEngine.Draw(spritebatch);
            spritebatch.Draw(casper, Position, color);
        }
    }
}
