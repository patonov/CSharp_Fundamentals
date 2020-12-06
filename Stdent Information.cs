using System;

public class Program
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        double grade = double.Parse(Console.ReadLine());

        Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:F2}", name, age, grade);

    }
}
