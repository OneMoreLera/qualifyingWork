using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDeeploma
{
    public partial class Teacher : Form
    {
        private GlobalClass.userTableMapper selectedUser;
        private List<GlobalClass.subjectMapper> Subjects;
        private DBConnect elementBase = new DBConnect();
        private System.Windows.Forms.ToolStripMenuItem [] SubjectsForTest;
        private System.Windows.Forms.ToolStripMenuItem[] SubjectsForQuestion;
        private System.Windows.Forms.DataGridView TeacherGridView;
        private int idSubject;
        private DataGridViewCellEventArgs mouseLocation;
        
        public void setUser(GlobalClass.userTableMapper sU)
        {
            this.selectedUser = sU;
            this.Text = this.selectedUser.reprUser;
        }
        public Teacher()
        {
            InitializeComponent();

        }
        private void generate_subject_list()
        {

            this.Subjects = this.elementBase.SelectSubject();
            if (this.SubjectsForTest != null)
                foreach (ToolStripMenuItem subjItem in this.SubjectsForTest)
                {
                    subjItem.Click -= new System.EventHandler(this.SubjectItemTest_Click);
                    this.списокТестовПоToolStripMenuItem.DropDownItems.Remove(subjItem);
                }

            if (this.SubjectsForQuestion != null)
                foreach (ToolStripMenuItem subjItem in this.SubjectsForQuestion)
                {
                    subjItem.Click -= new System.EventHandler(this.SubjectItemQuestion_Click);
                    this.списокВопросовПоПредметуToolStripMenuItem.DropDownItems.Remove(subjItem);
                }

            this.SubjectsForTest = new System.Windows.Forms.ToolStripMenuItem[this.Subjects.Count];
            this.SubjectsForQuestion = new System.Windows.Forms.ToolStripMenuItem[this.Subjects.Count];

            int i = 0;
            foreach (GlobalClass.subjectMapper Subject in this.Subjects)
            {
                this.SubjectsForTest[i] = new ToolStripMenuItem();
                this.SubjectsForTest[i].Name = Subject.ID + "_Test";
                this.SubjectsForTest[i].Size = new System.Drawing.Size(180, 22);
                this.SubjectsForTest[i].Text = Subject.Name;
                this.SubjectsForTest[i].Click += new System.EventHandler(this.SubjectItemTest_Click);

                this.SubjectsForQuestion[i] = new ToolStripMenuItem();
                this.SubjectsForQuestion[i].Name = Subject.ID + "_Question";
                this.SubjectsForQuestion[i].Size = new System.Drawing.Size(180, 22);
                this.SubjectsForQuestion[i].Text = Subject.Name;
                this.SubjectsForQuestion[i].Click += new System.EventHandler(this.SubjectItemQuestion_Click);

                i++;
            }
            this.списокТестовПоToolStripMenuItem.DropDownItems.AddRange(this.SubjectsForTest);
            this.списокВопросовПоПредметуToolStripMenuItem.DropDownItems.AddRange(this.SubjectsForQuestion);
            //this.SubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem()[];
        }
        private void generateTable(int flag)
        {
            if (this.PanelLayout.Controls.Contains(this.TeacherGridView))
            {
                this.TeacherGridView.CellMouseEnter -= new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherGridView_CellMouseEnter);
                this.PanelLayout.Controls.Remove(this.TeacherGridView);
                this.TeacherGridView.Dispose();

            }
            this.TeacherGridView = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGridView)).BeginInit();
            this.TeacherGridView.AllowUserToOrderColumns = true;
            this.TeacherGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeacherGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeacherGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.TeacherGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeacherGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherGridView.Location = new System.Drawing.Point(12, 27);
            this.TeacherGridView.Name = "AdminGridView";
            this.TeacherGridView.Size = new System.Drawing.Size(625, 266);
            this.TeacherGridView.TabIndex = 1;
            this.TeacherGridView.AllowUserToAddRows = false;
            this.TeacherGridView.AllowUserToDeleteRows = false;
            this.TeacherGridView.AllowUserToResizeColumns = true;
            this.TeacherGridView.AllowUserToResizeRows = true;
            if (flag == 1) this.TeacherGridView.RowTemplate.ContextMenuStrip = this.QuestSubjContext;
            if (flag == 2) this.TeacherGridView.RowTemplate.ContextMenuStrip = this.TestSubjContext;
            this.TeacherGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherGridView_CellMouseEnter);
            this.PanelLayout.Controls.Add(this.TeacherGridView);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void Teacher_Load(object sender, EventArgs e)
        {
            ForDeeploma.GlobalClass.incrementCounter();
            generate_subject_list();
        }
        private void Teacher_FormClosed(object sender, FormClosedEventArgs e)
        {

            ForDeeploma.GlobalClass.decrementCounter();
        }
        private void добавитьПредметToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSubject Adding = new NewSubject();
            Adding.ShowDialog();
            generate_subject_list();
        }

        private void SubjectItemQuestion_Click(object sender, EventArgs e)
        {
            string nameItem = ((System.Windows.Forms.ToolStripMenuItem)sender).Name;
            this.idSubject = Int32.Parse(nameItem.Split('_')[0]);
            generateTable(1);
            this.TeacherGridView.DataSource = this.elementBase.SelectQuestions(idSubject);
            this.TeacherGridView.Columns["ID"].Visible = false;
        }
        private void SubjectItemTest_Click(object sender, EventArgs e)
        {
            string nameItem = ((System.Windows.Forms.ToolStripMenuItem)sender).Name;
            this.idSubject = Int32.Parse(nameItem.Split('_')[0]);
            generateTable(2);
            this.TeacherGridView.DataSource = this.elementBase.SelectTests(idSubject);
            this.TeacherGridView.Columns["ID"].Visible = false;
        }
        private void TeacherGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs location)
        {
            this.mouseLocation = location;
        }

        private void подробностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowId = (int)((long)TeacherGridView.Rows[this.mouseLocation.RowIndex].Cells["ID"].Value);
            GlobalClass.QuestionAnswersMapper OneQuestion = this.elementBase.SelectQuestionWithAnswers(rowId);
            SelectedQuestion SelQuest = new SelectedQuestion(OneQuestion);
            SelQuest.ShowDialog();
            generateTable(1);
            this.TeacherGridView.DataSource = this.elementBase.SelectQuestions(this.idSubject);
            this.TeacherGridView.Columns["ID"].Visible = false;
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void подробностиToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void списокВопросовПоПредметуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuestion AddQuestWin = new AddQuestion();
            AddQuestWin.ShowDialog();
        }

        private void добавитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenTest AddQuest = new GenTest();
            AddQuest.ShowDialog();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 LoginWin = new Form1();
            LoginWin.Show();
            this.Close();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
