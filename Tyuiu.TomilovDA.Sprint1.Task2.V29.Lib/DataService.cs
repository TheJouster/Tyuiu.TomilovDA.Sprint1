using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TomilovDA.Sprint1.Task2.V29.Lib
{
    public class DataService : ISprint1Task2V29
    {
        public int ConvertSecondsToHours(int value)
        {
            return Convert.ToInt32(value/60);
        }
    }
}
