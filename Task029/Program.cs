﻿//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


class Program {
    static void Main(string[] args) {
        int[] array = {1, 2, 5, 7, 19, 6, 1, 33};

        Console.Write("[");
        for (int i = 0; i < array.Length; i++) {
            Console.Write(array[i]);
            if (i < array.Length - 1) {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}
