using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Projet_2._0.Levels
{
    class Sw1l2
    {
        List<Rectangle> sw1l2 = new List<Rectangle>();
        public Sw1l2()
        {
            sw1l2.Add(new Rectangle(Res.gI().ScaleX(120), Res.gI().ScaleY(880), Res.gI().ScaleX(1120), Res.gI().ScaleY(80))); //spikes
            sw1l2.Add(new Rectangle(Res.gI().ScaleX(320), Res.gI().ScaleY(680), Res.gI().ScaleX(80), Res.gI().ScaleY(80))); //spikes
            sw1l2.Add(new Rectangle(Res.gI().ScaleX(400), Res.gI().ScaleY(360), Res.gI().ScaleX(80), Res.gI().ScaleY(80))); //spikes
            sw1l2.Add(new Rectangle(Res.gI().ScaleX(1320), Res.gI().ScaleY(880), Res.gI().ScaleX(3600), Res.gI().ScaleY(80))); //spikes
            sw1l2.Add(new Rectangle(Res.gI().ScaleX(3560), Res.gI().ScaleY(480), Res.gI().ScaleX(80), Res.gI().ScaleY(280))); //spikes
        }

        public List<Rectangle> getList()
        {
            return sw1l2;
        }
    }
}
