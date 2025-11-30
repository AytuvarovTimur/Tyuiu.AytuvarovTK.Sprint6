using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AytuvarovTK.Sprint6.Task2.V22.Lib
{
    public class DataService : ISprint6Task2V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Написать программу, которая выводит таблицу значений функции: F(x) = (2x - 3)/(cos(x) + x) + 5 (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль. При делении на ноль вернуть значение 0. Значения занести в DataGridView Значения округлить до двух знаков после запятой. Графический интерфейс оформить по шаблону из лекции.
            int size = stopValue - startValue + 1;
            double[] results = new double[size];
            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                double denominator = Math.Cos(x) + x;
                if (denominator == 0)
                {
                    results[i] = 0;
                }
                else
                {
                    double F = (2 * x - 3) / denominator + 5;
                    results[i] = Math.Round(F, 2);
                }
            }
            return results;
        }
    }
}
