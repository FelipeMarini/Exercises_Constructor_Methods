using System;

namespace Ex__2_Constructor_Methods.Classes
{
    public class Product
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Stock { get; set; }


        public Product() { }   //first method for p1


        public Product(int code)
        { // second method for p2

            if (code < 0) { Console.WriteLine("Invalid Code"); }

            else
            {

                Code = code;

                Console.WriteLine($"Product registered: Name: {Name} | Code: {Code}");
            
            }
        }


        public Product(int code, string name, string description, int stock)
        { // third method for p3

            if (code <= 0) { Console.WriteLine("Invalid Code"); }

            else
            {

                Code = code;

                Name = name;

                Description = description;

                Stock = stock;

                Console.WriteLine($"Product registered: Name: {Name} | Code: {Code} | Description: {Description} | Stock Available: {Stock}");

            }
        }

    }
}