using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Projet_2._0.Menus
{
    public class Camera
    {
        public Matrix transform;
        Viewport view;
        public Vector2 centre;

        public Camera(Viewport newView)
        {
            view = newView;
        }

        public void update(GameTime gametime, Vector2 Position)
        {
            centre = new Vector2(Position.X - Res.gI().ScaleX(840), 0);
            transform = Matrix.CreateScale(new Vector3(1,1,0)) *
                Matrix.CreateTranslation(new Vector3(-centre.X, -centre.Y, 0));
        }

    }
}
