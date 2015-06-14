using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace MailSender1._1
{
       class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("o.mihaylov75@gmail.com");
                mail.To.Add("o.mihaylov@checkin-bg.com");
                mail.CC.Add("omihaylov@checkin-bg.com");
                mail.Subject = "Rapak Vision System Report";
                mail.Body = "Best Regards http://www.checkin-bg.com";

                System.Net.Mail.Attachment attachment1;
                attachment1 = new System.Net.Mail.Attachment("C:\\JobResults.csv");

               

                mail.Attachments.Add(attachment1);
                


                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("o.mihaylov75", "442653odb");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

}
