namespace paternProxy;

public class RealUser : IUser
{
    private UserInfo _userInfo;
    private UserContext _dbContext;

    public RealUser(int id, UserContext dbContext)
    {
        _dbContext = dbContext;
        var userInfo = _dbContext.Users.FirstOrDefault(u => u.Id == id);
        if (userInfo == null)
            throw new ArgumentException("Нет пользователся с таким Id");
        _userInfo = userInfo;
    }

    public string GetInfo()
    {
        return _userInfo.Info;
    }
}