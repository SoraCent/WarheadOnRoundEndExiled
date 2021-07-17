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

        public void OnEndingRoundEvent(RoundEndedEventArgs ev)
        {
            if (Warhead.IsDetonated) return;

            if(plugin.Config.CustomEndConditionEnabled)
            {
                if(plugin.Config.FactionsEndCondition.Contains(ev.LeadingTeam))
                {
                    StartWarhead(ev);
                }
            } 
            else
            {
                StartWarhead(ev);
            }
        }

        public void StartWarhead(RoundEndedEventArgs ev)
        {
            uint DetonationTimer = plugin.Config.DetonationTimer;
            // Checks if the DetonationTimer set in the Config is 0 or lower for instant Detonate.
            if (DetonationTimer <= 0)
            {
                Warhead.Detonate();
            }
            // Checks if the DetonationTimer set in the Config is longer then the RoundRestartTimer.
            else if (ev.TimeToRestart <= DetonationTimer)
            {
                Warhead.Start();
                Warhead.DetonationTimer = 5;
            }
            else
            {
                Warhead.Start();
                Warhead.DetonationTimer = DetonationTimer;
            }
        }
    }
}
