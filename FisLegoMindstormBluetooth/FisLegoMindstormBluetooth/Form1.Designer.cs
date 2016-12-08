namespace FisLegoMindstormBluetooth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comPorts_listbox = new System.Windows.Forms.ListBox();
            this.refresh_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.comPorts_label = new System.Windows.Forms.Label();
            this.startDriving_button = new System.Windows.Forms.Button();
            this.stopDriving_button = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comPorts_listbox
            // 
            this.comPorts_listbox.FormattingEnabled = true;
            this.comPorts_listbox.Location = new System.Drawing.Point(12, 25);
            this.comPorts_listbox.Name = "comPorts_listbox";
            this.comPorts_listbox.Size = new System.Drawing.Size(166, 82);
            this.comPorts_listbox.TabIndex = 0;
            this.comPorts_listbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(193, 25);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(113, 23);
            this.refresh_button.TabIndex = 1;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(193, 54);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(113, 23);
            this.connect_button.TabIndex = 2;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // disconnect_button
            // 
            this.disconnect_button.Location = new System.Drawing.Point(193, 84);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(113, 23);
            this.disconnect_button.TabIndex = 3;
            this.disconnect_button.Text = "Disconnect";
            this.disconnect_button.UseVisualStyleBackColor = true;
            this.disconnect_button.Click += new System.EventHandler(this.disconnect_button_Click);
            // 
            // comPorts_label
            // 
            this.comPorts_label.AutoSize = true;
            this.comPorts_label.Location = new System.Drawing.Point(12, 9);
            this.comPorts_label.Name = "comPorts_label";
            this.comPorts_label.Size = new System.Drawing.Size(99, 13);
            this.comPorts_label.TabIndex = 4;
            this.comPorts_label.Text = "Available com ports";
            this.comPorts_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // startDriving_button
            // 
            this.startDriving_button.Location = new System.Drawing.Point(335, 25);
            this.startDriving_button.Name = "startDriving_button";
            this.startDriving_button.Size = new System.Drawing.Size(75, 23);
            this.startDriving_button.TabIndex = 5;
            this.startDriving_button.Text = "Start driving";
            this.startDriving_button.UseVisualStyleBackColor = true;
            this.startDriving_button.Click += new System.EventHandler(this.startDriving_button_Click);
            // 
            // stopDriving_button
            // 
            this.stopDriving_button.Location = new System.Drawing.Point(335, 54);
            this.stopDriving_button.Name = "stopDriving_button";
            this.stopDriving_button.Size = new System.Drawing.Size(75, 23);
            this.stopDriving_button.TabIndex = 6;
            this.stopDriving_button.Text = "Stop driving";
            this.stopDriving_button.UseVisualStyleBackColor = true;
            this.stopDriving_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(332, 89);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(35, 13);
            this.status_label.TabIndex = 7;
            this.status_label.Text = "status";
            this.status_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.stopDriving_button);
            this.Controls.Add(this.startDriving_button);
            this.Controls.Add(this.comPorts_label);
            this.Controls.Add(this.disconnect_button);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.comPorts_listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox comPorts_listbox;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.Label comPorts_label;
        private System.Windows.Forms.Button startDriving_button;
        private System.Windows.Forms.Button stopDriving_button;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

