using DataStructureAlgorithm;
using DataStructureProblem;

public class Program
{
    static string searchFilePath = @"D:\Problem statemets\DataStructureAlgorithm\DataStructureAlgorithm\Files\Search.txt";
    public static void Main(string[] args)
    {
        Console.WriteLine("Data Structure\n");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter a option \n1.BinarySearch \n2.Anagram\n3.ReplaceString\n4.insertionsortn\n5.BubbleeSort\n6.Exit");
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
                    ReplaceString replaceString = new ReplaceString();
                    replaceString.replaceString();
                    break;
                case 4:
                    Insertionsort insertionsort = new Insertionsort();
                    insertionsort.insertionsort();
                    break;
                case 5:
                    int[] arr1 = { 20, 30, 10, 15, 40, 70, 60 };
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.bubbleSort(arr1);
                    Console.WriteLine("\nSorted array:");
                    bubbleSort.PrintArray(arr1);
                    break;
                case 6:
                    flag = false;
                    break;
            }
        }


    }
}