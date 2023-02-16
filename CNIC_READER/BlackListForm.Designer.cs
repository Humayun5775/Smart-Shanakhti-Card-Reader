namespace CNIC_READER
{
    partial class BlackListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnrest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbnic = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lbnic = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.dataGridViewNIC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNIC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrest.Location = new System.Drawing.Point(366, 301);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(137, 56);
            this.btnrest.TabIndex = 51;
            this.btnrest.Text = "&Reset";
            this.btnrest.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(530, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 56);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbnic
            // 
            this.tbnic.BackColor = System.Drawing.SystemColors.Menu;
            this.tbnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnic.Location = new System.Drawing.Point(431, 209);
            this.tbnic.Name = "tbnic";
            this.tbnic.Size = new System.Drawing.Size(236, 30);
            this.tbnic.TabIndex = 46;
            // 
            // tbname
            // 
            this.tbname.BackColor = System.Drawing.SystemColors.Menu;
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(431, 156);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(236, 30);
            this.tbname.TabIndex = 44;
            // 
            // lbnic
            // 
            this.lbnic.AutoSize = true;
            this.lbnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnic.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbnic.Location = new System.Drawing.Point(328, 214);
            this.lbnic.Name = "lbnic";
            this.lbnic.Size = new System.Drawing.Size(57, 25);
            this.lbnic.TabIndex = 42;
            this.lbnic.Text = "NIC :";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbname.Location = new System.Drawing.Point(312, 156);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(75, 25);
            this.lbname.TabIndex = 40;
            this.lbname.Text = "Name :";
            // 
            // dataGridViewNIC
            // 
            this.dataGridViewNIC.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewNIC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNIC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNIC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewNIC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.dataGridViewNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNIC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNIC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNIC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewNIC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridViewNIC.Location = new System.Drawing.Point(738, 96);
            this.dataGridViewNIC.Name = "dataGridViewNIC";
            this.dataGridViewNIC.ReadOnly = true;
            this.dataGridViewNIC.RowHeadersVisible = false;
            this.dataGridViewNIC.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridViewNIC.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewNIC.RowTemplate.Height = 24;
            this.dataGridViewNIC.Size = new System.Drawing.Size(294, 558);
            this.dataGridViewNIC.TabIndex = 52;
            // 
            // BlackListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1215, 658);
            this.Controls.Add(this.dataGridViewNIC);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbnic);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbnic);
            this.Controls.Add(this.lbname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BlackListForm";
            this.Text = "BlackListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbnic;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lbnic;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.DataGridView dataGridViewNIC;
    }
}