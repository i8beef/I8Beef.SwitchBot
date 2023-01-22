using System;
using I8Beef.SwitchBot.Protocol;
using I8Beef.SwitchBot.Protocol.GetDevices;
using Newtonsoft.Json.Linq;

namespace I8Beef.SwitchBot.JsonConverters
{
    /// <summary>
    /// The converter to use when deserializing device types.
    /// </summary>
    public class DeviceTypeJsonConverter : CustomJsonConverter<string>
    {
        /// <inheritdoc />
        protected override Type GetTargetType(Type objectType, JObject jsonObject)
        {
            // Examine the device type
            var typeName = jsonObject["deviceType"]?.ToString();

            // Based on the device type, instantiate and return a new object
            switch (typeName)
            {
                case DeviceTypes.BlindTilt:
                    return typeof(BlindTilt);
                case DeviceTypes.Bot:
                    return typeof(Bot);
                case DeviceTypes.CeilingLight:
                    return typeof(CeilingLight);
                case DeviceTypes.CeilingLightPro:
                    return typeof(CeilingLightPro);
                case DeviceTypes.ColorBulb:
                    return typeof(ColorBulb);
                case DeviceTypes.ContactSensor:
                    return typeof(ContactSensor);
                case DeviceTypes.Curtain:
                    return typeof(Curtain);
                case DeviceTypes.Hub:
                    return typeof(Hub);
                case DeviceTypes.HubPlus:
                    return typeof(HubPlus);
                case DeviceTypes.HubMini:
                    return typeof(HubMini);
                case DeviceTypes.Humidifier:
                    return typeof(Humidifier);
                case DeviceTypes.IndoorCam:
                    return typeof(IndoorCam);
                case DeviceTypes.Keypad:
                    return typeof(Keypad);
                case DeviceTypes.KeypadTouch:
                    return typeof(KeypadTouch);
                case DeviceTypes.Lock:
                    return typeof(Lock);
                case DeviceTypes.Meter:
                    return typeof(Meter);
                case DeviceTypes.MeterPlus:
                    return typeof(MeterPlus);
                case DeviceTypes.MotionSensor:
                    return typeof(MotionSensor);
                case DeviceTypes.PanTiltCam:
                    return typeof(PanTiltCam);
                case DeviceTypes.Plug:
                    return typeof(Plug);
                case DeviceTypes.PlugMiniJp:
                    return typeof(PlugMiniJp);
                case DeviceTypes.PlugMiniUs:
                    return typeof(PlugMiniUs);
                case DeviceTypes.Remote:
                    return typeof(Remote);
                case DeviceTypes.RobotVacuumCleanerS1:
                    return typeof(RobotVacuumCleanerS1);
                case DeviceTypes.RobotVacuumCleanerS1Plus:
                    return typeof(RobotVacuumCleanerS1Plus);
                case DeviceTypes.StripLight:
                    return typeof(StripLight);
                default:
                    return typeof(GenericDevice);
            }
        }
    }
}
