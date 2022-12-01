using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class AcadStafs: IAllStaffsFunctnalitis
    {
        public bool id       { get; set; }
        public string idColor{ get; set; }  
        public string name   { get; set; }
        public bool carSpace { get; set; }
        string IAllStaffsFunctnalitis.email { get; set; }
        string IAllStaffsFunctnalitis.password { get ; set ; }

        void IAllStaffsFunctnalitis.EditAcctDetails()
        {
            throw new NotImplementedException();
        }

        void IAllStaffsFunctnalitis.Login()
        {
            throw new NotImplementedException();
        }

        void IAllStaffsFunctnalitis.Logout()
        {
            throw new NotImplementedException();
        }

        void IAllStaffsFunctnalitis.Register()
        {
            throw new NotImplementedException();
        }
    }
}
