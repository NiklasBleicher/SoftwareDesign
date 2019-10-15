    public class Debug
    {
        public static void Main(string[] args)
        {
            var f = 3.67890;
            WriteLine($"double = {f}.");
            
            //Safe Number from 1-10 in intArray
            int[] intArray = new int[10];
            for(int i = 1; i < intArray.Length; i++)
            {
                intArray[i] = i;
                //WriteLine(intArray[i]);
            }
            
            //.toString()
            foreach (var number in intArray)
            {
                string stringNumber = number.ToString();
                //WriteLine(stringNumber);
            }
            Person[] personArray = new Person[5];
            
            //Initialize new Person and add it to Person Array
            Person person1 = new Person() {FirstName = "Hans", LastName = "Hoch", Age = new DateTime(1988, 4, 12)};
            personArray[0] = person1;
            Person person2 = new Person() {FirstName = "Niklas", LastName = "Bleicher", Age = new DateTime(1999, 5, 8)};
            personArray[1] = person2;

            for(int i = 0; i < personArray.Length; i++)
            {
                if (personArray[i].Age > personArray[i + 1].Age)
                {
                    Person oldest = personArray[i];
                    WriteLine($"The oldest Person is: {oldest.FirstName}");
                }
                
            }
            Console.WriteLine(person1);
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