using Problems.Solution;
using Problems.Sorting;
using System.Data;

namespace Problems
{
    internal class Program
    {
        static Fibonacci? fibonacci;
        static Factorial? factorial;
        static Power? power;
        static Permutation? permutation;
        static SquareRoot? squareRoot;
        static MergeSorted? mergeSorted;

        static BubbleSort? bubbleSort;
        static QuickSort? quickSort;

        private static void Main(string[] args)
        {
            quickSort = new QuickSort();
        }
    }
}