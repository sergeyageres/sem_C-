//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


  void MetodMy()
{
    int num1, num2; 
    Console.Write("\n\n");
    Console.Write("большее и меньшее число:\n");
    Console.Write("------------------------------------");
    Console.Write("\n\n");
    Console.Write("Введите 1-е число:");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2-е число:");
    num2 = Convert.ToInt32(Console.ReadLine());

  if (num1 > num2)
    {
        Console.Write("1-е число является наибольшим. \n\n");
        Console.Write("2-е число является наименьшим. \n\n");
    }
    
        else
        {
            Console.Write("1-е число является наименьшим. \n\n");
            Console.Write("2-е число является наибольшим. \n\n");
        }     
}

MetodMy();