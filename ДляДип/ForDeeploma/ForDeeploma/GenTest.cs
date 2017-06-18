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
    public partial class GenTest : Form
    {
        private DBConnect elementBase = new DBConnect();
        public List<GlobalClass.QuestionWithRepeatMapper> CandidateList = new List<GlobalClass.QuestionWithRepeatMapper>();
        int subjectId;
        public GenTest()
        {
            InitializeComponent();
        }

        private void GenTest_Load(object sender, EventArgs e)
        {
            SubjectList.DataSource = elementBase.SelectSubject();
            SubjectList.DisplayMember = "Name";
            SubjectList.ValueMember = "ID";
            ForDeeploma.GlobalClass.incrementCounter();
        }

        public void selectAnswerByOrder(int subject_id, int candidate_count)
        {
            CandidateList = elementBase.SelectQuestionsLimit(subject_id, candidate_count);
        }

        private void GenTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            ForDeeploma.GlobalClass.decrementCounter();
        }

        private void PickupQuest_Click(object sender, EventArgs e)
        {

            selectAnswerByOrder((int)SubjectList.SelectedValue, Decimal.ToInt32(this.ListCount.Value));
            this.ListCount.Value = this.CandidateList.Count;
            this.CandidateListView.DataSource = this.CandidateList;
            this.CandidateListView.Columns["ID"].Visible = false;
            this.CandidateListView.Columns["Question"].HeaderText = "Вопрос";
            this.CandidateListView.Columns["Repeat"].HeaderText = "Встречается";
        }

        private void CancelGen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveTest_Click(object sender, EventArgs e)
        {
            elementBase.InsertNewTest(this.CandidateList, (int)this.SubjectList.SelectedValue, this.DescrQuestT.Text);
            this.Close();
        }
    }
}
