using Sana05;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

MyDate StartDate = new MyDate(2023,12,31,23,00);
MyDate FinishDate = new MyDate(2024,1,1,6, 51);
Airplane flight1 = new Airplane("Kyiv","Lviv",StartDate,FinishDate);
Console.WriteLine($"{flight1.GetTotalTime()}");
if(flight1.IsArrivingToday() == true)
    Console.Write("Відправлення і прибуття відбудеться в один день");
else Console.Write("Відправлення і прибуття не відбудеться в один день");