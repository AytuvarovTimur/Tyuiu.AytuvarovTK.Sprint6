using tyuiu.cources.programming.interfaces.Sprint6; 
namespace Tyuiu.AytuvarovTK.Sprint6.Task3.V18.Lib
{
    public class DataService : ISprint6Task3V18
    {
        public int[,] Calculate(int[,] matrix)
        {
            // Дан массив 5 на 5 элементов. Заменить четные значения в четвертой строке на 0. Результат вывести в DataGridView. Графический интерфейс оформить по шаблону из лекции. -19 -19   1  18   7 5   3  -4  -6 -12  -15   6   2   2 -14   -9 -10  15  -5  -6  -13 -15  -9   7   1
            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[3, j] % 2 == 0)
                {
                    matrix[3, j] = 0;
                }
            }
            return matrix;

        }
    }
}
