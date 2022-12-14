namespace OraiFeladat12_04
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
            this.button_Insert = new System.Windows.Forms.Button();
            this.label_Kep = new System.Windows.Forms.Label();
            this.label_Nev = new System.Windows.Forms.Label();
            this.label_Szuletes = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox_felhasznalok = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Insert
            // 
            this.button_Insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Insert.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Insert.Location = new System.Drawing.Point(281, 370);
            this.button_Insert.Margin = new System.Windows.Forms.Padding(0);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(204, 79);
            this.button_Insert.TabIndex = 0;
            this.button_Insert.Text = "Instert";
            this.button_Insert.UseVisualStyleBackColor = false;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // label_Kep
            // 
            this.label_Kep.AutoSize = true;
            this.label_Kep.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Kep.Location = new System.Drawing.Point(327, 170);
            this.label_Kep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Kep.Name = "label_Kep";
            this.label_Kep.Size = new System.Drawing.Size(44, 24);
            this.label_Kep.TabIndex = 2;
            this.label_Kep.Text = "Kep";
            // 
            // label_Nev
            // 
            this.label_Nev.AutoSize = true;
            this.label_Nev.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Nev.Location = new System.Drawing.Point(327, 78);
            this.label_Nev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Nev.Name = "label_Nev";
            this.label_Nev.Size = new System.Drawing.Size(44, 24);
            this.label_Nev.TabIndex = 3;
            this.label_Nev.Text = "Nev";
            // 
            // label_Szuletes
            // 
            this.label_Szuletes.AutoSize = true;
            this.label_Szuletes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Szuletes.Location = new System.Drawing.Point(290, 124);
            this.label_Szuletes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Szuletes.Name = "label_Szuletes";
            this.label_Szuletes.Size = new System.Drawing.Size(81, 24);
            this.label_Szuletes.TabIndex = 4;
            this.label_Szuletes.Text = "Szuletes";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Id.Location = new System.Drawing.Point(346, 32);
            this.label_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(25, 24);
            this.label_Id.TabIndex = 5;
            this.label_Id.Text = "Id";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(757, 370);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(204, 79);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Update.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(522, 370);
            this.button_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(204, 79);
            this.button_Update.TabIndex = 7;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(378, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kep megadasa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_Nev.Location = new System.Drawing.Point(378, 75);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(147, 29);
            this.textBox_Nev.TabIndex = 10;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_Id.Location = new System.Drawing.Point(379, 32);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(146, 29);
            this.textBox_Id.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(650, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 290);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Location = new System.Drawing.Point(378, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // listBox_felhasznalok
            // 
            this.listBox_felhasznalok.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listBox_felhasznalok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_felhasznalok.FormattingEnabled = true;
            this.listBox_felhasznalok.ItemHeight = 24;
            this.listBox_felhasznalok.Location = new System.Drawing.Point(0, 0);
            this.listBox_felhasznalok.Name = "listBox_felhasznalok";
            this.listBox_felhasznalok.Size = new System.Drawing.Size(258, 679);
            this.listBox_felhasznalok.TabIndex = 14;
            this.listBox_felhasznalok.SelectedIndexChanged += new System.EventHandler(this.listBox_felhasznalok_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1031, 679);
            this.Controls.Add(this.listBox_felhasznalok);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label_Szuletes);
            this.Controls.Add(this.label_Nev);
            this.Controls.Add(this.label_Kep);
            this.Controls.Add(this.button_Insert);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Label label_Kep;
        private System.Windows.Forms.Label label_Nev;
        private System.Windows.Forms.Label label_Szuletes;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox_felhasznalok;
    }
}

