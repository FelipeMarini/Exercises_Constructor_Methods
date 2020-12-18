using System;
using Ex__2_Constructor_Methods.Classes;

namespace Ex__2_Constructor_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Product p1 = new Product(); // first method

        Console.WriteLine();
        Console.WriteLine($"Code = {p1.Code} // Name = {p1.Name ?? "null"}" + $" // Description = {p1.Description ?? "null"} // Stock = {p1.Stock}");
            
        
        Product p2 = new Product(1); // second method

        Console.WriteLine();
        Console.WriteLine($"Code = {p1.Code} // Name = {p2.Name ?? "null"}" + $" // Description = {p2.Description ?? "null"} // Stock = {p2.Stock}");

        
        
        Product p3 = new Product(1,"product 3","this is product 3",20); // third method

        Console.WriteLine();
        Console.WriteLine($"Code = {p3.Code} // Name = {p3.Name ?? "null"}" + $" // Description = {p3.Description ?? "null"} // Stock = {p3.Stock}");

         Console.ReadLine();

        }
    }
}
