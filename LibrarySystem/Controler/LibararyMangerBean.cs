using LibrarySystem.DataPers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibrarySystem.Controler
{
    public class LibararyMangerBean : LibraryManager
    {
        public void Login(String user, String pass)
        {
           
            LibraryDatasetTableAdapters.AccountAdminTableAdapter admin = DataAccess.Instance.AccountAdminTA;
            var a = admin.GetData(user);

            if (a.Count() == 0)
            {
                  throw new AccountLoginException("Invalid Account Name");
            }
            else if (a.Count == 1)
            {
                if (a[0].pass.Equals(pass))
                {
                   
                }
                else
                {
                     throw new AccountLoginException("Incorrect Password");
                }
            }
            else
            {
                 throw new AccountLoginException("Data Base Error! There is more than one account having the same user and passwrod");
            }
        }
    }
}
