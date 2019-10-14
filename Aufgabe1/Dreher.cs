 public static class LetterSwitcher
 {
     
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a small sentence:");
            Console.Write("> ");
            var text = Console.ReadLine();
            string letters = reverseLetters(text);
            string words = reverseWords(text);
            string sentence = reverseSentence(text);
            Console.WriteLine(letters);
            Console.Read();

        }

        public static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string word = charArray.ToString();
            string reversedString = string.Join( " ", charArray);

            return reversedString;
        }

        private static string reverseLetters(string text)
        {
            string[] sentence = text.Split(' ');
            string[] newSentence = new string[sentence.Length];

            for (int i = 0; i < sentence.Length; i++)
            {
                newSentence[i] = Reverse(sentence[i]);
            }

            string finalSentence = string.Join(" ", newSentence);
            
            return finalSentence;
        }

        private static string reverseWords(string text)
        {

            return "Test";
        }

        private static string reverseSentence(string text)
        {
            //string words = reverseLetters(text);
            return "Test";
        }
}