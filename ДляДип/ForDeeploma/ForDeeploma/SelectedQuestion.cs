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
    public partial class SelectedQuestion : Form
    {
        private GlobalClass.QuestionAnswersMapper SelectedQuest;
        public SelectedQuestion()
        {
            InitializeComponent();
        }
        public SelectedQuestion(GlobalClass.QuestionAnswersMapper OneQuestion)
        {
            InitializeComponent();
            this.SelectedQuest = OneQuestion;
            QuestT.Text = SelectedQuest.Question;
            foreach (GlobalClass.AnswerMapper Answer in this.SelectedQuest.Answers)
            {
                this.checkedListBox1.Items.Add(Answer.Answer, Answer.isTrue);
            }

        }
        private void SelectedQuestion_Load(object sender, EventArgs e)
        {
            ForDeeploma.GlobalClass.incrementCounter();
        }

        private void SelectedQuestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            ForDeeploma.GlobalClass.decrementCounter();
        }
    }
}
