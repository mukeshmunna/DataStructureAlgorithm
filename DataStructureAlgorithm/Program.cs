﻿using DataStructureAlgorithm;

public class Program
{
    static string searchFilePath = @"D:\Problem statemets\DataStructureAlgorithm\DataStructureAlgorithm\Files\Search.txt";
    public static void Main(string[] args)
    {
        Console.WriteLine("Data Structure\n");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter a option \n1.BinarySearch \n2.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearch search = new BinarySearch();
                    search.ReadTextFileAndSearch(searchFilePath);
                    break;
                case 2:
                    Anagram anagram = new Anagram();
                    anagram.checkAnagram();
                    break;
                case 3:
                    flag = false;
                    break;
            }
        }


    }
}