using ESMSBusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESMSDataAccess.Repository
{
    public interface IAdminRepository
    {
        IEnumerable<Admin> GetMembers();
        Admin GetMemberByID(int id);
        string checkLogin(string username, string password);
    }
}
