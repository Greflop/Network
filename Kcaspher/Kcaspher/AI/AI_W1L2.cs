using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Projet_2._0;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Kcaspher.AI
{
    class AI_W1L2
    {
        public List<AI_basic> AI_w1l2 = new List<AI_basic>();
        public List<Rectangle> ListHitbox;

        public AI_W1L2()
        {
            AI_w1l2.Add(new AI_basic(Content_Manager.getInstance().Textures["enemy1"], Content_Manager.getInstance().Textures["enemy2"], new Rectangle(Res.gI().ScaleX(800), Res.gI().ScaleY(600), Res.gI().ScaleX(40), Res.gI().ScaleY(40)), new Vector2(3, 0), 200));
        }


        public void update(GameTime gametime)
        {
            foreach (AI_basic AI in AI_w1l2)
            {
                AI.update(gametime);
            }
        }

        public void Draw(SpriteBatch spritebatch)
        {
            foreach (AI_basic AI in AI_w1l2)
            {
                AI.Draw(spritebatch);
            }
        }
        public List<Rectangle> getListRectangle()
        {
            ListHitbox = new List<Rectangle>();
            foreach (AI_basic AI in AI_w1l2)
            {
                ListHitbox.Add(AI.Hitbox);
            }
            return ListHitbox;
        }
    }
}
