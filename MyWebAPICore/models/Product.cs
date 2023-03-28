using System.Reflection;
namespace MyWebAPICore.models;


public class Product
{

    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public int WareHouseId {get ; set ;}

    public Product(int productId, string productName , int wareHouseId)
    {
        this.ProductId = productId;
        this.ProductName = productName;
        this.WareHouseId = wareHouseId;
    }


    public string getProductName (){
        return "this is my favourite product" + this.ProductName;
    }

}
