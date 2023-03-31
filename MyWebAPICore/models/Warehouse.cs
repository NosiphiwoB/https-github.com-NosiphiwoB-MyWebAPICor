using System.Reflection;
namespace MyWebAPICore.models;


public class WareHouse
{

    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyLocation { get; set; }



    public WareHouse(int companyId, string companyName , string companyLocation)
    {
        this.CompanyId = companyId;
        this.CompanyName = companyName;
        this.CompanyLocation = companyLocation;
    }


}
