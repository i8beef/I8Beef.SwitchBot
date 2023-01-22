namespace I8Beef.SwitchBot.Protocol.GetDevices
{
    /// <summary>
    /// Robot Vacuum Cleaner S1 Plus device type.
    /// </summary>
    public class RobotVacuumCleanerS1Plus : DeviceBase
    {
        /// <inheritdoc />
        public override string DeviceType { get; set; } = DeviceTypes.RobotVacuumCleanerS1Plus;
    }
}
