using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace EXCELAPPOTB
{
    public partial class Form1 : Form
    {
        private string pathFile = "";//save path of file excel 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTempData_Click(object sender, EventArgs e)
        {


            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Just file *.xlsx|*.xlsx";
            choofdlog.FilterIndex = 1;
            if (choofdlog.ShowDialog() == DialogResult.OK)
                pathFile = choofdlog.FileName;
            else
                pathFile = string.Empty;

            Microsoft.Office.Interop.Excel.Application objXL = null;
            Microsoft.Office.Interop.Excel.Workbook objWB = null;
            objXL = new Microsoft.Office.Interop.Excel.Application();
            objWB = objXL.Workbooks.Open(pathFile);
            Microsoft.Office.Interop.Excel.Worksheet objSHT = objWB.Worksheets["Shop_828_BRVT"];

            int rows = objSHT.UsedRange.Rows.Count;
            int cols = objSHT.UsedRange.Columns.Count;
            int startRows = Convert.ToInt32(txtStartRow.Value);
            int Endrow = Convert.ToInt32(txtEndRow.Value);
            int StartCol = Convert.ToInt32(txtStartColumn.Value);
            int EndCol = Convert.ToInt32(txtEndColumn.Value);

            System.Data.DataTable dtResult = new System.Data.DataTable();
            for (int c = StartCol; c <= EndCol; c++)
            {
                string colname = objSHT.Cells[1, c].Text;
                dtResult.Columns.Add(colname);
            }

            progressBar1.Minimum = startRows;
            progressBar1.Maximum = Endrow + 1;
            for (int r = startRows; r <= Endrow; r++)
            {
                progressBar1.Visible = true;

                DataRow dr = dtResult.NewRow();
                for (int c = 1; c <= EndCol; c++)
                {
                    dr[c - 1] = objSHT.Cells[r, c].Text;
                }

                progressBar1.Value = r;

                dtResult.Rows.Add(dr);
            }

            progressBar1.Visible = false;
            System.Data.DataTable data = new System.Data.DataTable();
            objWB.Close(); // Đóng  Workbook.
            objXL.Quit(); // Đóng phần mềm Excel.
            dgvData.DataSource = dtResult;
        }

        private void btnLichLamViec_Click(object sender, EventArgs e)
        {

        }
       
    }
}
