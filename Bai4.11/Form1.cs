using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai4_11
{
    public partial class Form1 : Form
    {
        private BindingList<RepairOrder> masterList = new BindingList<RepairOrder>();
        private BindingSource bindingSource = new BindingSource();
        private string currentImagePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] deviceTypes = { "Laptop", "Máy tính để bàn", "Điện thoại", "Máy tính bảng", "Máy in" };
            cboDeviceType.Items.AddRange(deviceTypes);
            cboDeviceType.SelectedIndex = 0;

            string[] statuses = { "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" };
            cboStatus.Items.AddRange(statuses);
            cboStatus.SelectedIndex = 0;

            cboFilterStatus.Items.Add("-- Tất cả --");
            cboFilterStatus.Items.AddRange(statuses);
            cboFilterStatus.SelectedIndex = 0;

            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.CellFormatting += DgvOrders_CellFormatting;

            bindingSource.DataSource = masterList;
            dgvOrders.DataSource = bindingSource;

            masterList.Add(new RepairOrder
            {
                OrderId = "DH001",
                CustomerName = "Nguyễn Văn A",
                Phone = "0912345678",
                DeviceType = "Laptop",
                ErrorDescription = "Không lên nguồn, hỏng sạc",
                ReceiveDate = DateTime.Now.AddDays(-1),
                EstimatedCost = 500000,
                Status = "Mới tiếp nhận",
                ImagePath = string.Empty
            });

            masterList.Add(new RepairOrder
            {
                OrderId = "DH002",
                CustomerName = "Trần Thị B",
                Phone = "0988888888",
                DeviceType = "Điện thoại",
                ErrorDescription = "Vỡ màn hình cảm ứng",
                ReceiveDate = DateTime.Now.AddDays(-3),
                EstimatedCost = 1200000,
                Status = "Đang sửa",
                ImagePath = string.Empty
            });

            ApplyFilterAndSearch();
        }

        private void DgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrders.Columns[e.ColumnIndex].DataPropertyName == "EstimatedCost" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal cost))
                {
                    e.Value = cost.ToString("N0");
                    e.FormattingApplied = true;
                }
            }
        }

        private bool ValidateData(bool isUpdate = false)
        {
            bool isValid = true;
            errorProvider1.Clear();

            string orderId = txtOrderId.Text.Trim();
            string customerName = txtCustomerName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string errorDesc = txtErrorDesc.Text.Trim();

            if (string.IsNullOrEmpty(orderId))
            {
                errorProvider1.SetError(txtOrderId, "Mã đơn không được để trống!");
                isValid = false;
            }
            else if (!isUpdate && masterList.Any(x => x.OrderId.Equals(orderId, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtOrderId, "Mã đơn bị trùng!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(customerName))
            {
                errorProvider1.SetError(txtCustomerName, "Tên khách hàng không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phone))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(errorDesc))
            {
                errorProvider1.SetError(txtErrorDesc, "Mô tả lỗi bắt buộc phải nhập!");
                isValid = false;
            }

            if (!decimal.TryParse(txtCost.Text.Trim(), out decimal cost) || cost < 0)
            {
                errorProvider1.SetError(txtCost, "Chi phí dự kiến phải là số không âm!");
                isValid = false;
            }

            return isValid;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentImagePath = ofd.FileName;
                    picDevice.ImageLocation = currentImagePath;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData(false)) return;

            var order = new RepairOrder
            {
                OrderId = txtOrderId.Text.Trim(),
                CustomerName = txtCustomerName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                DeviceType = cboDeviceType.SelectedItem.ToString(),
                ErrorDescription = txtErrorDesc.Text.Trim(),
                ReceiveDate = dtpReceiveDate.Value.Date,
                EstimatedCost = decimal.Parse(txtCost.Text.Trim()),
                Status = cboStatus.SelectedItem.ToString(),
                ImagePath = currentImagePath
            };

            masterList.Add(order);
            ApplyFilterAndSearch();
            MessageBox.Show("Thêm đơn sửa chữa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateData(true)) return;

            var selectedOrder = dgvOrders.CurrentRow.DataBoundItem as RepairOrder;
            if (selectedOrder != null)
            {
                selectedOrder.CustomerName = txtCustomerName.Text.Trim();
                selectedOrder.Phone = txtPhone.Text.Trim();
                selectedOrder.DeviceType = cboDeviceType.SelectedItem.ToString();
                selectedOrder.ErrorDescription = txtErrorDesc.Text.Trim();
                selectedOrder.ReceiveDate = dtpReceiveDate.Value.Date;
                selectedOrder.EstimatedCost = decimal.Parse(txtCost.Text.Trim());
                selectedOrder.Status = cboStatus.SelectedItem.ToString();
                selectedOrder.ImagePath = currentImagePath;

                bindingSource.ResetBindings(false);
                ApplyFilterAndSearch();
                MessageBox.Show("Cập nhật đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                var selectedOrder = dgvOrders.CurrentRow.DataBoundItem as RepairOrder;
                if (selectedOrder != null)
                {
                    masterList.Remove(selectedOrder);
                    ApplyFilterAndSearch();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
            }
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null && dgvOrders.CurrentRow.DataBoundItem is RepairOrder order)
            {
                txtOrderId.Text = order.OrderId;
                txtOrderId.Enabled = false;
                txtCustomerName.Text = order.CustomerName;
                txtPhone.Text = order.Phone;
                cboDeviceType.SelectedItem = order.DeviceType;
                txtErrorDesc.Text = order.ErrorDescription;
                dtpReceiveDate.Value = order.ReceiveDate;
                txtCost.Text = order.EstimatedCost.ToString();
                cboStatus.SelectedItem = order.Status;
                currentImagePath = order.ImagePath;

                if (!string.IsNullOrEmpty(currentImagePath) && File.Exists(currentImagePath))
                {
                    picDevice.ImageLocation = currentImagePath;
                }
                else
                {
                    picDevice.Image = null;
                }
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

            var query = masterList.AsEnumerable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.OrderId.ToLower().Contains(keyword) ||
                                         x.CustomerName.ToLower().Contains(keyword) ||
                                         x.Phone.Contains(keyword));
            }

            if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "-- Tất cả --")
            {
                query = query.Where(x => x.Status == selectedStatus);
            }

            var filteredList = query.ToList();
            bindingSource.DataSource = filteredList;
            UpdateStatusStripInfo(filteredList);
        }

        private void UpdateStatusStripInfo(System.Collections.Generic.List<RepairOrder> filteredList)
        {
            int count = filteredList.Count;
            lblFilterCount.Text = $"Số đơn hiển thị: {count}";

            decimal unfinishedCost = masterList.Where(x => x.Status != "Hoàn tất" && x.Status != "Đã hủy").Sum(x => x.EstimatedCost);
            lblTotalUnfinishedCost.Text = $"Tổng chi phí đơn chưa hoàn tất: {unfinishedCost:N0}";
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboFilterStatus.SelectedIndex = 0;
            bindingSource.DataSource = masterList;
            UpdateStatusStripInfo(masterList.ToList());
        }

        private void mnuExportCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = "RepairServiceOrders.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("OrderId,CustomerName,Phone,DeviceType,ErrorDescription,ReceiveDate,EstimatedCost,Status");

                    foreach (var item in bindingSource.List.Cast<RepairOrder>())
                    {
                        sb.AppendLine($"{item.OrderId},{item.CustomerName},{item.Phone},{item.DeviceType},\"{item.ErrorDescription}\",{item.ReceiveDate:dd/MM/yyyy},{item.EstimatedCost},{item.Status}");
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearInputs()
        {
            txtOrderId.Clear();
            txtOrderId.Enabled = true;
            txtCustomerName.Clear();
            txtPhone.Clear();
            if (cboDeviceType.Items.Count > 0) cboDeviceType.SelectedIndex = 0;
            txtErrorDesc.Clear();
            dtpReceiveDate.Value = DateTime.Now;
            txtCost.Text = "0";
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            currentImagePath = string.Empty;
            picDevice.Image = null;
            errorProvider1.Clear();
            txtOrderId.Focus();
        }
    }
}