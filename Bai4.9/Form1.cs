using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai4_9
{
    public partial class Form1 : Form
    {
        private BindingList<Appointment> masterList = new BindingList<Appointment>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] doctors = { "BS. Nguyễn Văn A", "BS. Trần Thị B", "BS. Lê Hoàng C", "BS. Phạm Minh D" };
            cboDoctor.Items.AddRange(doctors);
            cboDoctor.SelectedIndex = 0;

            string[] statuses = { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" };
            cboStatus.Items.AddRange(statuses);
            cboStatus.SelectedIndex = 0;

            cboFilterStatus.Items.Add("-- Tất cả --");
            cboFilterStatus.Items.AddRange(statuses);
            cboFilterStatus.SelectedIndex = 0;

            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            bindingSource.DataSource = masterList;
            dgvAppointments.DataSource = bindingSource;

            masterList.Add(new Appointment
            {
                AppointmentId = "LH001",
                PatientName = "Nguyễn Văn An",
                Phone = "0912345678",
                AppointmentDate = DateTime.Now.AddHours(2),
                Doctor = "BS. Nguyễn Văn A",
                Reason = "Đau đầu, chóng mặt",
                Status = "Chờ khám"
            });

            masterList.Add(new Appointment
            {
                AppointmentId = "LH002",
                PatientName = "Trần Thị Bình",
                Phone = "0988888888",
                AppointmentDate = DateTime.Now.AddDays(1),
                Doctor = "BS. Trần Thị B",
                Reason = "Khám tổng quát định kỳ",
                Status = "Chờ khám"
            });

            UpdateStatusStripCount();
        }

        private bool ValidateData(bool isUpdate = false)
        {
            bool isValid = true;
            errorProvider1.Clear();

            string id = txtAppointmentId.Text.Trim();
            string name = txtPatientName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string reason = txtReason.Text.Trim();
            DateTime appDate = dtpAppointmentDate.Value;

            if (string.IsNullOrEmpty(id))
            {
                errorProvider1.SetError(txtAppointmentId, "Mã lịch hẹn bắt buộc nhập!");
                isValid = false;
            }
            else if (!isUpdate && masterList.Any(x => x.AppointmentId.Equals(id, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtAppointmentId, "Mã lịch hẹn đã tồn tại!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(name))
            {
                errorProvider1.SetError(txtPatientName, "Tên bệnh nhân bắt buộc nhập!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phone) || !phone.All(char.IsDigit) || (phone.Length != 10 && phone.Length != 11))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại không hợp lệ!");
                isValid = false;
            }

            if (appDate < DateTime.Now.AddMinutes(-1))
            {
                errorProvider1.SetError(dtpAppointmentDate, "Ngày giờ hẹn không được nằm trong quá khứ!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(reason))
            {
                errorProvider1.SetError(txtReason, "Lý do khám bắt buộc nhập!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData(false)) return;

            var apt = new Appointment
            {
                AppointmentId = txtAppointmentId.Text.Trim(),
                PatientName = txtPatientName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                AppointmentDate = dtpAppointmentDate.Value,
                Doctor = cboDoctor.SelectedItem.ToString(),
                Reason = txtReason.Text.Trim(),
                Status = cboStatus.SelectedItem.ToString()
            };

            masterList.Add(apt);
            ApplyFilterAndSearch();
            MessageBox.Show("Thêm lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateData(true)) return;

            var selectedApt = dgvAppointments.CurrentRow.DataBoundItem as Appointment;
            if (selectedApt != null)
            {
                selectedApt.PatientName = txtPatientName.Text.Trim();
                selectedApt.Phone = txtPhone.Text.Trim();
                selectedApt.AppointmentDate = dtpAppointmentDate.Value;
                selectedApt.Doctor = cboDoctor.SelectedItem.ToString();
                selectedApt.Reason = txtReason.Text.Trim();
                selectedApt.Status = cboStatus.SelectedItem.ToString();

                bindingSource.ResetBindings(false);
                ApplyFilterAndSearch();
                MessageBox.Show("Cập nhật lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch hẹn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                var selectedApt = dgvAppointments.CurrentRow.DataBoundItem as Appointment;
                if (selectedApt != null)
                {
                    masterList.Remove(selectedApt);
                    ApplyFilterAndSearch();
                    MessageBox.Show("Xóa lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
            }
        }

        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow != null && dgvAppointments.CurrentRow.DataBoundItem is Appointment apt)
            {
                txtAppointmentId.Text = apt.AppointmentId;
                txtAppointmentId.Enabled = false;
                txtPatientName.Text = apt.PatientName;
                txtPhone.Text = apt.Phone;
                dtpAppointmentDate.Value = apt.AppointmentDate;
                cboDoctor.SelectedItem = apt.Doctor;
                txtReason.Text = apt.Reason;
                cboStatus.SelectedItem = apt.Status;
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
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cboFilterStatus.SelectedItem?.ToString();
            bool isFilterDate = chkFilterDate.Checked;
            DateTime filterDate = dtpFilterDate.Value.Date;

            var query = masterList.AsEnumerable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.PatientName.ToLower().Contains(keyword) || x.Phone.Contains(keyword));
            }

            if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "-- Tất cả --")
            {
                query = query.Where(x => x.Status == selectedStatus);
            }

            if (isFilterDate)
            {
                query = query.Where(x => x.AppointmentDate.Date == filterDate);
            }

            bindingSource.DataSource = query.ToList();
            UpdateStatusStripCount();
        }

        private void UpdateStatusStripCount()
        {
            int count = bindingSource.Count;
            lblCountStatus.Text = $"Tổng số lịch hẹn đang hiển thị: {count}";
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboFilterStatus.SelectedIndex = 0;
            chkFilterDate.Checked = false;
            bindingSource.DataSource = masterList;
            UpdateStatusStripCount();
        }

        private void mnuExportCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = "ClinicAppointments.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("AppointmentId,PatientName,Phone,AppointmentDate,Doctor,Reason,Status");

                    foreach (var item in bindingSource.List.Cast<Appointment>())
                    {
                        sb.AppendLine($"{item.AppointmentId},{item.PatientName},{item.Phone},{item.AppointmentDate:dd/MM/yyyy HH:mm},{item.Doctor},{item.Reason},{item.Status}");
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearInputs()
        {
            txtAppointmentId.Clear();
            txtAppointmentId.Enabled = true;
            txtPatientName.Clear();
            txtPhone.Clear();
            dtpAppointmentDate.Value = DateTime.Now;
            if (cboDoctor.Items.Count > 0) cboDoctor.SelectedIndex = 0;
            txtReason.Clear();
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            errorProvider1.Clear();
            txtAppointmentId.Focus();
        }
    }
}