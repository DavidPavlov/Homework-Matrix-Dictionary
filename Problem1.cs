using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillTheMatrix
{
    static void Main()
    {
	//Cool way to solve this shit.
        int size = int.Parse(Console.ReadLine());
        int[,] matrix1 = new int[size, size];
        int[,] matrix2 = new int[size, size];
        FillMatrix1(size, matrix1);
        Print(matrix1);
        Console.WriteLine();
        FillMatrix2(size, matrix2);
        Print(matrix2);

    }
    static void FillMatrix1(int size, int[,] matrix)
    {
        int iterator = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j< matrix.GetLength(1); j++)
            {
                matrix[j, i] = iterator;
                iterator++;
            }
        }
    }
    static void FillMatrix2(int size, int[,] matrix)
    {
        int iterator = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[j, i] = iterator;
                iterator++;
                
            }
            iterator += size - 1;
            
            i++;
            if (i == matrix.GetLength(0))
            {
                break;
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[j, i] = iterator;
                iterator--;
                
            }
            iterator+=size+1;
        }
    }
    static void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0} ",matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

