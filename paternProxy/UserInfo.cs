namespace paternProxy;

public class UserInfo
{
    public int Id { set; get; }
    public string Info { set; get; }
    public UserInfo(int id, string info)
    {
        Id = id;
        Info = info;
    }
}
