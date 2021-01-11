[![forthebadge](https://forthebadge.com/images/badges/built-with-love.svg)](https://forthebadge.com)[![forthebadge](https://forthebadge.com/images/badges/check-it-out.svg)](https://forthebadge.com)[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)

# WarheadOnRoundEndExiled
It's a Simple SCP:SL Plugin for Exiled that activating the Alpha Warhead when the Round is over and the set Team has Won the Round. The Alpha Warhead Detonates in the Time set in the Config.

# Config:
| Name | Type | Description | Default |
| ---- | ---- | ---- | ---- |
| IsEnabled | bool | Is the Plugin enabled | true |
| detonation_timer | uint | Detonation Time | 5 |
| CustomEndConditionEnabled | bool | Should Custom End Condition be enabled | false |
| FractionsEndCondition | List<string> | List of End Conditions | FacilityForces, ChaosInsurgency, Anomalies, Draw |

## Default Config
```yml
warhead_on_round_end_exiled:
  is_enabled: true
  # How long until the Warhead explodes after Round End in Seconds | Default = 5
  detonation_timer: 5
  # Enable Custom End Condition like SCPs Won or a Draw.
  custom_end_condition_enabled: false
  # List of EndConditions: FacilityForces = MTF Won, ChaosInsurgency = D-Boys Won, Anomalies = SCPs Won, Draw = It's a Draw. If you set all, the warhead always explodes after round.
  fractions_end_condition:
  - FacilityForces
  - ChaosInsurgency
  - Anomalies
  - Draw
```

## EndConditions
- FacilityForces - Triggers when MTF has won the Round
- ChaosInsurgency - Triggers when Class-D has won the Round
- Anomalies - Triggers when the SCP's won the Round
- Draw - Triggers when it's a stalemate

How to achieve each Ending you can see this Flowchart: [Win Condition Flowchart on Reddit](https://www.reddit.com/r/SCPSecretLab/comments/gzyl0t/win_condition_flowchart/)

# Upcoming Features:
- Nothing.

You can Send Suggestions or Ideas to me.
