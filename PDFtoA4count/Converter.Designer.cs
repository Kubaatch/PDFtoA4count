namespace PDFtoA4count
{
    partial class Converter
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.B_SelectFile = new System.Windows.Forms.Button();
            this.B_ExitApp = new System.Windows.Forms.Button();
            this.L_PageSizeMM = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.L_A4Count = new System.Windows.Forms.Label();
            this.L_Note = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AddExtension = false;
            this.openFileDialog1.DefaultExt = "pdf";
            this.openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "Downloads";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select file to convert:";
            // 
            // B_SelectFile
            // 
            this.B_SelectFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_SelectFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.SetColumnSpan(this.B_SelectFile, 3);
            this.B_SelectFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SelectFile.Location = new System.Drawing.Point(135, 170);
            this.B_SelectFile.Name = "B_SelectFile";
            this.tableLayoutPanel1.SetRowSpan(this.B_SelectFile, 3);
            this.B_SelectFile.Size = new System.Drawing.Size(317, 163);
            this.B_SelectFile.TabIndex = 0;
            this.B_SelectFile.Text = "Select File(s)";
            this.B_SelectFile.UseVisualStyleBackColor = false;
            this.B_SelectFile.Click += new System.EventHandler(this.B_SelectFile_Click);
            // 
            // B_ExitApp
            // 
            this.B_ExitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_ExitApp.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ExitApp.Location = new System.Drawing.Point(857, 513);
            this.B_ExitApp.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.B_ExitApp.Name = "B_ExitApp";
            this.B_ExitApp.Size = new System.Drawing.Size(115, 54);
            this.B_ExitApp.TabIndex = 4;
            this.B_ExitApp.Text = "Exit app";
            this.B_ExitApp.UseVisualStyleBackColor = true;
            this.B_ExitApp.Click += new System.EventHandler(this.B_ExitApp_Click);
            // 
            // L_PageSizeMM
            // 
            this.L_PageSizeMM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.L_PageSizeMM.AutoSize = true;
            this.L_PageSizeMM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.L_PageSizeMM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_PageSizeMM.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PageSizeMM.Location = new System.Drawing.Point(591, 490);
            this.L_PageSizeMM.Name = "L_PageSizeMM";
            this.tableLayoutPanel1.SetRowSpan(this.L_PageSizeMM, 2);
            this.L_PageSizeMM.Size = new System.Drawing.Size(180, 29);
            this.L_PageSizeMM.TabIndex = 7;
            this.L_PageSizeMM.Text = "Page size in mm: ";
            this.L_PageSizeMM.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.B_SelectFile, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.B_ExitApp, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.L_A4Count, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.L_PageSizeMM, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.L_Note, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 577);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // L_A4Count
            // 
            this.L_A4Count.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.L_A4Count.AutoSize = true;
            this.L_A4Count.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.L_A4Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_A4Count.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_A4Count.Location = new System.Drawing.Point(591, 237);
            this.L_A4Count.Name = "L_A4Count";
            this.L_A4Count.Size = new System.Drawing.Size(167, 29);
            this.L_A4Count.TabIndex = 9;
            this.L_A4Count.Text = "Total A4 Count: ";
            // 
            // L_Note
            // 
            this.L_Note.AutoSize = true;
            this.L_Note.Location = new System.Drawing.Point(140, 360);
            this.L_Note.Name = "L_Note";
            this.L_Note.Size = new System.Drawing.Size(270, 16);
            this.L_Note.TabIndex = 11;
            this.L_Note.Text = "A4 count is reset when new files are selected";
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(983, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Converter";
            this.Text = "Converter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button B_SelectFile;
        private System.Windows.Forms.Button B_ExitApp;
        private System.Windows.Forms.Label L_PageSizeMM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label L_A4Count;
        private System.Windows.Forms.Label L_Note;
    }
}

