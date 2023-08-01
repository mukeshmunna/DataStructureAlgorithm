using DataStructureAlgorithm;
using DataStructureAlgorithm.UnorderedList;
using DataStructureProblem;

public class Program
{
    static string searchFilePath = @"D:\Problem statemets\DataStructureAlgorithm\DataStructureAlgorithm\Files\Search.txt";
    static string unOrderedPath = @"D:\Problem statemets\DataStructureAlgorithm\DataStructureAlgorithm\UnorderedList\UnOrdered.txt";
    static string HashingFilePath = @"D:\Problem statemets\DataStructureAlgorithm\DataStructureAlgorithm\Hashing\Hash Table.txt";
    public static void Main(string[] args)
    {
        Console.WriteLine("Data Structure\n");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nEnter a option \n1.BinarySearch \n2.Anagram\n3.ReplaceString\n4.insertionsortn\n5.BubbleeSort\n6.PrimeNumber\n7.Exit");
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
                    PrimeNumbers primeNumbers = new PrimeNumbers();
                    Console.WriteLine( "enter a number upto prime number:");
                    int input = Convert.ToInt32(Console.ReadLine());
                    for(int i = 0;i<= input;i++)
                    {
                        primeNumbers.PrimeNumbersBetweenTheRange(i);
                    } 
                    break;
                case 7:
                    PrimeAnagramPalidrome extend = new PrimeAnagramPalidrome();
                    Console.WriteLine("Enter the range :");
                    int range2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < range2; i++)
                    {
                        if (extend.FindTheNumberIsPrime(i) && extend.PalindromeAnagram(i))
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine("\n");
                    break;
                case 8:
                    flag = false;
                    break;
            }
        }


    }
}