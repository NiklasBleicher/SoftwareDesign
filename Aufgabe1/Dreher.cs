 public static class LetterSwitcher
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bitte einen kleinen Satz eingeben");
            Console.Write("> ");
            var text = Console.ReadLine();
            string letters = reverseLetters(text);
            /*string words = reverseWords(text);
            string sentence = reverseSentence(text);*/
            Console.WriteLine(letters);
            Console.Read();

        }

        private static string reverseLetters(string text)
        {
            string newText = "This is a Test Text!";
            
            return newText;
        }
    }