using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai4_10
{
    public partial class Form1 : Form
    {
        private BindingList<EquipmentLoan> masterList = new BindingList<EquipmentLoan>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] equipments = { "Máy hiện sóng số", "Đồng hồ vạn năng", "Bộ nguồn DC một chiều", "Máy hàn linh kiện", "Kit vi điều khiển" };
            cboEquipment.Items.AddRange(equipments);
            cboEquipment.SelectedIndex = 0;

            string[] statuses = { "Đang mượn", "Đã trả", "Quá hạn" };
            cboStatus.Items.AddRange(statuses);
            cboStatus.SelectedIndex = 0;

            cboFilterStatus.Items.Add("-- Tất cả --");
            cboFilterStatus.Items.AddRange(statuses);
            cboFilterStatus.SelectedIndex = 0;

            dgvLoans.AutoGenerateColumns = false;
            dgvLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            bindingSource.DataSource = masterList;
            dgvLoans.DataSource = bindingSource;

            masterList.Add(new EquipmentLoan
            {
                LoanId = "PM001",
                StudentId = "SV001",
                StudentName = "Nguyễn Văn A",
                EquipmentName = "Máy hiện sóng số",
                Quantity = 1,
                LoanDate = DateTime.Now.AddDays(-5),
                DueDate = DateTime.Now.AddDays(-1),
                ReturnDate = null,
                Status = "Đang mượn"
            });

            masterList.Add(new EquipmentLoan
            {
                LoanId = "PM002",
                StudentId = "SV002",
                StudentName = "Trần Thị B",
                EquipmentName = "Đồng hồ vạn năng",
                Quantity = 2,
                LoanDate = DateTime.Now.AddDays(-2),
                DueDate = DateTime.Now.AddDays(3),
                ReturnDate = null,
                Status = "Đang mượn"
            });

            CheckAndUpdateOverdueStatus();
            ApplyFilterAndSearch();
        }

        private void CheckAndUpdateOverdueStatus()
        {
            foreach (var item in masterList)
            {
                if (item.Status != "Đã trả" && item.DueDate.Date < DateTime.Now.Date)
                {
                    item.Status = "Quá hạn";
                }
            }
        }

        private bool ValidateData(bool isUpdate = false)
        {
            bool isValid = true;
            errorProvider1.Clear();

            string loanId = txtLoanId.Text.Trim();
            string studentId = txtStudentId.Text.Trim();
            string studentName = txtStudentName.Text.Trim();
            string equipment = cboEquipment.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(loanId))
            {
                errorProvider1.SetError(txtLoanId, "Mã phiếu không được để trống!");
                isValid = false;
            }
            else if (!isUpdate && masterList.Any(x => x.LoanId.Equals(loanId, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtLoanId, "Mã phiếu bị trùng!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(studentId))
            {
                errorProvider1.SetError(txtStudentId, "Mã sinh viên không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(studentName))
            {
                errorProvider1.SetError(txtStudentName, "Tên sinh viên không được để trống!");
                isValid = false;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int qty) || qty <= 0)
            {
                errorProvider1.SetError(txtQuantity, "Số lượng phải là số nguyên lớn hơn 0!");
                isValid = false;
            }

            if (dtpDueDate.Value.Date < dtpLoanDate.Value.Date)
            {
                errorProvider1.SetError(dtpDueDate, "Hạn trả không được trước ngày mượn!");
                isValid = false;
            }

            if (dtpReturnDate.Checked && dtpReturnDate.Value.Date < dtpLoanDate.Value.Date)
            {
                errorProvider1.SetError(dtpReturnDate, "Ngày trả thực tế không được trước ngày mượn!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData(false)) return;

            var loan = new EquipmentLoan
            {
                LoanId = txtLoanId.Text.Trim(),
                StudentId = txtStudentId.Text.Trim(),
                StudentName = txtStudentName.Text.Trim(),
                EquipmentName = cboEquipment.SelectedItem.ToString(),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                LoanDate = dtpLoanDate.Value.Date,
                DueDate = dtpDueDate.Value.Date,
                ReturnDate = dtpReturnDate.Checked ? (DateTime?)dtpReturnDate.Value.Date : null,
                Status = cboStatus.SelectedItem.ToString()
            };

            if (loan.Status != "Đã trả" && loan.DueDate.Date < DateTime.Now.Date)
            {
                loan.Status = "Quá hạn";
            }

            masterList.Add(loan);
            CheckAndUpdateOverdueStatus();
            ApplyFilterAndSearch();
            MessageBox.Show("Thêm phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateData(true)) return;

            var selectedLoan = dgvLoans.CurrentRow.DataBoundItem as EquipmentLoan;
            if (selectedLoan != null)
            {
                selectedLoan.StudentId = txtStudentId.Text.Trim();
                selectedLoan.StudentName = txtStudentName.Text.Trim();
                selectedLoan.EquipmentName = cboEquipment.SelectedItem.ToString();
                selectedLoan.Quantity = int.Parse(txtQuantity.Text.Trim());
                selectedLoan.LoanDate = dtpLoanDate.Value.Date;
                selectedLoan.DueDate = dtpDueDate.Value.Date;
                selectedLoan.ReturnDate = dtpReturnDate.Checked ? (DateTime?)dtpReturnDate.Value.Date : null;
                selectedLoan.Status = cboStatus.SelectedItem.ToString();

                if (selectedLoan.Status != "Đã trả" && selectedLoan.DueDate.Date < DateTime.Now.Date)
                {
                    selectedLoan.Status = "Quá hạn";
                }

                CheckAndUpdateOverdueStatus();
                bindingSource.ResetBindings(false);
                ApplyFilterAndSearch();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                var selectedLoan = dgvLoans.CurrentRow.DataBoundItem as EquipmentLoan;
                if (selectedLoan != null)
                {
                    masterList.Remove(selectedLoan);
                    ApplyFilterAndSearch();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
            }
        }

        private void btnMarkReturned_Click(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn trên bảng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedLoan = dgvLoans.CurrentRow.DataBoundItem as EquipmentLoan;
            if (selectedLoan != null)
            {
                selectedLoan.Status = "Đã trả";
                selectedLoan.ReturnDate = DateTime.Now.Date;
                bindingSource.ResetBindings(false);
                ApplyFilterAndSearch();
                MessageBox.Show("Đã cập nhật trạng thái thành Đã trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvLoans_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow != null && dgvLoans.CurrentRow.DataBoundItem is EquipmentLoan loan)
            {
                txtLoanId.Text = loan.LoanId;
                txtLoanId.Enabled = false;
                txtStudentId.Text = loan.StudentId;
                txtStudentName.Text = loan.StudentName;
                cboEquipment.SelectedItem = loan.EquipmentName;
                txtQuantity.Text = loan.Quantity.ToString();
                dtpLoanDate.Value = loan.LoanDate;
                dtpDueDate.Value = loan.DueDate;
                if (loan.ReturnDate.HasValue)
                {
                    dtpReturnDate.Checked = true;
                    dtpReturnDate.Value = loan.ReturnDate.Value;
                }
                else
                {
                    dtpReturnDate.Checked = false;
                }
                cboStatus.SelectedItem = loan.Status;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSearch();
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilterAndSearch();
        }

        private void ApplyFilterAndSearch()
        {
            CheckAndUpdateOverdueStatus();
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cboFilterStatus.SelectedItem?.ToString();

            var query = masterList.AsEnumerable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.StudentId.ToLower().Contains(keyword) || x.EquipmentName.ToLower().Contains(keyword));
            }

            if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "-- Tất cả --")
            {
                query = query.Where(x => x.Status == selectedStatus);
            }

            bindingSource.DataSource = query.ToList();
            UpdateStatusStripInfo();
        }

        private void UpdateStatusStripInfo()
        {
            int total = bindingSource.Count;
            int overdue = masterList.Count(x => x.Status == "Quá hạn");
            lblTotalCount.Text = $"Tổng số phiếu: {total}";
            lblOverdueCount.Text = $"Số phiếu quá hạn: {overdue}";
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboFilterStatus.SelectedIndex = 0;
            bindingSource.DataSource = masterList;
            UpdateStatusStripInfo();
        }

        private void mnuExportCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = "EquipmentLoans.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("LoanId,StudentId,StudentName,EquipmentName,Quantity,LoanDate,DueDate,ReturnDate,Status");

                    foreach (var item in bindingSource.List.Cast<EquipmentLoan>())
                    {
                        string retDate = item.ReturnDate.HasValue ? item.ReturnDate.Value.ToString("dd/MM/yyyy") : "";
                        sb.AppendLine($"{item.LoanId},{item.StudentId},{item.StudentName},{item.EquipmentName},{item.Quantity},{item.LoanDate:dd/MM/yyyy},{item.DueDate:dd/MM/yyyy},{retDate},{item.Status}");
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearInputs()
        {
            txtLoanId.Clear();
            txtLoanId.Enabled = true;
            txtStudentId.Clear();
            txtStudentName.Clear();
            if (cboEquipment.Items.Count > 0) cboEquipment.SelectedIndex = 0;
            txtQuantity.Text = "1";
            dtpLoanDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now;
            dtpReturnDate.Checked = false;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            errorProvider1.Clear();
            txtLoanId.Focus();
        }
    }
}