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
    public partial class MainScreen : Form
    {
        Form frm_Current;
        LogIn frm_Login;
        AddModUser frm_AddModUser;
        UnlockUser frm_UnlockUser;
        ChangePassword frm_ChangePassword;
        
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            if (frm_Current == null)
            {
                frm_Current = new LogIn();
                frm_Current.MdiParent = this;
                frm_Current.Show();
                frm_Current.FormClosed += Frm_Login_FormClosed;
            }
            menuStrip1.Hide();
        }
        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Login = null;
            menuStrip1.Show();
        }
        private void addModUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchForms();
            if (frm_Current == null)
            {
                frm_Current = new AddModUser();
                frm_Current.MdiParent = this;
                frm_Current.Show();
                //frm_AddModUser.FormClosed += frm_AddModUser_FormClosed;
            }
        }
        private void frm_AddModUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_AddModUser = null;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            switchForms();
            if (frm_Current == null)
            {
                frm_Current = new LogIn();
                frm_Current.MdiParent = this;
                frm_Current.Show();
                //frm_Login.FormClosed += Frm_Login_FormClosed;
            }
            menuStrip1.Hide();
        }
        private void switchForms()
        {
            frm_Current.Close();
            frm_Current = null;
            GC.Collect();
            menuStrip1.Show();
        }

        private void unlockUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchForms();
            if (frm_Current == null)
            {
                frm_Current = new UnlockUser();
                frm_Current.MdiParent = this;
                frm_Current.Show();
                //forms.Add(frm_UnlockUser);
                //frm_UnlockUser.FormClosed += Frm_Login_FormClosed;
            }

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchForms();
            if (frm_Current == null)
            {
                frm_Current = new ChangePassword();
                frm_Current.MdiParent = this;
                frm_Current.Show();
                //frm_UnlockUser.FormClosed += Frm_Login_FormClosed;
            }
        }
    }
}
