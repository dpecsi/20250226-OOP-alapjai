using _20250226_MyClasses;

namespace _20250226_OOP_alapjai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User u1 = new User("John Doe",
                                   "john.doe@gov.hu");
                Console.WriteLine(u1);
            }
            catch (Exception e)
            {
                Console.WriteLine("HIBA: " + e.Message);
            }

            Console.WriteLine("------------");

            try
            {
                User u2 = new User("Jane Doe",
                                   "jane.doe");
                Console.WriteLine(u2);
            }
            catch (Exception e)
            {
                Console.WriteLine("HIBA: " + e.Message);
            }

            Console.WriteLine("------------");
            try
            {
                Employee u3 = new Employee("Jacob Doe", "jacob.doe@gov.hu", "+36123456789");
                Console.WriteLine(u3);
            }
            catch (Exception e)
            {
                Console.WriteLine("HIBA: " + e.Message);
            }

            Console.WriteLine("------------");
            try
            {
                Employee u4 = new Employee("Jacob Doe", "jacob.doe@gov.hu", "+36123456789");
                Console.WriteLine(u4);
            }
            catch (Exception e)
            {
                Console.WriteLine("HIBA: " + e.Message);
            }
        }
    }
}
