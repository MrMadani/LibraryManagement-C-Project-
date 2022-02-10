using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Admin_Control : UserControl
    {
        public Admin_Control()
        {
            InitializeComponent();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Name.Equals("register_Btn"))
            {
                bool Isopen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text=="admin_Reg")
                    {
                        Isopen = true;
                        f.BringToFront();
                        break;
                    }
                    
                }
                if (Isopen==false)
                {
                    admin_Reg adr = new admin_Reg();
                    adr.Show();
                }
            }
            if (button.Name.Equals("changePass_Btn"))
            {
                bool Isopen = false;
                foreach (Form C in Application.OpenForms)
                {
                    if (C.Text=="Change_Password")
                    {
                        Isopen = true;
                        C.BringToFront();
                        break;
                    }
                    
                }
                if (Isopen==false)
                {
                    Change_Password cp = new Change_Password();
                    cp.Show();
                }
            }
        }
    }
}
