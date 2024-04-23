namespace _03.FindTheIndexOfTheFirstOccurrenceInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Given two strings "needle" and "haystack", return the index of the first occurrence of "needle" in "haystack", or -1 if "needle" is not part of "haystack".
            */

            // Input 1:
            //string haystack = "sadbutsad";
            //string needle = "sad";
            // Expected Output: 0

            // Input 2:
            //string haystack = "leetcode";
            //string needle = "leeto";
            // Expected Output: -1

            // Input 3:
            string haystack = "mississippi";
            string needle = "issip";
            // Expected Output: 4;

            Console.WriteLine(StrStr(haystack, needle));
        }

        public static int StrStr(string haystack, string needle)
        {
            if (!haystack.Contains(needle)) return -1;
            else return haystack.IndexOf(needle);
        }
    }
}