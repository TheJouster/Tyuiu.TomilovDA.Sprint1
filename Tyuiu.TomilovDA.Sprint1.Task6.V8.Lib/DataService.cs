using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TomilovDA.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string res = "";
            string[] text = value.Split(' ');
            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];
                char chr = text[i][0];
                word = word.Remove(0,1);
                res += word + chr + " ";
            }
            res = res.Trim();
            return res;
        }
    }
}
