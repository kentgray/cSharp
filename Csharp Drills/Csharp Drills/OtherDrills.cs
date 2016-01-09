using System;


namespace Csharp_Drills
{
    class OtherDrills
    {
    }
    class Customer
    {
        string _firstName;
        string _lastName;
              
        public Customer(string FirstName, string LastName) //Constructor 
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Customer's Full Name = {0}\n", this._firstName + " " + this._lastName);
        }
        ~Customer() //destructor
        {
            //Clean up code here
        }
    }
}
