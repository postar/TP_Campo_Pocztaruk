using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddModUser : Form
    {
        public AddModUser()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text) && String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox4.Text)))
            {
                BLL.BLLUSER uSER = new BLL.BLLUSER();
                BE.USER tUser = new BE.USER();
                tUser.Id = Convert.ToInt32(textBox1.Text);
                tUser.Name = textBox2.Text;
                tUser.Email = textBox3.Text;
                tUser.Password = textBox4.Text;
                uSER.User = tUser;
                uSER.EditUser();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox2.Text)&& String.IsNullOrEmpty(textBox3.Text)&&String.IsNullOrEmpty(textBox4.Text)))
            {
                BLL.BLLUSER uSER = new BLL.BLLUSER();
                BE.USER tUser = new BE.USER();
                tUser.Name = textBox2.Text;
                tUser.Email = textBox3.Text;
                tUser.Password = textBox4.Text;
                uSER.User = tUser;
                uSER.AddUser();
            }

        }
    }
}
