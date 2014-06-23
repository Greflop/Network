using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Projet_2._0.Menus;

namespace Projet_2._0
{
    public class HealthPoint
    {
        public int healthpoint;
        public Boolean respawn;
        public ParticleEngine Hp1, Hp2, Hp3, Hp4, Hp5;

        public HealthPoint(int healthpoint)
        {
            this.healthpoint = healthpoint;
            respawn = false;
            List<Texture2D> textures = new List<Texture2D>();
            textures.Add(Content_Manager.getInstance().Textures["etoile"]);
            Hp1 = Hp2 = Hp3 = Hp4 = Hp5 = new ParticleEngine(textures, new Vector2(0, 0));
        }

        public void update(Casper casper, IEnumerable<Rectangle> enemies)
        {
            foreach (Rectangle rect in enemies)
            {
                if (casper.Hitbox.Intersects(rect))
                {
                    //Game1.GetGame().Exit();
                    respawn = true;
                    healthpoint += -1;
                    SoundManager.hp.Play();

                }
            }
        }

        public void draw(SpriteBatch spritebatch, Camera camera)
        {
            Hp1.EmitterLocation = new Vector2((int)camera.centre.X + Res.gI().ScaleX(44), (int)camera.centre.Y + Res.gI().ScaleX(44));
            Hp1.Update();
            Hp1.Draw(spritebatch);
            if (healthpoint > 3)
            {
                Hp2.EmitterLocation = new Vector2((int)camera.centre.X + Res.gI().ScaleX(44)*2, (int)camera.centre.Y + Res.gI().ScaleX(44));
                Hp2.Update();
                Hp2.Draw(spritebatch);
            }
            if (healthpoint > 6)
            {
                Hp3.EmitterLocation = new Vector2((int)camera.centre.X + Res.gI().ScaleX(44)*3, (int)camera.centre.Y + Res.gI().ScaleX(44));
                Hp3.Update();
                Hp3.Draw(spritebatch);
            }
            if (healthpoint > 9)
            {
                Hp4.EmitterLocation = new Vector2((int)camera.centre.X + Res.gI().ScaleX(44)*4, (int)camera.centre.Y + Res.gI().ScaleX(44));
                Hp4.Update();
                Hp4.Draw(spritebatch);
            }
            if (healthpoint > 12)
            {
                Hp5.EmitterLocation = new Vector2((int)camera.centre.X + Res.gI().ScaleX(44)*5, (int)camera.centre.Y + Res.gI().ScaleX(44));
                Hp5.Update();
                Hp5.Draw(spritebatch);
            }

           // spritebatch.Draw(Content_Manager.getInstance().Textures["enemy1"], new Rectangle((int)camera.centre.X, (int)camera.centre.Y, Res.gI().ScaleX(44), Res.gI().ScaleY(40)), Color.White);
            //if (healthpoint > 3)
             //   spritebatch.Draw(Content_Manager.getInstance().Textures["enemy1"], new Rectangle((int)camera.centre.X + Res.gI().ScaleX(44), (int)camera.centre.Y, Res.gI().ScaleX(44), Res.gI().ScaleY(40)), Color.White);
            //if (healthpoint > 6)
              //  spritebatch.Draw(Content_Manager.getInstance().Textures["enemy1"], new Rectangle((int)camera.centre.X + Res.gI().ScaleX(44) * 2, (int)camera.centre.Y, Res.gI().ScaleX(44), Res.gI().ScaleY(40)), Color.White);
            //if (healthpoint > 9)
             //   spritebatch.Draw(Content_Manager.getInstance().Textures["enemy1"], new Rectangle((int)camera.centre.X + Res.gI().ScaleX(44) * 3, (int)camera.centre.Y, Res.gI().ScaleX(44), Res.gI().ScaleY(40)), Color.White);
            //if (healthpoint > 12)
             //   spritebatch.Draw(Content_Manager.getInstance().Textures["enemy1"], new Rectangle((int)camera.centre.X + Res.gI().ScaleX(44) * 4, (int)camera.centre.Y, Res.gI().ScaleX(44), Res.gI().ScaleY(40)), Color.White);
        }

    }
}
