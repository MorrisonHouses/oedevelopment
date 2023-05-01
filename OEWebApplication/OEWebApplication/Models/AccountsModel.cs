
using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OEWebApplication.Models
{
    public class AccountsModel 
    {
        public string? Account { get; set; }
        public string? Account_Title { get; set; }
        public string? Gate_Keeper { get; set; }
        public double? Approval_Threshold { get; set; }
        public string? Approval_Gate_Keeper { get; set; }
        public override string ToString()
        {
            return string.Format("Account: {0}, Account_title: {1}, Gate_keeper {2}, Approval {3}, Approval_gate_keeper {4}"
                , Account, Account_Title, Gate_Keeper, Approval_Threshold, Approval_Gate_Keeper);
        }

    }//AccountsModel

}//namespace
