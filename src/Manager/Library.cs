using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement;
public class Library(INotificationService logger)
{
    private List<User> _users = new List<User>();
    private List<Book> _books = new List<Book>();

    private INotificationService _logger = logger;


    public List<Book> GetBooks(int page)
    {
        return _books.OrderBy(d => d.GetDate())
                     .Skip(page * 5)
                     .Take(5)
                     .ToList();
    }

    public List<User> GetUsers(int page)
    {
        return _users.OrderBy(d => d.GetDate())
                     .Skip(page * 5)
                     .Take(5)
                     .ToList();
    }

    public Book FindBook(string title)
    {
        Book? book = _books.Find(book => book.GetTitle() == title);
        if (book is null)
        {
            _logger.SendNotificationOnFailure($"finding '{title}'");
            throw new Exception("Book does not exist");
        }
        else
        {
            return book;
        }
        // return book is null ? throw new Exception("Book does not exist") : book;
    }

    public User FindUser(string name)
    {
        User? user = _users.Find(user => user.GetName() == name);
        if (user is null)
        {
            _logger.SendNotificationOnFailure($"finding '{name}'");
            throw new Exception("User does not exist");
        }
        else
        {
            return user;
        }
        // return user is null ? throw new Exception("User does not exist") : user;
    }

    public void AddUser(User newUser)
    {
        User? user = _users.Find(user => user == newUser);
        if (user is null)
        {
            _users.Add(newUser);
            _logger.SendNotificationOnSuccess($"new user named '{newUser.GetName()}'");
        }
        else
        {
            _logger.SendNotificationOnFailure($"adding user '{newUser.GetName()}'");
            throw new Exception("User already exist");
        }
    }

    public void AddBook(Book newBook)
    {
        Book? book = _books.Find(book => book == newBook);
        if (book is null)
        {
            _books.Add(newBook);
            _logger.SendNotificationOnSuccess($"new book titled '{newBook.GetTitle()}'");
        }
        else
        {
            _logger.SendNotificationOnFailure($"adding book '{newBook.GetTitle()}'");
            throw new Exception("Book already exist");
        }
    }

    public void DeleteBook(Guid bookId)
    {
        Book? book = _books.Find(book => book.GetId() == bookId);
        if (book is null)
        {
            _logger.SendNotificationOnFailure($"adding deleting '{bookId}'");
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
            _logger.SendNotificationOnFailure($"adding deleting '{userId}'");
            throw new Exception("User does not exist");
        }
        else
        {
            _users.Remove(user);
            Console.WriteLine($"User deleted successfully!");
        }
    }
}