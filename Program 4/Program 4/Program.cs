// Grading ID: J3408
// Program 4
// 12/03/2019
// CIS 199-01
// This program uses multiple methods and two classes for checking out, updating, and listing library books

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


public class LibraryBook
{
    // strings for book information 
    public string title;
    public string author;
    public string publisher;
    public int copyrightYear;
    public string callNumber;
    public bool checkoutStatus;

    
    public LibraryBook(string book_title, string book_author, string book_publisher, int book_copyright, string book_callnumber) 
    {
        // parameters for sending out from librarybook method
        
        title = book_title;
        author = book_author;
        publisher = book_publisher;
        copyrightYear = book_copyright;
        callNumber = book_callnumber;
        checkoutStatus = false; // boolean to false 
    }

    // Pre-condition: none
    // Post-condition: sets value to title
    public string Title
    {
        get
        {
            return title;
        }

        set
        {
            title = value;
        }
    }

    // Pre-condition: none
    // Post-condition: none
    public string Author
    {
        get
        {
            return author;
        }

        set
        {
            author = value;
        }
    }

    // Pre-condition: none
    // Post-condition: sets new value for changes in book
    public string Publisher
    {
        get
        {
            return publisher;
        }

        set
        {
            publisher = value;
        }
    }

    // Pre-condition: none
    // Post-condition: none
    public int CopyrightYear
    {
        get
        {
            return copyrightYear;
        }

        set
        {
            copyrightYear = value;
        }
    }

    // Pre-condition: none
    // Post-condition: sets new value for changes in book
    public string CallNumber
    {
        get
        {
            return callNumber;
        }

        set
        {
            callNumber = value;
        }
    }

    // Pre-condition: none
    // Post-condition: sets method will set checkout status to true if the book has been already checked out
    public void CheckOut()
    {
        checkoutStatus = !checkoutStatus;
    }

    // Pre-condition: none
    // Post-condition: sets checkout status to true if the book has been returned
    public void ReturnToShelf()
    {
        checkoutStatus = !checkoutStatus;
    }

    // Pre-condition: none
    // Post-condition: returns true if the book is checked out and false when not returns true if the book is checked out and false when not 
    public bool IsCheckedOut() 
    {
        return checkoutStatus;
    }

    // Pre-condition: none
    // Post-condition: formats the strings for book details and overrides 
    public override string ToString()
    {
        string result = "";

        result += "Title: " + title + Environment.NewLine;
        result += "Author: " + author + Environment.NewLine;
        result += "Publisher: " + publisher + Environment.NewLine;
        result += "Copyright Year: " + copyrightYear + Environment.NewLine;
        result += "Call Number: " + callNumber + Environment.NewLine;
        result += "Checkout Status: " + checkoutStatus + Environment.NewLine;

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // most popular books of 2019 hardcorded 
        LibraryBook book1 = new LibraryBook("The Testaments", "Margaret Atwood", "Doubleday", 2019, "LC.2502.M3.A8 2019");
        LibraryBook book2 = new LibraryBook("The Silent Patient", "Alex Michaelides", "Celadon Books", 2019, "JD.71.P453.2019");
        LibraryBook book3 = new LibraryBook("City of Girls", "Elizabeth Gilbert", "Riverhead Books", 2019, "QL.342.N743.2019");
        LibraryBook book4 = new LibraryBook("The Nickel Boys", "Colson Whitehead", "Doubleday", 2019, "N.42.G252 2019");
        LibraryBook book5 = new LibraryBook("Three Women", "Lisa Taddeo", "Simon & Schuster", 2019, "GN.21.5.M4 2019");

        // stores the books in an array
        LibraryBook[] books = { book1, book2, book3, book4, book5 };

        // ouputing books array to console
        WriteLine("Books Currently in Library");
        WriteLine();
        printBooks(books);

        // changes the book's information when checked out 
        book1.Publisher = "AppleTree Publisher";
        book2.CheckOut();
        book3.CallNumber = "JO.204.A4 2019";
        book4.CheckOut();
        book5.Publisher = "Thomas E. Broderick";

        // outputs the above method's changes to console
        WriteLine("Updating Library Books");
        WriteLine();
        printBooks(books);

        // calls two books to the checkout method when checked out
        book1.CheckOut();
        book2.CheckOut();

        // Final list of library books and shows books array
        WriteLine("Final List of Library Books");
        WriteLine();
        printBooks(books);
    }

    // Pre-condition: none
    // Post-condition: makes changes in books array
    public static void printBooks(LibraryBook[] books)
    {
        for (int index = 0; index < books.Length; ++index)
        {
            Console.WriteLine(books[index]);
        }
    }
}
