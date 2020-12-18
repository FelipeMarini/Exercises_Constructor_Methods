using System;
using M_todos_Construtores.Classes;

namespace M_todos_Construtores
{
    class Program 
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("Please type your first name:");
            string firstName = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine("Please type your last name:");
            string lastName = Console.ReadLine();
            
            
            Person person = new Person(firstName,lastName);

            person.ShowText();

        }
    }
}
