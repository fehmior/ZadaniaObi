using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Librainian_Managment
    {
        string UserType, Username, password;

        public List<string> List_Of_Books = new List<string>();
        public void Login()
        {
            Console.WriteLine("Login");
        }
        public void Register()
        {
            Console.WriteLine("Register");
        }
        public void Logout()
        {
            Console.WriteLine("Logout");
        }
    }
    internal class Book
    {
        string title, Author, ISBN, Publication;
        public void Show_duedt()
        {
            Console.WriteLine("Show_duedt");
        }
        public void Reservation_status()
        {
            Console.WriteLine("Reservation_status");
        }
        public void Feedback()
        {
            Console.WriteLine("Feedback");
        }
        public void book_request()
        {
            Console.WriteLine("book_request");
        }
        public void Renw_info()
        {
            Console.WriteLine("Renw_info");
        }
    }
    internal class User
    {
        public string name, id;
        public void verify()
        {
            Console.WriteLine("verify");
        }
        public void CheckAccount()
        {
            Console.WriteLine("CheckAccount");
        }
        public void get_book_info()
        {
            Console.WriteLine("get_book_info");
        }
    }
    internal class Account
    {
        string no_borrowed_books, no_reserved_books, no_retrurned_books, no_lost_books, fine_amount;
        public void Calculate_fine()
        {
            Console.WriteLine("Calculate_fine");
        }
    }
    internal class Librainian
    {
        string name, password, Searchingstring, Id;
        public void Verify_librainian()
        {
            Console.WriteLine("Verify_librainian");
        }
        public void Search()
        {
            Console.WriteLine("Search");
        }
    }
    internal class Library_database
    {
        string ListofBooks;
        public void Add()
        {
            Console.WriteLine("Add");
        }
        public void Delete()
        {
            Console.WriteLine("Delete");
        }
        public void Update()
        {
            Console.WriteLine("update");
        }
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Search()
        {
            Console.WriteLine("Search");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
