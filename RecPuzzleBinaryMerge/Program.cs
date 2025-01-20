using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPuzzleBinaryMerge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //solve puzzle of tower og hanoi
            Console.WriteLine("Enter the number of Disks:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Solving Tower of Hanoi Puzzle for {n} disks:");

            SolveTowerOfHanoi(n, 'A', 'C', 'B');

            Console.ReadLine();

            //binary search on sorted array
           
            //merge sort on array
        }

        static void SolveTowerOfHanoi(int n, char source, char destination, char auxiliary)
        {
            if (n == 1) //if 1 disk then move directly from source to destination
            {
                Console.WriteLine($"Move disk 1 from {source} to {destination}");
                return;

            }

            //move top n-1 disk from source to auxiliary using destination as helper
            SolveTowerOfHanoi(n-1, source, auxiliary, destination);

            Console.WriteLine($"Move disk {n} from {source} to {destination}");

            //move n-1 disks from auxiliary to destination using source as helper
            SolveTowerOfHanoi(n - 1, auxiliary, destination, source);
        }

       
    }
}
