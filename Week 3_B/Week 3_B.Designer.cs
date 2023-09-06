
namespace Week_3_B
{
    partial class frmWritingFiles
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
            this.btnGenerate_Save = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStartRange = new System.Windows.Forms.Label();
            this.lblEndRange = new System.Windows.Forms.Label();
            this.txtStartRange = new System.Windows.Forms.TextBox();
            this.txtEndRange = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnGenerate_Save
            // 
            this.btnGenerate_Save.Location = new System.Drawing.Point(73, 150);
            this.btnGenerate_Save.Name = "btnGenerate_Save";
            this.btnGenerate_Save.Size = new System.Drawing.Size(100, 32);
            this.btnGenerate_Save.TabIndex = 0;
            this.btnGenerate_Save.Text = "Generate/Save";
            this.btnGenerate_Save.UseVisualStyleBackColor = true;
            this.btnGenerate_Save.Click += new System.EventHandler(this.btnGenerate_Save_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(201, 150);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(308, 150);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStartRange
            // 
            this.lblStartRange.AutoSize = true;
            this.lblStartRange.Location = new System.Drawing.Point(86, 46);
            this.lblStartRange.Name = "lblStartRange";
            this.lblStartRange.Size = new System.Drawing.Size(148, 13);
            this.lblStartRange.TabIndex = 3;
            this.lblStartRange.Text = "Please Enter the Start Range:";
            // 
            // lblEndRange
            // 
            this.lblEndRange.AutoSize = true;
            this.lblEndRange.Location = new System.Drawing.Point(86, 76);
            this.lblEndRange.Name = "lblEndRange";
            this.lblEndRange.Size = new System.Drawing.Size(145, 13);
            this.lblEndRange.TabIndex = 4;
            this.lblEndRange.Text = "Please Enter the End Range:";
            // 
            // txtStartRange
            // 
            this.txtStartRange.Location = new System.Drawing.Point(250, 43);
            this.txtStartRange.Name = "txtStartRange";
            this.txtStartRange.Size = new System.Drawing.Size(100, 20);
            this.txtStartRange.TabIndex = 5;
            // 
            // txtEndRange
            // 
            this.txtEndRange.Location = new System.Drawing.Point(250, 76);
            this.txtEndRange.Name = "txtEndRange";
            this.txtEndRange.Size = new System.Drawing.Size(100, 20);
            this.txtEndRange.TabIndex = 6;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(26, 109);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(208, 13);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "Please Enter Desired Quantity of Numbers:";
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(250, 109);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(100, 20);
            this.txtNumbers.TabIndex = 8;
            // 
            // frmWritingFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 215);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtEndRange);
            this.Controls.Add(this.txtStartRange);
            this.Controls.Add(this.lblEndRange);
            this.Controls.Add(this.lblStartRange);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate_Save);
            this.Name = "frmWritingFiles";
            this.Text = "Writing Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate_Save;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStartRange;
        private System.Windows.Forms.Label lblEndRange;
        private System.Windows.Forms.TextBox txtStartRange;
        private System.Windows.Forms.TextBox txtEndRange;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
    }
}

