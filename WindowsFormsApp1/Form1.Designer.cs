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
            this.bnt_connect = new System.Windows.Forms.Button();
            this.lbl_test = new System.Windows.Forms.Label();
            this.tb_cmd = new System.Windows.Forms.TextBox();
            this.submit_cmd = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.output_data = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_connect
            // 
            this.bnt_connect.Location = new System.Drawing.Point(101, 84);
            this.bnt_connect.Name = "bnt_connect";
            this.bnt_connect.Size = new System.Drawing.Size(75, 23);
            this.bnt_connect.TabIndex = 0;
            this.bnt_connect.Text = "Connect ";
            this.bnt_connect.UseVisualStyleBackColor = true;
            this.bnt_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Location = new System.Drawing.Point(202, 94);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(0, 13);
            this.lbl_test.TabIndex = 2;
            // 
            // tb_cmd
            // 
            this.tb_cmd.Location = new System.Drawing.Point(223, 151);
            this.tb_cmd.Multiline = true;
            this.tb_cmd.Name = "tb_cmd";
            this.tb_cmd.Size = new System.Drawing.Size(100, 20);
            this.tb_cmd.TabIndex = 3;
            this.tb_cmd.TextChanged += new System.EventHandler(this.tb_cmd_TextChanged);
            // 
            // submit_cmd
            // 
            this.submit_cmd.Location = new System.Drawing.Point(354, 148);
            this.submit_cmd.Name = "submit_cmd";
            this.submit_cmd.Size = new System.Drawing.Size(100, 23);
            this.submit_cmd.TabIndex = 4;
            this.submit_cmd.Text = "Submit Command";
            this.submit_cmd.UseVisualStyleBackColor = true;
            this.submit_cmd.Click += new System.EventHandler(this.submit_cmd_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(379, 84);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 5;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Write AT Commands";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Response from BleuIO";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(521, 84);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 9;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // output_data
            // 
            this.output_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_data.Location = new System.Drawing.Point(223, 207);
            this.output_data.Multiline = true;
            this.output_data.Name = "output_data";
            this.output_data.ReadOnly = true;
            this.output_data.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output_data.Size = new System.Drawing.Size(540, 213);
            this.output_data.TabIndex = 10;
            this.output_data.TextChanged += new System.EventHandler(this.output_data_TextChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.output_data);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.submit_cmd);
            this.Controls.Add(this.tb_cmd);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.bnt_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_connect;
        private System.Windows.Forms.Label lbl_test;
        private System.Windows.Forms.TextBox tb_cmd;
        private System.Windows.Forms.Button submit_cmd;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox output_data;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

