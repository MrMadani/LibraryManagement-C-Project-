using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Lms : Form
    {
        public Lms()
        {
            InitializeComponent();
            admin_Control1.Show();
            book_Control1.Hide();
            borrowcontrol1.Hide();
            records1.Hide();
            studentControl1.Hide();


        }

        private void borrow_Btn_Click(object sender, EventArgs e)
        {
            
            borrowcontrol1.Show();
            book_Control1.Hide();
            records1.Hide();
            admin_Control1.Hide();
            studentControl1.Hide();
            sidepanel.Height = borrow_Btn.Height;
            sidepanel.Top = borrow_Btn.Top;
            borrowcontrol1.BringToFront();

          
        }

        private void book_Btn_Click(object sender, EventArgs e)
        {
            book_Control1.Show();
            borrowcontrol1.Hide();
            records1.Hide();
            admin_Control1.Hide();
            studentControl1.Hide();
            sidepanel.Height = book_Btn.Height;
            sidepanel.Top = book_Btn.Top;
            book_Control1.BringToFront();
        }
        private void records_Btn_Click(object sender, EventArgs e)
        {
            records1.Show();
            borrowcontrol1.Hide();
            book_Control1.Hide();
            admin_Control1.Hide();
            studentControl1.Hide();
            sidepanel.Height = records_Btn.Height;
            sidepanel.Top = records_Btn.Top;
            records1.BringToFront();
        }

        private void admin_Btn_Click(object sender, EventArgs e)
        {
            admin_Control1.Show();
            borrowcontrol1.Hide();
            book_Control1.Hide();
            records1.Hide();
            studentControl1.Hide();
            sidepanel.Height = admin_Btn.Height;
            sidepanel.Top = admin_Btn.Top;
            admin_Btn.BringToFront();
        }
        private void student_Btn_Click(object sender, EventArgs e)
        {
            studentControl1.Show();
            admin_Control1.Hide();
            borrowcontrol1.Hide();
            book_Control1.Hide();
            records1.Hide();
            sidepanel.Height = student_Btn.Height;
            sidepanel.Top = student_Btn.Top;
            student_Btn.BringToFront();
        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
