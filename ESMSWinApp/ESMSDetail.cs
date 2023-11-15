using ESMSBusinessObject.Model;
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
    public partial class ESMSDetail : Form
    {
        public ESMSDetail()
        {
            InitializeComponent();
        }

        public IExamScheduleRepository iExamScheduleRepository { get; set; }
        //iSupplierCompanyRepository sup = new SupplierCompanyRepository();
        public bool AddOrUpdate { get; set; }

        public ExamSchedule ac { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //string company = sup.GetCompanyByID(txtSupplier.Text);
                if (!isValidDataInput())
                {
                    MessageBox.Show("Must input all field");
                }

                else if (isValidDataInput())
                {
                    var ac = new ExamSchedule
                    {
                        Id = int.Parse(txtExamScheduleID.Text),
                        Room = txtExamScheduleRoom.Text,
                        Lecturer = txtExamScheduleLecturer.Text,
                        Course = txtExamScheduleCourse.Text,
                        Slotid = int.Parse(txtExamSlotID.Text),
                    };
                    if (AddOrUpdate == false)
                    {
                        iExamScheduleRepository.AddNewAirConditioner(ac);
                        MessageBox.Show("Add AC success!");
                        this.Close();
                    }
                    else
                    {
                        iExamScheduleRepository.UpdateAirConditioner(ac);
                        MessageBox.Show("Update AC success!");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AddOrUpdate == false ? "Add new AC" : "Update AC");
            }
        }

        bool isValidDataInput()
        {
            return !String.IsNullOrEmpty(txtExamScheduleID.Text) &&
                   !String.IsNullOrEmpty(txtExamScheduleRoom.Text) &&
                   !String.IsNullOrEmpty(txtExamScheduleLecturer.Text) &&
                   !String.IsNullOrEmpty(txtExamScheduleCourse.Text) &&
                   !String.IsNullOrEmpty(txtExamSlotID.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void ESMSDetail_Load(object sender, EventArgs e)
        {
            txtExamScheduleID.Enabled = !AddOrUpdate;
            if (AddOrUpdate == true) //Update
            {
                txtExamScheduleID.Text = ac.Id.ToString();
                txtExamScheduleRoom.Text = ac.Room;
                txtExamScheduleLecturer.Text = ac.Lecturer;
                txtExamScheduleCourse.Text = ac.Course;
                txtExamSlotID.Text = ac.Slotid.ToString();

            }
        }
    }
}
