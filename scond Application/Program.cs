
using System.Drawing;

namespace scond_Application
{
    internal class Program
    {
        enum Genre
        {
            Fiction,
            NonFiction,
            Science
        }
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
            //  enum Genre
            //{
            //  Fiction,
            //NonFiction,
            //Science
            //}

            //Genre genre = Genre.Science;
            //Console.WriteLine(genre);


            //Question 5 
            //Using the Genre enum above, print the underlying int value of 
            //Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.

            //  Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);
            //}

            //enum Genre
            //{
            //  Fiction,
            //NonFiction,

            //Science
            //Question 6 
            //Given int genreNumber = 1;, cast it into a Genre value and print the result.

            // int genreNumber = 1;

            //Console.WriteLine((Genre)genreNumber);

            //QUESTION 7
            //Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and 
            // print the result.

            string genreText = "Science";

            Genre genre = Enum.Parse<Genre>(genreText);

            Console.WriteLine(genre);


        }
    }
}
