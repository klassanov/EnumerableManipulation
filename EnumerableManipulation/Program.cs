// See https://aka.ms/new-console-template for more information
using EnumerableManipulation;

var collection1 = new string[] { "To6ko" };
var collection2 = new string[] { "To6ko", "Mitko" };
var collection3 = new string[] { "To6ko", "Mitko", "Zai4o" };
var collection4 = new string[] { "To6ko", "Mitko", "Zai4o", "Bai4o" };
var collection5 = new string[] { "To6ko", "Mitko", "Zai4o", "Bai4o", "Val4o" };

Console.WriteLine(collection1.GetMiddleElement()); //To6ko
Console.WriteLine(collection2.GetMiddleElement()); //Mitko
Console.WriteLine(collection3.GetMiddleElement()); //Mitko
Console.WriteLine(collection4.GetMiddleElement()); //Zai4o
Console.WriteLine(collection5.GetMiddleElement()); //Zai4o