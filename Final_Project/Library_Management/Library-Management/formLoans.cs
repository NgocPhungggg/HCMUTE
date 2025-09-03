using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace Library_Management
{
    public partial class formLoans : Form
    {
        private readonly LoanService _loanService = new LoanService();
        private readonly Reader _readerService = new Reader();
        private readonly Book _bookService = new Book();

        private List<LoanDto> _allLoans;
        private BindingSource _bs;
        private string _editingLoanId;   // null = tạo mới; !=null = đang edit

        public formLoans()
        {
            InitializeComponent();

            Load += formLoans_Load;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void formLoans_Load(object sender, EventArgs e)
        {
            // 1) Load data
            _allLoans = _loanService.GetAll();

            // 2) BindingSource + DataGridView
            _bs = new BindingSource { DataSource = _allLoans };

            dgvLoans.DataError += dgvLoans_DataError;
            dgvLoans.AutoGenerateColumns = false;
            dgvLoans.Columns.Clear();
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLoanId",
                HeaderText = "Loan ID",
                DataPropertyName = "LoanId"
            });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colReader",
                HeaderText = "Reader",
                DataPropertyName = "ReaderUsername"
            });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colBook",
                HeaderText = "Book",
                DataPropertyName = "BookId"
            });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colBorrow",
                HeaderText = "Borrow Date",
                DataPropertyName = "BorrowDate",
                DefaultCellStyle = { Format = "d" }
            });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDue",
                HeaderText = "Due Date",
                DataPropertyName = "DueDate",
                DefaultCellStyle = { Format = "d" }
            });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colReturn",
                HeaderText = "Return Date",
                DataPropertyName = "ReturnDate",
                DefaultCellStyle = { Format = "d" }
            });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStatus",
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

            dgvLoans.DataSource = _bs;

            // 3) Load ComboBox Reader & Book
            cboReader.DataSource = _readerService.GetAll();
            cboReader.DisplayMember = "Name";    // hoặc property phù hợp
            cboReader.ValueMember = "ReaderUsername";
            cboReader.SelectedIndex = -1;

            cboBook.DataSource = _bookService.GetAll();
            cboBook.DisplayMember = "Title";     // hoặc property phù hợp
            cboBook.ValueMember = "BookId";
            cboBook.SelectedIndex = -1;

            // 4) Thiết lập DatePickers + Status
            dtpBorrowDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(14);
            dtpReturnDate.Checked = false;      // unchecked = null
            dtpReturnDate.Format = DateTimePickerFormat.Custom;
            dtpReturnDate.CustomFormat = " ";   // khi unchecked hiển thị trống

            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new[] { "BORROWED", "RETURNED", "OVERDUE" });

            // 5) Về chế độ view-only
            ToggleEditMode(false);
        }

        private void RefreshGrid()
        {
            _bs.DataSource = _allLoans;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow == null) return;
            var dto = (LoanDto)dgvLoans.CurrentRow.DataBoundItem;

            _editingLoanId = dto.LoanId;
            txtLoanId.Text = dto.LoanId;
            cboReader.SelectedValue = dto.ReaderUsername;
            cboBook.SelectedValue = dto.BookId;
            dtpBorrowDate.Value = dto.BorrowDate;
            dtpDueDate.Value = dto.DueDate;

            if (dto.ReturnDate.HasValue)
            {
                dtpReturnDate.Checked = true;
                dtpReturnDate.Value = dto.ReturnDate.Value;
            }
            else
            {
                dtpReturnDate.Checked = false;
            }

            cboStatus.Text = dto.Status;
            ToggleEditMode(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _editingLoanId = null;
            ToggleEditMode(true);


            // 1) Gọi service để sinh LoanId mới
            txtLoanId.Text = _loanService.GetNextLoanId();

            // 2) Reset các trường còn lại
            cboReader.SelectedIndex = -1;
            cboBook.SelectedIndex = -1;
            dtpBorrowDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(14);
            dtpReturnDate.Checked = false;
            cboStatus.Text = "BORROWED";


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow == null) return;
            var dto = (LoanDto)dgvLoans.CurrentRow.DataBoundItem;

            if (MessageBox.Show(
                    $"Xác nhận xóa Loan {dto.LoanId}?",
                    "Confirm",
                    MessageBoxButtons.YesNo
                ) != DialogResult.Yes)
                return;

            if (_loanService.Delete(dto.LoanId))
            {
                // Reload toàn bộ từ DB
                _allLoans = _loanService.GetAll();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Lỗi khi xóa.");
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1) Validate
            if (cboReader.SelectedIndex < 0 || cboBook.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn Reader và Book trước khi lưu.");
                return;
            }

            // 2) Đọc các field
            var loanId = txtLoanId.Text;
            var readerUsername = cboReader.SelectedValue.ToString();
            var bookId = cboBook.SelectedValue.ToString();
            var borrowDate = dtpBorrowDate.Value;
            var dueDate = dtpDueDate.Value;

            // *** chỉ lấy returnDate khi người dùng tick ***
            DateTime? returnDate = dtpReturnDate.Checked
                ? (DateTime?)dtpReturnDate.Value
                : null;

            var status = cboStatus.Text;

            bool ok;
            if (_editingLoanId == null)
            {
                ok = _loanService.Create(
                    loanId,
                    readerUsername,
                    bookId,
                    borrowDate,
                    dueDate,
                    returnDate, // nullable
                    status
                );
            }
            else
            {
                ok = _loanService.Update(
                    loanId,
                    borrowDate,
                    dueDate,
                    returnDate, // nullable
                    status
                );
            }

            if (!ok)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu.");
                return;
            }

            MessageBox.Show("Lưu thành công!");
            // 3) Reload grid
            _allLoans = _loanService.GetAll();
            RefreshGrid();
            ToggleEditMode(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Hủy thao tác, load lại toàn bộ và về chế độ view-only
            _editingLoanId = null;
            _allLoans = _loanService.GetAll();
            RefreshGrid();
            ToggleEditMode(false);
        }

        private void ToggleEditMode(bool isEditing)
        {
            // Nút thao tác
            btnAdd.Enabled = !isEditing;
            btnEdit.Enabled = !isEditing;
            btnDelete.Enabled = !isEditing;
            btnSave.Enabled = isEditing;
            btnCancel.Enabled = isEditing;

            // Grid + input
            dgvLoans.Enabled = !isEditing;
            txtLoanId.ReadOnly = true;      // LoanId không chỉnh tay
            cboReader.Enabled = isEditing;
            cboBook.Enabled = isEditing;
            dtpBorrowDate.Enabled = isEditing;
            dtpDueDate.Enabled = isEditing;
            dtpReturnDate.Enabled = isEditing;
            cboStatus.Enabled = isEditing;
        }
        private void dgvLoans_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuStaff formmenustaff = new formMenuStaff();
            formmenustaff.Show();
            this.Hide();
        }
    }
}
