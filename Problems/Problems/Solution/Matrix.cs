using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class Matrix
    {
        public Matrix()
        {
            int[][] matrixArray = 
            {
                new int[] {5,1,9,11},
                new int[] {2,4,8,10},
                new int[] {13,3,6,7 },
                new int[] {15,14,12,16}
            };

            matrixArray = RotateMatrix(matrixArray);
            Display(matrixArray);
        }

        private int[][] RotateMatrix(int[][] matrix)
        {

            for(int x = 0; x < matrix.Length; x++)
            {
                for(int y = x + 1; y < matrix[x].Length; y++)
                {
                    int temp = matrix[x][y];
                    matrix[x][y] = matrix[y][x];
                    matrix[y][x] = temp;
                }
            }

            int columnCount = matrix[0].Length;
            int lastColumn = columnCount - 1;

            for(int col = 0; col < columnCount / 2; col++)
            {
                for(int row = 0; row < matrix.Length; row++)
                {
                    int temp = matrix[row][col];
                    matrix[row][col] = matrix[row][lastColumn];
                    matrix[row][lastColumn] = temp;
                }

                lastColumn--;
            }

            return matrix;
        }

        private void Display(int[][] matrix)
        {
            for(int x = 0; x < matrix.Length; x++)
            {
                for(int y = 0; y < matrix[x].Length; y++)
                {
                    Console.Write(matrix[x][y] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
