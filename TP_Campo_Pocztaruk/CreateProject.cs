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
    public partial class CreateProject : Form
    {
        public void Refresh()
        {
            BLL.BLLPROJECT project = new BLL.BLLPROJECT();
            dataGridView1.DataSource = project.ListEpics();
        }
        public CreateProject()
        {
            InitializeComponent();
        }

        private void Estimation_Load(object sender, EventArgs e)
        {
            
            //comboBox1.DataSource = 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.BLLPROJECT project = new BLL.BLLPROJECT();
            BE.USER user = new BE.USER();
            user.Id = Services.SESSIONMANAGER.GetSession.user.Id;
            project.CreateProject(textBox1.Text, "DescriptionTexT" ,user, Services.SESSIONMANAGER.GetSession.user);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
