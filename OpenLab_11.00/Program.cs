using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title = "LOTR";
            LOTR.Pages = 1137;
            LOTR.Category = "fantasy";
            LOTR.Author = "John Ronald Tolkien";
            LOTR.ReleaseDate = 1937;
            Console.WriteLine(LOTR.ToString());

            Book LOTR2 = new Book();
            Book LOTR3 = new Book("Lord Of The Rings 3", 50);
            Book Hobit = new Book("Hobit", 300, "fantasy", "John Ronald Tolkien", 1937);
            Hobit.Category = Book.categoryList[4];
            Console.WriteLine(LOTR2.ToString());
            Console.WriteLine(LOTR3.ToString());
            Console.WriteLine(Hobit.ToString());

            Library schoolLibrary = new Library();
            Book zakladyElektrotechniky = new Book("Základy elektrotechniky", 120000000);
            Book anj = new Book("Yes!", 3);
            Book sjl = new Book("skabyKar", 358);
            Book bigbrain = new Book("Úvod do OOP", 80);
            schoolLibrary.StudentsList.Add("John");
            schoolLibrary.StudentsList.Add("Poul");
            schoolLibrary.BooksList.Add("Základy elektrotechniky");
            schoolLibrary.BooksList.Add("Yes!");
            schoolLibrary.BooksList.Add("slabyKar");
            schoolLibrary.BooksList.Add("Úvod do OOP");
            schoolLibrary.NumberofBooks = 4;
            schoolLibrary.NumberofStudents = 2;
            Console.WriteLine(schoolLibrary.ToString());

        }
    }
}