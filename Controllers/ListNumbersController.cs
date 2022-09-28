using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
namespace LoadBalancerProject_ScalableService.Controllers;

[ApiController]
[Route("[controller]")]
public class ListNumbersController : ControllerBase
{


    [HttpGet("{number}")]
    public IEnumerable<int> Get(int number)
    {
        List<int> numberList = new List<int>();

        for (int i = 0; i < number; i++)
        {
            numberList.Add(i);
        }
        return numberList.ToArray();
    }

}
