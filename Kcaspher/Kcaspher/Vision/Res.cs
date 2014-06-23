using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Projet_2._0
{
    public class Res
    {
        private static Res instance;
        public double ScreenWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
        public double ScreenHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
        public double coeffX, coeffY;

        public Res()
        {
            this.coeffX = 1680d / ScreenWidth;
            this.coeffY = 1050d / ScreenHeight;
        }

        public static Res gI()
        {
            if (instance == null)
                instance = new Res();
            return instance;
        }

        public int ScaleX(int x)
        {
            return Convert.ToInt32(x / coeffX);
        }
        public int ScaleY(int x)
        {
            return Convert.ToInt32(x / coeffY);
        }

    }
}
