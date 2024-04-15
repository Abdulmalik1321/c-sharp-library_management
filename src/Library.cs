using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Library
    {
        private List<User> _users = new List<User>();
        private List<Book> _books = new List<Book>();


        public List<Book> GetBooks(int page)
        {
            return _books.OrderBy(d => d.GetDate())
                         .Skip(page)
                         .Take(5)
                         .ToList();
        }

        public List<User> GetUsers(int page)
        {
            return _users.OrderBy(d => d.GetDate())
                         .Skip(page)
                         .Take(5)
                         .ToList();
        }

        public Book FindBook(string title)
        {
            Book? book = _books.Find(book => book.GetTitle() == title);
            return book is null ? throw new Exception("Book does not exist") : book;
        }

        public User FindUser(string name)
        {
            User? user = _users.Find(user => user.GetName() == name);
            return user is null ? throw new Exception("User does not exist") : user;
        }

        public void AddUser(User newUser)
        {
            User? user = _users.Find(user => user == newUser);
            if (user is null)
            {
                _users.Add(newUser);
                Console.WriteLine($"New user added successfully!");
            }
            else
            {
                throw new Exception("User does exist");
            }
        }

        public void AddBook(Book newBook)
        {
            Book? book = _books.Find(book => book == newBook);
            if (book is null)
            {
                _books.Add(newBook);
                Console.WriteLine($"New book added successfully!");
            }
            else
            {
                throw new Exception("Book does exist");
            }
        }

        public void DeleteBook(Guid bookId)
        {
            Book? book = _books.Find(book => book.GetId() == bookId);
            if (book is null)
            {
                throw new Exception("Book does not exist");
            }
            else
            {
                _books.Remove(book);
                Console.WriteLine($"Book deleted successfully!");
            }
        }

        public void DeleteUser(Guid userId)
        {
            User? user = _users.Find(user => user.GetId() == userId);
            if (user is null)
            {
                throw new Exception("User does not exist");
            }
            else
            {
                _users.Remove(user);
                Console.WriteLine($"User deleted successfully!");
            }
        }
    }
}