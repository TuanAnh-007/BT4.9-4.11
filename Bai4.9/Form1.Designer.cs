namespace Bai4_9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.cboDoctor = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAppointmentId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.grpSearchFilter = new System.Windows.Forms.GroupBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.chkFilterDate = new System.Windows.Forms.CheckBox();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCountStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpSearchFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpSearchFilter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvAppointments, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 515);
            this.tableLayoutPanel1.TabIndex = 0;

            this.grpInput.Controls.Add(this.btnDelete);
            this.grpInput.Controls.Add(this.btnUpdate);
            this.grpInput.Controls.Add(this.btnAdd);
            this.grpInput.Controls.Add(this.cboStatus);
            this.grpInput.Controls.Add(this.lblStatus);
            this.grpInput.Controls.Add(this.txtReason);
            this.grpInput.Controls.Add(this.lblReason);
            this.grpInput.Controls.Add(this.cboDoctor);
            this.grpInput.Controls.Add(this.lblDoctor);
            this.grpInput.Controls.Add(this.dtpAppointmentDate);
            this.grpInput.Controls.Add(this.lblDate);
            this.grpInput.Controls.Add(this.txtPhone);
            this.grpInput.Controls.Add(this.lblPhone);
            this.grpInput.Controls.Add(this.txtPatientName);
            this.grpInput.Controls.Add(this.lblName);
            this.grpInput.Controls.Add(this.txtAppointmentId);
            this.grpInput.Controls.Add(this.lblId);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInput.Location = new System.Drawing.Point(3, 3);
            this.grpInput.Name = "grpInput";
            this.tableLayoutPanel1.SetRowSpan(this.grpInput, 2);
            this.grpInput.Size = new System.Drawing.Size(374, 509);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông tin lịch hẹn";

            this.btnDelete.Location = new System.Drawing.Point(260, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnUpdate.Location = new System.Drawing.Point(140, 420);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 30);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnAdd.Location = new System.Drawing.Point(20, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(115, 365);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(240, 21);
            this.cboStatus.TabIndex = 13;

            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 368);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Trạng thái:";

            this.txtReason.Location = new System.Drawing.Point(115, 270);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(240, 80);
            this.txtReason.TabIndex = 11;

            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(17, 273);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(53, 13);
            this.lblReason.TabIndex = 10;
            this.lblReason.Text = "Lý do khám:";

            this.cboDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctor.FormattingEnabled = true;
            this.cboDoctor.Location = new System.Drawing.Point(115, 225);
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.Size = new System.Drawing.Size(240, 21);
            this.cboDoctor.TabIndex = 9;

            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(17, 228);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(42, 13);
            this.lblDoctor.TabIndex = 8;
            this.lblDoctor.Text = "Bác sĩ:";

            this.dtpAppointmentDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(115, 180);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(240, 20);
            this.dtpAppointmentDate.TabIndex = 7;

            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 183);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Ngày giờ hẹn:";

            this.txtPhone.Location = new System.Drawing.Point(115, 135);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 20);
            this.txtPhone.TabIndex = 5;

            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(17, 138);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Số điện thoại:";

            this.txtPatientName.Location = new System.Drawing.Point(115, 90);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(240, 20);
            this.txtPatientName.TabIndex = 3;

            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên bệnh nhân:";

            this.txtAppointmentId.Location = new System.Drawing.Point(115, 45);
            this.txtAppointmentId.Name = "txtAppointmentId";
            this.txtAppointmentId.Size = new System.Drawing.Size(240, 20);
            this.txtAppointmentId.TabIndex = 1;

            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(17, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã lịch hẹn:";

            this.grpSearchFilter.Controls.Add(this.btnResetFilter);
            this.grpSearchFilter.Controls.Add(this.dtpFilterDate);
            this.grpSearchFilter.Controls.Add(this.chkFilterDate);
            this.grpSearchFilter.Controls.Add(this.cboFilterStatus);
            this.grpSearchFilter.Controls.Add(this.lblFilterStatus);
            this.grpSearchFilter.Controls.Add(this.txtSearch);
            this.grpSearchFilter.Controls.Add(this.lblSearch);
            this.grpSearchFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSearchFilter.Location = new System.Drawing.Point(383, 3);
            this.grpSearchFilter.Name = "grpSearchFilter";
            this.grpSearchFilter.Size = new System.Drawing.Size(622, 374);
            this.grpSearchFilter.TabIndex = 1;
            this.grpSearchFilter.TabStop = false;
            this.grpSearchFilter.Text = "Tìm kiếm và Lọc dữ liệu";

            this.btnResetFilter.Location = new System.Drawing.Point(495, 30);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(100, 60);
            this.btnResetFilter.TabIndex = 6;
            this.btnResetFilter.Text = "Xóa bộ lọc";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);

            this.dtpFilterDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterDate.Location = new System.Drawing.Point(325, 70);
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new System.Drawing.Size(150, 20);
            this.dtpFilterDate.TabIndex = 5;
            this.dtpFilterDate.ValueChanged += new System.EventHandler(this.Filter_Changed);

            this.chkFilterDate.AutoSize = true;
            this.chkFilterDate.Location = new System.Drawing.Point(230, 72);
            this.chkFilterDate.Name = "chkFilterDate";
            this.chkFilterDate.Size = new System.Drawing.Size(91, 17);
            this.chkFilterDate.TabIndex = 4;
            this.chkFilterDate.Text = "Lọc theo ngày:";
            this.chkFilterDate.UseVisualStyleBackColor = true;
            this.chkFilterDate.CheckedChanged += new System.EventHandler(this.Filter_Changed);

            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Location = new System.Drawing.Point(75, 70);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(140, 21);
            this.cboFilterStatus.TabIndex = 3;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);

            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Location = new System.Drawing.Point(15, 73);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(58, 13);
            this.lblFilterStatus.TabIndex = 2;
            this.lblFilterStatus.Text = "Trạng thái:";

            this.txtSearch.Location = new System.Drawing.Point(175, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 33);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(154, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm (Tên / Số điện thoại):";

            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colPhone,
            this.colDate,
            this.colDoctor,
            this.colReason,
            this.colStatus});
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.Location = new System.Drawing.Point(383, 383);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(622, 129);
            this.dgvAppointments.TabIndex = 2;
            this.dgvAppointments.SelectionChanged += new System.EventHandler(this.dgvAppointments_SelectionChanged);

            this.colId.DataPropertyName = "AppointmentId";
            this.colId.HeaderText = "Mã lịch hẹn";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;

            this.colName.DataPropertyName = "PatientName";
            this.colName.HeaderText = "Bệnh nhân";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;

            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Số điện thoại";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;

            this.colDate.DataPropertyName = "AppointmentDate";
            this.colDate.HeaderText = "Ngày giờ hẹn";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;

            this.colDoctor.DataPropertyName = "Doctor";
            this.colDoctor.HeaderText = "Bác sĩ";
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.ReadOnly = true;

            this.colReason.DataPropertyName = "Reason";
            this.colReason.HeaderText = "Lý do khám";
            this.colReason.Name = "colReason";
            this.colReason.ReadOnly = true;

            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";

            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportCSV});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";

            this.mnuExportCSV.Name = "mnuExportCSV";
            this.mnuExportCSV.Size = new System.Drawing.Size(193, 22);
            this.mnuExportCSV.Text = "Xuất danh sách ra CSV";
            this.mnuExportCSV.Click += new System.EventHandler(this.mnuExportCSV_Click);

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCountStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";

            this.lblCountStatus.Name = "lblCountStatus";
            this.lblCountStatus.Size = new System.Drawing.Size(117, 17);
            this.lblCountStatus.Text = "Tổng số lịch hẹn: 0";

            this.errorProvider1.ContainerControl = this;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Appointment Manager - Bài 4.9";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpSearchFilter.ResumeLayout(false);
            this.grpSearchFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpSearchFilter;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExportCSV;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCountStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.ComboBox cboDoctor;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.CheckBox chkFilterDate;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}