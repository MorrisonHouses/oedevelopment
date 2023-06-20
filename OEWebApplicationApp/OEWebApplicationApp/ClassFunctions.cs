
using System.Security.Principal;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using OEWebApplicationApp.Models;
using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace OEWebApplicationApp
{

    public class ClassFunctions
    {
        //==========================pulls the current date time===========================================
        public string dateTime()
        {
            DateTime localDate = DateTime.Now;
            string dateTime = localDate.ToString("d/M/yyyy");
            return dateTime;
        }//datetime

        //EMAIL===========================================================================================
        public void SendEmail(string SentTo, string body, string subject)
        {
            ClassConfig configclass = new();
            int port = Convert.ToInt32(configclass.EmailPort());
            SmtpClient smtp = new SmtpClient(configclass.EmailSMTP(), port);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = false;
            MailMessage mailMessage = new MailMessage();
            mailMessage.Priority = MailPriority.High;
            mailMessage.From = new MailAddress(configclass.EmailFrom());
            mailMessage.To.Add(SentTo);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            smtp.Send(mailMessage);
        }//SendEmail

        public void WriteToFile(int id, string vendor, string reason, string request, double gst, double totalAmount)
        {
            string[] lines = { "C,OE"+id+",1,\""+reason+ "\","+vendor+",,,,,\nCI, OE"+id+",1,\""+ request + "\",,,,,,,,GST5,"+gst+",,,,"+totalAmount };
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "FPO_Import.jcc"),true))
            {
                foreach (string line in lines) outputFile.WriteLine(line);
            }
        }

    }//class
}//OEWebData