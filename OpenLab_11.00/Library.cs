using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    class Library
    {
        public int numberofBooks;
        public int numberofStudents;
        public List<string> studentsList = new List<string>() {};
        public List<string> booksList = new List<string>() {};
        

        public int NumberofBooks
        {
            get { return numberofBooks; }
            set { numberofBooks = value; }
        }
        public int NumberofStudents
        {
            get { return numberofStudents; }
            set { numberofStudents = value; }
        }
        public List<string> StudentsList
        {
            get { return studentsList; }
            set { studentsList = value; }
        }
        public List<string> BooksList
        {
            get { return booksList; }
            set { booksList = value; }
        }
        public override string ToString()
        {
            var mylist = booksList.ConvertAll(x => x.ToString());
            return String.Format($"pocet studentov: {numberofStudents}\npocet knih: " +
                $"{numberofBooks}\nstudenti: "+ string.Join(", ", studentsList) + "\nknizocky: " + string.Join(", ", booksList));



        }

    }
}