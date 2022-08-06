using System;

namespace CsharpCourse
{

    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "mosh hamedani ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("Full Name: '{0}'", fullName);

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);   
            Console.WriteLine(firstName + ' ' + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            Console.WriteLine(fullName.Replace("mosh", "moshfegh"));
            
            if(String.IsNullOrEmpty("") || String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";
            var age = Convert.ToInt32(str); //Can also use Convert.ToByte because int is 4 bytes and we only need 1 byte to store a number less than 250
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
