using System;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Harry Potter", "JK Rowling", 400);


            Student student1 = new Student("Harry Potter", "Art", 3.2);
            Student student2 = new Student("Harry Potter", "Art", 3.8);
            Console.WriteLine(book1.title);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();
        }
        
    }
}
