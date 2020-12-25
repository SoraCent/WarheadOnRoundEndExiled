using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEC;

namespace WarheadOnRoundEndExiled
{
    public class EventHandler
    {
        public WarheadOnRoundEndExiled plugin;
        public EventHandler(WarheadOnRoundEndExiled plugin) => this.plugin = plugin;

        public void OnEndingRoundEvent(EndingRoundEventArgs ev)
        {
            if (ev.IsAllowed && ev.IsRoundEnded && !Warhead.IsDetonated)
            {
                Warhead.Start();
                Warhead.DetonationTimer = 5;
                Warhead.Shake();
            }
        }
    }
}
