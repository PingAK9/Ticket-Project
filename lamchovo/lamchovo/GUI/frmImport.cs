using lamchovo.BUS;
using lamchovo.DAO;
using lamchovo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamchovo.GUI
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
        }
        private void frmTicket_Load(object sender, EventArgs e)
        {
            cbClientImport.ValueMember = "ID";
            cbClientImport.DisplayMember = "clientt";
            cbClientImport.DataSource = ClientBUS.Select();
            //
            txbSheet.Text = "Sheet1";
            //
        }

        void AddFile(string file, string sheet)
        {
            string[] _split = file.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            file = _split[_split.Length - 1];
            string _name = "[" + file + "][" + sheet + "]";
            FileDTO _file = new FileDTO();
            _file.file = _name;
            FileBUS.Insert(_file);
            fileImport  = FileBUS.Select(_name);
        }
        void AddRow(DataRow row)
        {
            TicketDTO _item = new TicketDTO();
            try
            {
                _item.type = int.Parse(row.ItemArray[0].ToString());
                _item.price = StringToInt(row.ItemArray[2].ToString());
                int _count = StringToInt(row.ItemArray[6].ToString());
                int _countTSN = 0;
                try
                {
                    _countTSN = StringToInt(row.ItemArray[5].ToString());
                }
                catch (Exception)
                {
                }
                if (_item.price == 0 || _count == 0)
                {
                    errorCount++;
                    return;
                }

                object value = row.ItemArray[1];
                if (value != null)
                {
                    double dayDouble;
                    bool isDouble = Double.TryParse(value.ToString(), out dayDouble);
                    if (isDouble)
                    {
                        _item.day = DateTime.FromOADate(dayDouble);
                    }
                    else
                    {
                        DateTime _dt;
                        if (DateTime.TryParse(value.ToString(), out _dt) == false)
                        {
                            errorCount++;
                            return;
                        }
                        _item.day = _dt;
                    }
                }
                if (_item.day == null)
                {
                    errorCount++;
                    return;
                }
                _item.client = (int)cbClientImport.SelectedValue;
                _item.file = fileImport.ID;
                _item.dayon = dtDayImport.Value;
                if (_countTSN > 0)
                {
                    _item.count = _countTSN;
                    _item.tsn = true;
                    TicketBUS.Insert(_item);
                    //
                    _item.count = _count - _countTSN;
                    _item.tsn = false;
                    TicketBUS.Insert(_item);
                }
                else
                {
                    _item.count = _count;
                    _item.tsn = false;
                    TicketBUS.Insert(_item);
                }
                rowCount++;
            }
            catch (Exception)
            {
                errorCount++;
            }
        }
        int rowCount;
        int errorCount;
        FileDTO fileImport;
        private void btnimport_Click(object sender, EventArgs e)
        {
            try
            {
                rowCount = 0;
                errorCount = 0;
                string oldPath = Directory.GetCurrentDirectory();
                OpenFileDialog of = new OpenFileDialog();
                of.ShowDialog();
                string strPathName = of.FileName;
                Directory.SetCurrentDirectory(oldPath);
                DataTable dt = ExcelRead.getSheet(strPathName, txbSheet.Text);
                AddFile(strPathName, txbSheet.Text);
                foreach (DataRow row in dt.Rows)
                {
                    AddRow(row);
                }
                OnFinishImport();
                //
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi đọc file.", "Thông báo");
            }
        }
        void OnFinishImport()
        {
            MessageBox.Show("" + rowCount + "/" + (rowCount + errorCount) + " row.", "Thông báo");
            frmTicket.instance.HienThiDanhSachFileImport(fileImport.ID);
            this.Close();
        }
        int StringToInt(string _str)
        {
            string _strValue = _str.Replace(Application.CurrentCulture.NumberFormat.NumberGroupSeparator, "");
            try
            {
                return int.Parse(_strValue);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        private void frmImport_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

    }
}
