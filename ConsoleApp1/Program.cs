using Clean_arch.Domain.Shared;
using Clean_arch.Domain.Users;
using Clean_arch.Domain.Users.ValueObjects;

var mony = Mony.FromTooman(10000);
var mony2 = Mony.FromTooman(12000);
var mony3 = mony + mony2;
Console.WriteLine(mony3.ToString());
Console.WriteLine(mony == mony2);

var user = new User("dasdas", "dasdsa", new
    PhoneBook(new PhoneNumber("09170000000"), new PhoneNumber("09170000000")));

var user2 = new User("dasdas", "dasdsa", new
    PhoneBook(new PhoneNumber("09170000000"), new PhoneNumber("09170000000")));


Console.WriteLine(user.PhoneBook == user2.PhoneBook);
