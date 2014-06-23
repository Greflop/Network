using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Projet_2._0;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Kcaspher.AI
{
    class AI_W2L2
    {

        public List<AI_moderate> AI_w2l2 = new List<AI_moderate>();
        public List<Rectangle> ListHitbox;

        public AI_W2L2()
        {
            AI_w2l2.Add(new AI_moderate(Content_Manager.getInstance().Textures["enemy1"], new Rectangle(Res.gI().ScaleX(1790), Res.gI().ScaleY(540), Res.gI().ScaleX(40), Res.gI().ScaleY(40)),5));
            AI_w2l2.Add(new AI_moderate(Content_Manager.getInstance().Textures["enemy1"], new Rectangle(Res.gI().ScaleX(2160), Res.gI().ScaleY(540), Res.gI().ScaleX(40), Res.gI().ScaleY(40)),5));
            AI_w2l2.Add(new AI_moderate(Content_Manager.getInstance().Textures["enemy1"], new Rectangle(Res.gI().ScaleX(1740), Res.gI().ScaleY(80), Res.gI().ScaleX(40), Res.gI().ScaleY(40)),5));

        }

        public void update(GameTime gametime, Casper casper)
        {
            foreach (AI_moderate AI in AI_w2l2)
            {
                AI.update(gametime,casper);
            }
        }

        public void Draw(SpriteBatch spritebatch)
        {
            foreach (AI_moderate AI in AI_w2l2)
            {
                AI.Draw(spritebatch);
            }
        }
        public List<Rectangle> getListRectangle() 
        {
            ListHitbox = new List<Rectangle>();
            foreach (AI_moderate AI in AI_w2l2)
	        {
                ListHitbox.Add(AI.hitbox);
	        }
            return ListHitbox;
        }
    }
}
