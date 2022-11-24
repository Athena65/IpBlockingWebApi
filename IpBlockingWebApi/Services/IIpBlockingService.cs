using System.Net;

namespace IpBlockingWebApi.Services
{
    public interface IIpBlockingService
    {
        bool IsBlocked(IPAddress ipAddress);
    }
}
