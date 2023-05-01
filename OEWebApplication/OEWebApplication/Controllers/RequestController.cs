using Microsoft.AspNetCore.Mvc;
using OEWebApplication.Models;
using OEWebData;
using System;                     // For system functions like Console.
using System.Collections.Generic; // For generic collections like List.
using System.Data.SqlClient;      // For the database connections and objects.
using System.Threading.Tasks;
using System.Data.Common;
using MessagePack.Formatters;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEWebApplication.Controllers
{

    public class RequestController : Controller
    {
        Functions function = new();
        ConfigClass configclass = new();


        public IActionResult accounts()

        {
            List<ViewGlaccount> accounts = ViewGlaccountManager.GetAccounts();

            List<AccountsModel> combinedList = (
                from account in accounts
                select new AccountsModel
                {
                    Account = accounts.Account,
                    Account_Title = accounts.AccountTitle,
                    Gate_Keeper = accounts.GateKeeper,
                    Approval_Threshold = accounts.ApprovalThreshold,
                    Approval_Gate_Keeper = accounts.ApprovalGate_Keeper

                }
                ).ToList();
            return View(accounts);
        }

        //public IActionResult Index()
        //{
        //    //ViewBag.UserName = configclass.username();
        //    //ViewBag.DateTime = function.dateTime();

        //    List<AccountsModel> viewGlaccount = new List<AccountsModel>();
        //    string queryString = "exec spr_GLM_Accounts_User @windowsUser = 'edoucett'";
        //    string connectionString = "Data Source=VMORTL\\SQLEXPRESS;Initial Catalog=TimberlineLink;Persist Security Info=True;User Id=ITMain;" +
        //        "Password=M0rr1s0n1961; TrustServerCertificate=true";

        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        con.Open();
        //        DataSet ds;
        //        ds = new DataSet();
        //        SqlDataAdapter da = new SqlDataAdapter(queryString, connectionString);
        //        da.Fill(ds);

        //        using (SqlCommand cmd = new SqlCommand(queryString, con))
        //        {
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                string Account = reader.GetString(0);
        //                string Account_Title = reader.GetString(1);
        //                string Gate_Keeper = reader.GetString(2);
        //                double Approval_Threshold = reader.GetDouble(3);
        //                string Approval_gateKeeper = reader.GetString(4);
        //                viewGlaccount.Add(new AccountsModel
        //                {
        //                    Account = Account,
        //                    Account_Title = Account_Title,
        //                    Gate_Keeper = Gate_Keeper,
        //                    Approval_Threshold = Approval_Threshold,
        //                    Approval_Gate_Keeper = Approval_gateKeeper
        //                });
        //            }//while
        //        }//createcommand
        //    }//connection
        //    return View();
        //}


    }//class
}//namespace
