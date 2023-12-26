using Sana05;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

MyDate StartDate = new MyDate(2006,02,13,4,00);
MyDate FinishDate = new MyDate(2006, 03,13, 17, 00);
Airplane flight1 = new Airplane("Kyiv","Lviv",StartDate,FinishDate);
Console.WriteLine($"{flight1.GetTotalTime()}");
if(flight1.IsArrivingToday() == true)
    Console.Write("Відправлення і прибуття відбудеться в один день");
else Console.Write("Відправлення і прибуття не відбудеться в один день");