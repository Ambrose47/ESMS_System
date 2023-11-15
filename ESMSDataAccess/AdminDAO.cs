using ESMSBusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESMSDataAccess
{
    public class AdminDAO
    {
        private static AdminDAO instance = null;
        private static readonly object instanceLock = new object();

        public static AdminDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AdminDAO();
                    }
                    return instance;
                }
            }
        }

        // get Member list

        public IEnumerable<Admin> GetMembers()
        {
            var members = new List<Admin>();
            try
            {
                using var context = new EsmsContext();
                members = context.Admins.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return members;
        }

        // get member by id

        public Admin GetMemberByID(int id)
        {
            Admin member = null;
            try
            {
                using var context = new EsmsContext();
                member = context.Admins.SingleOrDefault(member => member.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return member;
        }

        public string checkLogin(string email, string password)
        {
            Admin member = null;
            string message = null;
            try
            {
                using var context = new EsmsContext();
                member = context.Admins.SingleOrDefault(member => member.Username == email && member.Password == password);
                if (member != null)
                {
                    if (member.Role == "1")
                    {
                        message = "Login success with Admin";
                        return message;
                    }
                    else
                    {
                        if(member.Role == "2" || member.Role == "3")
                        {
                            message = "Login success with Other";
                            return message;
                        }
                        else
                        {
                            message = "Invalid Role";
                            return message;
                        }
                    }
                    

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return message;
        }
    }
}
