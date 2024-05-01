using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.RandomTopics
{
    public class Book
    {
        public string Author;
        public string Title;
    }
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
    /// </summary>
    public class BookCollection
    {
        private Book[] books = { new Book { Title = "Call of the Wild, The", Author = "Jack London" },
                        new Book { Title = "Tale of Two Cities, A", Author = "Charles Dickens" }
                       };
        private Book nobook = null;

        public ref Book GetBookByTitle(string title)
        {
            for (int ctr = 0; ctr < books.Length; ctr++)
            {
                if (title == books[ctr].Title)
                    return ref books[ctr];
            }
            return ref nobook;
        }

        public void ListBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}, by {book.Author}");
            }
            Console.WriteLine();
        }
    }

    public class BookTest
    {
       List<Book> _books =new List<Book> { new Book { Author = "NDS", Title = "TestBook" }, new Book { Author = "NDS", Title = "C#INA NUTTSHELL" }, new Book { Author = "MDS", Title = "C#INA NUTTSHELL" }, new Book { Author = "MDS", Title = "C#INA NUTTSHELL" } };

       List<string> lstString = new List<string> { "chinook", "coho", "pink", "sockeye" };

        public List<String> GetListString()
        {
           // return lstString.Where(x=>x=="pink").ToList();//in this case a new list<string> instance will be created and returned hence when client will add any element into it
            // it will not changed original collection.

            // while like below case :
            return lstString; // if client will add any element to this collection it will be added to original collection.
        }

        public void printLstString()
        {
            lstString.ForEach((s) => Console.WriteLine(s));
        }

        public Book GetBookbyTitle(String title)
        {
            return _books.Where(x => x.Title == title).FirstOrDefault(); 
           
        }

        public void printBook()
        {
            Console.WriteLine("**********************************");
            foreach (Book _book in _books)
                Console.WriteLine("Book Author: {" + _book.Author + "} Book Title={" + _book.Title + "}");
        }
      
        public  List<Book> GetNewCollectionByAuthor(string author)
        {
            List<Book> books = new List<Book>();
            foreach (Book b in _books)
            {
                if (b.Author == author)
                {
                    books.Add(b);
                }
            }
            Console.WriteLine("books =" +  books.GetHashCode());
            return  books;
            // return ref _books;
        }
        public  List<Book> GetNewCollectionByAuthor2(string author)
        {

            List<Book> temp= _books.Where(x => x.Author == "MDS").ToList();
            temp.Add(new Book { Author = "Temp", Title = "TB" });
            return temp;
        }


    }

    //class RefReturnExample
    //{
    //    public static void Main() // Correct Main method name to run program.
    //    {

    //        //Example from MSDN
    //        var bc = new BookCollection();
    //        bc.ListBooks();

    //        ref var book = ref bc.GetBookByTitle("Call of the Wild, The");
    //        if (book != null)
    //            book = new Book { Title = "Republic, The", Author = "Plato" }; // Note : A new Book object is assigned to exsting reference.
    //        bc.ListBooks();
    //        // The example displays the following output:
    //        //       Call of the Wild, The, by Jack London
    //        //       Tale of Two Cities, A, by Charles Dickens
    //        //       
    //        //       Republic, The, by Plato
    //        //       Tale of Two Cities, A, by Charles Dickens

    //        // End : Example from MSDN

    //        // Test 2:

    //        BookTest b = new BookTest();
    //        b.printBook();
    //        Book b1 = b.GetBookbyTitle("TestBook");
    //        b1.Author = "Niranjan Sharma"; // It will change author in Book b because we are changing same object's property.
    //                                       // but  below line will not work  id we are not using 'ref local' as we are assigning a new object to exsting reference.
    //                                       //  Book b1 = new Book { Title = "ABC", Author = "KKK" }; 
    //        b.printBook();
           

    //        //Test 3:
    //        List<Book> lstbooks= b.GetNewCollectionByAuthor("MDS");
    //        Console.WriteLine("LstBooks Count=" + lstbooks.Count);
    //        lstbooks[0].Author = "MKS"; //it will change author of book in book collection of b object 
    //        b.printBook();


    //        //Test 4:

    //        List<string> tmpstr=b.GetListString();
    //        b.printLstString();
    //        tmpstr.Add("Niranjan");
    //        b.printLstString();

            
    //        Console.Read();
    //    }
    //}
}
