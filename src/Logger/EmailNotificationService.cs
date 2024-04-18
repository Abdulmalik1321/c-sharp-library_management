using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement;
public class EmailNotificationService : INotificationService
{
    public void SendNotificationOnSuccess(string message)
    {
        string email = $"Hello, a {message} has been successfully added to the Library. If you have any queries or feedback, please contact our support team at support@library.com.";
        Console.WriteLine(email);
        File.AppendAllText("emailLog.txt", $"{DateTime.Now} - {email} + \n\n");
    }
    public void SendNotificationOnFailure(string message)
    {
        string email = $"We encountered an issue adding 'ABC'. Please review the input data. For more help, visit our FAQ at library.com/faq.";
        Console.WriteLine(email);
        File.AppendAllText("emailLog.txt", $"{DateTime.Now} - {email} + \n\n");
    }
}