using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class CreateProject : Form
    {
        public void ProjectRefresh()
        {
            BLL.BLLPROJECT project = new BLL.BLLPROJECT();
            project.Project = BLL.BLLPROJECT.GetProject();
            List<BE.STORY> stories = new List<BE.STORY>();
            foreach (BE.STORY epic in project.ListEpics())
            {
                stories.Add(epic);
                stories.AddRange(BLL.BLLSTORY.ListStories(epic.IdStory));
            }
            dgv_Stories.DataSource = null;
            dgv_Stories.DataSource = stories;
            cb_Parent.DataSource = project.ListEpics();
            cb_Parent.DisplayMember = "Name";
        }
        public void RefreshCost()
        {
            BLL.BLLPROJECT project = new BLL.BLLPROJECT();
            project.Project = BLL.BLLPROJECT.GetProject();
            project.CalculateCost();
            tb_Cost.Text = project.Project.Cost.ToString();
        }
        public void ClientsRefresh()
        {
            BLL.BLLUSER user = new BLL.BLLUSER();
            cb_ClientSelect.DataSource = BLL.BLLUSER.ListUsers();
            cb_ClientSelect.DisplayMember = "Name";
            cb_ClientSelect.ValueMember = "Id";
        }
        public CreateProject()
        {
            InitializeComponent();
        }

        private void Estimation_Load(object sender, EventArgs e)
        {
            ClientsRefresh();
            ProjectRefresh();
            RefreshCost();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CreateProject(object sender, EventArgs e)
        {
            BLL.BLLPROJECT project = new BLL.BLLPROJECT();
            BE.USER user = new BE.USER();
            user.Id = Services.SESSIONMANAGER.GetSession.user.Id;
            project.CreateProject(textBox1.Text, "DescriptionTexT" ,user, Services.SESSIONMANAGER.GetSession.user);
            ProjectRefresh();
            RefreshCost();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CB_ClientSelect(object sender, EventArgs e)
        {

        }

        private void Btn_CreateStory(object sender, EventArgs e)
        {
            BLL.BLLSTORY story = new BLL.BLLSTORY();
            story.CreateStory(tb_StoryName.Text, BLL.BLLPROJECT.GetProject(), Services.SESSIONMANAGER.GetSession.user, points: Int32.Parse(tb_StoryPoints.Text), father: (BE.STORY)cb_Parent.SelectedItem);
            ProjectRefresh();
            RefreshCost();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CB_Parent(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
