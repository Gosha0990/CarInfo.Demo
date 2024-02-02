using CarInfo.CoreLib.Services;
using CarInfo.Demo.Models;

var carInfoService = new CarInfoService();
var car = new Car();
var wim = "mw6jc1inwscip8e82";
car.Wim = wim;

await Task.Delay(2000);

car.SetLocation(55.68740624329512, 37.59494390585138);
Console.WriteLine("Автомобиль находится в точке 55.68740624329512, 37.59494390585138");
await Task.Delay(2000);

var owner = new Owner();
owner.UsingCar(car ,56.29383105937935, 44.19520420521997);
await Task.Delay(2000);

Console.WriteLine("Автомобиль переместился в точку 56.29383105937935, 44.19520420521997");

owner.UsingCar(car, 59.87546659920895, 30.585432359428193);
await Task.Delay(2000);

Console.WriteLine("Автомобиль переместился в точку 59.87546659920895, 30.585432359428193");
owner.UsingCar(car, 59.87546659920895, 30.585432359428193);
await Task.Delay(2000);

owner.UsingCar(car, 56.78567304578879, 61.0488331947757);
Console.WriteLine("Автомобиль переместился в точку 56.78567304578879, 61.0488331947757");
await Task.Delay(2000);

Console.WriteLine("Текущий проб автомобиля {0}", (int)car.GetMileage());

Console.WriteLine("Пользователь принимает решение продать автомобиль.");

Console.WriteLine("Обращается к хакеру для того, чтобы изменить пробег автомобиля.");

var hacker = new Hacker();

hacker.ChangeMileage(car);

Console.WriteLine("Хакер выполнил свою работу.");
Console.WriteLine("Текущий пробег {0}", car.GetMileage());

Console.WriteLine("Пользователь автомобиля находит покупателя.");
var buyer = new Buyer();

Console.WriteLine("Покупатель проверяет пробег в машине. Пробег в ато: {0}", (int)car.GetMileage());
Console.WriteLine("Покупатель запрашивает пробег в сервисном центре. " +
    "\nИнформация из сервисного центра " +
    "\nСерийный номер автомобиля: {0}" +
    "\nПробег: {1}" ,car.Wim, (int)carInfoService.GetMileage(car.Wim));

Console.WriteLine("Обман разоблачен!");

Console.ReadLine();