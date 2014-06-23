using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Projet_2._0
{
    class AI_basic
    {
        public Texture2D Dtexture, Rtexture, Ltexture;
        public Rectangle Shitbox, Hitbox;
        public Vector2 Position, Velocity;
        public int Distance;

        public AI_basic(Texture2D Rtexture,Texture2D Ltexture, Rectangle Shitbox, Vector2 Velocity, int Distance)
        {
            this.Rtexture = Rtexture;
            this.Ltexture = Ltexture;
            this.Shitbox = Shitbox;
            this.Hitbox = Shitbox;
            Position = new Vector2(Shitbox.X, Shitbox.Y);
            this.Velocity = Velocity;
            this.Distance = Distance;
            this.Dtexture = Rtexture;
        }
        public void update(GameTime gametime)
        {
            if (Distance >= 0)
            {
                if (Position.X < Shitbox.X + Distance)
                    Position += Velocity;
                else
                    Distance = -Distance;
                Dtexture = Rtexture;
            }
            if (Distance < 0)
            {
                if (Position.X < Shitbox.X)
                    Distance = -Distance;
                else
                    Position -= Velocity;
                Dtexture = Ltexture;
            }
            Hitbox.X = (int)Position.X;
            Hitbox.Y = (int)Position.Y;
        }
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Dtexture, Hitbox, Color.White);
        }
    }
}
