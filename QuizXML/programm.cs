    public class Quiz
    {
        static XmlTextReader reader = new XmlTextReader("D:/Coding/C#/ConsoleApplication/ConsoleApplication/test.xml");
        
        public static void Main(string[] args)
        {
            StartQuiz();   
        }

        public static String GetQuestion()
        {
            bool found = false;
            String question = "";
            while (reader.Read() && found == false)
            {
                
                switch (reader.NodeType)
                {
                    case XmlNodeType.Text:
                        Console.WriteLine(reader.Value);
                        break;
                    
                }

            }

            return question;
        }

        public static void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!!!");
            String question1 = GetQuestion();
            Console.WriteLine("Question1: " + question1);
            Console.Read();
        }
    }