using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Projet_2._0
{
    class Spikes
    {
        List<Rectangle> spikes = new List<Rectangle>();
        public Spikes()
        {
            spikes.Add(new Rectangle(Res.gI().ScaleX(1040), Res.gI().ScaleY(880), Res.gI().ScaleX(80), Res.gI().ScaleY(80)));
            spikes.Add(new Rectangle(Res.gI().ScaleX(1760), Res.gI().ScaleY(880), Res.gI().ScaleX(240), Res.gI().ScaleY(80)));
            spikes.Add(new Rectangle(Res.gI().ScaleX(2240), Res.gI().ScaleY(80), Res.gI().ScaleX(160), Res.gI().ScaleY(80)));
            spikes.Add(new Rectangle(Res.gI().ScaleX(3240), Res.gI().ScaleY(640), Res.gI().ScaleX(80), Res.gI().ScaleY(80)));
            spikes.Add(new Rectangle(Res.gI().ScaleX(3360), Res.gI().ScaleY(720), Res.gI().ScaleX(80), Res.gI().ScaleY(80)));
            spikes.Add(new Rectangle(Res.gI().ScaleX(3800), Res.gI().ScaleY(880), Res.gI().ScaleX(1120), Res.gI().ScaleY(80)));
            spikes.Add(new Rectangle(Res.gI().ScaleX(4160), Res.gI().ScaleY(80), Res.gI().ScaleX(80), Res.gI().ScaleY(480)));
        }
        public List<Rectangle> getList()
        {
            return spikes;
        }
    }
}
