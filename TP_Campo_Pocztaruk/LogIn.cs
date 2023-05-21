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
    public partial class LogIn : Form
    {
        BE.USER tUser = new BE.USER();
        BLL.USER user = new BLL.USER();
        public LogIn()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tUser.Email = textBox1.Text;
            tUser.Password = textBox2.Text;
            user.User = tUser;
            try { user.ValidateUser(); }
            catch (Exception ex) {MessageBox.Show(ex.Message);}
            if (Services.SESSIONMANAGER.GetSession.IsLoggedIn != false)
            {
                this.Close();
            }
            else
            {
                Services.SESSIONMANAGER.Logout();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
