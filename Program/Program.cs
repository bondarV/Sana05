using Sana05;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

MyDate StartDate = new MyDate(2023,12,31,23,00);
MyDate FinishDate = new MyDate(2024,1,1,6,59);
Airplane flight1 = new Airplane("Kyiv","Lviv",StartDate,FinishDate);
Console.WriteLine($"Загальний політ з {flight1.StartCity} до {flight1.FinishCity} становить у хвилинах становить {flight1.GetTotalTime()}");
if (flight1.IsArrivingToday() == true)
    Console.Write("Відправлення і прибуття відбудеться в один день");
else Console.WriteLine ("Відправлення і прибуття не відбудеться в один день");

Currency currency1 = new Currency("EUR", 41.51F);
Product product1 = new Product("Samsung Galaxy S23 Ultra", 1000.500F, currency1, 10, "Samsung", 0.229F);
Console.WriteLine($"Ціна товару під назвою {product1.Name} у гривнях коштує = {product1.GetPriceInUAH()}");
Console.WriteLine($"Ціна товару під назвою {product1.Name} увесь який є на складі у гривнях коштує = {product1.GetTotalPriceInUAH()}");
Console.WriteLine($"Загальна вага товару під назвою {product1.Name} всього який наявний становить = {product1.GetTotalWeight()} кг");
