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
    public partial class Student : Form
    {
        private GlobalClass.userTableMapper selectedUser;
        private System.Windows.Forms.DataGridView StudentGridView;
        private DataGridViewCellEventArgs mouseLocation;
        private List<GlobalClass.AnswerWithQuestionMapper> SelectedTest;
        private DBConnect elementBase = new DBConnect();
        public void setUser(GlobalClass.userTableMapper sU)
        {
            this.selectedUser = sU;
            this.Text = this.selectedUser.reprUser;
        }
        public Student()
        {
            InitializeComponent();
        }

        private void generateTable()
        {
            if (this.MainPanelLayout.Controls.Contains(this.StudentGridView))
            {
                this.StudentGridView.CellMouseEnter -= new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellMouseEnter);
                this.StudentGridView.CellDoubleClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellDoubleClick);
                this.MainPanelLayout.Controls.Remove(this.StudentGridView);
                this.StudentGridView.Dispose();

            }
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.StudentGridView.AllowUserToOrderColumns = true;
            this.StudentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.StudentGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Location = new System.Drawing.Point(12, 27);
            this.StudentGridView.Name = "AdminGridView";
            this.StudentGridView.Size = new System.Drawing.Size(625, 266);
            this.StudentGridView.TabIndex = 1;
            this.StudentGridView.AllowUserToAddRows = false;
            this.StudentGridView.AllowUserToDeleteRows = false;
            this.StudentGridView.AllowUserToResizeColumns = true;
            this.StudentGridView.AllowUserToResizeRows = true;
            this.StudentGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellMouseEnter);
            this.StudentGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellDoubleClick);
            
            this.MainPanelLayout.Controls.Add(this.StudentGridView);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void StudentGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs location)
        {
            this.mouseLocation = location;
        }
        private void Student_Load(object sender, EventArgs e)
        {
            ForDeeploma.GlobalClass.incrementCounter();
        }

        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            ForDeeploma.GlobalClass.decrementCounter();
        }

        private void пройденныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 LoginWin = new Form1();
            LoginWin.Show();
            this.Close();
        }

        private void порядокПрохожденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutWin = new About();
            AboutWin.Show();

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramm AboutPr = new AboutProgramm();
            AboutPr.Show();
        }

        private void сдатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test testing = new Test();
            testing.Show();
        }

        private void списокДосутпныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTable();
            this.StudentGridView.DataSource = this.elementBase.SelectTestsForUser();
            this.StudentGridView.Columns["ID"].Visible = false;
        }
        private void StudentGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs location)
        {
            int rowId = (int)((long)StudentGridView.Rows[this.mouseLocation.RowIndex].Cells["ID"].Value);
            SelectedTest = this.elementBase.SelectOneTest(rowId);
            List<GlobalClass.QuestionAnswersMapper> setQuestion = new List<GlobalClass.QuestionAnswersMapper>();

            IEnumerable<IGrouping<string, GlobalClass.AnswerWithQuestionMapper>> query =
                            SelectedTest.GroupBy(Question => Question.Question, Question => Question);

            foreach (IGrouping<string, GlobalClass.AnswerWithQuestionMapper> QuestionGRoup in query)
            {
                List<GlobalClass.AnswerMapper> tempAnswers = new List<GlobalClass.AnswerMapper>();
                // Print the key value of the IGrouping.
                // Iterate over each value in the 
                // IGrouping and print the value.
                int id_Q = -1;
                foreach (GlobalClass.AnswerWithQuestionMapper Answer in QuestionGRoup)
                {
                    GlobalClass.AnswerMapper tempAnswer = new GlobalClass.AnswerMapper(Answer.ID_Answer, Answer.Answer, Answer.isTrue);
                    id_Q = Answer.ID_Question;
                    tempAnswers.Add(tempAnswer);
                }
                GlobalClass.QuestionAnswersMapper tempQuestion = new GlobalClass.QuestionAnswersMapper(id_Q, -1, QuestionGRoup.Key, tempAnswers.Count, tempAnswers);
                setQuestion.Add(tempQuestion);
            }

            TestingForm NewTest = new TestingForm(setQuestion,rowId,selectedUser.ID);
            NewTest.ShowDialog();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
