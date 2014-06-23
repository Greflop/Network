using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Projet_2._0.Levels
{
    public class W2L3
    {
        List<Rectangle> w2l3 = new List<Rectangle>();

        public W2L3()
        {

            w2l3.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(0), Res.gI().ScaleX(2520), Res.gI().ScaleY(25)));
            w2l3.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(0), Res.gI().ScaleX(25), Res.gI().ScaleY(1050)));
            w2l3.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(1025), Res.gI().ScaleX(2520), Res.gI().ScaleY(25)));
            w2l3.Add(new Rectangle(Res.gI().ScaleX(125), Res.gI().ScaleY(701), Res.gI().ScaleX(25), Res.gI().ScaleY(350)));
            w2l3.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(195), Res.gI().ScaleX(75), Res.gI().ScaleY(25)));
            w2l3.Add(new Rectangle(Res.gI().ScaleX(119), Res.gI().ScaleY(195), Res.gI().ScaleX(75), Res.gI().ScaleY(25)));
            w2l3.Add(new Rectangle(Res.gI().ScaleX(169), Res.gI().ScaleY(0), Res.gI().ScaleX(25), Res.gI().ScaleY(220)));
            w2l3.Add(new Rectangle(Res.gI().ScaleX(885), Res.gI().ScaleY(0), Res.gI().ScaleX(25), Res.gI().ScaleY(323)));
            w2l3.Add(new Rectangle(Res.gI().ScaleX(885), Res.gI().ScaleY(653), Res.gI().ScaleX(25), Res.gI().ScaleY(397)));
            w2l3.Add(new Rectangle(Res.gI().ScaleX(359), Res.gI().ScaleY(34), Res.gI().ScaleX(379), Res.gI().ScaleY(90)));
            w2l3.Add(new Rectangle(Res.gI().ScaleX(2187), Res.gI().ScaleY(350), Res.gI().ScaleX(104), Res.gI().ScaleY(342)));
            w2l3.Add(new Rectangle(Res.gI().ScaleX(2491), Res.gI().ScaleY(0), Res.gI().ScaleX(25), Res.gI().ScaleY(1050)));
        }



        public List<Rectangle> getList()
        {
            return w2l3;
        }
    }
}
