using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Windows.Forms;

namespace LearnPrograms
{
    class UserClass
    {
     
        public string GetUserName()
        {
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                return user.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get username! Error Information: "+ex.ToString(), "User Name error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;                
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }
    }
}
