using ESMSDataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESMSWinApp
{
    public partial class ESMSLogin : Form
    {
        IAdminRepository iAdminRepository = new AdminRepository();
        public ESMSLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string message = iAdminRepository.checkLogin(txtUsername.Text, txtPassword.Text);
            ESMSManager esmsManager = null;
            if (message == "Login success with Admin")
            {
                esmsManager = new ESMSManager
                {
                    AdminOrOther = false,
                };
                esmsManager.Closed += (s, args) => this.Close();
                this.Hide();
                esmsManager.Show();
            }
            else
            {
                if(message == "Login success with Other")
                {
                    esmsManager = new ESMSManager
                    {
                        AdminOrOther = true,
                    };
                    esmsManager.Closed += (s, args) => this.Close();
                    this.Hide();
                    esmsManager.Show();
                }
                else if (message == "Invalid Role")
                {
                    MessageBox.Show("You have no permission to access this function!");
                    txtUsername.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid Account");
                    txtUsername.Focus();
                }
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
