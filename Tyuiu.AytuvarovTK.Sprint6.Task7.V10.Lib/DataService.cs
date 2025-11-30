using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AytuvarovTK.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {
        public int[,] GetMatrix(string path)
        {
            // Дан файл InPutFileTask7V10.csv в котором хранится матрица целочисленных значений. Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить в пятой строке значения от 5 до 10 на 0. Результат вывести в объект dataGridViewOut. Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog. Графический интерфейс пользователя оформить по образцу как в лекции

            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines.Length == 0)
                return new int[0, 0];

            char[] separators = new[] { ';', ',' };
            int rowCount = lines.Length;
            int colCount = lines[0].Split(separators, StringSplitOptions.RemoveEmptyEntries).Length;
            int[,] matrix = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] values = lines[i].Split(separators, StringSplitOptions.None);
                for (int j = 0; j < colCount; j++)
                {
                    if (j < values.Length && int.TryParse(values[j].Trim(), out int parsed))
                    {
                        matrix[i, j] = parsed;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            if (rowCount > 4)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (matrix[4, j] >= 5 && matrix[4, j] <= 10)
                    {
                        matrix[4, j] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}