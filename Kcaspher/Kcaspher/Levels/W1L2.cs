using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Projet_2._0.Levels
{
    class W1L2
    {
        List<Rectangle> w1l2 = new List<Rectangle>();

        public W1L2()
        {
            w1l2.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(0), Res.gI().ScaleX(5040), Res.gI().ScaleY(80)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(80), Res.gI().ScaleX(120), Res.gI().ScaleY(880)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(960), Res.gI().ScaleX(5040), Res.gI().ScaleY(80)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(120), Res.gI().ScaleY(280), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            //w1l2.Add(new Rectangle(Res.gI().ScaleX(120), Res.gI().ScaleY(880), Res.gI().ScaleX(1120), Res.gI().ScaleY(80))); //spikes
            w1l2.Add(new Rectangle(Res.gI().ScaleX(240), Res.gI().ScaleY(280), Res.gI().ScaleX(80), Res.gI().ScaleY(560)));
            //w1l2.Add(new Rectangle(Res.gI().ScaleX(320), Res.gI().ScaleY(680), Res.gI().ScaleX(80), Res.gI().ScaleY(80))); //spikes
            w1l2.Add(new Rectangle(Res.gI().ScaleX(320), Res.gI().ScaleY(760), Res.gI().ScaleX(400), Res.gI().ScaleY(80)));
            //w1l2.Add(new Rectangle(Res.gI().ScaleX(400), Res.gI().ScaleY(360), Res.gI().ScaleX(80), Res.gI().ScaleY(80))); //spikes
            w1l2.Add(new Rectangle(Res.gI().ScaleX(480), Res.gI().ScaleY(80), Res.gI().ScaleX(80), Res.gI().ScaleY(480)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(560), Res.gI().ScaleY(480), Res.gI().ScaleX(80), Res.gI().ScaleY(80)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(760), Res.gI().ScaleY(360), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(800), Res.gI().ScaleY(640), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(1240), Res.gI().ScaleY(80), Res.gI().ScaleX(80), Res.gI().ScaleY(120)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(1240), Res.gI().ScaleY(480), Res.gI().ScaleX(80), Res.gI().ScaleY(480)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(1320), Res.gI().ScaleY(560), Res.gI().ScaleX(960), Res.gI().ScaleY(80)));
            //w1l2.Add(new Rectangle(Res.gI().ScaleX(1320), Res.gI().ScaleY(880), Res.gI().ScaleX(3600), Res.gI().ScaleY(80))); //spikes
            w1l2.Add(new Rectangle(Res.gI().ScaleX(2200), Res.gI().ScaleY(640), Res.gI().ScaleX(80), Res.gI().ScaleY(200)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(2280), Res.gI().ScaleY(760), Res.gI().ScaleX(1440), Res.gI().ScaleY(80)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(2480), Res.gI().ScaleY(440), Res.gI().ScaleX(160), Res.gI().ScaleY(80)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(2760), Res.gI().ScaleY(400), Res.gI().ScaleX(960), Res.gI().ScaleY(80)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(2920), Res.gI().ScaleY(80), Res.gI().ScaleX(80), Res.gI().ScaleY(320)));
            //w1l2.Add(new Rectangle(Res.gI().ScaleX(3560), Res.gI().ScaleY(480), Res.gI().ScaleX(80), Res.gI().ScaleY(280))); //spikes
            w1l2.Add(new Rectangle(Res.gI().ScaleX(3640), Res.gI().ScaleY(480), Res.gI().ScaleX(80), Res.gI().ScaleY(280)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(4440), Res.gI().ScaleY(760), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l2.Add(new Rectangle(Res.gI().ScaleX(4920), Res.gI().ScaleY(80), Res.gI().ScaleX(120), Res.gI().ScaleY(880)));
        }

        public List<Rectangle> getList()
        {
            return w1l2;
        }
    }
}
