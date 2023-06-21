using Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;
using System.Net.Mail;
using MailMessage = System.Net.Mail.MailMessage;
using System.Diagnostics;
using Azure;
using Microsoft.Office.Core;
//using worddocument.Models;



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

        //EXPORT FILE=====================================================================================
        public void WriteToFile(int id, string vendor, string reason, string request, double gst, double totalAmount)
        {
            string[] lines = { "C,OE"+id+",1,\""+reason+ "\","+vendor+",,,,,\nCI, OE"+id+",1,\""+ request + "\",,,,,,,,GST5,"+gst+",,,,"+totalAmount };
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "FPO_Import.jcc"),true))
            {
                foreach (string line in lines) outputFile.WriteLine(line);
            }
        }

        //WORD TO PDF OR PRINT FILE======================================================================
        public void CreateWordDocument(string RequestId, string vendorId, string PurchaseDate, string GlAccount, string Request, string Amount, string GstAmt, string TotalAmt, string vendorName)
        {
            var applicationWord = new Microsoft.Office.Interop.Word.Application();
            object missing = System.Reflection.Missing.Value;
            object replaceAll = WdReplace.wdReplaceAll;

            applicationWord.Documents.Open(@"C:\Users\edoucett\Desktop\MorrisonOEPO.docx" );
            applicationWord.Visible = false;

            Find findObject = applicationWord.Selection.Find;
            findObject.ClearFormatting();
            object findText = "@VendorID";
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = vendorId;
            findObject.Execute(ref findText,
            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing,
            ref missing, ref missing);

            Find findObject2 = applicationWord.Selection.Find;
            findObject2.ClearFormatting();
            object findText2 = "@PurchaseOrder";
            findObject2.Replacement.ClearFormatting();
            findObject2.Replacement.Text = RequestId;
            findObject2.Execute(ref findText2,
            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing,
            ref missing, ref missing);

            Find findObject3 = applicationWord.Selection.Find;
            findObject3.ClearFormatting();
            object findText3 = "@PurchaseDate";
            findObject3.Replacement.ClearFormatting();
            findObject3.Replacement.Text = PurchaseDate;
            findObject3.Execute(ref findText3,
            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing,
            ref missing, ref missing);

            Find findObject4 = applicationWord.Selection.Find;
            findObject4.ClearFormatting();
            object findText4 = "@GlAccount";
            findObject4.Replacement.ClearFormatting();
            findObject4.Replacement.Text = GlAccount;
            findObject4.Execute(ref findText4,
            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing,
            ref missing, ref missing);

            Find findObject5 = applicationWord.Selection.Find;
            findObject5.ClearFormatting();
            object findText5 = "@Request";
            findObject5.Replacement.ClearFormatting();
            findObject5.Replacement.Text = Request;
            findObject5.Execute(ref findText5,
            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing,
            ref missing, ref missing);

            Find findObject6 = applicationWord.Selection.Find;
            findObject6.ClearFormatting();
            object findText6 = "@AmountAmt";
            findObject6.Replacement.ClearFormatting();
            findObject6.Replacement.Text = Amount;
            findObject6.Execute(ref findText6,
            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing,
            ref missing, ref missing);

            Find findObject7 = applicationWord.Selection.Find;
            findObject7.ClearFormatting();
            object findText7 = "@TaxAmt";
            findObject7.Replacement.ClearFormatting();
            findObject7.Replacement.Text = GstAmt;
            findObject7.Execute(ref findText7,
            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing,
            ref missing, ref missing);

            Find findObject8 = applicationWord.Selection.Find;
            findObject8.ClearFormatting();
            object findText8 = "@TotalAmt";
            findObject8.Replacement.ClearFormatting();
            findObject8.Replacement.Text = TotalAmt;
            findObject8.Execute(ref findText8,
            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing,
            ref missing, ref missing);

            Find findObject9 = applicationWord.Selection.Find;
            findObject9.ClearFormatting();
            object findText9 = "@VendorName";
            findObject9.Replacement.ClearFormatting();
            findObject9.Replacement.Text = vendorName;
            findObject9.Execute(ref findText9,
            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing,
            ref missing, ref missing);

            var path = @"C:\Users\edoucett\Desktop\MorrisonOEPO.docx";
            var outpath = Path.ChangeExtension(path, "pdf");
            dynamic doc = applicationWord.Documents.Open(path);
            doc.ExportAsFixedFormat(outpath, ExportFormat: 17/*pdf*/);
            doc.Close(0/*DoNotSaveChanges*/);
            applicationWord.Quit();

        }

    }//class
}//OEWebData