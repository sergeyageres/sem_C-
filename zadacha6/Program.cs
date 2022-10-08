//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

  void Main()
{
    int num;
    Console.Write("\n");
    Console.Write("число является четным:\n");
    Console.Write("------------------------------------");
    Console.Write("\n");
    Console.Write("Введите число:");
    num = Convert.ToInt32(Console.ReadLine());
     
  if (num % 2==0)
    {
        Console.Write("Число является чётным. \n");
    } 
    else
    {
        Console.Write("Число является нечётным. \n");
    }

}   

Main();