namespace ESMSWinApp
{
    partial class ESMSManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbExamScheduleID = new Label();
            lbExamScheduleLecturer = new Label();
            lbExamScheduleRoom = new Label();
            lbExamScheduleCourse = new Label();
            lbExamSlotID = new Label();
            txtExamScheduleID = new TextBox();
            txtExamScheduleRoom = new TextBox();
            txtExamScheduleLecturer = new TextBox();
            txtExamScheduleCourse = new TextBox();
            txtExamSlotID = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClose = new Button();
            dgvEsmsManager = new DataGridView();
            txtSearchRoom = new TextBox();
            txtSearchCourse = new TextBox();
            btnSearchCourse = new Button();
            btnSearchRoom = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEsmsManager).BeginInit();
            SuspendLayout();
            // 
            // lbExamScheduleID
            // 
            lbExamScheduleID.AutoSize = true;
            lbExamScheduleID.Location = new Point(69, 45);
            lbExamScheduleID.Name = "lbExamScheduleID";
            lbExamScheduleID.Size = new Size(120, 20);
            lbExamScheduleID.TabIndex = 1;
            lbExamScheduleID.Text = "ExamScheduleID";
            // 
            // lbExamScheduleLecturer
            // 
            lbExamScheduleLecturer.AutoSize = true;
            lbExamScheduleLecturer.Location = new Point(69, 143);
            lbExamScheduleLecturer.Name = "lbExamScheduleLecturer";
            lbExamScheduleLecturer.Size = new Size(158, 20);
            lbExamScheduleLecturer.TabIndex = 2;
            lbExamScheduleLecturer.Text = "ExamScheduleLecturer";
            // 
            // lbExamScheduleRoom
            // 
            lbExamScheduleRoom.AutoSize = true;
            lbExamScheduleRoom.Location = new Point(69, 96);
            lbExamScheduleRoom.Name = "lbExamScheduleRoom";
            lbExamScheduleRoom.Size = new Size(145, 20);
            lbExamScheduleRoom.TabIndex = 3;
            lbExamScheduleRoom.Text = "ExamScheduleRoom";
            // 
            // lbExamScheduleCourse
            // 
            lbExamScheduleCourse.AutoSize = true;
            lbExamScheduleCourse.Location = new Point(551, 45);
            lbExamScheduleCourse.Name = "lbExamScheduleCourse";
            lbExamScheduleCourse.Size = new Size(150, 20);
            lbExamScheduleCourse.TabIndex = 4;
            lbExamScheduleCourse.Text = "ExamScheduleCourse";
            // 
            // lbExamSlotID
            // 
            lbExamSlotID.AutoSize = true;
            lbExamSlotID.Location = new Point(551, 96);
            lbExamSlotID.Name = "lbExamSlotID";
            lbExamSlotID.Size = new Size(86, 20);
            lbExamSlotID.TabIndex = 5;
            lbExamSlotID.Text = "ExamSlotID";
            // 
            // txtExamScheduleID
            // 
            txtExamScheduleID.Location = new Point(240, 42);
            txtExamScheduleID.Name = "txtExamScheduleID";
            txtExamScheduleID.Size = new Size(267, 27);
            txtExamScheduleID.TabIndex = 6;
            // 
            // txtExamScheduleRoom
            // 
            txtExamScheduleRoom.Location = new Point(240, 93);
            txtExamScheduleRoom.Name = "txtExamScheduleRoom";
            txtExamScheduleRoom.Size = new Size(267, 27);
            txtExamScheduleRoom.TabIndex = 7;
            // 
            // txtExamScheduleLecturer
            // 
            txtExamScheduleLecturer.Location = new Point(240, 140);
            txtExamScheduleLecturer.Name = "txtExamScheduleLecturer";
            txtExamScheduleLecturer.Size = new Size(267, 27);
            txtExamScheduleLecturer.TabIndex = 8;
            // 
            // txtExamScheduleCourse
            // 
            txtExamScheduleCourse.Location = new Point(707, 42);
            txtExamScheduleCourse.Name = "txtExamScheduleCourse";
            txtExamScheduleCourse.Size = new Size(259, 27);
            txtExamScheduleCourse.TabIndex = 9;
            // 
            // txtExamSlotID
            // 
            txtExamSlotID.Location = new Point(707, 93);
            txtExamSlotID.Name = "txtExamSlotID";
            txtExamSlotID.Size = new Size(259, 27);
            txtExamSlotID.TabIndex = 10;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(99, 204);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(86, 34);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(317, 204);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(86, 34);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(579, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 34);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(825, 204);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 34);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(483, 583);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 34);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvEsmsManager
            // 
            dgvEsmsManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEsmsManager.Location = new Point(12, 244);
            dgvEsmsManager.Name = "dgvEsmsManager";
            dgvEsmsManager.RowHeadersWidth = 51;
            dgvEsmsManager.RowTemplate.Height = 29;
            dgvEsmsManager.Size = new Size(1042, 333);
            dgvEsmsManager.TabIndex = 16;
            dgvEsmsManager.CellContentDoubleClick += dgvEsmsManager_CellContentDoubleClick;
            // 
            // txtSearchRoom
            // 
            txtSearchRoom.Location = new Point(551, 140);
            txtSearchRoom.Name = "txtSearchRoom";
            txtSearchRoom.Size = new Size(125, 27);
            txtSearchRoom.TabIndex = 17;
            // 
            // txtSearchCourse
            // 
            txtSearchCourse.Location = new Point(799, 140);
            txtSearchCourse.Name = "txtSearchCourse";
            txtSearchCourse.Size = new Size(125, 27);
            txtSearchCourse.TabIndex = 19;
            // 
            // btnSearchCourse
            // 
            btnSearchCourse.Location = new Point(930, 139);
            btnSearchCourse.Name = "btnSearchCourse";
            btnSearchCourse.Size = new Size(111, 29);
            btnSearchCourse.TabIndex = 20;
            btnSearchCourse.Text = "SearchCourse";
            btnSearchCourse.UseVisualStyleBackColor = true;
            btnSearchCourse.Click += btnSearchCourse_Click;
            // 
            // btnSearchRoom
            // 
            btnSearchRoom.Location = new Point(682, 139);
            btnSearchRoom.Name = "btnSearchRoom";
            btnSearchRoom.Size = new Size(111, 29);
            btnSearchRoom.TabIndex = 21;
            btnSearchRoom.Text = "SearchRoom";
            btnSearchRoom.UseVisualStyleBackColor = true;
            btnSearchRoom.Click += btnSearchRoom_Click;
            // 
            // ESMSManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 629);
            Controls.Add(btnSearchRoom);
            Controls.Add(btnSearchCourse);
            Controls.Add(txtSearchCourse);
            Controls.Add(txtSearchRoom);
            Controls.Add(dgvEsmsManager);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtExamSlotID);
            Controls.Add(txtExamScheduleCourse);
            Controls.Add(txtExamScheduleLecturer);
            Controls.Add(txtExamScheduleRoom);
            Controls.Add(txtExamScheduleID);
            Controls.Add(lbExamSlotID);
            Controls.Add(lbExamScheduleCourse);
            Controls.Add(lbExamScheduleRoom);
            Controls.Add(lbExamScheduleLecturer);
            Controls.Add(lbExamScheduleID);
            Name = "ESMSManager";
            Text = "ESMSManager";
            Load += ESMSManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEsmsManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbExamScheduleID;
        private Label lbExamScheduleLecturer;
        private Label lbExamScheduleRoom;
        private Label lbExamScheduleCourse;
        private Label lbExamSlotID;
        private TextBox txtExamScheduleID;
        private TextBox txtExamScheduleRoom;
        private TextBox txtExamScheduleLecturer;
        private TextBox txtExamScheduleCourse;
        private TextBox txtExamSlotID;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClose;
        private DataGridView dgvEsmsManager;
        private TextBox txtSearchRoom;
        private TextBox txtSearchCourse;
        private Button btnSearchCourse;
        private Button btnSearchRoom;
    }
}