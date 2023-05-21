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
                frm_Current.FormClosed += Frm_Current_FormClosed;
            }
            //menuStrip1.Hide();
        }
        private void Frm_Current_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Current = null;
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
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Services.SESSIONMANAGER.Logout();
            switchForms();
            if (frm_Current == null)
            {
                frm_Current = new LogIn();
                frm_Current.MdiParent = this;
                frm_Current.Show();
            }
            menuStrip1.Hide();
        }
        public void switchForms()
        {
            if (frm_Current != null)
            {
                frm_Current.Close();
                frm_Current = null;
                GC.Collect();
                menuStrip1.Show();
            }
        }

        private void unlockUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchForms();
            if (frm_Current == null)
            {
                frm_Current = new UnlockUser();
                frm_Current.MdiParent = this;
                frm_Current.Show();
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
            }
        }
    }
}
