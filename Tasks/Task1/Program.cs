//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    Console.WriteLine("Введите число А: ");
	 int a = int.Parse(Console.ReadLine());
	Console.WriteLine("Введите число B: ");
 	 int b = int.Parse(Console.ReadLine());
         
         if (a > b)
    {
             Console.WriteLine($"Число {a} - max, число {b} - min");  
    }
         else
    {
             Console.WriteLine($"Число {b} - max, число {a} - min");
    }