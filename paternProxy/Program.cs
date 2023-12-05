using System.Diagnostics;
using paternProxy;

using UserContext db = new UserContext();

if(db.Users.Count() == 0)
{
    List<UserInfo> data = new()
    {
        new UserInfo(1, "Name: Анна Иванова, Age: 28"),
        new UserInfo(2, "Name: Иван Петров, Age: 35"),
        new UserInfo(3, "Name: Елена Смирнова, Age: 42"),
        new UserInfo(4, "Name: Александр Козлов, Age: 25"),
        new UserInfo(5, "Name: Татьяна Новикова, Age: 31"),
        new UserInfo(6, "Name: Дмитрий Морозов, Age: 40"),
        new UserInfo(7, "Name: Ольга Павлова, Age: 22"),
        new UserInfo(8, "Name: Сергей Соколов, Age: 38"),
        new UserInfo(9, "Name: Мария Федорова, Age: 45"),
        new UserInfo(10, "Name: Андрей Кузнецов, Age: 29"),
        new UserInfo(11, "Name: Юлия Лебедева, Age: 33"),
        new UserInfo(12, "Name: Павел Васнецов, Age: 26"),
        new UserInfo(13, "Name: Наталья Захарова, Age: 39"),
        new UserInfo(14, "Name: Максим Андреев, Age: 27"),
        new UserInfo(15, "Name: Екатерина Яковлева, Age: 32"),
        new UserInfo(16, "Name: Владимир Сергеев, Age: 36")
    };
    db.Users.AddRange(data);
    db.SaveChanges();
}
var user = new ProxyUser(10,db);

var stopwatch = new Stopwatch();
Console.WriteLine(db.Users.Count());
stopwatch.Start();
Console.WriteLine(user.GetInfo());
stopwatch.Stop();
Console.WriteLine($"Выполнено за {stopwatch.ElapsedTicks} тиков");
stopwatch.Reset();

stopwatch.Start();
Console.WriteLine(user.GetInfo());
stopwatch.Stop();
Console.WriteLine($"Выполнено за {stopwatch.ElapsedTicks} тиков");
stopwatch.Reset();
foreach (var dbUser in db.Users)
{
    if (dbUser.Id == 10)
    {
        dbUser.Info = "Name: Андрей Кузнецов, Age:30";
        db.SaveChanges();
        break;
    }
}

stopwatch.Start();
Console.WriteLine(user.GetInfo());
stopwatch.Stop();
Console.WriteLine($"Выполнено за {stopwatch.ElapsedTicks} тиков");
stopwatch.Reset();

stopwatch.Start();
Console.WriteLine(user.GetInfo());
stopwatch.Stop();
Console.WriteLine($"Выполнено за {stopwatch.ElapsedTicks} тиков");
stopwatch.Reset();