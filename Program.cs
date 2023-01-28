//Задача № 27 --> Программа, которая принимает на вход число,
//и выдаёт сумму цифр в числе.

Console.Write("Enter a value: ");
int Val = Convert.ToInt32(Console.ReadLine());

int Sum()
{
    int i = Val;
    int SumVal = 0;
    while (i != 0)
    {
        int X = i % 10;
        SumVal = SumVal + X;
        i = i / 10;
    }
    Console.WriteLine(SumVal);
    return SumVal;
}
Sum();