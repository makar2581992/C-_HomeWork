// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
int b = 1;

for (int count = b; count <= a; count++)

{
    if (count % 2 == 0)  
    {
     Console.Write(count + " ");
     count++;   
    }
}
