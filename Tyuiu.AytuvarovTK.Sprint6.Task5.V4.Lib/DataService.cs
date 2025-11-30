using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AytuvarovTK.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public double[] LoadFromDataFile(string path)
        {
            // Прочитать данные из файла InPutFileTask5V4.txt. Вывести в dataGridView. Вывести все целые числа.. Построить диаграмму по этим значениям. Графический интерфейс пользователя оформить по примеру из лекции. У вещественных значений округлить до трёх знаков после запятой.
            string[] lines = System.IO.File.ReadAllLines(path);
            double[] results = new double[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                if (double.TryParse(lines[i], out double value))
                {
                    results[i] = Math.Round(value, 3);
                }
                else
                {
                    results[i] = 0; // или обработать ошибку по-другому
                }
            }
            return results;
        }
    }
}
