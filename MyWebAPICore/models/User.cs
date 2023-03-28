using System.Reflection;
namespace MyWebAPICore.models
{


    public class User
    {


    public string? UserName { get; set; }
       public string UserRole { get; set; }



    public User (string userName, string userRole)
    {
        this.UserName = userName;
        this.UserRole = userRole;
    } 
        
    }


}