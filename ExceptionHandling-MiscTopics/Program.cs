using System;
namespace ExceptionHandling_MiscTopics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte x;
            string name;
            name = Console.ReadLine();
            int[] num = new int[10];
            try
            {
                Console.WriteLine("ENter x");
                x = Byte.Parse(Console.ReadLine());
                if (x < 1 || x > 100)
                {
                    throw new CustomException("Please enter values betwen 1 to 100");
                }
                Console.WriteLine(x);
                 name = Console.ReadLine();
                if (name == null)
                    throw new CustomException("Min 10 characters are needed");
                Console.WriteLine(name);
                //num[20] = 90;
            }
            catch (IndexOutOfRangeException obj)
            {
                Console.WriteLine("Array out of index");
            }
            catch (OverflowException obj)
            {
                Console.WriteLine("Value is not in  range");
            }
            catch (FormatException obj)
            {
                Console.WriteLine("Please enter number");
            }
            catch (CustomException obj)
            {
                Console.WriteLine(obj.Message);
            }
            catch (Exception obj)
            {
                Console.WriteLine("In catch block");
                Console.WriteLine(obj.Message);

            }
            finally
            {
                Console.WriteLine("IN finally block");
            }
            Console.WriteLine("Outside catch block");

            MainClass mainClass = new MainClass();
            Console.Write(mainClass.ReveseString("aaaa"));

            Int16 num1 = 10;
            Console.WriteLine(num1.NumberMoreThan5(num1));

            Console.WriteLine(name.FirstLetterStartsWithA("Ajay"));
            
            int? num3 = 10;
            //Console.WriteLine("ENter num3");
            //num3= Byte.Parse(Console.ReadLine());
            if (num3.HasValue)
            {
                Console.WriteLine(num3.Value);
            }
            else
                Console.WriteLine("Num contains null");


            PartialClass partialClass = new PartialClass();
            partialClass.CallMethods();

                }
    }
}