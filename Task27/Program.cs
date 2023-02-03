//Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10

int num = new Random().Next(1, 100000);
Console.WriteLine(num);
Console.WriteLine(GetSum(num));

static int GetSum(int num)
{
    int numSum = 0;
    while(num > 0)
    {
        numSum = numSum + (num % 10);
        num /= 10;
    }
    return numSum;
}

