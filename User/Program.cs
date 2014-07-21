using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your login");
            string login = Console.ReadLine();

            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            User newUser = new User(login, firstName, surname, age);

            Console.WriteLine(newUser);

            Console.ReadLine();
        }
    }
}
