namespace Graphing_Calculator
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
            this.topPnl = new System.Windows.Forms.Panel();
            this.closePctrBx = new System.Windows.Forms.PictureBox();
            this.minimizePctrBx = new System.Windows.Forms.PictureBox();
            this.graphPctrBx = new System.Windows.Forms.PictureBox();
            this.yLbl = new System.Windows.Forms.Label();
            this.xLbl = new System.Windows.Forms.Label();
            this.zoomOutCstmBttn = new Calculator.CustomButton();
            this.resetCstmBttn = new Calculator.CustomButton();
            this.zoomInCstmBttn = new Calculator.CustomButton();
            this.functionCstmPnl = new Graphing_Calculator.CustomPanel();
            this.functionCstmTxtBx = new Graphing_Calculator.CustomControls.CustomTextBox();
            this.enterFunctionLbl = new System.Windows.Forms.Label();
            this.drawCstmBttn = new Calculator.CustomButton();
            this.cstmDrgCntrl = new Graphing_Calculator.CustomControls.CustomDragControl();
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePctrBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePctrBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPctrBx)).BeginInit();
            this.functionCstmPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(204)))), ((int)(((byte)(136)))));
            this.topPnl.Controls.Add(this.closePctrBx);
            this.topPnl.Controls.Add(this.minimizePctrBx);
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(1039, 39);
            this.topPnl.TabIndex = 0;
            // 
            // closePctrBx
            // 
            this.closePctrBx.BackColor = System.Drawing.Color.White;
            this.closePctrBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePctrBx.Location = new System.Drawing.Point(1005, 11);
            this.closePctrBx.Name = "closePctrBx";
            this.closePctrBx.Size = new System.Drawing.Size(17, 17);
            this.closePctrBx.TabIndex = 2;
            this.closePctrBx.TabStop = false;
            this.closePctrBx.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minimizePctrBx
            // 
            this.minimizePctrBx.BackColor = System.Drawing.Color.White;
            this.minimizePctrBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePctrBx.Location = new System.Drawing.Point(975, 11);
            this.minimizePctrBx.Name = "minimizePctrBx";
            this.minimizePctrBx.Size = new System.Drawing.Size(17, 17);
            this.minimizePctrBx.TabIndex = 1;
            this.minimizePctrBx.TabStop = false;
            this.minimizePctrBx.Click += new System.EventHandler(this.minimizePctrBx_Click);
            // 
            // graphPctrBx
            // 
            this.graphPctrBx.Location = new System.Drawing.Point(393, 39);
            this.graphPctrBx.Name = "graphPctrBx";
            this.graphPctrBx.Size = new System.Drawing.Size(645, 645);
            this.graphPctrBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.graphPctrBx.TabIndex = 3;
            this.graphPctrBx.TabStop = false;
            // 
            // yLbl
            // 
            this.yLbl.AutoSize = true;
            this.yLbl.BackColor = System.Drawing.Color.Transparent;
            this.yLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.yLbl.Location = new System.Drawing.Point(724, 46);
            this.yLbl.Name = "yLbl";
            this.yLbl.Size = new System.Drawing.Size(16, 16);
            this.yLbl.TabIndex = 7;
            this.yLbl.Text = "Y";
            // 
            // xLbl
            // 
            this.xLbl.AutoSize = true;
            this.xLbl.BackColor = System.Drawing.Color.Transparent;
            this.xLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.xLbl.Location = new System.Drawing.Point(1006, 327);
            this.xLbl.Name = "xLbl";
            this.xLbl.Size = new System.Drawing.Size(15, 16);
            this.xLbl.TabIndex = 8;
            this.xLbl.Text = "X";
            // 
            // zoomOutCstmBttn
            // 
            this.zoomOutCstmBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.zoomOutCstmBttn.BorderColor = System.Drawing.Color.Gray;
            this.zoomOutCstmBttn.BorderRadius = 8;
            this.zoomOutCstmBttn.BorderSize = 0;
            this.zoomOutCstmBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zoomOutCstmBttn.FlatAppearance.BorderSize = 0;
            this.zoomOutCstmBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomOutCstmBttn.ForeColor = System.Drawing.Color.White;
            this.zoomOutCstmBttn.Location = new System.Drawing.Point(985, 631);
            this.zoomOutCstmBttn.Name = "zoomOutCstmBttn";
            this.zoomOutCstmBttn.Size = new System.Drawing.Size(41, 41);
            this.zoomOutCstmBttn.TabIndex = 6;
            this.zoomOutCstmBttn.Text = "–";
            this.zoomOutCstmBttn.UseCompatibleTextRendering = true;
            this.zoomOutCstmBttn.UseVisualStyleBackColor = false;
            this.zoomOutCstmBttn.Click += new System.EventHandler(this.zoomOutCstmBttn_Click);
            // 
            // resetCstmBttn
            // 
            this.resetCstmBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.resetCstmBttn.BorderColor = System.Drawing.Color.Gray;
            this.resetCstmBttn.BorderRadius = 8;
            this.resetCstmBttn.BorderSize = 0;
            this.resetCstmBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetCstmBttn.FlatAppearance.BorderSize = 0;
            this.resetCstmBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetCstmBttn.ForeColor = System.Drawing.Color.White;
            this.resetCstmBttn.Location = new System.Drawing.Point(934, 631);
            this.resetCstmBttn.Name = "resetCstmBttn";
            this.resetCstmBttn.Size = new System.Drawing.Size(41, 41);
            this.resetCstmBttn.TabIndex = 5;
            this.resetCstmBttn.Text = "↻";
            this.resetCstmBttn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.resetCstmBttn.UseCompatibleTextRendering = true;
            this.resetCstmBttn.UseVisualStyleBackColor = false;
            this.resetCstmBttn.Click += new System.EventHandler(this.resetCstmBttn_Click);
            // 
            // zoomInCstmBttn
            // 
            this.zoomInCstmBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.zoomInCstmBttn.BorderColor = System.Drawing.Color.Gray;
            this.zoomInCstmBttn.BorderRadius = 8;
            this.zoomInCstmBttn.BorderSize = 0;
            this.zoomInCstmBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zoomInCstmBttn.FlatAppearance.BorderSize = 0;
            this.zoomInCstmBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomInCstmBttn.ForeColor = System.Drawing.Color.White;
            this.zoomInCstmBttn.Location = new System.Drawing.Point(883, 631);
            this.zoomInCstmBttn.Name = "zoomInCstmBttn";
            this.zoomInCstmBttn.Size = new System.Drawing.Size(41, 41);
            this.zoomInCstmBttn.TabIndex = 4;
            this.zoomInCstmBttn.Text = "+";
            this.zoomInCstmBttn.UseCompatibleTextRendering = true;
            this.zoomInCstmBttn.UseVisualStyleBackColor = false;
            this.zoomInCstmBttn.Click += new System.EventHandler(this.zoomInCstmBttn_Click);
            // 
            // functionCstmPnl
            // 
            this.functionCstmPnl.Angle = 90F;
            this.functionCstmPnl.BackColor = System.Drawing.Color.White;
            this.functionCstmPnl.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.functionCstmPnl.Controls.Add(this.functionCstmTxtBx);
            this.functionCstmPnl.Controls.Add(this.enterFunctionLbl);
            this.functionCstmPnl.Controls.Add(this.drawCstmBttn);
            this.functionCstmPnl.Location = new System.Drawing.Point(0, 39);
            this.functionCstmPnl.Name = "functionCstmPnl";
            this.functionCstmPnl.Size = new System.Drawing.Size(393, 645);
            this.functionCstmPnl.TabIndex = 1;
            this.functionCstmPnl.TopColor = System.Drawing.Color.White;
            // 
            // functionCstmTxtBx
            // 
            this.functionCstmTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.functionCstmTxtBx.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.functionCstmTxtBx.BorderFocusColor = System.Drawing.Color.Transparent;
            this.functionCstmTxtBx.BorderRadius = 5;
            this.functionCstmTxtBx.BorderSize = 0;
            this.functionCstmTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.functionCstmTxtBx.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.functionCstmTxtBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(151)))), ((int)(((byte)(152)))));
            this.functionCstmTxtBx.Location = new System.Drawing.Point(35, 168);
            this.functionCstmTxtBx.Margin = new System.Windows.Forms.Padding(4);
            this.functionCstmTxtBx.MaxLength = 32767;
            this.functionCstmTxtBx.Multiline = false;
            this.functionCstmTxtBx.Name = "functionCstmTxtBx";
            this.functionCstmTxtBx.PaddingLeft = 17;
            this.functionCstmTxtBx.PaddingTop = 15;
            this.functionCstmTxtBx.PasswordChar = false;
            this.functionCstmTxtBx.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.functionCstmTxtBx.PlaceholderText = "";
            this.functionCstmTxtBx.SelectionLength = 0;
            this.functionCstmTxtBx.SelectionStart = 0;
            this.functionCstmTxtBx.Size = new System.Drawing.Size(323, 61);
            this.functionCstmTxtBx.TabIndex = 2;
            this.functionCstmTxtBx.Texts = "y = ";
            this.functionCstmTxtBx.UnderlinedStyle = false;
            // 
            // enterFunctionLbl
            // 
            this.enterFunctionLbl.AutoSize = true;
            this.enterFunctionLbl.BackColor = System.Drawing.Color.Transparent;
            this.enterFunctionLbl.Location = new System.Drawing.Point(28, 103);
            this.enterFunctionLbl.Name = "enterFunctionLbl";
            this.enterFunctionLbl.Size = new System.Drawing.Size(149, 16);
            this.enterFunctionLbl.TabIndex = 1;
            this.enterFunctionLbl.Text = "ВВЕДИТЕ ФУНКЦИЮ:";
            // 
            // drawCstmBttn
            // 
            this.drawCstmBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(204)))), ((int)(((byte)(136)))));
            this.drawCstmBttn.BorderColor = System.Drawing.Color.Gray;
            this.drawCstmBttn.BorderRadius = 12;
            this.drawCstmBttn.BorderSize = 0;
            this.drawCstmBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawCstmBttn.FlatAppearance.BorderSize = 0;
            this.drawCstmBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawCstmBttn.ForeColor = System.Drawing.Color.White;
            this.drawCstmBttn.Location = new System.Drawing.Point(100, 310);
            this.drawCstmBttn.Name = "drawCstmBttn";
            this.drawCstmBttn.Size = new System.Drawing.Size(192, 63);
            this.drawCstmBttn.TabIndex = 0;
            this.drawCstmBttn.Text = "РИСОВАТЬ";
            this.drawCstmBttn.UseVisualStyleBackColor = false;
            this.drawCstmBttn.Click += new System.EventHandler(this.drawCstmBttn_Click);
            // 
            // cstmDrgCntrl
            // 
            this.cstmDrgCntrl.SelectControl = this.topPnl;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 685);
            this.Controls.Add(this.xLbl);
            this.Controls.Add(this.yLbl);
            this.Controls.Add(this.zoomOutCstmBttn);
            this.Controls.Add(this.resetCstmBttn);
            this.Controls.Add(this.zoomInCstmBttn);
            this.Controls.Add(this.graphPctrBx);
            this.Controls.Add(this.functionCstmPnl);
            this.Controls.Add(this.topPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.topPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePctrBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePctrBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPctrBx)).EndInit();
            this.functionCstmPnl.ResumeLayout(false);
            this.functionCstmPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.PictureBox closePctrBx;
        private System.Windows.Forms.PictureBox minimizePctrBx;
        private CustomControls.CustomDragControl cstmDrgCntrl;
        private CustomPanel functionCstmPnl;
        private Calculator.CustomButton drawCstmBttn;
        private System.Windows.Forms.Label enterFunctionLbl;
        private System.Windows.Forms.PictureBox graphPctrBx;
        private CustomControls.CustomTextBox functionCstmTxtBx;
        private Calculator.CustomButton zoomInCstmBttn;
        private Calculator.CustomButton resetCstmBttn;
        private Calculator.CustomButton zoomOutCstmBttn;
        private System.Windows.Forms.Label yLbl;
        private System.Windows.Forms.Label xLbl;
    }
}

