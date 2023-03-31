using Microsoft.AspNetCore.Mvc;

using MyWebAPICore.models;


namespace MyWebAPICore.Controllers
{


[ApiController]
[Route("[controller]")]

    public class WareHouseController : ControllerBase
    {
        public static List<WareHouse> wareHouse = new List<WareHouse>();

         [HttpGet(Name = "WareHouse")]
        public List<WareHouse> GetWareHouses()
        {
            return wareHouse;
        }

        [HttpPost()]
        public void PostWareHouse(WareHouse company)
        {
            wareHouse.Add(company);
        }

    }
}