// Задача 3

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int Prompt(string message)
{
    System.Console.Write(message);
    string readVelue = Console.ReadLine();
    int result = int.Parse(readVelue);
    return result;
}


void SetN(int num)
{
    int i=1;
    while(i<=num) 
    {
        System.Console.Write(i*i*i + " ");
        i++;
    }
}


SetN(Prompt("Введите число -> "));