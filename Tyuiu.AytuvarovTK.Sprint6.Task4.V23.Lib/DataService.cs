using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AytuvarovTK.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Написать программу, которая выводит таблицу значений функции: F(x) = 4 - 2x + (2 + cos(x))/(2x - 2) (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль. При делении на ноль вернуть значение 0. Округлить до двух знаков после запятой. Результат вывести в textBox, построить график функции и сохранить в файл OutPutFileTask4V23.txt по нажатию кнопки. Графический интерфейс пользователя оформить по примеру из лекции.
            int size = stopValue - startValue + 1;
            double[] results = new double[size];
            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                double denominator = 2 * x - 2;
                if (denominator == 0)
                {
                    results[i] = 0;
                }
                else
                {
                    double F = 4 - 2 * x + (2 + Math.Cos(x)) / denominator;
                    results[i] = Math.Round(F, 2);
                }
            }
            return results;
        }
    }
}
