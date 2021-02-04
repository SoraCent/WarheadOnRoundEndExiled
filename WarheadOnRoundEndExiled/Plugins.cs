using System;
using Exiled.API.Features;

namespace WarheadOnRoundEndExiled
{
    public class WarheadOnRoundEndExiled : Plugin<Config>
    {
        public override string Name => nameof(WarheadOnRoundEndExiled);
        public override string Author => "SoraCént";
        public override Version Version => new Version(1, 2, 1);
        public override Version RequiredExiledVersion => new Version(2, 1, 28);

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

        public override void OnReloaded() { }
    }
}