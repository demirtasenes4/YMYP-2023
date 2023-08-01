// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//[ ] => listeleri temsil eder => arra işareti

//string[] names = { "araba", "armut" };
//index numarası dersek => 0'dan başlar
//string[] names = new string[3];

//names[0] = "Enes";
//names[1] = "Enes";
//names[2] = "Enes";

//List<string> names = new List<string>(); { "Armut", "Elma" };

List<string> names = new(); //örneğe dönüştürmek için new kelimesini kullanıyoruz. Örneğe dönüştürme işlemine yazılımda instance üretme deniyor.

names.Add("Enes");
names.Add("Enes");
names.Add("Enes");
names.Add("Enes");
names.Add("Enes");
names.Add("Enes");

names[3] = "Enes'in günlüğü";

Console.WriteLine(names[3]);