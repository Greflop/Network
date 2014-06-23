using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Projet_2._0
{
    public class Movable : Object
    {
        public Vector2 Direction;
        public float Speed;
        public Vector2 Velocity;

        public Movable(Texture2D Sprite, Rectangle Hitbox)
            : base(Sprite, Hitbox)
        {

        }

        public void Update(GameTime gameTime)
        {
            //Position += Direction * Speed;// gameTime.ElapsedGameTime.TotalSeconds;
        }

        public Vector2 getVelocity()
        {
            return Velocity;
        }
    }
}
