using Problems.Solution;
namespace Problems
{
    internal class Program
    {
        static Fibonacci fibonacci;
        static Factorial factorial;
        static Power power;
        static Permutation permutation;

        private static void Main(string[] args)
        {
            permutation = new Permutation("abc");
        }
    }
}