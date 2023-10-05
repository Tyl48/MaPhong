namespace QLNS
{
    partial class Form2
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
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.txtmp = new System.Windows.Forms.TextBox();
            this.txttp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtttp = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma_phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_truong_phuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(59, 170);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click_1);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(199, 170);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click_1);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(366, 170);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // txtmp
            // 
            this.txtmp.Location = new System.Drawing.Point(170, 35);
            this.txtmp.Name = "txtmp";
            this.txtmp.Size = new System.Drawing.Size(142, 22);
            this.txtmp.TabIndex = 3;
            // 
            // txttp
            // 
            this.txttp.Location = new System.Drawing.Point(170, 87);
            this.txttp.Name = "txttp";
            this.txttp.Size = new System.Drawing.Size(142, 22);
            this.txttp.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ma phong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ten phong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ten truong phong";
            // 
            // txtttp
            // 
            this.txtttp.Location = new System.Drawing.Point(551, 29);
            this.txtttp.Name = "txtttp";
            this.txtttp.Size = new System.Drawing.Size(132, 22);
            this.txtttp.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_phong,
            this.Ten_phong,
            this.Ten_truong_phuong});
            this.dataGridView1.Location = new System.Drawing.Point(28, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 180);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Chon_dong);
            // 
            // Ma_phong
            // 
            this.Ma_phong.DataPropertyName = "Ma_phong";
            this.Ma_phong.HeaderText = "Ma phong";
            this.Ma_phong.MinimumWidth = 6;
            this.Ma_phong.Name = "Ma_phong";
            this.Ma_phong.Width = 125;
            // 
            // Ten_phong
            // 
            this.Ten_phong.DataPropertyName = "Ten_phong";
            this.Ten_phong.HeaderText = "Ten phong";
            this.Ten_phong.MinimumWidth = 6;
            this.Ten_phong.Name = "Ten_phong";
            this.Ten_phong.Width = 125;
            // 
            // Ten_truong_phuong
            // 
            this.Ten_truong_phuong.DataPropertyName = "Ten_truong_phuong";
            this.Ten_truong_phuong.HeaderText = "Ten truong phong";
            this.Ten_truong_phuong.MinimumWidth = 6;
            this.Ten_truong_phuong.Name = "Ten_truong_phuong";
            this.Ten_truong_phuong.Width = 125;
            // 
            // Excel
            // 
            this.Excel.Location = new System.Drawing.Point(527, 170);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(75, 23);
            this.Excel.TabIndex = 10;
            this.Excel.Text = "Excel";
            this.Excel.UseVisualStyleBackColor = true;
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtttp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttp);
            this.Controls.Add(this.txtmp);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox txtmp;
        private System.Windows.Forms.TextBox txttp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtttp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_truong_phuong;
        private System.Windows.Forms.Button Excel;
    }
}