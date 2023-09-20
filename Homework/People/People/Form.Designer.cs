namespace People
{
    partial class Form
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
            this.backgroundCstmPnl = new CustomControls.CustomPanel();
            this.peopleInputCstmPnl = new CustomControls.CustomPanel();
            this.ageCstmTxtBx = new CustomControls.CustomTextBox();
            this.nameCstmTxtBx = new CustomControls.CustomTextBox();
            this.minimizeClosePnl = new System.Windows.Forms.Panel();
            this.closePctrBx = new System.Windows.Forms.PictureBox();
            this.minimizePctrBx = new System.Windows.Forms.PictureBox();
            this.cstmDrgCntrl = new CustomControls.CustomDragControl();
            this.saveCstmBttn = new CustomControls.CustomButton();
            this.showAllCstmBttn = new CustomControls.CustomButton();
            this.peopleInfoCstmPnl = new CustomControls.CustomPanel();
            this.searchCstmTxtBx = new CustomControls.CustomTextBox();
            this.searchCstmBttn = new CustomControls.CustomButton();
            this.nameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundCstmPnl.SuspendLayout();
            this.peopleInputCstmPnl.SuspendLayout();
            this.minimizeClosePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePctrBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePctrBx)).BeginInit();
            this.peopleInfoCstmPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundCstmPnl
            // 
            this.backgroundCstmPnl.Angle = -225F;
            this.backgroundCstmPnl.BackColor = System.Drawing.Color.Transparent;
            this.backgroundCstmPnl.BorderColor = System.Drawing.Color.Gray;
            this.backgroundCstmPnl.BorderRadius = 0;
            this.backgroundCstmPnl.BorderSize = 0;
            this.backgroundCstmPnl.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(32)))), ((int)(((byte)(87)))));
            this.backgroundCstmPnl.Controls.Add(this.peopleInfoCstmPnl);
            this.backgroundCstmPnl.Controls.Add(this.peopleInputCstmPnl);
            this.backgroundCstmPnl.Controls.Add(this.minimizeClosePnl);
            this.backgroundCstmPnl.Location = new System.Drawing.Point(0, 0);
            this.backgroundCstmPnl.Name = "backgroundCstmPnl";
            this.backgroundCstmPnl.Size = new System.Drawing.Size(890, 624);
            this.backgroundCstmPnl.TabIndex = 0;
            this.backgroundCstmPnl.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(32)))), ((int)(((byte)(87)))));
            // 
            // peopleInputCstmPnl
            // 
            this.peopleInputCstmPnl.Angle = 0F;
            this.peopleInputCstmPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(54)))));
            this.peopleInputCstmPnl.BorderColor = System.Drawing.Color.Empty;
            this.peopleInputCstmPnl.BorderRadius = 25;
            this.peopleInputCstmPnl.BorderSize = 0;
            this.peopleInputCstmPnl.BottomColor = System.Drawing.Color.Empty;
            this.peopleInputCstmPnl.Controls.Add(this.ageLbl);
            this.peopleInputCstmPnl.Controls.Add(this.nameLbl);
            this.peopleInputCstmPnl.Controls.Add(this.showAllCstmBttn);
            this.peopleInputCstmPnl.Controls.Add(this.saveCstmBttn);
            this.peopleInputCstmPnl.Controls.Add(this.ageCstmTxtBx);
            this.peopleInputCstmPnl.Controls.Add(this.nameCstmTxtBx);
            this.peopleInputCstmPnl.Location = new System.Drawing.Point(28, 48);
            this.peopleInputCstmPnl.Name = "peopleInputCstmPnl";
            this.peopleInputCstmPnl.Size = new System.Drawing.Size(370, 288);
            this.peopleInputCstmPnl.TabIndex = 1;
            this.peopleInputCstmPnl.TopColor = System.Drawing.Color.Empty;
            // 
            // ageCstmTxtBx
            // 
            this.ageCstmTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(83)))));
            this.ageCstmTxtBx.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.ageCstmTxtBx.BorderFocusColor = System.Drawing.Color.Empty;
            this.ageCstmTxtBx.BorderRadius = 15;
            this.ageCstmTxtBx.BorderSize = 0;
            this.ageCstmTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageCstmTxtBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.ageCstmTxtBx.Location = new System.Drawing.Point(140, 100);
            this.ageCstmTxtBx.Margin = new System.Windows.Forms.Padding(4);
            this.ageCstmTxtBx.MaxLength = 32767;
            this.ageCstmTxtBx.Multiline = false;
            this.ageCstmTxtBx.Name = "ageCstmTxtBx";
            this.ageCstmTxtBx.PaddingLeft = 15;
            this.ageCstmTxtBx.PaddingTop = 4;
            this.ageCstmTxtBx.PasswordChar = false;
            this.ageCstmTxtBx.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ageCstmTxtBx.PlaceholderText = "";
            this.ageCstmTxtBx.SelectionLength = 0;
            this.ageCstmTxtBx.SelectionStart = 0;
            this.ageCstmTxtBx.Size = new System.Drawing.Size(195, 37);
            this.ageCstmTxtBx.TabIndex = 1;
            this.ageCstmTxtBx.Texts = "";
            this.ageCstmTxtBx.UnderlinedStyle = false;
            // 
            // nameCstmTxtBx
            // 
            this.nameCstmTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(83)))));
            this.nameCstmTxtBx.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.nameCstmTxtBx.BorderFocusColor = System.Drawing.Color.Empty;
            this.nameCstmTxtBx.BorderRadius = 15;
            this.nameCstmTxtBx.BorderSize = 0;
            this.nameCstmTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCstmTxtBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.nameCstmTxtBx.Location = new System.Drawing.Point(140, 44);
            this.nameCstmTxtBx.Margin = new System.Windows.Forms.Padding(4);
            this.nameCstmTxtBx.MaxLength = 32767;
            this.nameCstmTxtBx.Multiline = false;
            this.nameCstmTxtBx.Name = "nameCstmTxtBx";
            this.nameCstmTxtBx.PaddingLeft = 15;
            this.nameCstmTxtBx.PaddingTop = 4;
            this.nameCstmTxtBx.PasswordChar = false;
            this.nameCstmTxtBx.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.nameCstmTxtBx.PlaceholderText = "";
            this.nameCstmTxtBx.SelectionLength = 0;
            this.nameCstmTxtBx.SelectionStart = 0;
            this.nameCstmTxtBx.Size = new System.Drawing.Size(195, 37);
            this.nameCstmTxtBx.TabIndex = 0;
            this.nameCstmTxtBx.Texts = "";
            this.nameCstmTxtBx.UnderlinedStyle = false;
            // 
            // minimizeClosePnl
            // 
            this.minimizeClosePnl.BackColor = System.Drawing.Color.Transparent;
            this.minimizeClosePnl.Controls.Add(this.closePctrBx);
            this.minimizeClosePnl.Controls.Add(this.minimizePctrBx);
            this.minimizeClosePnl.Location = new System.Drawing.Point(0, 0);
            this.minimizeClosePnl.Name = "minimizeClosePnl";
            this.minimizeClosePnl.Size = new System.Drawing.Size(890, 48);
            this.minimizeClosePnl.TabIndex = 0;
            // 
            // closePctrBx
            // 
            this.closePctrBx.BackColor = System.Drawing.Color.White;
            this.closePctrBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePctrBx.Location = new System.Drawing.Point(858, 16);
            this.closePctrBx.Name = "closePctrBx";
            this.closePctrBx.Size = new System.Drawing.Size(17, 17);
            this.closePctrBx.TabIndex = 1;
            this.closePctrBx.TabStop = false;
            this.closePctrBx.Click += new System.EventHandler(this.closePctrBx_Click);
            // 
            // minimizePctrBx
            // 
            this.minimizePctrBx.BackColor = System.Drawing.Color.White;
            this.minimizePctrBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePctrBx.Location = new System.Drawing.Point(829, 16);
            this.minimizePctrBx.Name = "minimizePctrBx";
            this.minimizePctrBx.Size = new System.Drawing.Size(17, 17);
            this.minimizePctrBx.TabIndex = 0;
            this.minimizePctrBx.TabStop = false;
            this.minimizePctrBx.Click += new System.EventHandler(this.minimizePctrBx_Click);
            // 
            // cstmDrgCntrl
            // 
            this.cstmDrgCntrl.SelectControl = this.minimizeClosePnl;
            // 
            // saveCstmBttn
            // 
            this.saveCstmBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.saveCstmBttn.BorderColor = System.Drawing.Color.Gray;
            this.saveCstmBttn.BorderRadius = 25;
            this.saveCstmBttn.BorderSize = 0;
            this.saveCstmBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveCstmBttn.FlatAppearance.BorderSize = 0;
            this.saveCstmBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCstmBttn.ForeColor = System.Drawing.Color.White;
            this.saveCstmBttn.Location = new System.Drawing.Point(35, 193);
            this.saveCstmBttn.Name = "saveCstmBttn";
            this.saveCstmBttn.Size = new System.Drawing.Size(132, 51);
            this.saveCstmBttn.TabIndex = 2;
            this.saveCstmBttn.Text = "Save";
            this.saveCstmBttn.UseVisualStyleBackColor = false;
            this.saveCstmBttn.Click += new System.EventHandler(this.saveCstmBttn_Click);
            // 
            // showAllCstmBttn
            // 
            this.showAllCstmBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(244)))));
            this.showAllCstmBttn.BorderColor = System.Drawing.Color.Gray;
            this.showAllCstmBttn.BorderRadius = 25;
            this.showAllCstmBttn.BorderSize = 0;
            this.showAllCstmBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllCstmBttn.FlatAppearance.BorderSize = 0;
            this.showAllCstmBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllCstmBttn.ForeColor = System.Drawing.Color.White;
            this.showAllCstmBttn.Location = new System.Drawing.Point(192, 193);
            this.showAllCstmBttn.Name = "showAllCstmBttn";
            this.showAllCstmBttn.Size = new System.Drawing.Size(143, 51);
            this.showAllCstmBttn.TabIndex = 3;
            this.showAllCstmBttn.Text = "Show All";
            this.showAllCstmBttn.UseVisualStyleBackColor = false;
            this.showAllCstmBttn.Click += new System.EventHandler(this.showAllCstmBttn_Click);
            // 
            // peopleInfoCstmPnl
            // 
            this.peopleInfoCstmPnl.Angle = 0F;
            this.peopleInfoCstmPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(13)))), ((int)(((byte)(54)))));
            this.peopleInfoCstmPnl.BorderColor = System.Drawing.Color.Gray;
            this.peopleInfoCstmPnl.BorderRadius = 25;
            this.peopleInfoCstmPnl.BorderSize = 0;
            this.peopleInfoCstmPnl.BottomColor = System.Drawing.Color.Empty;
            this.peopleInfoCstmPnl.Controls.Add(this.textBox1);
            this.peopleInfoCstmPnl.Controls.Add(this.searchCstmBttn);
            this.peopleInfoCstmPnl.Controls.Add(this.searchCstmTxtBx);
            this.peopleInfoCstmPnl.Location = new System.Drawing.Point(422, 48);
            this.peopleInfoCstmPnl.Name = "peopleInfoCstmPnl";
            this.peopleInfoCstmPnl.Size = new System.Drawing.Size(440, 528);
            this.peopleInfoCstmPnl.TabIndex = 2;
            this.peopleInfoCstmPnl.TopColor = System.Drawing.Color.Empty;
            // 
            // searchCstmTxtBx
            // 
            this.searchCstmTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(83)))));
            this.searchCstmTxtBx.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.searchCstmTxtBx.BorderFocusColor = System.Drawing.Color.Empty;
            this.searchCstmTxtBx.BorderRadius = 15;
            this.searchCstmTxtBx.BorderSize = 0;
            this.searchCstmTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCstmTxtBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.searchCstmTxtBx.Location = new System.Drawing.Point(35, 446);
            this.searchCstmTxtBx.Margin = new System.Windows.Forms.Padding(4);
            this.searchCstmTxtBx.MaxLength = 32767;
            this.searchCstmTxtBx.Multiline = false;
            this.searchCstmTxtBx.Name = "searchCstmTxtBx";
            this.searchCstmTxtBx.PaddingLeft = 15;
            this.searchCstmTxtBx.PaddingTop = 4;
            this.searchCstmTxtBx.PasswordChar = false;
            this.searchCstmTxtBx.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchCstmTxtBx.PlaceholderText = "";
            this.searchCstmTxtBx.SelectionLength = 0;
            this.searchCstmTxtBx.SelectionStart = 0;
            this.searchCstmTxtBx.Size = new System.Drawing.Size(258, 38);
            this.searchCstmTxtBx.TabIndex = 1;
            this.searchCstmTxtBx.Texts = "";
            this.searchCstmTxtBx.UnderlinedStyle = false;
            // 
            // searchCstmBttn
            // 
            this.searchCstmBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(244)))));
            this.searchCstmBttn.BorderColor = System.Drawing.Color.Gray;
            this.searchCstmBttn.BorderRadius = 19;
            this.searchCstmBttn.BorderSize = 0;
            this.searchCstmBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchCstmBttn.FlatAppearance.BorderSize = 0;
            this.searchCstmBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCstmBttn.ForeColor = System.Drawing.Color.White;
            this.searchCstmBttn.Location = new System.Drawing.Point(313, 446);
            this.searchCstmBttn.Name = "searchCstmBttn";
            this.searchCstmBttn.Size = new System.Drawing.Size(92, 38);
            this.searchCstmBttn.TabIndex = 4;
            this.searchCstmBttn.Text = "Search";
            this.searchCstmBttn.UseVisualStyleBackColor = false;
            this.searchCstmBttn.Click += new System.EventHandler(this.searchCstmBttn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(26, 38);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(47, 16);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Name:";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.ForeColor = System.Drawing.Color.White;
            this.ageLbl.Location = new System.Drawing.Point(26, 95);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(35, 16);
            this.ageLbl.TabIndex = 5;
            this.ageLbl.Text = "Age:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(35, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(370, 378);
            this.textBox1.TabIndex = 5;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 624);
            this.Controls.Add(this.backgroundCstmPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.backgroundCstmPnl.ResumeLayout(false);
            this.peopleInputCstmPnl.ResumeLayout(false);
            this.peopleInputCstmPnl.PerformLayout();
            this.minimizeClosePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePctrBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePctrBx)).EndInit();
            this.peopleInfoCstmPnl.ResumeLayout(false);
            this.peopleInfoCstmPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CustomPanel backgroundCstmPnl;
        private System.Windows.Forms.Panel minimizeClosePnl;
        private System.Windows.Forms.PictureBox closePctrBx;
        private System.Windows.Forms.PictureBox minimizePctrBx;
        private CustomControls.CustomPanel peopleInputCstmPnl;
        private CustomControls.CustomDragControl cstmDrgCntrl;
        private CustomControls.CustomTextBox nameCstmTxtBx;
        private CustomControls.CustomTextBox ageCstmTxtBx;
        private CustomControls.CustomButton saveCstmBttn;
        private CustomControls.CustomButton showAllCstmBttn;
        private CustomControls.CustomPanel peopleInfoCstmPnl;
        private CustomControls.CustomTextBox searchCstmTxtBx;
        private CustomControls.CustomButton searchCstmBttn;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}

