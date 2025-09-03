using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace Library_Management
{
    public partial class formTransactions : Form
    {
        private readonly TransactionService _trsService = new TransactionService();
        private readonly LoanService _loanService = new LoanService();

        private List<TransactionDto> _allTransactions;
        private BindingSource _bs;

        public formTransactions()
        {
            InitializeComponent();

            // Đăng ký sự kiện
            this.Load += formTransactions_Load;
            cboLoan.SelectedIndexChanged += cboLoan_SelectedIndexChanged;
            btnAdd.Click += btnAdd_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            dgvTransactions.DataError += dgvTransactions_DataError;
        }

        private void formTransactions_Load(object sender, EventArgs e)
        {
            // 1) Load toàn bộ transactions
            _allTransactions = _trsService.GetAll();

            // 2) Khởi tạo BindingSource + DataGridView
            _bs = new BindingSource { DataSource = _allTransactions };
            dgvTransactions.AutoGenerateColumns = false;
            dgvTransactions.Columns.Clear();

            // --- Thiết lập cột ---
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLoanId",
                HeaderText = "Loan ID",
                DataPropertyName = "LoanId",
                Width = 80
            });
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colReaderUsername",
                HeaderText = "Reader Username",
                DataPropertyName = "ReaderUsername",
                Width = 120
            });
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colBookId",
                HeaderText = "Book ID",
                DataPropertyName = "BookId",
                Width = 80
            });
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStaffUsername",
                HeaderText = "Staff Username",
                DataPropertyName = "StaffUsername",
                Width = 120
            });
            var colDate = new DataGridViewTextBoxColumn
            {
                Name = "colDate",
                HeaderText = "Date",
                DataPropertyName = "TransactionDate",
                Width = 140
            };
            colDate.DefaultCellStyle.Format = "g";
            dgvTransactions.Columns.Add(colDate);
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colType",
                HeaderText = "Type",
                DataPropertyName = "Type",
                Width = 80
            });
            var colAmount = new DataGridViewTextBoxColumn
            {
                Name = "colAmount",
                HeaderText = "Amount",
                DataPropertyName = "Amount",
                Width = 80
            };
            colAmount.DefaultCellStyle.Format = "N2";
            dgvTransactions.Columns.Add(colAmount);

            dgvTransactions.DataSource = _bs;

            // 3) Load ComboBox Loan
            var loans = _loanService.GetAll();
            cboLoan.DataSource = loans;
            cboLoan.DisplayMember = "LoanId";   // hoặc "BookTitle" nếu bạn có
            cboLoan.ValueMember = "LoanId";
            cboLoan.SelectedIndex = -1;

            // 4) Khởi tạo controls edit
            dtpDate.Value = DateTime.Now;
            cboType.Items.Clear();
            cboType.Items.AddRange(new[] { "LateFee", "Fine", "Payment" });
            txtAmount.Text = "0";

            // 5) Về chế độ view-only
            ToggleEditMode(false);
        }

        private void cboLoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            if (cboLoan.SelectedIndex >= 0 && cboLoan.SelectedValue is string loanId)
            {
                _bs.DataSource = _allTransactions
                                 .Where(t => t.LoanId == loanId)
                                 .ToList();
                btnAdd.Enabled = true;
            }
            else
            {
                _bs.DataSource = _allTransactions;
                btnAdd.Enabled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Bắt buộc đã chọn Loan
            if (cboLoan.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn một Loan trước khi thêm!");
                return;
            }

            ToggleEditMode(true);

            // Reset input
            cboType.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
            txtAmount.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1) Parse amount
            if (!decimal.TryParse(txtAmount.Text, out var amount))
            {
                MessageBox.Show("Số tiền không hợp lệ!");
                txtAmount.Focus();
                return;
            }

            // 2) Lấy dữ liệu từ form
            var loanId = cboLoan.SelectedValue.ToString();
            var type = cboType.Text;
            var date = dtpDate.Value;
            var staffUsername = Session.Username; // nhớ using Business_Logic_Layer

            // 3) Gọi service lưu
            var ok = _trsService.Create(loanId, staffUsername, date, type, amount);
            if (!ok)
            {
                MessageBox.Show("Lỗi khi lưu giao dịch!");
                return;
            }

            MessageBox.Show("Đã lưu giao dịch!");

            // 4) Reload toàn bộ danh sách & filter lại
            _allTransactions = _trsService.GetAll();
            RefreshGrid();

            // 5) Về chế độ view-only
            ToggleEditMode(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Hủy thao tác edit
            ToggleEditMode(false);

            // Reload full list (hoặc có thể giữ filter nếu muốn)
            _allTransactions = _trsService.GetAll();
            cboLoan.SelectedIndex = -1;   // ← nếu muốn clear filter
            RefreshGrid();
        }

        private void dgvTransactions_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Ẩn dialog lỗi khi user click vào hàng New-Row
            e.ThrowException = false;
        }

        private void ToggleEditMode(bool isEditing)
        {
            btnSave.Enabled = isEditing;
            btnCancel.Enabled = isEditing;
            btnAdd.Enabled = !isEditing && cboLoan.SelectedIndex >= 0;
            dgvTransactions.Enabled = !isEditing;

            cboLoan.Enabled = !isEditing;
            cboType.Enabled = isEditing;
            dtpDate.Enabled = isEditing;
            txtAmount.Enabled = isEditing;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuStaff formmenustaff = new formMenuStaff();
            formmenustaff.Show();
            this.Hide();
        }
    }
}
