using System.Collections;

namespace test1
{
    public class EnvironmentVariable
    {
        public static string GetValueOrDefault(string key, string defaultValue)
        {
            foreach (DictionaryEntry de in System.Environment.GetEnvironmentVariables())
            {
                if (de.Key?.ToString() == key)
                {
                    return de.Value.ToString();
                }
            }
            return defaultValue;
        }
    }
}
