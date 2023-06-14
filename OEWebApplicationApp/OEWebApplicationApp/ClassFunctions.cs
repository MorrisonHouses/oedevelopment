
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
            SmtpClient smtp = new SmtpClient("10.0.0.26",25);
            //smtp.Credentials = new NetworkCredential("or@morrisonhomes.ca", "");
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = false;
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("oe@morrisonhomes.ca ");
            mailMessage.To.Add(SentTo);
            mailMessage.Subject = subject;
            mailMessage.Body = body;

            smtp.Send(mailMessage);
        }

    }//class
}//OEWebData