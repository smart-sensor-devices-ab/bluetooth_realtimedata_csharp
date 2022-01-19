namespace WindowsFormsApp1
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
            this.lbl_test = new System.Windows.Forms.Label();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_deviceList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dropdown_device = new System.Windows.Forms.ComboBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.sensor_op = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Location = new System.Drawing.Point(202, 94);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(0, 13);
            this.lbl_test.TabIndex = 2;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(703, 27);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 5;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sensor Value";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://www.bleuio.com/images/logo.png";
            this.pictureBox1.Location = new System.Drawing.Point(101, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_deviceList
            // 
            this.btn_deviceList.Location = new System.Drawing.Point(101, 89);
            this.btn_deviceList.Name = "btn_deviceList";
            this.btn_deviceList.Size = new System.Drawing.Size(183, 23);
            this.btn_deviceList.TabIndex = 12;
            this.btn_deviceList.Text = "Scan for HibouAir Devices";
            this.btn_deviceList.UseVisualStyleBackColor = true;
            this.btn_deviceList.Click += new System.EventHandler(this.btn_deviceList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dropdown_device
            // 
            this.dropdown_device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_device.FormattingEnabled = true;
            this.dropdown_device.Items.AddRange(new object[] {
            "Load Devices"});
            this.dropdown_device.Location = new System.Drawing.Point(101, 132);
            this.dropdown_device.Name = "dropdown_device";
            this.dropdown_device.Size = new System.Drawing.Size(280, 21);
            this.dropdown_device.TabIndex = 14;
            this.dropdown_device.SelectedIndexChanged += new System.EventHandler(this.dropdown_device_SelectedIndexChanged);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(412, 130);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 15;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Visible = false;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // sensor_op
            // 
            this.sensor_op.AutoSize = true;
            this.sensor_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor_op.Location = new System.Drawing.Point(98, 197);
            this.sensor_op.Name = "sensor_op";
            this.sensor_op.Size = new System.Drawing.Size(0, 16);
            this.sensor_op.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.sensor_op);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.dropdown_device);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deviceList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.lbl_test);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_test;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_deviceList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropdown_device;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label sensor_op;
    }
}

