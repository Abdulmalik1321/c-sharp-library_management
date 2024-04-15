using LibraryManagement;
internal class Program
{
    private static void Main()
    {

        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book2 = new Book("1984", new DateTime(2023, 2, 1));
        var book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
        var book4 = new Book("The Catcher in the Rye", new DateTime(2023, 4, 1));
        var book5 = new Book("Pride and Prejudice", new DateTime(2023, 5, 1));
        var book6 = new Book("Wuthering Heights", new DateTime(2023, 6, 1));
        var book7 = new Book("Jane Eyre", new DateTime(2023, 7, 1));
        var book8 = new Book("Brave New World", new DateTime(2023, 8, 1));
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
        var book19 = new Book("The Iliad");
        var book20 = new Book("Anna Karenina");

        Console.WriteLine($"{book18.GetDate()}");

    }
}