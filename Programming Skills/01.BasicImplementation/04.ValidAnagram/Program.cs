namespace _04.ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Given two strings "s" and "t", return "true" if "t" is an anagram of "s", and "false" otherwise.
            An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
            */

            // Input 1:
            string s = "anagram";
            string t = "nagaram";
            // Expected Output: true

            // Input 2:
            //string s = "rat";
            //string t = "car";
            // Expected Output: false

            Console.WriteLine(IsAnagram(s, t));
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            else
            {
                char[] first = s.ToCharArray();
                char[] second = t.ToCharArray();

                Array.Sort(first);
                Array.Sort(second);

                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] != second[i]) return false;
                }

                return true;
            }
        }
    }
}