using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AytuvarovTK.Sprint6.Task0.V1.Lib
{
    public class DataService : ISprint6Task0V1
    {
        public double Calculate(int x)
        {
            // Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции. y(x) = x / (x^3 + 2) 

            double y = x / (Math.Pow(x, 3) + 2);
            return Math.Round(y, 3);
        }
    }
}
