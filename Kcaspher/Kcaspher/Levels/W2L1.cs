using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Projet_2._0.Levels
{
    public class W2L1
    {
        List<Rectangle> w2l1 = new List<Rectangle>();

        public W2L1()
        {
            w2l1.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(0), Res.gI().ScaleX(25), Res.gI().ScaleY(1050)));
            w2l1.Add(new Rectangle(Res.gI().ScaleX(1025), Res.gI().ScaleY(0), Res.gI().ScaleX(2520), Res.gI().ScaleY(25)));
            w2l1.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(0), Res.gI().ScaleX(2520), Res.gI().ScaleY(25)));
            w2l1.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(1025), Res.gI().ScaleX(2520), Res.gI().ScaleY(25)));
            w2l1.Add(new Rectangle(Res.gI().ScaleX(125), Res.gI().ScaleY(651), Res.gI().ScaleX(25), Res.gI().ScaleY(400)));
            w2l1.Add(new Rectangle(Res.gI().ScaleX(125), Res.gI().ScaleY(651), Res.gI().ScaleX(411), Res.gI().ScaleY(25)));
            w2l1.Add(new Rectangle(Res.gI().ScaleX(511), Res.gI().ScaleY(251), Res.gI().ScaleX(25), Res.gI().ScaleY(356)));
            w2l1.Add(new Rectangle(Res.gI().ScaleX(511), Res.gI().ScaleY(0), Res.gI().ScaleX(25), Res.gI().ScaleY(144)));
            w2l1.Add(new Rectangle(Res.gI().ScaleX(2370), Res.gI().ScaleY(0), Res.gI().ScaleX(25), Res.gI().ScaleY(589)));
            w2l1.Add(new Rectangle(Res.gI().ScaleX(2491), Res.gI().ScaleY(0), Res.gI().ScaleX(25), Res.gI().ScaleY(1050)));
            w2l1.Add(new Rectangle(Res.gI().ScaleX(367), Res.gI().ScaleY(755), Res.gI().ScaleX(97), Res.gI().ScaleY(218)));
            w2l1.Add(new Rectangle(Res.gI().ScaleX(1225), Res.gI().ScaleY(954), Res.gI().ScaleX(320), Res.gI().ScaleY(71)));
        }



        public List<Rectangle> getList()
        {
            return w2l1;
        }
    }
}
