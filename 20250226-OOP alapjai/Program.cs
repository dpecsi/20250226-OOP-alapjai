using _20250226_MyClasses;

namespace _20250226_OOP_alapjai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User? u1 = null;
            try
            {
                u1 = new User("John Doe",
                                   "john.doe@gov.hu");
                Console.WriteLine(u1);
            }
            catch (Exception e)
            {
                Console.WriteLine("HIBA: " + e.Message);
            }

            Console.WriteLine("------------");

            User? u2 = null;
            try
            {
                u2 = new User("Jane Doe",
                                   "jane.doe");
                Console.WriteLine(u2);
            }
            catch (Exception e)
            {
                Console.WriteLine("HIBA: " + e.Message);
            }

            Console.WriteLine("------------");

            Employee? u3 = null;
            try
            {
                u3 = new Employee("Jacob Doe", "jacob.doe@gov.hu", "+36123456789");
                Console.WriteLine(u3);
            }
            catch (Exception e)
            {
                Console.WriteLine("HIBA: " + e.Message);
            }

            Console.WriteLine("------------");
            Employee? u4 = null;
            try
            {
                u4 = new Employee("Jacob Doe", "jacob.doe@gov.hu", "+36123456789");
                Console.WriteLine(u4);
            }
            catch (Exception e)
            {
                Console.WriteLine("HIBA: " + e.Message);
            }

            Console.WriteLine("------------");
            User? u5 = null;
            try
            {
                Console.Write("Alkalmazott? (Igen/Nem): ");
                if(Console.ReadLine() == "Igen")
                {
                    u5 = new Employee("John Doe", "john.doe@gov.hu", "+36963258741");
                } else
                {
                    u5 = new User("John Doe", "asdasdas@asdasd.hu");
                }
                Console.WriteLine(u5);
            }
            catch (Exception e)
            {
                Console.WriteLine("HIBA: " + e.Message);
            }

            Console.WriteLine("============");
            List<User?> users = new List<User?>();
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            users.Add(u5);

            Console.Write("Kit keresel: ");
            User segéd = new User("Segéd", "asd@asd");
            segéd.Name = Console.ReadLine();
            if (users.Contains(segéd))
            {
                Console.WriteLine("Találat");
                int index = users.IndexOf(segéd);
                Console.WriteLine(users[index]);
            }

            users.Sort();
        }
    }
}
