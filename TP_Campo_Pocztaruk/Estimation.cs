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
    public partial class Estimation : Form
    {
        public Estimation()
        {
            InitializeComponent();
        }

        private void Estimation_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.PROJECT project = new BLL.PROJECT();
            BE.USER user = new BE.USER();
            user.Id = Convert.ToInt32(textBox2.Text);
            project.CreateProject(textBox1.Text, user, Services.SESSIONMANAGER.GetSession.user);
        }
    }
}
