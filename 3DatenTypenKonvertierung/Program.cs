using System;

Console.WriteLine($"size of short ={sizeof(short)}");
Console.WriteLine($"size of short ={sizeof(short)}");
Console.WriteLine($"short.MinValue = {short.MinValue}");
Console.WriteLine($"short.MaxValue = {short.MaxValue}");

Console.WriteLine($"size of int ={sizeof(int)}");
Console.WriteLine($"size of int ={sizeof(int)}");
Console.WriteLine($"int.MinValue = {int.MinValue}");
Console.WriteLine($"int.MaxValue = {int.MaxValue}");

Console.WriteLine($"size of long ={sizeof(long)}");
Console.WriteLine($"size of long ={sizeof(long)}");
Console.WriteLine($"long.MinValue = {long.MinValue}");
Console.WriteLine($"long.MaxValue = {long.MaxValue}");

Console.WriteLine($"size of float ={sizeof(float)}");
Console.WriteLine($"size of float ={sizeof(float)}");
Console.WriteLine($"float.Minvalue = {float.MinValue}");
Console.WriteLine($"float.Maxvalue = {float.MaxValue}");

Console.WriteLine($"size of double ={sizeof(double)}");
Console.WriteLine($"size of double ={sizeof(double)}");
Console.WriteLine($"double.Minvalue = {double.MinValue}");
Console.WriteLine($"double.Maxvalue = {double.MaxValue}");

Console.WriteLine($"size of decimal ={sizeof(decimal)}");
Console.WriteLine($"size of decimal ={sizeof(decimal)}");
Console.WriteLine($"decimal.Minvalue = {decimal.MinValue}");
Console.WriteLine($"decimal.Maxvalue = {decimal.MaxValue}");

//A2
{

    string firstname = "Sumiyabazar";
    string Lastname = "Gerelt-Od";
    short age = 20;
    Console.WriteLine(firstname + "\n" + Lastname + "\n" + age);
}


//A3
{

    int DollorZahl = 36;

    char Dollor = (char)DollorZahl;
    Console.WriteLine("char(" + DollorZahl + ") is " + Dollor);
}

//A4
{
    Console.WriteLine("give double  ");

    Double Number = Double.Parse(Console.ReadLine());

}
