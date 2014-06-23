using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Projet_2._0
{
    class Decors : Object
    {
        public Texture2D decors;

        public Decors(Texture2D decors, Rectangle hitbox)
            : base(decors, hitbox)
        {
            this.decors = decors;
            this.Position = new Vector2(0, 0);
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(decors, Hitbox, Color.White);
        }
    }
}
