using System;
using System.Collections;
using System.Collections.Generic;


namespace AddressBook
{

    class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
            public int PhoneNo { get; set; }
            public string Email { get; set; }
        }
        //Creating  list to store the person in Address Book
        public static List<Person> list = new List<Person>();


        static string userStringEntry;
        static int userChoice;



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");
            MainMenu();

            Console.ReadKey();
        }
        static void MainMenu()
        {


            Console.WriteLine("Choose the option ");
            Console.WriteLine("\n1 - Add Contact.");


            userStringEntry = Console.ReadLine();
            userChoice = System.Int32.Parse(userStringEntry);
            //selection statement
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Adding  New Contacts");
                    AddContact();
                    
                    break;
                default:
                    break;
            }
        }
        //A function to ADD contact details of the user
        static void AddContact()
        {
            do
            {

                Person person = new Person();//Creating object for class person

                //Getting Contact Details  from the User
                Console.WriteLine("Please Enter your First Name:");
                person.FirstName = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Please Enter your Lastname:");
                person.LastName = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Please Enter your Address :");
                person.Address = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Please Enter your State");
                person.State = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Please Enter your Country");
                person.Country = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Please Enter your Phone Number");
                person.PhoneNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter your EmailAddress");
                person.Email = Convert.ToString(Console.ReadLine());
                //Adding person details to the list using ADD();
                list.Add(person);
                //Displaying the Contact Details of the person     
                Console.WriteLine("***********************************");
                Console.WriteLine("    Address Book  of the person     ");
                Console.WriteLine("***********************************");
                Console.WriteLine("First Name:" + person.FirstName);
                Console.WriteLine("Last Name:" + person.LastName);
                Console.WriteLine("Address:" + person.Address);
                Console.WriteLine("State:" + person.State);
                Console.WriteLine("Country:" + person.Country);
                Console.WriteLine("Phone Number:" + person.PhoneNo);
                Console.WriteLine("Mail :" + person.Email);
                Console.WriteLine("***********************************");

                Console.WriteLine("\nIs the following information correct?");
                Console.WriteLine("\n1 - Yes. 2 - Retry.");

                userStringEntry = Console.ReadLine();
                userChoice = System.Int32.Parse(userStringEntry);

            }
            while (userChoice == 2);

            if (userChoice == 1)
            {
                MainMenu();
            }
        }

    }
}






    

    


