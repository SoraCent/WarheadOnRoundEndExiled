using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WarheadOnRoundEndExiled
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("How long until the Warhead explodes after Round End in Seconds | Default = 5")]
        public uint DetonationTimer { get; set; } = 5;
    }
}
