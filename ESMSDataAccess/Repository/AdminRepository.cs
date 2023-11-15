using ESMSBusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESMSDataAccess.Repository
{
    public class AdminRepository : IAdminRepository
    {
        public Admin GetMemberByID(int id) => AdminDAO.Instance.GetMemberByID(id);
        public string checkLogin(string username, string password) => AdminDAO.Instance.checkLogin(username, password);
        public IEnumerable<Admin> GetMembers() => AdminDAO.Instance.GetMembers();
    }
}
