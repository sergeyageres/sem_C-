//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

void Main(int number)
{
    int num = 1;
    while (num <= number)
        {
         if (num % 2 == 0)
          {
           Console.WriteLine(num);
          }
      num++;
   }
}
Console.Write("Введите число:\n");
int number = int.Parse(Console.ReadLine());
Console.Write("--------------------------------\n");
Console.Write("Четные числа данного промежутка:\n");
Main(number);