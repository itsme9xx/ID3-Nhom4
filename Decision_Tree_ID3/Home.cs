using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Decision_Tree_ID3
{
    public partial class frmHome : Form
    {
        public static List<List<string>> dtSource;
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            Create_Source_Clauses();
        }

        private void Create_Source_Clauses()
        {
            DataTable dt = new DataTable();
            dataGridViewClauses.Columns.Clear();
            //dt.Columns.Add("STT");
            DataView dv = new DataView(dt);
            dataGridViewClauses.DataSource = dv;
            dataGridViewClauses.Font = new Font("Segoe UI", 11.0F, FontStyle.Regular);
            dataGridViewClauses.ForeColor = Color.Black;
        }

        //Thêm 1 cột
        private void btnAddClause_Click(object sender, EventArgs e)
        {
            if (txtClause.Text != null && txtClause.Text.Trim() != "")
            {
                if (!dataGridViewClauses.Columns.Contains(txtClause.Text.Trim()))
                    dataGridViewClauses.Columns.Add(txtClause.Text.Trim(), txtClause.Text.Trim());
                else
                    MessageBox.Show("Clause đã có trong tập Clauses", "Add clause error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClause.Clear();
            }
        }

        //Event khi nhấn Enter trong TextBox
        private void txtClause_Enter(object sender, EventArgs e)
        {
            //Add clause into the clauses data
            frmHome.ActiveForm.AcceptButton = btnAddClause;
        }

        //Xóa 1 cột đã chọn
        private void btnRemoveClause_Click(object sender, EventArgs e)
        {
            if (txtClause.Text.Trim() != "")
            {
                dataGridViewClauses.Columns.Remove(txtClause.Text.Trim());
                txtClause.Clear();
            }
        }

        private void dataGridViewClauses_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtClause.Text = dataGridViewClauses.Columns[e.ColumnIndex].Name;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Create_Source_Clauses();
        }

        private void btnOpenTextSource_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open data source";
                ofd.Filter = "File text|*.txt|All file|*.*";
                List<List<string>> arrObject = new List<List<string>>();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName,Encoding.UTF8);
                    string line = "";
                    int index = 0;
                    DataTable dt = new DataTable();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] obj = line.Trim().Split(' ');
                        arrObject.Add(new List<string>());
                        arrObject[index++] = obj.ToList();
                    }

                    for(int i = 0; i < arrObject.Count(); i++)
                    {
                        if (i == 0)
                        {
                            foreach(string item in arrObject[0])
                            {
                                dt.Columns.Add(item);
                            }
                        }
                        else
                        {
                            dt.Rows.Add(arrObject[i].ToArray());
                        }
                    }
                    dataGridViewClauses.DataSource = dt;
                    sr.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenExcelSource_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open data source";
                ofd.Filter = "File Excel|*.xlsx; *.xls|All file|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // chạy file Excel theo đường dẫn
                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);

                    // Lấy Sheet 1
                    Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets.get_Item(1);
                    // Lấy phạm vi dữ liệu
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    // Tạo mảng lưu trữ dữ liệu
                    object[,] valueArray = (object[,])xlRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);
                    int column = valueArray.GetLength(1);
                    int row = valueArray.GetLength(0);
                    //Hiển thị lên datagridview
                    DataTable dt = new DataTable();
                    for (int i = 1; i <= row; i++)
                    {
                        if (i == 1)
                        {
                            for (int j = 1; j <= column; j++)
                            {
                                dt.Columns.Add(valueArray[1,j].ToString());
                            }
                        }
                        else
                        {
                            List<string> arrObject = new List<string>();
                            for(int j = 1; j <= column; j++)
                            {
                                arrObject.Add(valueArray[i, j].ToString());
                            }
                            dt.Rows.Add(arrObject.ToArray());

                        }
                    }
                    dataGridViewClauses.DataSource = dt;

                    // Đóng Workbook.
                    xlWorkbook.Close(false);
                    // Đóng application.
                    xlApp.Quit();
                    //Khử hết đối tượng
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkbook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateBest_ID3_Click(object sender, EventArgs e)
        {
            if(dataGridViewClauses.Columns.Count < 1)
            {
                MessageBox.Show("Không có dữ liệu mẫu để chạy thuật toán", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dtSource = new List<List<string>>();
            for(int i = 0; i < dataGridViewClauses.Columns.Count; i++)
            {
                dtSource.Add(new List<string>());
                dtSource[i].Add(dataGridViewClauses.Columns[i].Name);
                for(int j = 0; j < dataGridViewClauses.Rows.Count -1; j++)
                {
                    dtSource[i].Add(dataGridViewClauses.Rows[j].Cells[i].Value.ToString());
                }
            }

            Form frmView = new KetQua();
            frmView.Show();
            frmView.FormClosed += new FormClosedEventHandler(Close_Form);
            this.Hide();

        }

        private void Close_Form(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }
        }

       
    }
}
