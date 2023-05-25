using Microsoft.Data.SqlClient;
using OEWebApplicationApp.Models;
using System.Data;

namespace OEWebApplicationApp
{
    public class ViewGLaccountManager
    {
        ClassFunctions function = new();
        ClassConfig configclass = new();

        /// <summary>
        /// view all accounts
        /// </summary>
        /// <returns></returns>
        public static  List<ViewGlaccount> GetViewGlaccounts()
        {
            TimberlineLinkContext context = new TimberlineLinkContext();
            List<ViewGlaccount> viewGlaccounts = context.ViewGlaccounts.ToList();
            return viewGlaccounts;
        }

        /// <summary>
        /// insures that the person loggin in is a requester based on the GateKeeper field====================================
        /// </summary>
        /// <returns>bool</returns>
        public static Boolean GetRequestBool()
        {
            ClassConfig classConfig = new ClassConfig();
            List<ViewGlaccount> viewGlaccounts = ViewGLaccountManager.GetViewGlaccounts();

            List<ViewGlaccountModel> listing = (
                from ViewGlaccount in viewGlaccounts
                where ViewGlaccount.GateKeeper == classConfig.username()
                select new ViewGlaccountModel
                {
                    Account = ViewGlaccount.Account,
                }
                ).ToList();
            int count = listing.Count();
            bool check = false;
            if (count > 0) { check = true; } else { check = false; };
            return check;
        }//GetRequestBool

        /// <summary>
        /// checks if the person loggin in is an approver based on the ApprovalGateKeeper field===================================================
        /// </summary>
        /// <returns></returns>
        public static Boolean GetApprovalBool()
        {
            ClassConfig classConfig = new ClassConfig();
            List<ViewGlaccount> viewGlaccounts = ViewGLaccountManager.GetViewGlaccounts();

            List<ViewGlaccountModel> listing = (
                from ViewGlaccount in viewGlaccounts
                where ViewGlaccount.ApprovalGateKeeper == classConfig.username()
                select new ViewGlaccountModel
                {
                    Account = ViewGlaccount.Account,
                }
                ).ToList();
            int count = listing.Count();
            bool check = false;
            if (count > 0) { check = true; } else { check = false; };
            return check;
        }//GetApprovalBool

        //GET ALL GLACCOUNTS ======================================================================
        public List<ViewGlaccountModel> GetAllGlAccounts()
        {
            ClassConfig classConfig = new ClassConfig();

            List<ViewGlaccountModel> listOfGls = new List<ViewGlaccountModel>();
            string username = configclass.username();
            
            string config = @"Data Source=VMORTL\SQLEXPRESS;Initial Catalog=TimberlineLink;User ID=ITMain; Password=M0rr1s0n1961; TrustServerCertificate = True";
            using (SqlConnection connection = new SqlConnection(config))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spr_GLM_Accounts_User";
                command.Parameters.AddWithValue("@windowsUser", username);
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                DataTable dtOE = new DataTable();
                connection.Open();
                sqlda.Fill(dtOE);
                connection.Close();
                foreach (DataRow dr in dtOE.Rows)
                {
                    listOfGls.Add(new ViewGlaccountModel
                    {
                        AccountCustomField = dr["Account_Custom_Field"].ToString(),
                        AccountTitle = dr["Account_Title"].ToString(),
                        ApprovalGateKeeper = (string)dr["Approval_Gate_Keeper"],
                        ApprovalThreshold = (double?)dr["Approval_Threshold"],
                        GateKeeper = dr["Gate_Keeper"].ToString(),
                    }); //list
                }//foreach
            }//using
            return listOfGls;
        }//GetAllGlAccounts


    }//class
}//namespace
