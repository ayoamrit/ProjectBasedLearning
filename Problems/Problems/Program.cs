using Problems.Solution;
using Problems.Sorting;
using System.Data.SqlTypes;

namespace Problems
{
    internal class Program
    {
        static Fibonacci? fibonacci;
        static Factorial? factorial;
        static Power? power;
        static Permutation? permutation;
        static SquareRoot? squareRoot;
        static MaxProfit? maxProfit;
        static MergeSorted? mergeSorted;
        static FindMedian? findMedian;
        static ConversionArray? conversionArray;
        static GenerateParenthesis? generateParenthesis;
        static SubstringConcatenation? substringConcatenation;

        static BubbleSort? bubbleSort;
        static QuickSort? quickSort;
        static MajorityElement? majorityElement;
        static HappyNumber? happyNumber;


        private static void Main(string[] args)
        {
            substringConcatenation = new SubstringConcatenation();
        }
    }
}