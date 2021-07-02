using System;
using Exiled.API.Features;

namespace WarheadOnRoundEndExiled
{
    public class WarheadOnRoundEndExiled : Plugin<Config>
    {
        public override string Author => "SoraCént";
        public override Version Version => new Version(1, 3, 0);
        public override Version RequiredExiledVersion => new Version(2, 8, 0);

        public EventHandler Handler;

        public override void OnEnabled()
        {
            Handler = new EventHandler(this);
            Exiled.Events.Handlers.Server.RoundEnded += Handler.OnEndingRoundEvent;
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundEnded -= Handler.OnEndingRoundEvent;
            Handler = null;
        }
    }
}