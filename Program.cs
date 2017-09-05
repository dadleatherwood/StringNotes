using System;

namespace StringNotes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var fullName = "Jacob Leatherwood ";

            //trim

            Console.WriteLine("Trim:  '{0}'", fullName.Trim());

            //ToUpper
            Console.WriteLine("ToUpper:  '{0}'", fullName.Trim().ToUpper());

            //Split (two ways)
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
			Console.WriteLine("First Name: " + names[0]);
			Console.WriteLine("Last Name: " + names[1]);

            //Replace
            Console.WriteLine(fullName.Replace("Jacob", "AwesomeDude"));
            Console.WriteLine( fullName.Replace("a", "A") );

            //IsNullOrEmpty

            if (String.IsNullOrEmpty(""))
            {
                Console.WriteLine("Invalid");
            }

            //IsNullOrWhiteSpace
            if(String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            //convert strings to numbers
            var str = "25";

            Console.WriteLine( Convert.ToInt32(str) );

            //convert number to string
            var price = 29.95f;

            Console.WriteLine(price.ToString("C"));



        }
    }
}
