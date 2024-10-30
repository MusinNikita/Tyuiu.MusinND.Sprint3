using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusinND.Sprint3.Task3.V19.Lib
{
    public class DataServiceTest : ISprint3Task3V19
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string result = "";

            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    result += replacement;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
