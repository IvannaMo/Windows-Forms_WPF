namespace Clock
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
            this.components = new System.ComponentModel.Container();
            this.clockPctrBx = new System.Windows.Forms.PictureBox();
            this.digitalClockPctrBx = new System.Windows.Forms.PictureBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clockPctrBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalClockPctrBx)).BeginInit();
            this.SuspendLayout();
            // 
            // clockPctrBx
            // 
            this.clockPctrBx.Location = new System.Drawing.Point(184, 64);
            this.clockPctrBx.Name = "clockPctrBx";
            this.clockPctrBx.Size = new System.Drawing.Size(444, 444);
            this.clockPctrBx.TabIndex = 0;
            this.clockPctrBx.TabStop = false;
            this.clockPctrBx.Paint += new System.Windows.Forms.PaintEventHandler(this.clockPctrBx_Paint);
            // 
            // digitalClockPctrBx
            // 
            this.digitalClockPctrBx.Location = new System.Drawing.Point(288, 560);
            this.digitalClockPctrBx.Name = "digitalClockPctrBx";
            this.digitalClockPctrBx.Size = new System.Drawing.Size(234, 120);
            this.digitalClockPctrBx.TabIndex = 1;
            this.digitalClockPctrBx.TabStop = false;
            this.digitalClockPctrBx.Paint += new System.Windows.Forms.PaintEventHandler(this.digitalClockPctrBx_Paint);
            // 
            // timeLbl
            // 
            this.timeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.timeLbl.Location = new System.Drawing.Point(315, 583);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(184, 64);
            this.timeLbl.TabIndex = 2;
            this.timeLbl.Text = "00:00";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(807, 733);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.digitalClockPctrBx);
            this.Controls.Add(this.clockPctrBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.ShowIcon = false;
            this.Text = "Clock";
            ((System.ComponentModel.ISupportInitialize)(this.clockPctrBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalClockPctrBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox clockPctrBx;
        private System.Windows.Forms.PictureBox digitalClockPctrBx;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer timer;
    }
}

