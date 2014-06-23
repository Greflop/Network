using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Projet_2._0.AI
{
    class AI_W1L1
    {
        public List<AI_basic> AI_w1l1 = new List<AI_basic>();
        public List<Rectangle> ListHitbox;

        public AI_W1L1()
        {
            AI_w1l1.Add(new AI_basic(Content_Manager.getInstance().Textures["enemy1"], Content_Manager.getInstance().Textures["enemy2"], new Rectangle(Res.gI().ScaleX(1120), Res.gI().ScaleY(920), Res.gI().ScaleX(40), Res.gI().ScaleY(40)), new Vector2(3, 0), 440));
            AI_w1l1.Add(new AI_basic(Content_Manager.getInstance().Textures["enemy1"], Content_Manager.getInstance().Textures["enemy2"], new Rectangle(Res.gI().ScaleX(2000), Res.gI().ScaleY(920), Res.gI().ScaleX(40), Res.gI().ScaleY(40)), new Vector2(3, 0), 1160));
            AI_w1l1.Add(new AI_basic(Content_Manager.getInstance().Textures["enemy1"], Content_Manager.getInstance().Textures["enemy2"], new Rectangle(Res.gI().ScaleX(3320), Res.gI().ScaleY(920), Res.gI().ScaleX(40), Res.gI().ScaleY(40)), new Vector2(3, 0), 320));
            AI_w1l1.Add(new AI_basic(Content_Manager.getInstance().Textures["enemy1"], Content_Manager.getInstance().Textures["enemy2"], new Rectangle(Res.gI().ScaleX(3440), Res.gI().ScaleY(320), Res.gI().ScaleX(40), Res.gI().ScaleY(40)), new Vector2(3, 0), 100));

        }

        public void update(GameTime gametime)
        {
            foreach (AI_basic AI in AI_w1l1)
            {
                AI.update(gametime);
            }
        }

        public void Draw(SpriteBatch spritebatch)
        {
            foreach (AI_basic AI in AI_w1l1)
            {
                AI.Draw(spritebatch);
            }
        }
        public List<Rectangle> getListRectangle() 
        {
            ListHitbox = new List<Rectangle>();
            foreach (AI_basic AI in AI_w1l1)
	        {
                ListHitbox.Add(AI.Hitbox);
	        }
            return ListHitbox;
        }
    }
}
