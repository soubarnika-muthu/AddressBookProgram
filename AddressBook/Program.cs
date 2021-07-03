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



        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");
          
            CreateContacts();//Calling createcontacts method  to create new contacts in Address Book
        }
            //A function to get contact details from the user
            static void CreateContacts()
            {
               Person person = new Person();//Creating object for class person
            Console.WriteLine("--Creating New contact Details :--");
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

    }






}
}
    

    


