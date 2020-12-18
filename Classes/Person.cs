using System;

namespace M_todos_Construtores.Classes
{
    public class Person
    {
        public string firstName = "Ronaldo";
        public string lastName = "Fenômeno";


        public Person(string firstName, string lastName) {

            this.firstName = firstName;

            this.lastName = lastName;

            Console.WriteLine();
            Console.WriteLine($"Welcome {firstName} {lastName}");
        }

        public void ShowText() {
            
            Console.WriteLine();
            Console.WriteLine("Here I will show the text");

        }

    }
}