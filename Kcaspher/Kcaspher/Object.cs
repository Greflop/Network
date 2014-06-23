using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Projet_2._0
{
    public class Object
    {
        public Texture2D Sprite;
        public Rectangle Hitbox;
        public Vector2 Position;

        public Object(Texture2D Sprite, Rectangle Hitbox)
        {
            this.Sprite = Sprite;
            this.Hitbox = Hitbox;
            Position = new Vector2(Res.gI().ScaleX(Hitbox.X), Res.gI().ScaleY(Hitbox.Y));
        }

        public Vector2 getPosition()
        {
            return Position;
        }
    }
}
