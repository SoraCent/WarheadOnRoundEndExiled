﻿using System;
using Exiled.API.Features;

namespace WarheadOnRoundEndExiled
{
    public class WarheadOnRoundEndExiled : Plugin<Config>
    {
        public override string Author => "SoraCént";
        public override Version Version => new Version(1, 3, 2);
        public override Version RequiredExiledVersion => new Version(2, 8, 0);

        public EventHandler Handler;

        public override void OnEnabled()
        {
            base.OnEnabled();

            Handler = new EventHandler(this);
            Exiled.Events.Handlers.Server.RoundEnded += Handler.OnEndingRoundEvent;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Exiled.Events.Handlers.Server.RoundEnded -= Handler.OnEndingRoundEvent;
            Handler = null;
        }
    }
}