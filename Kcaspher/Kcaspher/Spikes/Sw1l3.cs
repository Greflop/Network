using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Projet_2._0
{
    class Sw1l3
    {
        List<Rectangle> sw1l3 = new List<Rectangle>();

        public Sw1l3()
        {
            sw1l3.Add(new Rectangle(Res.gI().ScaleX(160), Res.gI().ScaleY(80), Res.gI().ScaleX(240), Res.gI().ScaleY(80))); //spikes
            sw1l3.Add(new Rectangle(Res.gI().ScaleX(160), Res.gI().ScaleY(880), Res.gI().ScaleX(1960), Res.gI().ScaleY(80))); //spikes
            sw1l3.Add(new Rectangle(Res.gI().ScaleX(1880), Res.gI().ScaleY(80), Res.gI().ScaleX(240), Res.gI().ScaleY(80))); //spikes
        }

        public List<Rectangle> getList()
        {
            return sw1l3;
        }
    }
}
