using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Projet_2._0.Levels
{
    class W1L3
    {
        List<Rectangle> w1l3 = new List<Rectangle>();

        public W1L3()
        {
            w1l3.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(0), Res.gI().ScaleX(2240), Res.gI().ScaleY(80)));
            w1l3.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(80), Res.gI().ScaleX(40), Res.gI().ScaleY(880)));
            w1l3.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(960), Res.gI().ScaleX(2240), Res.gI().ScaleY(80)));
            w1l3.Add(new Rectangle(Res.gI().ScaleX(40), Res.gI().ScaleY(80), Res.gI().ScaleX(120), Res.gI().ScaleY(360)));
            w1l3.Add(new Rectangle(Res.gI().ScaleX(40), Res.gI().ScaleY(680), Res.gI().ScaleX(120), Res.gI().ScaleY(280)));
            //w1l3.Add(new Rectangle(Res.gI().ScaleX(160), Res.gI().ScaleY(80), Res.gI().ScaleX(240), Res.gI().ScaleY(80))); //spikes
            //w1l3.Add(new Rectangle(Res.gI().ScaleX(160), Res.gI().ScaleY(880), Res.gI().ScaleX(1960), Res.gI().ScaleY(80))); //spikes
            w1l3.Add(new Rectangle(Res.gI().ScaleX(340), Res.gI().ScaleY(640), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l3.Add(new Rectangle(Res.gI().ScaleX(420), Res.gI().ScaleY(320), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l3.Add(new Rectangle(Res.gI().ScaleX(740), Res.gI().ScaleY(480), Res.gI().ScaleX(80), Res.gI().ScaleY(80)));
            w1l3.Add(new Rectangle(Res.gI().ScaleX(820), Res.gI().ScaleY(200), Res.gI().ScaleX(640), Res.gI().ScaleY(80)));
            w1l3.Add(new Rectangle(Res.gI().ScaleX(900), Res.gI().ScaleY(746), Res.gI().ScaleX(80), Res.gI().ScaleY(80)));
            w1l3.Add(new Rectangle(Res.gI().ScaleX(1300), Res.gI().ScaleY(746), Res.gI().ScaleX(80), Res.gI().ScaleY(80)));
            w1l3.Add(new Rectangle(Res.gI().ScaleX(1460), Res.gI().ScaleY(480), Res.gI().ScaleX(80), Res.gI().ScaleY(80)));
            w1l3.Add(new Rectangle(Res.gI().ScaleX(1620), Res.gI().ScaleY(320), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l3.Add(new Rectangle(Res.gI().ScaleX(1700), Res.gI().ScaleY(640), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            //w1l3.Add(new Rectangle(Res.gI().ScaleX(1880), Res.gI().ScaleY(80), Res.gI().ScaleX(240), Res.gI().ScaleY(80))); //spikes
            w1l3.Add(new Rectangle(Res.gI().ScaleX(2120), Res.gI().ScaleY(80), Res.gI().ScaleX(120), Res.gI().ScaleY(880)));
        }

        public List<Rectangle> getList()
        {
            return w1l3;
        }
    }
}
