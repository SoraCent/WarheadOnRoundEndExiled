using Exiled.API.Features;

namespace WarheadOnRoundEndExiled
{
    public class WarheadOnRoundEndExiled : Plugin<Config>
    {
        public static WarheadOnRoundEndExiled WarheadOnRoundEndExiledRef { get; private set; }
        public override string Name => nameof(WarheadOnRoundEndExiled);
        public override string Author => "SoraCént";
        public EventHandler Handler;

        public WarheadOnRoundEndExiled()
        {
            WarheadOnRoundEndExiledRef = this;
        }

        public override void OnEnabled()
        {
            Log.Info("WarheadOnRoundEndExiled Plugin Aktiviert!");
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