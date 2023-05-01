using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEWebData
{
    public class ViewGlaccountManager
    {
        public static List<ViewGlaccount> GetAccounts()
        {
            TimberlineLinkContext db = new TimberlineLinkContext();
            List<ViewGlaccount> viewGlaccounts = db.ViewGlaccounts.ToList();
            
            return viewGlaccounts;
        }
    }//class
}//namespace
