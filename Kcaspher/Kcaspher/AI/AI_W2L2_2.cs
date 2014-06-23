using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Projet_2._0;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Kcaspher.AI
{
    class AI_W2L2_2
    {

        public List<AI_basic> AI_w2l2_2 = new List<AI_basic>();
        public List<Rectangle> ListHitbox;

        public AI_W2L2_2()
        {
            AI_w2l2_2.Add(new AI_basic(Content_Manager.getInstance().Textures["block"], Content_Manager.getInstance().Textures["block"], new Rectangle(Res.gI().ScaleX(320), Res.gI().ScaleY(140), Res.gI().ScaleX(100), Res.gI().ScaleY(100)), new Vector2(3, 0), 1000));
            AI_w2l2_2.Add(new AI_basic(Content_Manager.getInstance().Textures["block"], Content_Manager.getInstance().Textures["block"], new Rectangle(Res.gI().ScaleX(320), Res.gI().ScaleY(340), Res.gI().ScaleX(100), Res.gI().ScaleY(100)), new Vector2(3, 0), 1000));
            AI_w2l2_2.Add(new AI_basic(Content_Manager.getInstance().Textures["block"], Content_Manager.getInstance().Textures["block"], new Rectangle(Res.gI().ScaleX(320), Res.gI().ScaleY(640), Res.gI().ScaleX(100), Res.gI().ScaleY(100)), new Vector2(3, 0), 1000));
            AI_w2l2_2.Add(new AI_basic(Content_Manager.getInstance().Textures["block"], Content_Manager.getInstance().Textures["block"], new Rectangle(Res.gI().ScaleX(320), Res.gI().ScaleY(840), Res.gI().ScaleX(100), Res.gI().ScaleY(100)), new Vector2(3, 0), 1000));

        }

        public void update(GameTime gametime)
        {
            foreach (AI_basic AI in AI_w2l2_2)
            {
                AI.update(gametime);
            }
        }

        public void Draw(SpriteBatch spritebatch)
        {
            foreach (AI_basic AI in AI_w2l2_2)
            {
                AI.Draw(spritebatch);
            }
        }
        public List<Rectangle> getListRectangle() 
        {
            ListHitbox = new List<Rectangle>();
            foreach (AI_basic AI in AI_w2l2_2)
	        {
                ListHitbox.Add(AI.Hitbox);
	        }
            return ListHitbox;
        }
    }
}
