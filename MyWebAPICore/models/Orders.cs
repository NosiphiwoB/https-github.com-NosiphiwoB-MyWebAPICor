using System.Reflection;
namespace MyWebAPICore.models
{


    public class Orders
    {
        public int UserId { get; set; }
       public string ProductName { get; set; }



    public Orders (int userId, string productName)
    {
        this.UserId = userId;
        this.ProductName = productName;
    } 

    }


}