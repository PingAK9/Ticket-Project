using System;
using System.Windows.Forms;
using lamchovo.BUS;
using lamchovo.DTO;

namespace lamchovo.GUI
{
    public partial class frmFile : Form
    {
        public frmFile()
        {
            InitializeComponent();
        }

        private void frmFile_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        void HienThiDanhSach()
        {
            gridView.DataSource = FileBUS.Select();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FileDTO _item = new FileDTO();
            _item.file = txtFile.Text;
            if (FileBUS.Insert(_item) == false)
            {
                MessageBox.Show("Dữ liệu nhập vào đã có trong cơ sở dữ liệu", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                HienThiDanhSach();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            FileDTO _item = new FileDTO();
            _item.ID = int.Parse(txtID.Text);
            _item.file = txtFile.Text;
            if (FileBUS.Delete(_item.ID) == false)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                HienThiDanhSach();
            }
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            if (gridView.SelectedCells.Count > 0)
            {
                int row = gridView.SelectedCells[0].RowIndex;
                txtID.Text = gridView.Rows[row].Cells[0].Value.ToString();
                txtFile.Text = gridView.Rows[row].Cells[1].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FileDTO _item = new FileDTO();
            _item.file = txtFile.Text;
            _item.ID = int.Parse(txtID.Text);
            FileBUS.Update(_item);
            MessageBox.Show("Cập nhật thành công", "Thông báo");
            HienThiDanhSach();
        }

        private void frmFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmTicket.instance.refreshFormFile();
        }
    }
}
