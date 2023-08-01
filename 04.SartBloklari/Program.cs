using System.ComponentModel.Design;


Console.WriteLine("Hello, World!");


//if bloğu
//else if bloğu
//switch bloğu

int a = 1;
int b = 3;

if (a < 3)
{ //scope
    Console.WriteLine("a değeri 3'ten küçük bir değer!");
}
else if (a > 3)
{
    Console.WriteLine("a değeri 3'ten daha büyük bir değer");
}
else
{
    Console.WriteLine("a değeri 3'e eşittir");
}

if (b < 3)
{ //scope
    Console.WriteLine("b değeri 3'ten küçük bir değer!");
}
else if (b > 3)
{
    Console.WriteLine("b değeri 3'ten daha büyük bir değer");
}
else
{
    Console.WriteLine("b değeri 3'e eşittir");
}

    //syntax => bir kodun nasıl yazılması gerektiğidir
    //&& => ve operatörü
    //|| => veya operatörü

    //if (b == 3 && a < 3 || a == 3 || a > 3) ;
    //{
    //Console.WriteLine("Olumlu!");
    //}
    //else
    //{
    //Console.WriteLine("Olumsuz :(");
    //}

    int kdv = 1;

switch (kdv)
{
    case 1:
        //işlem
        Console.WriteLine("Ohh Çohşühür");
        break;
    case 10:
        //işlem2
        Console.WriteLine("Reyis sağolsun");
        break;
    case 20:
        //işlem3
        Console.WriteLine("Yuh amk");
        break;
}