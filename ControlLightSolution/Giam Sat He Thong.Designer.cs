namespace congcom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_Connect = new System.Windows.Forms.Button();
            this.cbb_Select_Com = new System.Windows.Forms.ComboBox();
            this.lb_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Com = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LED3 = new System.Windows.Forms.PictureBox();
            this.LED2 = new System.Windows.Forms.PictureBox();
            this.LED1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Receive_Data = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LED3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(283, 33);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(82, 21);
            this.bt_Connect.TabIndex = 0;
            this.bt_Connect.Text = "Connect";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // cbb_Select_Com
            // 
            this.cbb_Select_Com.FormattingEnabled = true;
            this.cbb_Select_Com.Location = new System.Drawing.Point(133, 33);
            this.cbb_Select_Com.Name = "cbb_Select_Com";
            this.cbb_Select_Com.Size = new System.Drawing.Size(121, 21);
            this.cbb_Select_Com.TabIndex = 1;
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(169, 57);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(61, 13);
            this.lb_Status.TabIndex = 2;
            this.lb_Status.Text = "Disconnect";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select COM";
            // 
            // Com
            // 
            this.Com.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.OnCom);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            this.imageList1.Images.SetKeyName(1, "h2.PNG");
            this.imageList1.Images.SetKeyName(2, "h3.PNG");
            // 
            // LED3
            // 
            this.LED3.Location = new System.Drawing.Point(325, 125);
            this.LED3.Name = "LED3";
            this.LED3.Size = new System.Drawing.Size(96, 134);
            this.LED3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LED3.TabIndex = 9;
            this.LED3.TabStop = false;
            // 
            // LED2
            // 
            this.LED2.Location = new System.Drawing.Point(197, 125);
            this.LED2.Name = "LED2";
            this.LED2.Size = new System.Drawing.Size(105, 134);
            this.LED2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LED2.TabIndex = 11;
            this.LED2.TabStop = false;
            // 
            // LED1
            // 
            this.LED1.Location = new System.Drawing.Point(70, 125);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(112, 134);
            this.LED1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LED1.TabIndex = 12;
            this.LED1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "DEN1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "DEN2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "DEN3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Receive Data";
            // 
            // txt_Receive_Data
            // 
            this.txt_Receive_Data.Location = new System.Drawing.Point(133, 78);
            this.txt_Receive_Data.Multiline = true;
            this.txt_Receive_Data.Name = "txt_Receive_Data";
            this.txt_Receive_Data.Size = new System.Drawing.Size(121, 20);
            this.txt_Receive_Data.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 336);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LED1);
            this.Controls.Add(this.LED2);
            this.Controls.Add(this.LED3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Receive_Data);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.cbb_Select_Com);
            this.Controls.Add(this.bt_Connect);
            this.Name = "Form1";
            this.Text = "Giam Sat He Thong";
            ((System.ComponentModel.ISupportInitialize)(this.LED3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.ComboBox cbb_Select_Com;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort Com;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox LED3;
        private System.Windows.Forms.PictureBox LED2;
        private System.Windows.Forms.PictureBox LED1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Receive_Data;
    }
}

