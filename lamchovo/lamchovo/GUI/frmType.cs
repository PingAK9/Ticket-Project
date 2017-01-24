using lamchovo.BUS;
using lamchovo.DTO;
using System;
using System.Windows.Forms;

namespace lamchovo.GUI
{
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
        }

        private void frmError_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        public void refeshForm()
        {
            HienThiDanhSach();
        }
        void HienThiDanhSach()
        {
            gridView.DataSource = TypeTicketBUS.Select();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TypeTicketDTO _item = new TypeTicketDTO();
            _item.typet = txtType.Text;
            if (TypeTicketBUS.Insert(_item) == false)
            {
                MessageBox.Show("Dữ liệu nhập vào đã có trong cơ sở dữ liệu", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                HienThiDanhSach();
            }
        }
        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            if (gridView.SelectedCells.Count > 0)
            {
                int row = gridView.SelectedCells[0].RowIndex;
                txtID.Text = gridView.Rows[row].Cells[0].Value.ToString();
                txtType.Text = gridView.Rows[row].Cells[1].Value.ToString();
            }
        }

        private void frmType_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmTicket.instance.refeshFormType();
        }
    }
}
