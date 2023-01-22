namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Robot Vacuum Cleaner S1 device type.
    /// </summary>
    public class RobotVacuumCleanerS1 : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.RobotVacuumCleanerS1;
    }
}
