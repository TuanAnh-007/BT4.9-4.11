namespace Bai4_10
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
            this.btnMarkReturned = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.lblLoanDate = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cboEquipment = new System.Windows.Forms.ComboBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtLoanId = new System.Windows.Forms.TextBox();
            this.lblLoanId = new System.Windows.Forms.Label();
            this.grpSearchFilter = new System.Windows.Forms.GroupBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.colLoanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotalCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOverdueCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpSearchFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpSearchFilter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvLoans, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 550);
            this.tableLayoutPanel1.TabIndex = 0;

            this.grpInput.Controls.Add(this.btnMarkReturned);
            this.grpInput.Controls.Add(this.btnDelete);
            this.grpInput.Controls.Add(this.btnUpdate);
            this.grpInput.Controls.Add(this.btnAdd);
            this.grpInput.Controls.Add(this.cboStatus);
            this.grpInput.Controls.Add(this.lblStatus);
            this.grpInput.Controls.Add(this.dtpReturnDate);
            this.grpInput.Controls.Add(this.lblReturnDate);
            this.grpInput.Controls.Add(this.dtpDueDate);
            this.grpInput.Controls.Add(this.lblDueDate);
            this.grpInput.Controls.Add(this.dtpLoanDate);
            this.grpInput.Controls.Add(this.lblLoanDate);
            this.grpInput.Controls.Add(this.txtQuantity);
            this.grpInput.Controls.Add(this.lblQuantity);
            this.grpInput.Controls.Add(this.cboEquipment);
            this.grpInput.Controls.Add(this.lblEquipment);
            this.grpInput.Controls.Add(this.txtStudentName);
            this.grpInput.Controls.Add(this.lblStudentName);
            this.grpInput.Controls.Add(this.txtStudentId);
            this.grpInput.Controls.Add(this.lblStudentId);
            this.grpInput.Controls.Add(this.txtLoanId);
            this.grpInput.Controls.Add(this.lblLoanId);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInput.Location = new System.Drawing.Point(3, 3);
            this.grpInput.Name = "grpInput";
            this.tableLayoutPanel1.SetRowSpan(this.grpInput, 2);
            this.grpInput.Size = new System.Drawing.Size(374, 544);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông tin phiếu mượn thiết bị";

            this.btnMarkReturned.Location = new System.Drawing.Point(20, 480);
            this.btnMarkReturned.Name = "btnMarkReturned";
            this.btnMarkReturned.Size = new System.Drawing.Size(334, 30);
            this.btnMarkReturned.TabIndex = 21;
            this.btnMarkReturned.Text = "Đánh dấu Đã trả";
            this.btnMarkReturned.UseVisualStyleBackColor = true;
            this.btnMarkReturned.Click += new System.EventHandler(this.btnMarkReturned_Click);

            this.btnDelete.Location = new System.Drawing.Point(255, 435);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnUpdate.Location = new System.Drawing.Point(140, 435);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 30);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnAdd.Location = new System.Drawing.Point(20, 435);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 30);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(115, 395);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(240, 21);
            this.cboStatus.TabIndex = 17;

            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 398);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 13);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Tình trạng:";

            this.dtpReturnDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnDate.Location = new System.Drawing.Point(115, 350);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.ShowCheckBox = true;
            this.dtpReturnDate.Size = new System.Drawing.Size(240, 20);
            this.dtpReturnDate.TabIndex = 15;

            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(17, 353);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(77, 13);
            this.lblReturnDate.TabIndex = 14;
            this.lblReturnDate.Text = "Ngày trả thực tế:";

            this.dtpDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(115, 305);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(240, 20);
            this.dtpDueDate.TabIndex = 13;

            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(17, 308);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(50, 13);
            this.lblDueDate.TabIndex = 12;
            this.lblDueDate.Text = "Hạn trả:";

            this.dtpLoanDate.CustomFormat = "dd/MM/yyyy";
            this.dtpLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoanDate.Location = new System.Drawing.Point(115, 260);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(240, 20);
            this.dtpLoanDate.TabIndex = 11;

            this.lblLoanDate.AutoSize = true;
            this.lblLoanDate.Location = new System.Drawing.Point(17, 263);
            this.lblLoanDate.Name = "lblLoanDate";
            this.lblLoanDate.Size = new System.Drawing.Size(63, 13);
            this.lblLoanDate.TabIndex = 10;
            this.lblLoanDate.Text = "Ngày mượn:";

            this.txtQuantity.Location = new System.Drawing.Point(115, 215);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(240, 20);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.Text = "1";

            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(17, 218);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(52, 13);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Số lượng:";

            this.cboEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquipment.FormattingEnabled = true;
            this.cboEquipment.Location = new System.Drawing.Point(115, 170);
            this.cboEquipment.Name = "cboEquipment";
            this.cboEquipment.Size = new System.Drawing.Size(240, 21);
            this.cboEquipment.TabIndex = 7;

            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(17, 173);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(47, 13);
            this.lblEquipment.TabIndex = 6;
            this.lblEquipment.Text = "Thiết bị:";

            this.txtStudentName.Location = new System.Drawing.Point(115, 125);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(240, 20);
            this.txtStudentName.TabIndex = 5;

            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(17, 128);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(76, 13);
            this.lblStudentName.TabIndex = 4;
            this.lblStudentName.Text = "Tên sinh viên:";

            this.txtStudentId.Location = new System.Drawing.Point(115, 80);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(240, 20);
            this.txtStudentId.TabIndex = 3;

            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(17, 83);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(70, 13);
            this.lblStudentId.TabIndex = 2;
            this.lblStudentId.Text = "Mã sinh viên:";

            this.txtLoanId.Location = new System.Drawing.Point(115, 35);
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.Size = new System.Drawing.Size(240, 20);
            this.txtLoanId.TabIndex = 1;

            this.lblLoanId.AutoSize = true;
            this.lblLoanId.Location = new System.Drawing.Point(17, 38);
            this.lblLoanId.Name = "lblLoanId";
            this.lblLoanId.Size = new System.Drawing.Size(55, 13);
            this.lblLoanId.TabIndex = 0;
            this.lblLoanId.Text = "Mã phiếu:";

            this.grpSearchFilter.Controls.Add(this.btnResetFilter);
            this.grpSearchFilter.Controls.Add(this.cboFilterStatus);
            this.grpSearchFilter.Controls.Add(this.lblFilterStatus);
            this.grpSearchFilter.Controls.Add(this.txtSearch);
            this.grpSearchFilter.Controls.Add(this.lblSearch);
            this.grpSearchFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSearchFilter.Location = new System.Drawing.Point(383, 3);
            this.grpSearchFilter.Name = "grpSearchFilter";
            this.grpSearchFilter.Size = new System.Drawing.Size(638, 414);
            this.grpSearchFilter.TabIndex = 1;
            this.grpSearchFilter.TabStop = false;
            this.grpSearchFilter.Text = "Tìm kiếm và Lọc";

            this.btnResetFilter.Location = new System.Drawing.Point(525, 25);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(95, 50);
            this.btnResetFilter.TabIndex = 4;
            this.btnResetFilter.Text = "Xóa bộ lọc";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);

            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Location = new System.Drawing.Point(370, 40);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(140, 21);
            this.cboFilterStatus.TabIndex = 3;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);

            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Location = new System.Drawing.Point(305, 43);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(58, 13);
            this.lblFilterStatus.TabIndex = 2;
            this.lblFilterStatus.Text = "Tình trạng:";

            this.txtSearch.Location = new System.Drawing.Point(75, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm:";

            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLoanId,
            this.colStudentId,
            this.colStudentName,
            this.colEquipment,
            this.colQuantity,
            this.colLoanDate,
            this.colDueDate,
            this.colReturnDate,
            this.colStatus});
            this.dgvLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoans.Location = new System.Drawing.Point(383, 423);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.Size = new System.Drawing.Size(638, 124);
            this.dgvLoans.TabIndex = 2;
            this.dgvLoans.SelectionChanged += new System.EventHandler(this.dgvLoans_SelectionChanged);

            this.colLoanId.DataPropertyName = "LoanId";
            this.colLoanId.HeaderText = "Mã phiếu";
            this.colLoanId.Name = "colLoanId";
            this.colLoanId.ReadOnly = true;

            this.colStudentId.DataPropertyName = "StudentId";
            this.colStudentId.HeaderText = "Mã SV";
            this.colStudentId.Name = "colStudentId";
            this.colStudentId.ReadOnly = true;

            this.colStudentName.DataPropertyName = "StudentName";
            this.colStudentName.HeaderText = "Họ tên";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;

            this.colEquipment.DataPropertyName = "EquipmentName";
            this.colEquipment.HeaderText = "Thiết bị";
            this.colEquipment.Name = "colEquipment";
            this.colEquipment.ReadOnly = true;

            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "SL";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;

            this.colLoanDate.DataPropertyName = "LoanDate";
            this.colLoanDate.HeaderText = "Ngày mượn";
            this.colLoanDate.Name = "colLoanDate";
            this.colLoanDate.ReadOnly = true;

            this.colDueDate.DataPropertyName = "DueDate";
            this.colDueDate.HeaderText = "Hạn trả";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;

            this.colReturnDate.DataPropertyName = "ReturnDate";
            this.colReturnDate.HeaderText = "Ngày trả";
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.ReadOnly = true;

            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Tình trạng";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
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
            this.lblTotalCount,
            this.lblOverdueCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1024, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";

            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(90, 17);
            this.lblTotalCount.Text = "Tổng số phiếu: 0";

            this.lblOverdueCount.Name = "lblOverdueCount";
            this.lblOverdueCount.Size = new System.Drawing.Size(101, 17);
            this.lblOverdueCount.Text = "Số phiếu quá hạn: 0";

            this.errorProvider1.ContainerControl = this;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 596);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Equipment Checkout - Bài 4.10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpSearchFilter.ResumeLayout(false);
            this.grpSearchFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpSearchFilter;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExportCSV;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalCount;
        private System.Windows.Forms.ToolStripStatusLabel lblOverdueCount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnMarkReturned;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
        private System.Windows.Forms.Label lblLoanDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cboEquipment;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtLoanId;
        private System.Windows.Forms.Label lblLoanId;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}