using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public interface IAllStaffsFunctnalitis
    {
         string email { get; set; } 
        string name { get; set; }   
         string password { get; set; }   

        void Register();
        void Login(); 
        void Logout();
        void EditAcctDetails();

    }
}
