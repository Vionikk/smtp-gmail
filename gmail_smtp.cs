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
                    SmtpClient CL = new SmtpClient("smtp.gmail.com"); //you must allow it: https//myaccount.google.com/lesssecureapps
                    CL.Port = 587;
                    CL.Credentials = new NetworkCredential("yourgmailaddress@gmail.com", "yourpassword"); //input your gmail address and password
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
