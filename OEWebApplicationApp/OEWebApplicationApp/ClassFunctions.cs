
using System.Security.Principal;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using OEWebApplicationApp.Models;

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


    }//Functions
}//OEWebData