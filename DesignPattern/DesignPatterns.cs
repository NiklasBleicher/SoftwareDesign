   public class DesignPattern
   {
       public static void Main(string[] args)
       {
           Singleton singleton = Singleton.Instance; //Calling instance of Singleton

           for (int i = 0; i < 10; i++)
           {
               int rndID = 0;
               rndID = singleton.GenerateNewID();
               Console.WriteLine(rndID);
           }

           Console.Read();


       }
   }

   public sealed class Singleton
   {
       private int run = 0;
       private static Singleton instance = new Singleton();

       public static Singleton Instance
       {
           get { return instance; }
       }

       public int GenerateNewID()
       {
           Random rnd = new Random();
           int newId = rnd.Next(1, 1000);
           run++;

           return newId;
       }
       
   }