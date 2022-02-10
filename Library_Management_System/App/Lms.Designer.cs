namespace App
{
    partial class Lms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lms));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.admin_Btn = new System.Windows.Forms.Button();
            this.student_Btn = new System.Windows.Forms.Button();
            this.book_Btn = new System.Windows.Forms.Button();
            this.borrow_Btn = new System.Windows.Forms.Button();
            this.records_Btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.book_Control1 = new App.Book_Control();
            this.studentControl1 = new App.StudentControl();
            this.admin_Control1 = new App.Admin_Control();
            this.records1 = new App.Records();
            this.borrowcontrol1 = new App.borrowcontrol();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 15);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.admin_Btn);
            this.panel1.Controls.Add(this.student_Btn);
            this.panel1.Controls.Add(this.book_Btn);
            this.panel1.Controls.Add(this.borrow_Btn);
            this.panel1.Controls.Add(this.records_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 592);
            this.panel1.TabIndex = 7;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.sidepanel.Location = new System.Drawing.Point(2, 76);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(11, 54);
            this.sidepanel.TabIndex = 5;
            // 
            // admin_Btn
            // 
            this.admin_Btn.FlatAppearance.BorderSize = 0;
            this.admin_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_Btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_Btn.ForeColor = System.Drawing.Color.White;
            this.admin_Btn.Image = ((System.Drawing.Image)(resources.GetObject("admin_Btn.Image")));
            this.admin_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_Btn.Location = new System.Drawing.Point(19, 77);
            this.admin_Btn.Name = "admin_Btn";
            this.admin_Btn.Size = new System.Drawing.Size(151, 54);
            this.admin_Btn.TabIndex = 9;
            this.admin_Btn.Text = "   Admin";
            this.admin_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.admin_Btn.UseVisualStyleBackColor = true;
            this.admin_Btn.Click += new System.EventHandler(this.admin_Btn_Click);
            // 
            // student_Btn
            // 
            this.student_Btn.FlatAppearance.BorderSize = 0;
            this.student_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_Btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_Btn.ForeColor = System.Drawing.Color.White;
            this.student_Btn.Image = ((System.Drawing.Image)(resources.GetObject("student_Btn.Image")));
            this.student_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.student_Btn.Location = new System.Drawing.Point(19, 317);
            this.student_Btn.Name = "student_Btn";
            this.student_Btn.Size = new System.Drawing.Size(151, 54);
            this.student_Btn.TabIndex = 8;
            this.student_Btn.Text = "   Student";
            this.student_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.student_Btn.UseVisualStyleBackColor = true;
            this.student_Btn.Click += new System.EventHandler(this.student_Btn_Click);
            // 
            // book_Btn
            // 
            this.book_Btn.FlatAppearance.BorderSize = 0;
            this.book_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_Btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_Btn.ForeColor = System.Drawing.Color.White;
            this.book_Btn.Image = ((System.Drawing.Image)(resources.GetObject("book_Btn.Image")));
            this.book_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.book_Btn.Location = new System.Drawing.Point(19, 257);
            this.book_Btn.Name = "book_Btn";
            this.book_Btn.Size = new System.Drawing.Size(151, 54);
            this.book_Btn.TabIndex = 7;
            this.book_Btn.Text = "    Book";
            this.book_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.book_Btn.UseVisualStyleBackColor = true;
            this.book_Btn.Click += new System.EventHandler(this.book_Btn_Click);
            // 
            // borrow_Btn
            // 
            this.borrow_Btn.FlatAppearance.BorderSize = 0;
            this.borrow_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow_Btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_Btn.ForeColor = System.Drawing.Color.White;
            this.borrow_Btn.Image = ((System.Drawing.Image)(resources.GetObject("borrow_Btn.Image")));
            this.borrow_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrow_Btn.Location = new System.Drawing.Point(19, 197);
            this.borrow_Btn.Name = "borrow_Btn";
            this.borrow_Btn.Size = new System.Drawing.Size(151, 54);
            this.borrow_Btn.TabIndex = 6;
            this.borrow_Btn.Text = "    Borrow";
            this.borrow_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.borrow_Btn.UseVisualStyleBackColor = true;
            this.borrow_Btn.Click += new System.EventHandler(this.borrow_Btn_Click);
            // 
            // records_Btn
            // 
            this.records_Btn.FlatAppearance.BorderSize = 0;
            this.records_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.records_Btn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.records_Btn.ForeColor = System.Drawing.Color.White;
            this.records_Btn.Image = ((System.Drawing.Image)(resources.GetObject("records_Btn.Image")));
            this.records_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.records_Btn.Location = new System.Drawing.Point(19, 137);
            this.records_Btn.Name = "records_Btn";
            this.records_Btn.Size = new System.Drawing.Size(151, 54);
            this.records_Btn.TabIndex = 5;
            this.records_Btn.Text = "    Records";
            this.records_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.records_Btn.UseVisualStyleBackColor = true;
            this.records_Btn.Click += new System.EventHandler(this.records_Btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(228, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 114);
            this.panel4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Library";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // book_Control1
            // 
            this.book_Control1.Location = new System.Drawing.Point(179, 121);
            this.book_Control1.Name = "book_Control1";
            this.book_Control1.Size = new System.Drawing.Size(775, 438);
            this.book_Control1.TabIndex = 15;
            // 
            // studentControl1
            // 
            this.studentControl1.Location = new System.Drawing.Point(179, 121);
            this.studentControl1.Name = "studentControl1";
            this.studentControl1.Size = new System.Drawing.Size(775, 434);
            this.studentControl1.TabIndex = 14;
            // 
            // admin_Control1
            // 
            this.admin_Control1.Location = new System.Drawing.Point(179, 121);
            this.admin_Control1.Name = "admin_Control1";
            this.admin_Control1.Size = new System.Drawing.Size(775, 440);
            this.admin_Control1.TabIndex = 13;
            // 
            // records1
            // 
            this.records1.Location = new System.Drawing.Point(186, 121);
            this.records1.Name = "records1";
            this.records1.Size = new System.Drawing.Size(790, 427);
            this.records1.TabIndex = 12;
            // 
            // borrowcontrol1
            // 
            this.borrowcontrol1.Location = new System.Drawing.Point(173, 121);
            this.borrowcontrol1.Name = "borrowcontrol1";
            this.borrowcontrol1.Size = new System.Drawing.Size(790, 438);
            this.borrowcontrol1.TabIndex = 10;
            // 
            // Lms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 592);
            this.Controls.Add(this.book_Control1);
            this.Controls.Add(this.studentControl1);
            this.Controls.Add(this.admin_Control1);
            this.Controls.Add(this.records1);
            this.Controls.Add(this.borrowcontrol1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "Lms";
            this.Text = "Lms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button admin_Btn;
        private System.Windows.Forms.Button student_Btn;
        private System.Windows.Forms.Button book_Btn;
        private System.Windows.Forms.Button borrow_Btn;
        private System.Windows.Forms.Button records_Btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private borrowcontrol borrowcontrol1;
        private Records records1;
        private Admin_Control admin_Control1;
        private StudentControl studentControl1;
        private Book_Control book_Control1;
    }
}