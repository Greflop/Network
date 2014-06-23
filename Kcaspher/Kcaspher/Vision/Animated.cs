using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Projet_2._0
{
    public class Animated : Movable
    {
        public int healthPoint;

        public Animated(int healthPoint, Texture2D Sprite, Rectangle Hitbox)
            : base(Sprite, Hitbox)
        {
            this.healthPoint = healthPoint;
        }

        public bool isAlive(int healthPoint)
        {
            return healthPoint > 0;
        }
        
    }
}
