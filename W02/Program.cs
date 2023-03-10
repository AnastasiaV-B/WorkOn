// Задача. Упорядочить двумерный массив.
// m•n
// 4 5 3 2 1
// 5 6 3 2 1
// 5 4 3 2 1
// 5 6 4 1 1

// int[] data = Console.ReadLine()
//                     .Split(' ')
//                     .Select(int.Parse)
//                     .ToArray()


int[,] matrix = new int[4, 5] {{4, 5, 3, 2, 1},
                               {5, 6, 3, 2, 1},
                               {5, 4, 3, 2, 1},
                               {5, 6, 4, 1, 1}};

void Pprint(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(0); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Pprint(matrix);

for (int k = 0; k < matrix.GetLength(0); k++)
{
 int size = matrix.GetLength(1);
  for (int i = 0; i < size - 1; i++)
  {
    int pos = i;
    for (int j = i + 1; j < size; j++)
    {
        if (matrix[k, j] < matrix[k, pos]) pos = j;
    }
    int temp = matrix[k, i];
    matrix[k, i] = matrix[k, pos];
    matrix[k, pos] = temp;
  }
}
Pprint(matrix);
