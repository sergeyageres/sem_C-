//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

  void Main()
{
    int num1, num2, num3;
    Console.Write("\n\n");
    Console.Write("Найдите наибольшее из трех чисел:\n");
    Console.Write("------------------------------------");
    Console.Write("\n\n");
    Console.Write("Введите 1-е число:");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2-е число:");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 3-е число:");
    num3 = Convert.ToInt32(Console.ReadLine());
 
  if (num1 > num2)
    {
        if (num1 > num3)
        {
            Console.Write("1-е число является наибольшим из трех. \n\n");
        }
        else
        {
            Console.Write("3-е число является наибольшим из трех. \n\n");
        }
    }
    else if (num2 > num3)
        Console.Write("2-е число является наибольшим из трех \n\n");
    else
        Console.Write("3-е число является наибольшим из трех \n\n");
}

Main();