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
            int startRow = Convert.ToInt32(txtStartRow.Value);
            int endRow = Convert.ToInt32(txtEndRow.Value);
            int startCol = Convert.ToInt32(txtStartColumn.Value);
            int endCol = Convert.ToInt32(txtEndColumn.Value);
            dgvData.DataSource = ReadExcel(startRow, endRow, startCol, endCol, txtSheetNameData.Text);
            txtTempData.Text = pathFile;
        }

        private void btnLichLamViec_Click(object sender, EventArgs e)
        {
            int startRow = Convert.ToInt32(txtPlanStartRow.Value);
            int endRow = Convert.ToInt32(txtPlanEndRow.Value);
            int startCol = Convert.ToInt32(txtPlanStartCol.Value);
            int endCol = Convert.ToInt32(txtPlanEndCol.Value);
            dgvPlan.DataSource = ReadExcel(startRow, endRow, startCol, endCol, txtSheetPlan.Text);
            txtLichLamViec.Text = pathFile;
        }
       
        private System.Data.DataTable ReadExcel(int startRow, int endRow, int startCol, int endCol, string sheeName)
        {
            System.Data.DataTable dtResult = new System.Data.DataTable();

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
            Microsoft.Office.Interop.Excel.Worksheet objSHT = objWB.Worksheets[sheeName];

            //int rows = objSHT.UsedRange.Rows.Count;
            //int cols = objSHT.UsedRange.Columns.Count;
            for (int c = startCol; c <= endCol; c++)
            {
                string colname = objSHT.Cells[1, c].Text;
                dtResult.Columns.Add(colname);
            }

            progressBar1.Minimum = startRow;
            progressBar1.Maximum = endRow + 1;

            for (int r = startRow; r <= endRow; r++)
            {
                progressBar1.Visible = true;

                DataRow dr = dtResult.NewRow();
                for (int c = 1; c <= endCol; c++)
                {
                    dr[c - 1] = objSHT.Cells[r, c].Text;
                }

                progressBar1.Value = r;

                dtResult.Rows.Add(dr);
            }

            progressBar1.Visible = false;
            objWB.Close(); // Đóng  Workbook.
            objXL.Quit(); // Đóng phần mềm Excel.

            return dtResult;
        }
    }
}
