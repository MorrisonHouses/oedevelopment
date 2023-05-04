using OEWebApplicationApp.Models;

namespace OEWebApplicationApp
{
    public class ViewGLaccountManager
    {

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

    }//class
}//namespace
