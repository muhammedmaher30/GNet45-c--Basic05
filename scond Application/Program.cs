using System.Drawing;

namespace scond_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question -1 
            //Add a private string password = "secret"; field to a Book class. Try to print it from Main 
            // (outside the class). What happens, and why?
            // string password = "secret";
            // Console.WriteLine(password);


            //Question-2 
            //Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? 
            // Why ?
            // int copiesInStock = 5;
            //Console.WriteLine(copiesInStock);
            //Question -3 
            //Add a public string Title; field to Book. Set it and print it from Main. 
            // string Title = "C# Programming";

            // Console.WriteLine(Title);



            //Question -4 
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, 
            // assign it Genre.Science, and print it. 
           enum Genre
        {
            Fiction,
            NonFiction,
            Science
        }

        Genre genre = Genre.Science;

        Console.WriteLine(genre);

        }
    }
}
