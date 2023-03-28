using System.Reflection;
namespace MyWebAPICore.models;


public class Warehouse
{

    public int WareHouseId { get; set; }

    public string? WareHouseName { get; set; }



    public Warehouse(int wareHouseId, string warehouseName)
    {
        this.WareHouseId = wareHouseId;
        this.WareHouseName = warehouseName;
    }


}
