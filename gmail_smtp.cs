using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using static System.Console;

//Made by Vionikk
/*
  run with argument passing
*/
namespace Lab1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                try
                {
                    SmtpClient CL = new SmtpClient("smtp.gmail.com"); #you must allow it: https://myaccount.google.com/lesssecureapps
                    CL.Port = 587;
                    CL.Credentials = new NetworkCredential("yourgmailaddress@gmail.com", "yourpassword");
                    CL.EnableSsl = true;
                    CL.DeliveryMethod = SmtpDeliveryMethod.Network;
                    CL.Send(new MailMessage("yourgmailaddress@gmail.com", args[0], args[1], $"{DateTime.Now} Hello, gmail;)"));
                    Console.WriteLine("Message was send...");
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Incorrect usage!");
                Console.WriteLine("Two arguments required: <E-mail address> <Subject>");
            }
        }
    }
}

//try
//{

//    if (args.Length != 2)
//    {
//        Console.WriteLine("Incorrect usage!");
//        Console.WriteLine("Two arguments required: <E-mail address> <Subject>");
//        return 1;
//    }
//    string host = args[0];
//    string subject = args[1];
//    using (SmtpClient mail = new SmtpClient("smtp.gmail.com"))
//    {
//        mail.Port = 587;
//        mail.EnableSsl = true;
//        mail.Credentials = new NetworkCredential("vladsheln58@gmail.com", "Password");
//        string text = "Name: Vlad\nSurname:Shelin\nDate:" + DateTime.Now;
//        mail.Send(host, host, subject, text);
//    }

//    return 0;
//}
//catch (Exception e)
//{
//    Console.WriteLine(e);
//    return -1;
//}