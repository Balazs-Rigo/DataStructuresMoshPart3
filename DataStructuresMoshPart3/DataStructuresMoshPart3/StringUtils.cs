using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMoshPart3
{
    public class StringUtils
    {
        public static int CountVowels(string str)
        {
            if (str == null)
                return 0;

            int count = 0;
            string vowels = "aeiou";
            foreach (var ch in str.ToLower().ToCharArray())
            {
                if (vowels.IndexOf(ch) != -1)
                    count++;
            }
            return count;
        }

        public static string Reverse(string str)
        {
            if (str == null)
                return "";

            StringBuilder reversed = new StringBuilder();
            for (var i = str.Length - 1; i >= 0; i--)
                reversed.Append(str[i]);

            return reversed.ToString();
        }

        public static string ReverseWords(string sentence)
        {
            if (sentence == null)
                return "";

            string[] words = sentence.Trim().Split(" ");
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public static bool AreRotations(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;

            return (str1.Length == str2.Length && (str1 + str1).Contains(str2)); 
        }

        public static string RemoveDuplicates(string str)
        {
            if (str == null)
                return "";

            StringBuilder output = new StringBuilder();
            ISet<char> seen = new HashSet<char>();

            foreach (var ch in str.ToCharArray())
            {
                if(!seen.Contains(ch))
                {
                    seen.Add(ch);
                    output.Append(ch);
                }
            }
            return output.ToString();
        }

        public static char GetMaxOccouringChar(string str)
        {
            if (str == null || str.Length == 0)
                throw new InvalidOperationException();

            const int ASCII_SIZE = 256;
            int[] frequencies = new int[ASCII_SIZE];
            foreach (var ch in str.ToCharArray())
                frequencies[ch]++;

            int max = 0;
            char result = ' ';
            for (int i = 0; i < frequencies.Length; i++)
                if (frequencies[i]>max)
                {
                    max = frequencies[i];
                    result = (char)i;
                }
                return result;
        }

        public static string Capitalize(string sentence)
        {
            if (sentence == null || sentence.Trim().Length == 0)
                return "";

            string[] words = sentence.Trim().Replace(" +", " ").Split(" ");

            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].Substring(0,1).ToUpper() + words[i].Substring(1).ToLower();

            return string.Join(" ",words);
        }

        public static bool AreAnagrams(string first, string second)
        {
            if (first == null || second == null || first.Length != second.Length)
                return false;

            var array1 = first.ToLower().ToCharArray();
            Array.Sort(array1);

            var array2 = second.ToLower().ToCharArray();
            Array.Sort(array2);

            return array1.Equals(array2);
        }

        public static bool AreAnagram2(string first,string second)
        {
            if (first == null || second == null)
                return false;

            const int ENGLISH_ALPHABET = 26;
            int[] frequencies = new int[ENGLISH_ALPHABET];

            first = first.ToLower();
            for (var i = 0; i < first.Length; i++)
                frequencies[first[i] - 'a']++;

            second = second.ToLower();
            for (int i = 0; i < second.Length; i++)
            {
                var index = second[i] - 'a';
                if (frequencies[index] == 0)
                    return false;

                frequencies[index]--;
            }

            return true;
        }

        public static bool IsPalindrome(string word)
        {
            if (word==null)
                return false;

            int left = 0;
            int right = word.Length - 1;

            while (left < right)
                if (word[left++] != word[right--])
                    return false;

            return true;
        }
    }
}
