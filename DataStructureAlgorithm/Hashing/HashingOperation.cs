using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureAlgorithm.UnorderedList;

namespace DataStructureAlgorithm.Hashing
{
    public class HashingOperation
    {
        static int size = 11;
        UnorderedList.LinkedList<int>[] array = new UnorderedList.LinkedList<int>[size];
        public HashingOperation()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = new UnorderedList.LinkedList<int>();
            }
        }
        public void ReadFile(string filePath)
        {
            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(",");
            foreach (var data in words)
            {
                int num = Convert.ToInt32(data);
                int position = num % size;
                array[position].Add(num);
            }
        }
        public void Display()
        {
            foreach (var data in array)
            {
                data.Display();
            }
        }
    }
}