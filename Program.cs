﻿using System;
					
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if(number % 2 == 0)
            Console.WriteLine("да.");
        else
            Console.WriteLine("нет");
    }
}
