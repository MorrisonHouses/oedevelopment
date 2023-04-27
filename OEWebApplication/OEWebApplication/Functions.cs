using Newtonsoft.Json;
using NuGet.Configuration;
using System.Security.Principal;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.IO;
using System.Text;

namespace OEWebData
{

    public class Functions
    {
        public string dateTime()
        {
            DateTime localDate = DateTime.Now;
            string dateTime = localDate.ToString("d/M/yyyy");
            return dateTime;
        }



    }//Functions
}//OEWebData