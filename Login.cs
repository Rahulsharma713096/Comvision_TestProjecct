using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comvision_TestProjecct
{
    public partial class Login : Form
    {
        int attempt;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Close ();
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = Email.Text;
            string pwd = password.Text;
            
            if(id=="123"&& pwd=="123")
            {
                Index i = new Index();
                i.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password or Email is incorrect");
            }

            /*
             

                if ((this.Email.Text == "Admin") && (this.password.Text == "admin"))
                {
                   attempt = 0;
                    MessageBox.Show("you are granted with access");


                }
                else if ((attempt == 3) && (attempt > 0))
                {
                    MessageBox.Show("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                    --attempt;
                }
                else
                {
                    MessageBox.Show("you are not granted with access");
                }

        */
            }




        private void button3_Click(object sender, EventArgs e)
        {
            Email.Text="";
            password.Text="";
        }
    }
}
