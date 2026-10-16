namespace Bai4_11
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
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.picDevice = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.dtpReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.lblReceiveDate = new System.Windows.Forms.Label();
            this.txtErrorDesc = new System.Windows.Forms.TextBox();
            this.lblErrorDesc = new System.Windows.Forms.Label();
            this.cboDeviceType = new System.Windows.Forms.ComboBox();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.grpSearchFilter = new System.Windows.Forms.GroupBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrorDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstimatedCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblFilterCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalUnfinishedCost = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice)).BeginInit();
            this.grpSearchFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpSearchFilter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvOrders, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 510F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 650);
            this.tableLayoutPanel1.TabIndex = 0;

            this.grpInput.Controls.Add(this.btnBrowseImage);
            this.grpInput.Controls.Add(this.picDevice);
            this.grpInput.Controls.Add(this.btnDelete);
            this.grpInput.Controls.Add(this.btnUpdate);
            this.grpInput.Controls.Add(this.btnAdd);
            this.grpInput.Controls.Add(this.cboStatus);
            this.grpInput.Controls.Add(this.lblStatus);
            this.grpInput.Controls.Add(this.txtCost);
            this.grpInput.Controls.Add(this.lblCost);
            this.grpInput.Controls.Add(this.dtpReceiveDate);
            this.grpInput.Controls.Add(this.lblReceiveDate);
            this.grpInput.Controls.Add(this.txtErrorDesc);
            this.grpInput.Controls.Add(this.lblErrorDesc);
            this.grpInput.Controls.Add(this.cboDeviceType);
            this.grpInput.Controls.Add(this.lblDeviceType);
            this.grpInput.Controls.Add(this.txtPhone);
            this.grpInput.Controls.Add(this.lblPhone);
            this.grpInput.Controls.Add(this.txtCustomerName);
            this.grpInput.Controls.Add(this.lblCustomerName);
            this.grpInput.Controls.Add(this.txtOrderId);
            this.grpInput.Controls.Add(this.lblOrderId);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInput.Location = new System.Drawing.Point(3, 3);
            this.grpInput.Name = "grpInput";
            this.tableLayoutPanel1.SetRowSpan(this.grpInput, 2);
            this.grpInput.Size = new System.Drawing.Size(394, 644);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông tin đơn sửa chữa";

            this.btnBrowseImage.Location = new System.Drawing.Point(270, 395);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(100, 30);
            this.btnBrowseImage.TabIndex = 20;
            this.btnBrowseImage.Text = "Chọn ảnh...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);

            this.picDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDevice.Location = new System.Drawing.Point(120, 350);
            this.picDevice.Name = "picDevice";
            this.picDevice.Size = new System.Drawing.Size(130, 110);
            this.picDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDevice.TabIndex = 19;
            this.picDevice.TabStop = false;

            this.btnDelete.Location = new System.Drawing.Point(270, 535);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnUpdate.Location = new System.Drawing.Point(145, 535);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnAdd.Location = new System.Drawing.Point(20, 535);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(120, 490);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(250, 21);
            this.cboStatus.TabIndex = 15;

            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 493);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 13);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Trạng thái:";

            this.txtCost.Location = new System.Drawing.Point(120, 310);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(250, 20);
            this.txtCost.TabIndex = 13;
            this.txtCost.Text = "0";

            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(17, 313);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(74, 13);
            this.lblCost.TabIndex = 12;
            this.lblCost.Text = "Chi phí dự kiến:";

            this.dtpReceiveDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceiveDate.Location = new System.Drawing.Point(120, 265);
            this.dtpReceiveDate.Name = "dtpReceiveDate";
            this.dtpReceiveDate.Size = new System.Drawing.Size(250, 20);
            this.dtpReceiveDate.TabIndex = 11;

            this.lblReceiveDate.AutoSize = true;
            this.lblReceiveDate.Location = new System.Drawing.Point(17, 268);
            this.lblReceiveDate.Name = "lblReceiveDate";
            this.lblReceiveDate.Size = new System.Drawing.Size(77, 13);
            this.lblReceiveDate.TabIndex = 10;
            this.lblReceiveDate.Text = "Ngày tiếp nhận:";

            this.txtErrorDesc.Location = new System.Drawing.Point(120, 185);
            this.txtErrorDesc.Multiline = true;
            this.txtErrorDesc.Name = "txtErrorDesc";
            this.txtErrorDesc.Size = new System.Drawing.Size(250, 60);
            this.txtErrorDesc.TabIndex = 9;

            this.lblErrorDesc.AutoSize = true;
            this.lblErrorDesc.Location = new System.Drawing.Point(17, 188);
            this.lblErrorDesc.Name = "lblErrorDesc";
            this.lblErrorDesc.Size = new System.Drawing.Size(58, 13);
            this.lblErrorDesc.TabIndex = 8;
            this.lblErrorDesc.Text = "Mô tả lỗi:";

            this.cboDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeviceType.FormattingEnabled = true;
            this.cboDeviceType.Location = new System.Drawing.Point(120, 140);
            this.cboDeviceType.Name = "cboDeviceType";
            this.cboDeviceType.Size = new System.Drawing.Size(250, 21);
            this.cboDeviceType.TabIndex = 7;

            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Location = new System.Drawing.Point(17, 143);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(64, 13);
            this.lblDeviceType.TabIndex = 6;
            this.lblDeviceType.Text = "Loại thiết bị:";

            this.txtPhone.Location = new System.Drawing.Point(120, 100);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 20);
            this.txtPhone.TabIndex = 5;

            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(17, 103);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Số điện thoại:";

            this.txtCustomerName.Location = new System.Drawing.Point(120, 60);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(250, 20);
            this.txtCustomerName.TabIndex = 3;

            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(17, 63);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(89, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Tên khách hàng:";

            this.txtOrderId.Location = new System.Drawing.Point(120, 20);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(250, 20);
            this.txtOrderId.TabIndex = 1;

            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(17, 23);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(44, 13);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Mã đơn:";

            this.grpSearchFilter.Controls.Add(this.btnResetFilter);
            this.grpSearchFilter.Controls.Add(this.cboFilterStatus);
            this.grpSearchFilter.Controls.Add(this.lblFilterStatus);
            this.grpSearchFilter.Controls.Add(this.txtSearch);
            this.grpSearchFilter.Controls.Add(this.lblSearch);
            this.grpSearchFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSearchFilter.Location = new System.Drawing.Point(403, 3);
            this.grpSearchFilter.Name = "grpSearchFilter";
            this.grpSearchFilter.Size = new System.Drawing.Size(744, 504);
            this.grpSearchFilter.TabIndex = 1;
            this.grpSearchFilter.TabStop = false;
            this.grpSearchFilter.Text = "Tìm kiếm và Lọc";

            this.btnResetFilter.Location = new System.Drawing.Point(550, 25);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(100, 35);
            this.btnResetFilter.TabIndex = 4;
            this.btnResetFilter.Text = "Xóa bộ lọc";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);

            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Location = new System.Drawing.Point(380, 32);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(150, 21);
            this.cboFilterStatus.TabIndex = 3;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);

            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Location = new System.Drawing.Point(315, 35);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(58, 13);
            this.lblFilterStatus.TabIndex = 2;
            this.lblFilterStatus.Text = "Trạng thái:";

            this.txtSearch.Location = new System.Drawing.Point(85, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm:";

            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderId,
            this.colCustomerName,
            this.colPhone,
            this.colDeviceType,
            this.colErrorDesc,
            this.colReceiveDate,
            this.colEstimatedCost,
            this.colStatus});
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(403, 513);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(744, 134);
            this.dgvOrders.TabIndex = 2;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);

            this.colOrderId.DataPropertyName = "OrderId";
            this.colOrderId.HeaderText = "Mã đơn";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.ReadOnly = true;

            this.colCustomerName.DataPropertyName = "CustomerName";
            this.colCustomerName.HeaderText = "Khách hàng";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;

            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Số điện thoại";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;

            this.colDeviceType.DataPropertyName = "DeviceType";
            this.colDeviceType.HeaderText = "Loại thiết bị";
            this.colDeviceType.Name = "colDeviceType";
            this.colDeviceType.ReadOnly = true;

            this.colErrorDesc.DataPropertyName = "ErrorDescription";
            this.colErrorDesc.HeaderText = "Mô tả lỗi";
            this.colErrorDesc.Name = "colErrorDesc";
            this.colErrorDesc.ReadOnly = true;

            this.colReceiveDate.DataPropertyName = "ReceiveDate";
            this.colReceiveDate.HeaderText = "Ngày tiếp nhận";
            this.colReceiveDate.Name = "colReceiveDate";
            this.colReceiveDate.ReadOnly = true;

            this.colEstimatedCost.DataPropertyName = "EstimatedCost";
            this.colEstimatedCost.HeaderText = "Chi phí dự kiến";
            this.colEstimatedCost.Name = "colEstimatedCost";
            this.colEstimatedCost.ReadOnly = true;

            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";

            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportCSV,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";

            this.mnuExportCSV.Name = "mnuExportCSV";
            this.mnuExportCSV.Size = new System.Drawing.Size(193, 22);
            this.mnuExportCSV.Text = "Xuất danh sách ra CSV";
            this.mnuExportCSV.Click += new System.EventHandler(this.mnuExportCSV_Click);

            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(193, 22);
            this.mnuExit.Text = "Thoát ứng dụng";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFilterCount,
            this.lblTotalUnfinishedCost});
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1150, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";

            this.lblFilterCount.Name = "lblFilterCount";
            this.lblFilterCount.Size = new System.Drawing.Size(95, 17);
            this.lblFilterCount.Text = "Số đơn hiển thị: 0";

            this.lblTotalUnfinishedCost.Name = "lblTotalUnfinishedCost";
            this.lblTotalUnfinishedCost.Size = new System.Drawing.Size(174, 17);
            this.lblTotalUnfinishedCost.Text = "Tổng chi phí đơn chưa hoàn tất: 0";

            this.errorProvider1.ContainerControl = this;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repair Service Tracker - Bài 4.11";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice)).EndInit();
            this.grpSearchFilter.ResumeLayout(false);
            this.grpSearchFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpSearchFilter;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExportCSV;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblFilterCount;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalUnfinishedCost;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.PictureBox picDevice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.DateTimePicker dtpReceiveDate;
        private System.Windows.Forms.Label lblReceiveDate;
        private System.Windows.Forms.TextBox txtErrorDesc;
        private System.Windows.Forms.Label lblErrorDesc;
        private System.Windows.Forms.ComboBox cboDeviceType;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrorDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstimatedCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}