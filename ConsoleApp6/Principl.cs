using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Principl : IPrincplFunctnalitis
    {
        public bool id { get; set; }
        public string idColor { get; set; }
        public string name { get; set; }
        public bool carSpace { get; set; }
        public string email { get; set; }
        public string password { get ; set; }

        public void AddOrRemove()
        {
            throw new NotImplementedException();
        }

        public void EditAcctDetails()
        {
            throw new NotImplementedException();
        }

        public void Login()
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public void Register()
        {
            throw new NotImplementedException();
        }

        public void TransferAdminRole()
        {
            throw new NotImplementedException();
        }

        public void TransferAdminRole(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
