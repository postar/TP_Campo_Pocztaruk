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
    public partial class UnlockUser : Form
    {
        private void refreshTable ()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLL.USER.ListUsers();
        }
        public UnlockUser()
        {
            InitializeComponent();
        }

        private void UnlockUser_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BE.USER uSER = new BE.USER();
            try 
            {
                uSER.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                BLL.USER bLL = new BLL.USER();
                bLL.User = uSER;
                bLL.UnlockUser();
                refreshTable();
            }
            catch { }

        }
    }
}
