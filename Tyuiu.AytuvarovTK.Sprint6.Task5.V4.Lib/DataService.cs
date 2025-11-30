using System;
using System.Collections.Generic;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AytuvarovTK.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public double[] LoadFromDataFile(string path)
        {
            // Прочитать данные из файла InPutFileTask5V4.txt. Вывести в dataGridView. Вывести все целые числа.. Построить диаграмму по этим значениям. Графический интерфейс пользователя оформить по примеру из лекции. У вещественных значений округлить до трёх знаков после запятой.
            string[] lines = System.IO.File.ReadAllLines(path);
            var resultsList = new List<double>();
            foreach (var line in lines)
            {
                if (double.TryParse(line, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                {
                    // include only integer values (values without fractional part)
                    if (Math.Abs(value - Math.Round(value)) < 1e-9)
                    {
                        resultsList.Add(Math.Round(value, 3));
                    }
                }
            }
            return resultsList.ToArray();
        }
    }
}