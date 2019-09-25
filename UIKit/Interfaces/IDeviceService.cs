using UIKit.Models;

namespace UIKit.Interfaces
{
    public interface IDeviceService
    {
        Device GetDevice(int deviceId);
    }
}
