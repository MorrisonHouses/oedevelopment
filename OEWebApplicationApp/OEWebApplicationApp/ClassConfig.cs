
using System.Security.Principal;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.IO;
using System.Text;

namespace OEWebApplicationApp
{
    /// <summary>
    /// containes methods and functions: code is layed out as such
    /// GST=5
    /// CONFIG LOCATION = C:/Users/edoucett/Desktop/ConfigOEWebApp.txt
    /// </summary>
    public class ClassConfig
    {
        /// <summary>
        /// pulls the current user name
        /// </summary>
        /// <returns>user name </returns>
        public string username()
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string name = userName.Remove(0, 14);
            name = "yclement";
            return name;
        }//username

        // TODO: gnicholls name error


        /*=======================================================================================================================================*/
        /// <summary>
        /// pulls the current user address
        /// </summary>
        /// <returns>user address</returns>
        public string Address()
        {
            string Address = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            return Address;
        }//Address
        /*=======================================================================================================================================*/
        /// <summary>
        /// To parse the txt Config file 
        /// </summary>
        /// <returns>Line 1 </returns>
        public string ConfigGST()
        {
            string GST = "GST";
            StringBuilder sbText = new StringBuilder();
            using (var reader = new System.IO.StreamReader("C:/Users/edoucett/Desktop/ConfigOEWebApp.txt"))
            {
                Int32 lineItem = 1;
                Int32 ctn = 0;
                foreach (string line in File.ReadLines(@"C:/Users/edoucett/Desktop/ConfigOEWebApp.txt"))
                {
                    if (line.Contains(GST))
                    {
                        sbText.Append(line);
                    }
                }//foreach
            }//using
            return Convert.ToString(sbText).Remove(0, 4);
        }//ConfigGST
        /*=======================================================================================================================================*/
        /// <summary>
        /// To parse the txt Config File
        /// </summary>
        /// <returns>Line 2 </returns>
        public string ConfigLocation()
        {
            string ConfigLocation = "CONFIG LOCATION";
            StringBuilder sbText = new StringBuilder();
            using (var reader = new System.IO.StreamReader("C:/Users/edoucett/Desktop/ConfigOEWebApp.txt"))
            {
                Int32 lineItem = 2;
                Int32 ctn = 0;
                foreach (string line in File.ReadLines(@"C:/Users/edoucett/Desktop/ConfigOEWebApp.txt"))
                {
                    if (line.Contains(ConfigLocation))
                    {
                        sbText.Append(line);
                    }
                }//foreach
            }//using
            return Convert.ToString(sbText).Remove(0, 18);
        }//ConfigLocation
        /*=======================================================================================================================================*/
        /// <summary>
        /// To parse the txt Config File
        /// </summary>
        /// <returns>Line 3 </returns>
        public string ExportLocation()
        {
            string ConfigLocation = "FILE EXPORT LOCATION =";
            StringBuilder sbText = new StringBuilder();
            using (var reader = new System.IO.StreamReader("C:/Users/edoucett/Desktop/ConfigOEWebApp.txt"))
            {
                Int32 lineItem = 3;
                Int32 ctn = 0;
                foreach (string line in File.ReadLines(@"C:/Users/edoucett/Desktop/ConfigOEWebApp.txt"))
                {
                    if (line.Contains(ConfigLocation))
                    {
                        sbText.Append(line);
                    }
                }//foreach
            }//using
            return Convert.ToString(sbText).Remove(0, 22);
        }//ExportLocation
        /*=======================================================================================================================================*/
    }//ConfigClass
}//namespace
