using System.Collections.Generic;
using System.Linq;
using UIKit.Interfaces;
using UIKit.Models;

namespace UIKit.Services
{
    public class DeviceService : IDeviceService
    {
        public List<Device> DataDevices = new List<Device>
        {
            new Device {DeviceId = 1, Name = "Light Bulb", Info = "The light bulb is supplied with electric current by terminals or wires embedded in the glass.", IsOnlineOffline = false}
        };

        public Device GetDevice(int deviceId)
        {
            return DataDevices.FirstOrDefault(_ => _.DeviceId == deviceId);
        }
    }
}