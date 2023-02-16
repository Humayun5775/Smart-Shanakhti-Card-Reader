namespace CNIC_READER
{
    partial class DataEnteryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEnteryForm));
            this.tbgender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnic = new System.Windows.Forms.TextBox();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lbnic = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnrest = new System.Windows.Forms.Button();
            this.btncapture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbreason = new System.Windows.Forms.Label();
            this.tbreason = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnconvert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbgender
            // 
            this.tbgender.BackColor = System.Drawing.SystemColors.Menu;
            this.tbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgender.Location = new System.Drawing.Point(271, 232);
            this.tbgender.Name = "tbgender";
            this.tbgender.Size = new System.Drawing.Size(236, 30);
            this.tbgender.TabIndex = 31;
            this.tbgender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbgender_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(137, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Gender :";
            // 
            // tbnic
            // 
            this.tbnic.BackColor = System.Drawing.SystemColors.Menu;
            this.tbnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnic.Location = new System.Drawing.Point(271, 182);
            this.tbnic.Name = "tbnic";
            this.tbnic.Size = new System.Drawing.Size(236, 30);
            this.tbnic.TabIndex = 27;
            this.tbnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnic_KeyPress);
            // 
            // tbfname
            // 
            this.tbfname.BackColor = System.Drawing.SystemColors.Menu;
            this.tbfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfname.Location = new System.Drawing.Point(271, 128);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(236, 30);
            this.tbfname.TabIndex = 24;
            this.tbfname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbfname_KeyPress);
            // 
            // tbname
            // 
            this.tbname.BackColor = System.Drawing.SystemColors.Menu;
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(271, 77);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(236, 30);
            this.tbname.TabIndex = 23;
            this.tbname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbname_KeyPress);
            // 
            // lbnic
            // 
            this.lbnic.AutoSize = true;
            this.lbnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnic.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbnic.Location = new System.Drawing.Point(168, 187);
            this.lbnic.Name = "lbnic";
            this.lbnic.Size = new System.Drawing.Size(57, 25);
            this.lbnic.TabIndex = 21;
            this.lbnic.Text = "NIC :";
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFname.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbFname.Location = new System.Drawing.Point(86, 128);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(141, 25);
            this.lbFname.TabIndex = 18;
            this.lbFname.Text = "Father Name : ";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbname.Location = new System.Drawing.Point(152, 77);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(75, 25);
            this.lbname.TabIndex = 17;
            this.lbname.Text = "Name :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(403, 512);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 56);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrest.Location = new System.Drawing.Point(239, 512);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(137, 56);
            this.btnrest.TabIndex = 33;
            this.btnrest.Text = "&Reset";
            this.btnrest.UseVisualStyleBackColor = false;
            this.btnrest.Click += new System.EventHandler(this.btnrest_Click);
            // 
            // btncapture
            // 
            this.btncapture.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapture.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncapture.Location = new System.Drawing.Point(804, 451);
            this.btncapture.Name = "btncapture";
            this.btncapture.Size = new System.Drawing.Size(214, 56);
            this.btncapture.TabIndex = 34;
            this.btncapture.Text = "&Capture";
            this.btncapture.UseVisualStyleBackColor = false;
            this.btncapture.Click += new System.EventHandler(this.btncapture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(661, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lbreason
            // 
            this.lbreason.AutoSize = true;
            this.lbreason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbreason.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbreason.Location = new System.Drawing.Point(130, 343);
            this.lbreason.Name = "lbreason";
            this.lbreason.Size = new System.Drawing.Size(95, 25);
            this.lbreason.TabIndex = 22;
            this.lbreason.Text = "Reason : ";
            // 
            // tbreason
            // 
            this.tbreason.BackColor = System.Drawing.SystemColors.Menu;
            this.tbreason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbreason.Location = new System.Drawing.Point(271, 343);
            this.tbreason.Name = "tbreason";
            this.tbreason.Size = new System.Drawing.Size(234, 137);
            this.tbreason.TabIndex = 29;
            this.tbreason.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(73, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Phone Number :";
            // 
            // tbphone
            // 
            this.tbphone.BackColor = System.Drawing.SystemColors.Menu;
            this.tbphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbphone.Location = new System.Drawing.Point(271, 285);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(238, 30);
            this.tbphone.TabIndex = 39;
            this.tbphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbphone_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(829, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 33);
            this.comboBox1.TabIndex = 40;
            // 
            // btnconvert
            // 
            this.btnconvert.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnconvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnconvert.Location = new System.Drawing.Point(661, 451);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(137, 56);
            this.btnconvert.TabIndex = 41;
            this.btnconvert.Text = "&Convert";
            this.btnconvert.UseVisualStyleBackColor = false;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(656, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Select Camera :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnbrowse);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnconvert);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.tbphone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btncapture);
            this.panel1.Controls.Add(this.btnrest);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tbgender);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbreason);
            this.panel1.Controls.Add(this.tbnic);
            this.panel1.Controls.Add(this.tbfname);
            this.panel1.Controls.Add(this.tbname);
            this.panel1.Controls.Add(this.lbreason);
            this.panel1.Controls.Add(this.lbnic);
            this.panel1.Controls.Add(this.lbFname);
            this.panel1.Controls.Add(this.lbname);
            this.panel1.Location = new System.Drawing.Point(67, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 629);
            this.panel1.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(804, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 56);
            this.button1.TabIndex = 46;
            this.button1.Text = "&Preprocessing";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbrowse.Location = new System.Drawing.Point(1024, 451);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(137, 56);
            this.btnbrowse.TabIndex = 45;
            this.btnbrowse.Text = "&Browse";
            this.btnbrowse.UseVisualStyleBackColor = false;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // DataEnteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1386, 761);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataEnteryForm";
            this.Text = "DataEnteryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataEnteryForm_FormClosing);
            this.Load += new System.EventHandler(this.DataEnteryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbgender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnic;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lbnic;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button btncapture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbreason;
        private System.Windows.Forms.RichTextBox tbreason;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Button button1;
    }
}