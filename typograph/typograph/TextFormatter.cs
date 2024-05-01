using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace typograph
{
    public class TextFormatter
    {
        public string TypographyText(string inputText)
        {
            if (!string.IsNullOrEmpty(inputText))
            {
                string result = ChangePunctuation(inputText);
                result = WhitespChangingTheSpellingOfSpaceace(result);
                result = ChangingQuotes(result);
                result = ReplacingTheSignApproximately(result);
                result = ReplaceEllipsis(result);
                result = ReplaceExclamationMark(result);
                result = ReverseSentences(result);

                return result;
            }
            return string.Empty;
        }
        //rule 1
        public string ChangePunctuation(string input)
        {
            string result = Regex.Replace(input, @"(\p{L})\s+(\p{P})", "$1$2");
            result = Regex.Replace(result, @"([^\w\s]+)", "$0");
            result = Regex.Replace(result, @"(\w)(-)(\w)", "$1 $2 $3");
            result = Regex.Replace(result, @"([({<«])\s*(\w)", "$1$2");
            result = Regex.Replace(result, @"(\w)([)}\]>»])(\w)", "$1$2 $3");
            result = Regex.Replace(result, @"([""“])\s*(\w)", " $1$2");
            result = Regex.Replace(result, @"(\w)([""”])(\w)", "$1$2 $3");

            return result;
        }

        //rule 2
        public string WhitespChangingTheSpellingOfSpaceace(string input)
        {
            return Regex.Replace(input, @"\s{2,}", " ");
        }

        //rule 3
        public string ChangingQuotes(string input)
        {
            string result = Regex.Replace(input, "\"(.*?)\"", match =>
            {
                string captured = match.Groups[1].Value;
                string firstWord = char.ToUpper(captured[0]) + captured.Substring(1);
                return "«" + firstWord + "»";
            });

            return result;
        }

        //rule 9
        public string ReplacingTheSignApproximately(string input)
        {
            return Regex.Replace(input, @"\+\-|\-\+", " ± ");
        }

        //rule 13
        public string ReplaceEllipsis(string input)
        {
            return input.Replace("...", "…");
        }

        /// <summary>
        /// После знаков завершающих препинания(точка, восклицание, вопрос, троеточие) последующее слово начинается с заглавной буквы
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReplaceExclamationMark(string input)
        {
            string result = Regex.Replace(input, @"[?!.]\s+(.)", match =>
            {
                string letter = match.Groups[1].Value.ToUpper();
                return match.Value.Replace(match.Groups[1].Value, letter);
            });

            return result;
        }

        /// <summary>
        /// Запись предложений задом на перед
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseSentences(string input)
        {
            string[] sentences = Regex.Split(input, @"(?<=[.!?])\s+");
            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = ReverseString(sentences[i]);
            }
            return string.Join(" ", sentences);
        }

        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
