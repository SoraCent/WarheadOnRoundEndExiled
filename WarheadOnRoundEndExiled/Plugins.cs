using Exiled.API.Features;

namespace WarheadOnRoundEndExiled
{
    public class WarheadOnRoundEndExiled : Plugin<Config>
    {
        public override string Name => nameof(WarheadOnRoundEndExiled);
        public override string Author => "SoraCént";
        public EventHandler Handler;

        public override void OnEnabled()
        {
            Log.Info("WarheadOnRoundEndExiled Plugin Activated!");
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