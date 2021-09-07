using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class AbstractC
    {
    }
    abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }
    class MyBook : Book
    {
        protected int mypPrice;
        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.mypPrice = price;
        }
        public override void display()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {mypPrice}");
        }
    }
}
