using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AytuvarovTK.Sprint6.Task1.V11.Lib
{
    public class DataService : ISprint6Task1V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Написать программу, которая выводит таблицу значений функции: F(x) = (5x + 2.5)/(sin(x) + 3) + 2x + cos(x) (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль. При делении на ноль вернуть значение 0. Результат вывести в Textbox Значения округлить до двух знаков после запятой. Графический интерфейс оформить по шаблону из лекции.
            int size = stopValue - startValue + 1;
            double[] results = new double[size];
            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                double denominator = Math.Sin(x) + 3;
                if (denominator == 0)
                {
                    results[i] = 0;
                }
                else
                {
                    double F = (5 * x + 2.5) / denominator + 2 * x + Math.Cos(x);
                    results[i] = Math.Round(F, 2);
                }
            }
            return results;
        }
    }
}
