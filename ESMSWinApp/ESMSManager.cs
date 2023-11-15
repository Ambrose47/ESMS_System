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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ESMSWinApp
{
    public partial class ESMSManager : Form
    {

        IExamScheduleRepository ac = new ExamScheduleRepository();
        //Create a data source
        BindingSource source;
        public bool AdminOrOther { get; set; }
        public ESMSManager()
        {
            InitializeComponent();
        }

        private void dgvEsmsManager_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private ExamSchedule getACs()
        {
            ExamSchedule ac = null;
            try
            {
                ac = new ExamSchedule
                {
                    Id = int.Parse(txtExamScheduleID.Text),
                    Room = txtExamScheduleRoom.Text,
                    Lecturer = txtExamScheduleLecturer.Text,
                    Course = txtExamScheduleCourse.Text,
                    Slotid = int.Parse(txtExamSlotID.Text),

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get AC");
            }
            return ac;
        }
        public void LoadACList()
        {
            var acs = ac.GetAirConditioners();
            try
            {
                source = new BindingSource();
                source.DataSource = acs;

                txtExamScheduleID.DataBindings.Clear();
                txtExamScheduleRoom.DataBindings.Clear();
                txtExamScheduleLecturer.DataBindings.Clear();
                txtExamScheduleCourse.DataBindings.Clear();
                txtExamSlotID.DataBindings.Clear();


                txtExamScheduleID.DataBindings.Add("Text", source, "Id");
                txtExamScheduleRoom.DataBindings.Add("Text", source, "Room");
                txtExamScheduleLecturer.DataBindings.Add("Text", source, "Lecturer");
                txtExamScheduleCourse.DataBindings.Add("Text", source, "Course");
                txtExamSlotID.DataBindings.Add("Text", source, "Slotid");


                dgvEsmsManager.DataSource = null;
                dgvEsmsManager.DataSource = source;

                if (acs.Count() == 0 )
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    if(acs.Count() != 0 && AdminOrOther == true)
                    {
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load ac list");
            }
        }
        private void ClearText()
        {
            txtExamScheduleID.Text = string.Empty;
            txtExamScheduleRoom.Text = string.Empty;
            txtExamScheduleLecturer.Text = string.Empty;
            txtExamScheduleCourse.Text = string.Empty;
            txtExamSlotID.Text = string.Empty;


        }

        private void SetTextBoxReadOnly(bool isReadOnly)
        {
            txtExamScheduleID.ReadOnly = isReadOnly;
            txtExamScheduleRoom.ReadOnly = isReadOnly;
            txtExamScheduleLecturer.ReadOnly = isReadOnly;
            txtExamScheduleCourse.ReadOnly = isReadOnly;
            txtExamSlotID.ReadOnly = isReadOnly;
        }
        private void SetButtonReadOnly(bool isReadOnly)
        {
            btnNew.Enabled = !isReadOnly;
            btnDelete.Enabled = !isReadOnly;
            btnUpdate.Enabled = !isReadOnly;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadACList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ESMSDetail aCDetail = new ESMSDetail
            {
                Text = "Add AC",
                AddOrUpdate = false,
                iExamScheduleRepository = ac,
            };
            aCDetail.ShowDialog();
            LoadACList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var acs = getACs();
                if(acs.Id != null)
                {
                    throw new Exception();
                }
                else
                {
                    ac.RemoveAirConditioner(acs.Id);
                    LoadACList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a ac");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ESMSDetail aCDetail = new ESMSDetail
            {
                Text = "Add AC",
                AddOrUpdate = true,
                iExamScheduleRepository = ac,
                ac = getACs()
            };
            if (aCDetail.ShowDialog() == DialogResult.OK)
            {
                LoadACList();
                source.Position = source.Count - 1;
            }
        }

        private void ESMSManager_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            SetTextBoxReadOnly(AdminOrOther);
            SetButtonReadOnly(AdminOrOther);
            dgvEsmsManager.CellContentDoubleClick += dgvEsmsManager_CellContentDoubleClick;
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            var acs = ac.SearchByRoom(txtSearchRoom.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = acs;

                txtExamScheduleID.DataBindings.Clear();
                txtExamScheduleRoom.DataBindings.Clear();
                txtExamScheduleLecturer.DataBindings.Clear();
                txtExamScheduleCourse.DataBindings.Clear();
                txtExamSlotID.DataBindings.Clear();


                txtExamScheduleID.DataBindings.Add("Text", source, "Id");
                txtExamScheduleRoom.DataBindings.Add("Text", source, "Room");
                txtExamScheduleLecturer.DataBindings.Add("Text", source, "Lecturer");
                txtExamScheduleCourse.DataBindings.Add("Text", source, "Course");
                txtExamSlotID.DataBindings.Add("Text", source, "Slotid");

                dgvEsmsManager.DataSource = null;
                dgvEsmsManager.DataSource = source;
                if (acs.Count() == 0 && AdminOrOther == false)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    if (acs.Count() != 0 && AdminOrOther == true)
                    {
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load ac list");
            }
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            var acs = ac.SearchByCourse(txtSearchCourse.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = acs;

                txtExamScheduleID.DataBindings.Clear();
                txtExamScheduleRoom.DataBindings.Clear();
                txtExamScheduleLecturer.DataBindings.Clear();
                txtExamScheduleCourse.DataBindings.Clear();
                txtExamSlotID.DataBindings.Clear();


                txtExamScheduleID.DataBindings.Add("Text", source, "Id");
                txtExamScheduleRoom.DataBindings.Add("Text", source, "Room");
                txtExamScheduleLecturer.DataBindings.Add("Text", source, "Lecturer");
                txtExamScheduleCourse.DataBindings.Add("Text", source, "Course");
                txtExamSlotID.DataBindings.Add("Text", source, "Slotid");

                dgvEsmsManager.DataSource = null;
                dgvEsmsManager.DataSource = source;
                if (acs.Count() == 0 && AdminOrOther == false)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    if (acs.Count() != 0 && AdminOrOther == true)
                    {
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load ac list");
            }
        }
    }
}
