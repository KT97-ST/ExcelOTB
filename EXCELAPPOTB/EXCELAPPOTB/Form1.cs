using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace EXCELAPPOTB
{
    public partial class Form1 : Form
    {
        private string pathFile = "";//save path of file excel 
        private string templateFilePath = "";
        private string outputFilePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTempData_Click(object sender, EventArgs e)
        {
            int rowHeader = Convert.ToInt32(txtRowHeaderData.Value);
            int startRow = Convert.ToInt32(txtStartRow.Value);
            int endRow = Convert.ToInt32(txtEndRow.Value);
            int startCol = Convert.ToInt32(txtStartColumn.Value);
            int endCol = Convert.ToInt32(txtEndColumn.Value);
            dgvData.DataSource = ReadExcel(rowHeader,startRow, endRow, startCol, endCol, txtSheetNameData.Text);
            txtTempData.Text = pathFile;
        }

        private void btnLichLamViec_Click(object sender, EventArgs e)
        {
            int rowHeader =  Convert.ToInt32(txtRowHeaderPlan.Value);
            int startRow = Convert.ToInt32(txtPlanStartRow.Value);
            int endRow = Convert.ToInt32(txtPlanEndRow.Value);
            int startCol = Convert.ToInt32(txtPlanStartCol.Value);
            int endCol = Convert.ToInt32(txtPlanEndCol.Value);
            dgvPlan.DataSource = ReadExcel(rowHeader, startRow, endRow, startCol, endCol, txtSheetPlan.Text);
            txtLichLamViec.Text = pathFile;
        }
       
        private System.Data.DataTable ReadExcel(int rowHeader,int startRow, int endRow, int startCol, int endCol, string sheeName)
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
            try
            {
                //int cols = objSHT.UsedRange.Columns.Count;
                for (int c = startCol; c <= endCol; c++)
                {
                    string colname = objSHT.Cells[rowHeader, c].Text;
                    dtResult.Columns.Add(colname);
                }

                progressBar1.Minimum = startRow;
                progressBar1.Maximum = endRow + 1;
               
                for (int r = startRow; r <= endRow; r++)
                {
                    lblProcess.Visible = true;
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
                lblProcess.Visible = false;
                objWB.Close(); // Đóng  Workbook.
                objXL.Quit(); // Đóng phần mềm Excel.
               
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                objWB.Close(); // Đóng  Workbook.
                objXL.Quit(); // Đóng phần mềm Excel.
                progressBar1.Visible = false;
                lblProcess.Visible = false;
            }
            //int rows = objSHT.UsedRange.Rows.Count;
            return dtResult;
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 1;
            progressBar1.Maximum = dgvData.Rows.Count;

            int iter = 1;
            if (dgvPlan.Rows.Count > 0 && dgvData.Rows.Count > 0)
            {
                System.Data.DataTable dtPlan = new System.Data.DataTable();

                dtPlan = (System.Data.DataTable)dgvPlan.DataSource;

                System.Data.DataTable dtData = new System.Data.DataTable();

                dtData = (System.Data.DataTable)dgvData.DataSource;

               

                foreach (DataRow row in dtPlan.Rows)
                {
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                   // string templateFilePath = "PathToYourTemplateFile.xlsx"; // Đường dẫn tới file template Excel
                    
                    string outputFileName = "OutputExcelFile_" + iter + ".xlsx"; // Tên tập tin cho file Excel xuất ra
                    outputFilePath = Path.Combine(Path.GetDirectoryName(templateFilePath), outputFileName);

                    // Mở file Excel đầu ra
                    Workbook workbook = excelApp.Workbooks.Open(outputFilePath);
                    Worksheet worksheet = (Worksheet)workbook.Sheets[1];
                    try
                    {
                        //xuất dữ liệu mỗi plan là một datatable
                        System.Data.DataTable dtExport = new System.Data.DataTable();
                        dtExport = dtData.Clone();

                        // Copy template file to output file
                        File.Copy(templateFilePath, outputFilePath, true);



                        int startCol = 1;

                        progressBar1.Visible = true;
                        lblProcess.Visible = true;
                        foreach (DataColumn col in dtPlan.Columns)
                        {
                            if (startCol >= 11)
                            {
                                string date = col.ColumnName.ToString();
                                string[] dateParts = date.Split('_');

                                if (dateParts.Length >= 3)
                                {
                                    int month = int.Parse(dateParts[0]);
                                    int day = int.Parse(dateParts[1]);
                                    if (string.IsNullOrEmpty(row[col].ToString()) == false)
                                    {
                                        foreach (DataRow rowdt in dtData.Rows)
                                        {
                                            DataRow rowExport = dtExport.NewRow();
                                            rowExport.ItemArray = rowdt.ItemArray.Clone() as object[];
                                            rowExport[0] = month;
                                            rowExport[2] = day;
                                            dtExport.Rows.Add(rowExport);

                                            if (iter <= progressBar1.Maximum)
                                            {
                                                progressBar1.Value = iter;
                                            }

                                        }
                                    }
                                }
                            }

                            Console.WriteLine($"Row: {row[col]} - Column: {col.ColumnName}");

                            startCol = startCol + 1;
                        }

                        int startRowEx = 3;
                        // Điền dữ liệu từ DataTable vào worksheet
                        for (int rowEx = 0; rowEx < dtExport.Rows.Count; rowEx++)
                        {
                            for (int colEx = 0; colEx < dtExport.Columns.Count; colEx++)
                            {
                                worksheet.Cells[rowEx + startRowEx, colEx + startCol].Value = dtExport.Rows[rowEx][colEx];
                            }
                        }
                        iter = iter + 1;
                        // Lưu và đóng workbook
                        workbook.Save();
                        workbook.Close();
                        excelApp.Quit();
                    }
                    catch(Exception ex)
                    {
                        // Lưu và đóng workbook
                        workbook.Save();
                        workbook.Close();
                        excelApp.Quit();
                    }
                }



                progressBar1.Visible = false;
                lblProcess.Visible = false;
            }
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Just file *.xlsx|*.xlsx";
            choofdlog.FilterIndex = 1;
            if (choofdlog.ShowDialog() == DialogResult.OK)
                templateFilePath = choofdlog.FileName;
            else
                templateFilePath = string.Empty;

            txtTemplate.Text = templateFilePath;
        }
    }
}
