namespace ESMSWinApp
{
    partial class ESMSDetail
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
            ExamScheduleRoom = new Label();
            lbExamScheduleLecturer = new Label();
            lbExamScheduleCourse = new Label();
            lbExamSlotID = new Label();
            txtExamScheduleID = new TextBox();
            txtExamScheduleRoom = new TextBox();
            txtExamScheduleLecturer = new TextBox();
            txtExamScheduleCourse = new TextBox();
            txtExamSlotID = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbExamScheduleID
            // 
            lbExamScheduleID.AutoSize = true;
            lbExamScheduleID.Location = new Point(48, 49);
            lbExamScheduleID.Name = "lbExamScheduleID";
            lbExamScheduleID.Size = new Size(120, 20);
            lbExamScheduleID.TabIndex = 0;
            lbExamScheduleID.Text = "ExamScheduleID";
            // 
            // ExamScheduleRoom
            // 
            ExamScheduleRoom.AutoSize = true;
            ExamScheduleRoom.Location = new Point(48, 110);
            ExamScheduleRoom.Name = "ExamScheduleRoom";
            ExamScheduleRoom.Size = new Size(145, 20);
            ExamScheduleRoom.TabIndex = 1;
            ExamScheduleRoom.Text = "ExamScheduleRoom";
            // 
            // lbExamScheduleLecturer
            // 
            lbExamScheduleLecturer.AutoSize = true;
            lbExamScheduleLecturer.Location = new Point(48, 172);
            lbExamScheduleLecturer.Name = "lbExamScheduleLecturer";
            lbExamScheduleLecturer.Size = new Size(158, 20);
            lbExamScheduleLecturer.TabIndex = 2;
            lbExamScheduleLecturer.Text = "ExamScheduleLecturer";
            // 
            // lbExamScheduleCourse
            // 
            lbExamScheduleCourse.AutoSize = true;
            lbExamScheduleCourse.Location = new Point(48, 234);
            lbExamScheduleCourse.Name = "lbExamScheduleCourse";
            lbExamScheduleCourse.Size = new Size(150, 20);
            lbExamScheduleCourse.TabIndex = 3;
            lbExamScheduleCourse.Text = "ExamScheduleCourse";
            // 
            // lbExamSlotID
            // 
            lbExamSlotID.AutoSize = true;
            lbExamSlotID.Location = new Point(48, 294);
            lbExamSlotID.Name = "lbExamSlotID";
            lbExamSlotID.Size = new Size(86, 20);
            lbExamSlotID.TabIndex = 4;
            lbExamSlotID.Text = "ExamSlotID";
            // 
            // txtExamScheduleID
            // 
            txtExamScheduleID.Location = new Point(224, 46);
            txtExamScheduleID.Name = "txtExamScheduleID";
            txtExamScheduleID.Size = new Size(255, 27);
            txtExamScheduleID.TabIndex = 5;
            // 
            // txtExamScheduleRoom
            // 
            txtExamScheduleRoom.Location = new Point(224, 107);
            txtExamScheduleRoom.Name = "txtExamScheduleRoom";
            txtExamScheduleRoom.Size = new Size(255, 27);
            txtExamScheduleRoom.TabIndex = 6;
            // 
            // txtExamScheduleLecturer
            // 
            txtExamScheduleLecturer.Location = new Point(224, 169);
            txtExamScheduleLecturer.Name = "txtExamScheduleLecturer";
            txtExamScheduleLecturer.Size = new Size(255, 27);
            txtExamScheduleLecturer.TabIndex = 7;
            // 
            // txtExamScheduleCourse
            // 
            txtExamScheduleCourse.Location = new Point(224, 231);
            txtExamScheduleCourse.Name = "txtExamScheduleCourse";
            txtExamScheduleCourse.Size = new Size(255, 27);
            txtExamScheduleCourse.TabIndex = 8;
            // 
            // txtExamSlotID
            // 
            txtExamSlotID.Location = new Point(224, 291);
            txtExamSlotID.Name = "txtExamSlotID";
            txtExamSlotID.Size = new Size(255, 27);
            txtExamSlotID.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(104, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(328, 362);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ESMSDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 433);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtExamSlotID);
            Controls.Add(txtExamScheduleCourse);
            Controls.Add(txtExamScheduleLecturer);
            Controls.Add(txtExamScheduleRoom);
            Controls.Add(txtExamScheduleID);
            Controls.Add(lbExamSlotID);
            Controls.Add(lbExamScheduleCourse);
            Controls.Add(lbExamScheduleLecturer);
            Controls.Add(ExamScheduleRoom);
            Controls.Add(lbExamScheduleID);
            Name = "ESMSDetail";
            Text = "ESMSDetail";
            Load += ESMSDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbExamScheduleID;
        private Label ExamScheduleRoom;
        private Label lbExamScheduleLecturer;
        private Label lbExamScheduleCourse;
        private Label lbExamSlotID;
        private TextBox txtExamScheduleID;
        private TextBox txtExamScheduleRoom;
        private TextBox txtExamScheduleLecturer;
        private TextBox txtExamScheduleCourse;
        private TextBox txtExamSlotID;
        private Button btnSave;
        private Button btnCancel;
    }
}