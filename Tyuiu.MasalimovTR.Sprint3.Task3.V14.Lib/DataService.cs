using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MasalimovTR.Sprint3.Task3.V14.Lib
{
    public class DataService : ISprint3Task3V14
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            foreach (char replaceabled in value) 
            {
                if (replaceable == 'd') 
                {
                    value = value.Replace(replaceable, replacement);
                }
                
            }
            return value;

        }
    }
}
