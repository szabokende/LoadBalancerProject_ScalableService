using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
namespace LoadBalancerProject_ScalableService.Controllers;

[ApiController]
[Route("[controller]")]
public class ConnectionController : ControllerBase
{

    [HttpGet]
    public int Get()
    {
        return ShowActiveTcpConnections();

    }
    public static int ShowActiveTcpConnections()
    {
        Console.WriteLine("Active TCP Connections");
        IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
        TcpConnectionInformation[] connections = properties.GetActiveTcpConnections();
        System.Console.WriteLine("number of connections: " + connections.Count().ToString());

        return connections.Count();
    }
}
