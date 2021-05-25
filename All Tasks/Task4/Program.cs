using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            About thing = new About();
            thing.book = Console.ReadLine();
            thing.title = Console.ReadLine();
            thing.author = Console.ReadLine();
            thing.content = Console.ReadLine();
            Show(thing.book, thing.title, thing.author, thing.content);
        }
        static void Show(string book, string title, string author, string content)
        {
            Console.WriteLine(book, title, author, content);
        }
    }
    class About
    {
        public string book;
        public string title;
        public string author;
        public string content;
    }
}
