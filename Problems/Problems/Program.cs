using Problems.Solution;
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

        private static void Main(string[] args)
        {
            mergeSorted = new MergeSorted();
        }
    }
}