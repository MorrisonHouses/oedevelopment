using System.Security.Principal;

namespace OEWebData
{
    public class UserFunctions
    {
        public void UserName()
        {
            IntPtr accountToken = WindowsIdentity.GetCurrent().Token;
            Console.WriteLine("Token number is: " + accountToken.ToString());
        }


    }
}