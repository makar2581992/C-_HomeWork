//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    Console.WriteLine("Введите число А: ");
	 int a = int.Parse(Console.ReadLine());
	Console.WriteLine("Введите число B: ");
 	 int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число C: ");
 	 int c = int.Parse(Console.ReadLine());
         
     int max = a;
	if (a > max) max = a; 
	if (b > max) max = b;
	if (c > max) max = c;
		Console.Write ($"Число {max} является максимальным");
		Console.WriteLine();