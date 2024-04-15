﻿using LibraryManagement;
internal class Program
{
    private static void Main()
    {
        try
        {
            var user1 = new User("Alice", new DateTime(2023, 1, 1));
            var user2 = new User("Bob", new DateTime(2023, 2, 1));
            var user3 = new User("Charlie", new DateTime(2023, 3, 1));
            var user4 = new User("David", new DateTime(2023, 4, 1));
            var user5 = new User("Eve", new DateTime(2024, 5, 1));
            var user6 = new User("Fiona", new DateTime(2024, 6, 1));
            var user7 = new User("George", new DateTime(2024, 7, 1));
            var user8 = new User("Hannah", new DateTime(2024, 8, 1));
            var user9 = new User("Ian");
            var user10 = new User("Julia");

            var book19 = new Book("The Iliad");
            var book20 = new Book("Anna Karenina");
            var book2 = new Book("1984", new DateTime(2023, 2, 1));
            var book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
            var book4 = new Book("The Catcher in the Rye", new DateTime(2023, 4, 1));
            var book5 = new Book("Pride and Prejudice", new DateTime(2023, 5, 1));
            var book6 = new Book("Wuthering Heights", new DateTime(2023, 6, 1));
            var book7 = new Book("Jane Eyre", new DateTime(2023, 7, 1));
            var book8 = new Book("Brave New World", new DateTime(2023, 8, 1));
            var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
            var book9 = new Book("Moby-Dick", new DateTime(2023, 9, 1));
            var book10 = new Book("War and Peace", new DateTime(2023, 10, 1));
            var book11 = new Book("Hamlet", new DateTime(2023, 11, 1));
            var book12 = new Book("Great Expectations", new DateTime(2023, 12, 1));
            var book13 = new Book("Ulysses", new DateTime(2024, 1, 1));
            var book14 = new Book("The Odyssey", new DateTime(2024, 2, 1));
            var book15 = new Book("The Divine Comedy", new DateTime(2024, 3, 1));
            var book16 = new Book("Crime and Punishment", new DateTime(2024, 4, 1));
            var book17 = new Book("The Brothers Karamazov", new DateTime(2024, 5, 1));
            var book18 = new Book("Don Quixote", new DateTime(2024, 6, 1));



            Library library = new();

            library.AddBook(book19);
            library.AddBook(book20);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            library.AddBook(book7);
            library.AddBook(book8);
            library.AddBook(book1);
            library.AddBook(book9);
            library.AddBook(book10);
            library.AddBook(book11);
            library.AddBook(book12);
            library.AddBook(book13);
            library.AddBook(book14);
            library.AddBook(book15);
            library.AddBook(book16);
            library.AddBook(book17);
            library.AddBook(book18);

            library.AddUser(user1);
            library.AddUser(user2);
            library.AddUser(user3);
            library.AddUser(user4);
            library.AddUser(user5);
            library.AddUser(user6);
            library.AddUser(user7);
            library.AddUser(user8);
            library.AddUser(user9);
            library.AddUser(user10);


            List<Book> allBooks = library.GetBooks(1);
            allBooks.ForEach(book =>
            {
                Console.WriteLine($"{book.GetDate()} - {book.GetTitle()}");

            });

            library.DeleteBook(book1.GetId());
            library.DeleteUser(library.FindUser("Fiona").GetId());

            Console.WriteLine($"{library.FindBook("The Iliad").GetTitle()}");

            Console.WriteLine($"{library.FindUser("Fiona").GetName()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }





    }
}