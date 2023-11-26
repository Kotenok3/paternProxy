namespace paternProxy;

public class ProxyUser : IUser
{
    private RealUser realUser;
    private int userId;
    private UserContext dataBase;

    public ProxyUser(int id, UserContext dataBase)
    {
        userId = id;
        this.dataBase = dataBase;
    }

    public string GetInfo()
    {
        if (realUser == null)
        { 
            realUser = new RealUser(userId, dataBase);
            Console.WriteLine("Взяли пользователся из базы");
        }
        else
        {
            Console.WriteLine("Взяли пользователся из кэша");
        }
        
        return realUser.GetInfo();
    }
}