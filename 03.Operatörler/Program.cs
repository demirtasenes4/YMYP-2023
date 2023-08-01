// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Operatörler
//= eşittir operatörü => değer ataması yapar
//== kontrol operatörü => a ve b değerini kontrol eder

int a = 0;
int b = 1;

var c = (a == b);

// + - * / Matematiksel operatörler

int r = ((5 * 2) + 5 - 0);

int z = 1;

z += 5;

int x = 1;

x++;
x--;

//+ operatörü string değerlerde birleştirme işlemi yapar;

string name = "Enes" + " " + "Demirtas"; // Enes Demirtaş
string name2 = $"{name} 27 yaşında bir mühendis"; // ==> Enes Demirtaş 27 yaşında bir eğitmen

//@ operatörü \ ters bölü işaretini kullanmamızı sağlayan operatör
string url = @"http:\";
 
//% => mod operatörü sayının verilen sayıya tam bölünüp bölünmediğini kontrol eder 0 veya küsürat dönüyor

var r2 = (x % 2);

