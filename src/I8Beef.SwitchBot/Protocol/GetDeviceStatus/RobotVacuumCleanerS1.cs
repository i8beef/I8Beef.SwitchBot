using Newtonsoft.Json;

namespace I8Beef.SwitchBot.Protocol.GetDeviceStatus
{
    /// <summary>
    /// Robot Vacuum Cleaner S1 device type.
    /// </summary>
    public class RobotVacuumCleanerS1 : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.RobotVacuumCleanerS1;

        /// <summary>
        /// The working status of the device. StandBy, Clearing, Paused, GotoChargeBase, Charging, ChargeDone, Dormant, InTrouble, InRemoteControl, or InDustCollecting.
        /// </summary>
        [JsonProperty(PropertyName = "workingStatus")]
        public string WorkingStatus { get; set; }

        /// <summary>
        /// Ohe connection status of the device. online or offline.
        /// </summary>
        [JsonProperty(PropertyName = "onlineStatus")]
        public string OnlineStatus { get; set; }

        /// <summary>
        /// The current battery level.
        /// </summary>
        [JsonProperty(PropertyName = "battery")]
        public int Battery { get; set; }
    }
}
