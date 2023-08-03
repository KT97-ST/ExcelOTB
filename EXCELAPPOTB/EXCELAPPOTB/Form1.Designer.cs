
namespace EXCELAPPOTB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTempData = new System.Windows.Forms.Button();
            this.txtTempData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLichLamViec = new System.Windows.Forms.Button();
            this.txtLichLamViec = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartRow = new System.Windows.Forms.NumericUpDown();
            this.txtEndRow = new System.Windows.Forms.NumericUpDown();
            this.txtEndColumn = new System.Windows.Forms.NumericUpDown();
            this.txtStartColumn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTempData);
            this.groupBox1.Controls.Add(this.txtTempData);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File dữ liệu";
            // 
            // btnTempData
            // 
            this.btnTempData.Location = new System.Drawing.Point(354, 17);
            this.btnTempData.Name = "btnTempData";
            this.btnTempData.Size = new System.Drawing.Size(75, 23);
            this.btnTempData.TabIndex = 1;
            this.btnTempData.Text = "Nhập";
            this.btnTempData.UseVisualStyleBackColor = true;
            this.btnTempData.Click += new System.EventHandler(this.btnTempData_Click);
            // 
            // txtTempData
            // 
            this.txtTempData.Location = new System.Drawing.Point(7, 20);
            this.txtTempData.Name = "txtTempData";
            this.txtTempData.Size = new System.Drawing.Size(341, 20);
            this.txtTempData.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLichLamViec);
            this.groupBox2.Controls.Add(this.txtLichLamViec);
            this.groupBox2.Location = new System.Drawing.Point(21, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File lịch làm việc";
            // 
            // btnLichLamViec
            // 
            this.btnLichLamViec.Location = new System.Drawing.Point(354, 17);
            this.btnLichLamViec.Name = "btnLichLamViec";
            this.btnLichLamViec.Size = new System.Drawing.Size(75, 23);
            this.btnLichLamViec.TabIndex = 1;
            this.btnLichLamViec.Text = "Nhập";
            this.btnLichLamViec.UseVisualStyleBackColor = true;
            this.btnLichLamViec.Click += new System.EventHandler(this.btnLichLamViec_Click);
            // 
            // txtLichLamViec
            // 
            this.txtLichLamViec.Location = new System.Drawing.Point(7, 20);
            this.txtLichLamViec.Name = "txtLichLamViec";
            this.txtLichLamViec.Size = new System.Drawing.Size(341, 20);
            this.txtLichLamViec.TabIndex = 0;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(21, 130);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(767, 308);
            this.dgvData.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Row";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(231, 247);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(313, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Row";
            // 
            // txtStartRow
            // 
            this.txtStartRow.Location = new System.Drawing.Point(573, 29);
            this.txtStartRow.Name = "txtStartRow";
            this.txtStartRow.Size = new System.Drawing.Size(59, 20);
            this.txtStartRow.TabIndex = 7;
            this.txtStartRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtEndRow
            // 
            this.txtEndRow.Location = new System.Drawing.Point(706, 29);
            this.txtEndRow.Name = "txtEndRow";
            this.txtEndRow.Size = new System.Drawing.Size(63, 20);
            this.txtEndRow.TabIndex = 8;
            this.txtEndRow.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            // 
            // txtEndColumn
            // 
            this.txtEndColumn.Location = new System.Drawing.Point(706, 58);
            this.txtEndColumn.Name = "txtEndColumn";
            this.txtEndColumn.Size = new System.Drawing.Size(63, 20);
            this.txtEndColumn.TabIndex = 12;
            this.txtEndColumn.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // txtStartColumn
            // 
            this.txtStartColumn.Location = new System.Drawing.Point(573, 58);
            this.txtStartColumn.Name = "txtStartColumn";
            this.txtStartColumn.Size = new System.Drawing.Size(59, 20);
            this.txtStartColumn.TabIndex = 11;
            this.txtStartColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "End Column";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start Column";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEndColumn);
            this.Controls.Add(this.txtStartColumn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndRow);
            this.Controls.Add(this.txtStartRow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTempData;
        private System.Windows.Forms.TextBox txtTempData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLichLamViec;
        private System.Windows.Forms.TextBox txtLichLamViec;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtStartRow;
        private System.Windows.Forms.NumericUpDown txtEndRow;
        private System.Windows.Forms.NumericUpDown txtEndColumn;
        private System.Windows.Forms.NumericUpDown txtStartColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

