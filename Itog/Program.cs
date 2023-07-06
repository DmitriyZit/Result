/*Задача 54: Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Write("Введите колличество строк массива : ");
int rows = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите колличество столбцов массива : ");
int colums = Convert.ToInt32(Console.ReadLine());

void Printmatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write("\t" + matrix[i, j]);
            //.ToString("f1")
        }
        Console.WriteLine();
    }
}

//  int rows = 4;
//  int colums = 4;
int[,] Fillmatrix(int[,] matrix)
{

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);

        }

    }
    return matrix;
}

int[,] Arrange(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int temp = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }

    }
    return matr;

}

int[,] matrix = new int[rows, colums];

Fillmatrix(matrix);
Console.WriteLine();
Printmatrix(matrix);
Arrange(matrix);
Console.WriteLine("Упорядочная таблица");
Printmatrix(matrix);






/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер
строки с наименьшей суммой элементов: 1 строка
*/
//   Console.Write("Введите колличество строк массива : ");
//  int sizeS = Convert.ToInt32(Console.ReadLine());


//  Console.Write("Введите колличество столбцов массива : ");
//  int sizeV = Convert.ToInt32(Console.ReadLine());
/*
 void Printmatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {

        Console.Write("\t" + matrix[i, j]);
        //.ToString("f1")
     }
    Console.WriteLine();
    }
}

 int rows = 4;
 int colums = 4;
 int[,] Fillmatrix(int[,] matrix)
 {
    
     for (int i = 0; i < rows; i++) 
     {
         for (int j = 0; j < colums; j++)
         {
          matrix[i,j] = new Random().Next(1 , 5); 
        
         }

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < colums; j++)
        {
         matrix[i,j] = new Random().Next(1 , 5); //Rmatrixndom().Next(1,10);

        }

    }
    return matrix;
}
 int[,] matrix = new int[rows, colums];

    Fillmatrix(matrix);
    Console.WriteLine();
    Printmatrix(matrix);
    MinSum();
    //Console.WriteLine();
    //Printmatrixrrmatrixy(mmatrixtrix);


    void MinSum()
{ 
    int minRowSum = int.MaxValue;
    int minIndex = 0;
    int rowSum = 0;

    for (int i = 0; i < rows; i++)
             {
                rowSum = 0;
                for (int j = 0; j < colums; j++)
                    rowSum += matrix[i,j];
                    Console.WriteLine("сумма строки " + rowSum);


                   if (rowSum < minRowSum)
                   {
                    minRowSum = rowSum;
                    minIndex = i;
                    Console.WriteLine("миниммальное промежуточное " + minRowSum);
                   }

            }
             Console.WriteLine("Строка с минимальной суммой элементов");
                 for(int j = 0; j < colums; j++)
                    Console.Write(matrix[minIndex, j] + "\t");



}
*/
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18





void Printmatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
        
        Console.Write("\t" + matrix[i, j]);
        //.ToString("f1")
     }
    Console.WriteLine();
    }
}

int rows = 2;
int colums = 2;
int[,] Fillmatrix(int[,] matrix)
{
    
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < colums; j++)
        {
         matrix[i,j] = new Random().Next(1 , 5); //Rmatrixndom().Next(1,10);
        
        }
    
    }
    return matrix;
}
int[,] Multiplicmat(int[,] matrix, int[,] matrixTwo)
        {
            if (matrix.GetLength(1) != matrixTwo.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] matrixResult = new int[matrix.GetLength(0), matrixTwo.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
                {
                for (int j = 0; j < matrixTwo.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixTwo.GetLength(0); k++)
                    {
                        matrixResult[i,j] += matrix[i,k] * matrixTwo[k,j];
                    }
                }
            }
            Console.WriteLine("Результат умножения");
            Printmatrix(matrixResult);
            return matrixResult;
        }

 int[,] matrix = new int[rows, colums];
 int[,] matrixTwo = new int[rows, colums];
 int[,] matrixResult = new int[rows, colums];
    
    Fillmatrix(matrix);
    Fillmatrix(matrixTwo);
    Printmatrix(matrix);
    Console.WriteLine();
    Printmatrix(matrixTwo);
    
    Multiplicmat(matrix , matrixTwo);
    Console.WriteLine();
    
    


*/


/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)



  Console.Write("Введите колличество строк массива : ");
  int rows = Convert.ToInt32(Console.ReadLine());


    
  Console.Write("Введите колличество столбцов массива : ");
  int colums = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите глубину  массива : ");
 int depth = Convert.ToInt32(Console.ReadLine());

 
  void Printmatrix(int[,,] matrix)
 {
    
     for (int i = 0; i < matrix.GetLength(0); i++) 
     {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
         Console.Write("\t" + matrix[i, j, k] + (i,j,k));
         //.ToString("f1")
        }
      }
     Console.WriteLine();
     }
 }

//  int rows = 2;
//  int colums = 2;
//  int depth = 2;
 int[,,] Fillmatrix(int[,,] matrix)
 {
    
     for (int i = 0; i < rows; i++) 
     {
         for (int j = 0; j < colums; j++)
         {
            for (int k = 0; k < depth; k++)
            {
                matrix[i,j,k] = new Random().Next(10 , 50); 
            }
          
        
         }

     }
     return matrix;
 }
  int[,,] matrix = new int[rows, colums, depth];

    Printmatrix(matrix);
    Fillmatrix(matrix);
    Console.WriteLine();
    Printmatrix(matrix);

    */
/*
ДОПОЛНИТЕЛЬНАЯ. Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

Начиная с этого урока, учитывается чистота программного кода (именования методов и переменных в нужных стилях, нет "matrix" и прочего индусского кода).
Имя отражает суть переменной или метода
*/



