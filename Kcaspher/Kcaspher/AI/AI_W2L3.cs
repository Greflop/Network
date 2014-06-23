using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Projet_2._0;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Kcaspher.AI
{
    class AI_W2L3
    {

        public List<AI_moderate> AI_w2l3 = new List<AI_moderate>();
        public List<Rectangle> ListHitbox;

        public AI_W2L3()
        {
            AI_w2l3.Add(new AI_moderate(Content_Manager.getInstance().Textures["focheur"], new Rectangle(Res.gI().ScaleX(760), Res.gI().ScaleY(330), Res.gI().ScaleX(60), Res.gI().ScaleY(100)),10)); // garde 1
            AI_w2l3.Add(new AI_moderate(Content_Manager.getInstance().Textures["focheur"], new Rectangle(Res.gI().ScaleX(760), Res.gI().ScaleY(610), Res.gI().ScaleX(60), Res.gI().ScaleY(100)),10)); // garde 2
            AI_w2l3.Add(new AI_moderate(Content_Manager.getInstance().Textures["enemy1"], new Rectangle(Res.gI().ScaleX(515), Res.gI().ScaleY(156), Res.gI().ScaleX(40), Res.gI().ScaleY(40)),5)); // random vert
            AI_w2l3.Add(new AI_moderate(Content_Manager.getInstance().Textures["enemy3"], new Rectangle(Res.gI().ScaleX(60), Res.gI().ScaleY(120), Res.gI().ScaleX(60), Res.gI().ScaleY(60)),7)); // chiote

        }

        public void update(GameTime gametime, Casper casper)
        {
            foreach (AI_moderate AI in AI_w2l3)
            {
                AI.update(gametime,casper);
            }
        }

        public void Draw(SpriteBatch spritebatch)
        {
            foreach (AI_moderate AI in AI_w2l3)
            {
                AI.Draw(spritebatch);
            }
        }
        public List<Rectangle> getListRectangle() 
        {
            ListHitbox = new List<Rectangle>();
            foreach (AI_moderate AI in AI_w2l3)
	        {
                ListHitbox.Add(AI.hitbox);
	        }
            return ListHitbox;
        }
    }
}
