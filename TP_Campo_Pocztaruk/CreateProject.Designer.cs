namespace UI
{
    partial class CreateProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CreateProject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_ClientSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Stories = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.btn_CreateStory = new System.Windows.Forms.Button();
            this.lbl_StoryName = new System.Windows.Forms.Label();
            this.tb_StoryName = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.lbl_Parent = new System.Windows.Forms.Label();
            this.cb_Parent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbl_StoryPoints = new System.Windows.Forms.Label();
            this.tb_StoryPoints = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stories)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_CreateProject
            // 
            this.btn_CreateProject.Location = new System.Drawing.Point(233, 52);
            this.btn_CreateProject.Name = "btn_CreateProject";
            this.btn_CreateProject.Size = new System.Drawing.Size(94, 23);
            this.btn_CreateProject.TabIndex = 2;
            this.btn_CreateProject.Text = "Create Project";
            this.btn_CreateProject.UseVisualStyleBackColor = true;
            this.btn_CreateProject.Click += new System.EventHandler(this.Btn_CreateProject);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "New Client";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cb_ClientSelect
            // 
            this.cb_ClientSelect.FormattingEnabled = true;
            this.cb_ClientSelect.Location = new System.Drawing.Point(106, 83);
            this.cb_ClientSelect.Name = "cb_ClientSelect";
            this.cb_ClientSelect.Size = new System.Drawing.Size(121, 21);
            this.cb_ClientSelect.TabIndex = 6;
            this.cb_ClientSelect.SelectedIndexChanged += new System.EventHandler(this.CB_ClientSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stories";
            // 
            // dgv_Stories
            // 
            this.dgv_Stories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stories.Location = new System.Drawing.Point(35, 135);
            this.dgv_Stories.Name = "dgv_Stories";
            this.dgv_Stories.Size = new System.Drawing.Size(425, 282);
            this.dgv_Stories.TabIndex = 8;
            this.dgv_Stories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cost";
            // 
            // tb_Cost
            // 
            this.tb_Cost.Location = new System.Drawing.Point(77, 425);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(100, 20);
            this.tb_Cost.TabIndex = 11;
            this.tb_Cost.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tb_Cost.ReadOnly = true;
            // 
            // btn_CreateStory
            // 
            this.btn_CreateStory.Location = new System.Drawing.Point(540, 315);
            this.btn_CreateStory.Name = "btn_CreateStory";
            this.btn_CreateStory.Size = new System.Drawing.Size(126, 43);
            this.btn_CreateStory.TabIndex = 14;
            this.btn_CreateStory.Text = "Create Story";
            this.btn_CreateStory.UseVisualStyleBackColor = true;
            this.btn_CreateStory.Click += new System.EventHandler(this.Btn_CreateStory);
            // 
            // lbl_StoryName
            // 
            this.lbl_StoryName.AutoSize = true;
            this.lbl_StoryName.Location = new System.Drawing.Point(478, 151);
            this.lbl_StoryName.Name = "lbl_StoryName";
            this.lbl_StoryName.Size = new System.Drawing.Size(62, 13);
            this.lbl_StoryName.TabIndex = 13;
            this.lbl_StoryName.Text = "Story Name";
            this.lbl_StoryName.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_StoryName
            // 
            this.tb_StoryName.Location = new System.Drawing.Point(555, 148);
            this.tb_StoryName.Name = "tb_StoryName";
            this.tb_StoryName.Size = new System.Drawing.Size(121, 20);
            this.tb_StoryName.TabIndex = 12;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(478, 177);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(60, 13);
            this.lbl_Description.TabIndex = 16;
            this.lbl_Description.Text = "Description";
            this.lbl_Description.Click += new System.EventHandler(this.label6_Click);
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(555, 174);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(121, 20);
            this.tb_Description.TabIndex = 15;
            this.tb_Description.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lbl_Parent
            // 
            this.lbl_Parent.AutoSize = true;
            this.lbl_Parent.Location = new System.Drawing.Point(478, 203);
            this.lbl_Parent.Name = "lbl_Parent";
            this.lbl_Parent.Size = new System.Drawing.Size(38, 13);
            this.lbl_Parent.TabIndex = 18;
            this.lbl_Parent.Text = "Parent";
            this.lbl_Parent.Click += new System.EventHandler(this.label7_Click);
            // 
            // cb_Parent
            // 
            this.cb_Parent.FormattingEnabled = true;
            this.cb_Parent.Location = new System.Drawing.Point(555, 200);
            this.cb_Parent.Name = "cb_Parent";
            this.cb_Parent.Size = new System.Drawing.Size(121, 21);
            this.cb_Parent.TabIndex = 19;
            this.cb_Parent.SelectedIndexChanged += new System.EventHandler(this.CB_Parent);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Description";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(555, 227);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 20;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lbl_StoryPoints
            // 
            this.lbl_StoryPoints.AutoSize = true;
            this.lbl_StoryPoints.Location = new System.Drawing.Point(478, 256);
            this.lbl_StoryPoints.Name = "lbl_StoryPoints";
            this.lbl_StoryPoints.Size = new System.Drawing.Size(63, 13);
            this.lbl_StoryPoints.TabIndex = 23;
            this.lbl_StoryPoints.Text = "Story Points";
            this.lbl_StoryPoints.Click += new System.EventHandler(this.label9_Click);
            // 
            // tb_StoryPoints
            // 
            this.tb_StoryPoints.Location = new System.Drawing.Point(555, 253);
            this.tb_StoryPoints.Name = "tb_StoryPoints";
            this.tb_StoryPoints.Size = new System.Drawing.Size(121, 20);
            this.tb_StoryPoints.TabIndex = 22;
            this.tb_StoryPoints.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_StoryPoints);
            this.Controls.Add(this.tb_StoryPoints);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cb_Parent);
            this.Controls.Add(this.lbl_Parent);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.btn_CreateStory);
            this.Controls.Add(this.lbl_StoryName);
            this.Controls.Add(this.tb_StoryName);
            this.Controls.Add(this.tb_Cost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_Stories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_ClientSelect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_CreateProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProject";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estimation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Estimation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CreateProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_ClientSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Stories;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Cost;
        private System.Windows.Forms.Button btn_CreateStory;
        private System.Windows.Forms.Label lbl_StoryName;
        private System.Windows.Forms.TextBox tb_StoryName;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label lbl_Parent;
        private System.Windows.Forms.ComboBox cb_Parent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl_StoryPoints;
        private System.Windows.Forms.TextBox tb_StoryPoints;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}