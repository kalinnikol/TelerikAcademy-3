﻿using System;

class IndexByFive
{
    static void Main()
    {
        int[] array = new int[20];
        for (int index = 0; index < array.Length; index++)
        {
            array[index] = index * 5;
            Console.Write("{0} ", array[index]);
        }
        Console.WriteLine();
    }
}   

