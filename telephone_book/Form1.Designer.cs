namespace telephone_book
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 569);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.mskPhone);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Location = new System.Drawing.Point(756, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 407);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(132, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(285, 26);
            this.txtID.TabIndex = 20;
            // 
            // mskPhone
            // 
            this.mskPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mskPhone.Location = new System.Drawing.Point(132, 225);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(285, 26);
            this.mskPhone.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(132, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 544);
            this.dataGridView1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtName.Location = new System.Drawing.Point(132, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(285, 26);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSurname.Location = new System.Drawing.Point(132, 137);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(285, 26);
            this.txtSurname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMail.Location = new System.Drawing.Point(132, 180);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(285, 26);
            this.txtMail.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(308, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(132, 326);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 35);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(308, 326);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1305, 643);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}

