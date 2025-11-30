using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AytuvarovTK.Sprint6.Task6.V6.Lib
{
    public class DataService : ISprint6Task6V6
    {
        public string CollectTextFromFile(string path)
        {
            // Дан файл InPutFileTask6V6.txt который может находится в любом месте на диске. Загрузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречается b в результирующею строку и вывести ее в textBoxOut. Графический интерфейс пользователя оформить по образцу как в лекции
            string content = System.IO.File.ReadAllText(path);
            string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t', ',', '.', ';', '!', '?' }, System.StringSplitOptions.RemoveEmptyEntries);
            List<string> resultWords = new List<string>();
            foreach (string word in words)
            {
                if (word.IndexOf('b', System.StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    resultWords.Add(word);
                }
            }
            return string.Join(" ", resultWords);

        }
    }
}
