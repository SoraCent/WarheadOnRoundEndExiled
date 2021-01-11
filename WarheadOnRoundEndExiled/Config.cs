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

        [Description("Enable Custom End Condition like SCPs Won or a Draw.")]
        public bool CustomEndConditionEnabled { get; set; } = false;

        [Description("List of EndConditions: FacilityForces = MTF Won, ChaosInsurgency = D-Boys Won, Anomalies = SCPs Won, Draw = It's a Draw. If you set all, the warhead always explodes after round.")]
        public List<string> FractionsEndCondition { get; set; } = new List<string> 
        {
        "FacilityForces",
        "ChaosInsurgency",
        "Anomalies",
        "Draw"
        };
    }
}
