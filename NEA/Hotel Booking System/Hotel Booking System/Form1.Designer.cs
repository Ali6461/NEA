namespace Hotel_Booking_System
{
    partial class FmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.btBooking = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btStatistics = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 266);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.SystemColors.GrayText;
            this.lbTitle.Font = new System.Drawing.Font("Comic Sans MS", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(375, 41);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(347, 69);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "FlyPool Hotel";
            // 
            // btBooking
            // 
            this.btBooking.Location = new System.Drawing.Point(387, 184);
            this.btBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btBooking.Name = "btBooking";
            this.btBooking.Size = new System.Drawing.Size(281, 63);
            this.btBooking.TabIndex = 3;
            this.btBooking.Text = "Booking";
            this.btBooking.UseVisualStyleBackColor = true;
            this.btBooking.Click += new System.EventHandler(this.btBooking_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(928, 505);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(107, 34);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btStatistics
            // 
            this.btStatistics.Location = new System.Drawing.Point(388, 362);
            this.btStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.btStatistics.Name = "btStatistics";
            this.btStatistics.Size = new System.Drawing.Size(280, 59);
            this.btStatistics.TabIndex = 5;
            this.btStatistics.Text = "Statistics";
            this.btStatistics.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(388, 273);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(280, 63);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel Booking";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1067, 545);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btStatistics);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btBooking);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FmMenu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btBooking;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btStatistics;
        private System.Windows.Forms.Button btCancel;
    }
}

