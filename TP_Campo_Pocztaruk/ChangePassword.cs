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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox1.Text)&& String.IsNullOrEmpty(textBox2.Text)) && textBox1.Text == textBox2.Text)
            {
                BLL.USER uSER = new BLL.USER();
                BE.USER tUser = new BE.USER();
                tUser.Password = textBox1.Text;
                uSER.User = Services.SESSIONMANAGER.GetSession.user;
                uSER.User.Password = tUser.Password;
                uSER.EditUser();
            }
            else
            {
                MessageBox.Show("Invalid Password");
            }
        }
    }
}
