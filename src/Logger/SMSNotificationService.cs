using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class SMSNotificationService : INotificationService
    {
        public void SendNotificationOnSuccess(string message)
        {
            string sms = $"{message} added to Library. Thank you!";
            Console.WriteLine(sms);
            File.AppendAllText("smsLog.txt", $"{DateTime.Now} - {sms} + \n\n");

        }
        public void SendNotificationOnFailure(string message)
        {
            string sms = $"Error {message}. Please email support@library.com.";
            Console.WriteLine(sms);
            File.AppendAllText("smsLog.txt", $"{DateTime.Now} - {sms} + \n\n");
        }
    }
}