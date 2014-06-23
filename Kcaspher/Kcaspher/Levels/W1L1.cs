using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Projet_2._0.Levels
{
    class W1L1
    {
        List<Rectangle> w1l1 = new List<Rectangle>();

        public W1L1()
        {
            w1l1.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(0), Res.gI().ScaleX(5040), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(80), Res.gI().ScaleX(120), Res.gI().ScaleY(880)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(0), Res.gI().ScaleY(960), Res.gI().ScaleX(5040), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(560), Res.gI().ScaleY(880), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(680), Res.gI().ScaleY(800), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(800), Res.gI().ScaleY(720), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(1240), Res.gI().ScaleY(400), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(1320), Res.gI().ScaleY(720), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(1600), Res.gI().ScaleY(240), Res.gI().ScaleX(480), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(1600), Res.gI().ScaleY(880), Res.gI().ScaleX(80), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(1680), Res.gI().ScaleY(560), Res.gI().ScaleX(80), Res.gI().ScaleY(400)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(2242), Res.gI().ScaleY(400), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(2242), Res.gI().ScaleY(480), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(2482), Res.gI().ScaleY(280), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(2602), Res.gI().ScaleY(560), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(2722), Res.gI().ScaleY(280), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(2962), Res.gI().ScaleY(280), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(2960), Res.gI().ScaleY(480), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(2960), Res.gI().ScaleY(560), Res.gI().ScaleX(480), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(3202), Res.gI().ScaleY(280), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(3200), Res.gI().ScaleY(880), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(3320), Res.gI().ScaleY(640), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(3442), Res.gI().ScaleY(360), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(3440), Res.gI().ScaleY(720), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(3680), Res.gI().ScaleY(360), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(3680), Res.gI().ScaleY(880), Res.gI().ScaleX(120), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(3880), Res.gI().ScaleY(720), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(4240), Res.gI().ScaleY(80), Res.gI().ScaleX(80), Res.gI().ScaleY(480)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(4240), Res.gI().ScaleY(760), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(4400), Res.gI().ScaleY(440), Res.gI().ScaleX(80), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(4520), Res.gI().ScaleY(600), Res.gI().ScaleX(80), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(4600), Res.gI().ScaleY(320), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            w1l1.Add(new Rectangle(Res.gI().ScaleX(4920), Res.gI().ScaleY(80), Res.gI().ScaleX(120), Res.gI().ScaleY(880)));
        }

        public List<Rectangle> getList()
        {
            return w1l1;
        }
    }
}
