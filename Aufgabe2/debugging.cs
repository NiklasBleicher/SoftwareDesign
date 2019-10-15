    public class Debug
    {
        public static void Main(string[] args)
        {
            var f = 3.67890;
            WriteLine($"double = {f}.");
            
            //Safe Number from 1-10 in intArray
            int[] intArray = new int[10];
            for(int i = 1; i <= intArray.Length; i++)
            {
                intArray[i] = i;
                WriteLine(intArray[i]);
            }
            
            //.toString()
            foreach (var number in intArray)
            {
                string stringNumber = number.ToString();
                WriteLine(stringNumber);
            }
            
            //Initialize new Person
            Person person1 = new Person() {FirstName = "Hans", LastName = "Hoch", Age = new DateTime(1988, 4, 12)};
            
            Console.Read();
        }
    }

    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime Age;

        public override string ToString()
        {
            return ($"FirstName: {FirstName} \n LastName: {LastName} \n Birthday: {Age}");
        }

    }