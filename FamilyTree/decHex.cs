  public class NumberSystems
   {
       public static void Main(string[] args)
       {
           Console.WriteLine("Please enter a Number between 0 - 1023: ");
           int decNumber = Convert.ToInt32(Console.ReadLine());
           int hexNumber = ConvertDecimalToHexal(decNumber);
           Console.WriteLine($"HexNumber is: {hexNumber}");
           
           Console.WriteLine("Please enter Hexal Number: ");
           int hex2 = Convert.ToInt32(Console.ReadLine());
           int dec2 = ConvertHeximaltoDecimal(hex2);
           Console.WriteLine($"Dec Number is: {dec2}");
           
            
           Console.WriteLine("Please enter and Number: ");
           int number = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Please enter Divison Base: ");
           int basis = Convert.ToInt32(Console.ReadLine());
           int result = ConvertToDecimalFromBase(basis, number);
           Console.WriteLine($"Result with base of {basis} : {result} ");
           Console.ReadKey();


       }

       public static int ConvertDecimalToHexal(int dec)
       {
           int result = dec / 6;
           int rest = dec % 6;

           return (result * 10) + rest;
       }

       public static int ConvertHeximaltoDecimal(int hex)
       {
           int sixes = hex / 10;
           int rest = hex % 10;


           return (sixes * 6) + rest;
       }

       public static int ConvertToBaseFromDecimal(int toBase, int number)
       {
           
           
           
       }

       public static int ConvertToDecimalFromBase(int fromBase, int number)
       {
           int result = number / fromBase;
           int rest = number % fromBase;

           return (result * fromBase) + rest;
           
       }

       public static int ConvertNumbertoBaseFromBase(int number, int toBase, int fromBase)
       {


           return -1;
       }
       
   }