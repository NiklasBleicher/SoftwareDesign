public class Quiz
    {
        public static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("D:/Coding/C#/ConsoleApplication/ConsoleApplication/test.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "Question")
                        {
                            Console.WriteLine(">" + reader.Name);
                            Console.WriteLine("Value: " + reader.GetAttribute("type"));
                        }


                        break;
                }

            }

            Console.Read();
        }
    }