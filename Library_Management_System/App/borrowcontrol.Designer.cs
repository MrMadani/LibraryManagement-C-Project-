namespace App
{
    partial class borrowcontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrowcontrol));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.name = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookList = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.overDue = new System.Windows.Forms.Label();
            this.borrowed = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.borrowList = new System.Windows.Forms.Label();
            this.borrowDate = new System.Windows.Forms.Label();
            this.dueDate = new System.Windows.Forms.Label();
            this.borrowDateLB = new System.Windows.Forms.Label();
            this.dueDateLB = new System.Windows.Forms.Label();
            this.borrowbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.name.Location = new System.Drawing.Point(20, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(82, 14);
            this.name.TabIndex = 0;
            this.name.Text = "Name                     :";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.department.Location = new System.Drawing.Point(20, 130);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(84, 14);
            this.department.TabIndex = 1;
            this.department.Text = "Department      :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 192);
            this.dataGridView1.TabIndex = 2;
            // 
            // bookList
            // 
            this.bookList.AutoSize = true;
            this.bookList.Location = new System.Drawing.Point(11, 210);
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(51, 13);
            this.bookList.TabIndex = 3;
            this.bookList.Text = "Book List";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(138, 100);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(162, 20);
            this.nameBox.TabIndex = 4;
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(138, 126);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(162, 20);
            this.departmentBox.TabIndex = 5;
            // 
            // overDue
            // 
            this.overDue.AutoSize = true;
            this.overDue.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.overDue.Location = new System.Drawing.Point(486, 106);
            this.overDue.Name = "overDue";
            this.overDue.Size = new System.Drawing.Size(97, 14);
            this.overDue.TabIndex = 6;
            this.overDue.Text = "Over Due                    :";
            // 
            // borrowed
            // 
            this.borrowed.AutoSize = true;
            this.borrowed.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.borrowed.Location = new System.Drawing.Point(486, 136);
            this.borrowed.Name = "borrowed";
            this.borrowed.Size = new System.Drawing.Size(99, 14);
            this.borrowed.TabIndex = 7;
            this.borrowed.Text = "Borrowed                    :";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(14, 176);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(328, 20);
            this.searchBox.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(340, 175);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(25, 21);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(446, 245);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(335, 128);
            this.dataGridView2.TabIndex = 10;
            // 
            // borrowList
            // 
            this.borrowList.AutoSize = true;
            this.borrowList.Location = new System.Drawing.Point(446, 229);
            this.borrowList.Name = "borrowList";
            this.borrowList.Size = new System.Drawing.Size(59, 13);
            this.borrowList.TabIndex = 11;
            this.borrowList.Text = "Borrow List";
            // 
            // borrowDate
            // 
            this.borrowDate.AutoSize = true;
            this.borrowDate.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.borrowDate.Location = new System.Drawing.Point(486, 178);
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.Size = new System.Drawing.Size(86, 14);
            this.borrowDate.TabIndex = 12;
            this.borrowDate.Text = "Borrow Date       :";
            // 
            // dueDate
            // 
            this.dueDate.AutoSize = true;
            this.dueDate.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dueDate.Location = new System.Drawing.Point(486, 201);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(85, 14);
            this.dueDate.TabIndex = 13;
            this.dueDate.Text = "Due Date              :";
            // 
            // borrowDateLB
            // 
            this.borrowDateLB.AutoSize = true;
            this.borrowDateLB.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.borrowDateLB.Location = new System.Drawing.Point(587, 178);
            this.borrowDateLB.Name = "borrowDateLB";
            this.borrowDateLB.Size = new System.Drawing.Size(79, 14);
            this.borrowDateLB.TabIndex = 14;
            this.borrowDateLB.Text = "Borrow Date     ";
            // 
            // dueDateLB
            // 
            this.dueDateLB.AutoSize = true;
            this.dueDateLB.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dueDateLB.Location = new System.Drawing.Point(588, 201);
            this.dueDateLB.Name = "dueDateLB";
            this.dueDateLB.Size = new System.Drawing.Size(56, 14);
            this.dueDateLB.TabIndex = 15;
            this.dueDateLB.Text = "Due Date ";
            // 
            // borrowbtn
            // 
            this.borrowbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.borrowbtn.ForeColor = System.Drawing.Color.White;
            this.borrowbtn.Location = new System.Drawing.Point(446, 379);
            this.borrowbtn.Name = "borrowbtn";
            this.borrowbtn.Size = new System.Drawing.Size(335, 36);
            this.borrowbtn.TabIndex = 16;
            this.borrowbtn.Text = "Borrow";
            this.borrowbtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(591, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(591, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 45);
            this.button2.TabIndex = 20;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(761, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 21);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(499, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 20);
            this.textBox3.TabIndex = 21;
            // 
            // borrowcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.borrowbtn);
            this.Controls.Add(this.dueDateLB);
            this.Controls.Add(this.borrowDateLB);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.borrowDate);
            this.Controls.Add(this.borrowList);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.borrowed);
            this.Controls.Add(this.overDue);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.bookList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.department);
            this.Controls.Add(this.name);
            this.Name = "borrowcontrol";
            this.Size = new System.Drawing.Size(787, 418);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label bookList;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.Label overDue;
        private System.Windows.Forms.Label borrowed;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label borrowList;
        private System.Windows.Forms.Label borrowDate;
        private System.Windows.Forms.Label dueDate;
        private System.Windows.Forms.Label borrowDateLB;
        private System.Windows.Forms.Label dueDateLB;
        private System.Windows.Forms.Button borrowbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
    }
}
