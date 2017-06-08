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
    public partial class TestingForm : Form
    {
        private List<System.Windows.Forms.CheckBox> checkBoxes;
        List<GlobalClass.QuestionAnswersMapper>  SetTest;
        List<GlobalClass.StudQuestionAnswersMapper> StudAns = new List<GlobalClass.StudQuestionAnswersMapper>();
        GlobalClass.QuestionAnswersMapper CurrQuestion;
        public TestingForm()
        {
            InitializeComponent();

        }

        public TestingForm( List<GlobalClass.QuestionAnswersMapper> Test)
        {
            InitializeComponent();
            this.SetTest = Test;
            this.CurrQuestion = this.SetTest[0];
            this.SetTest.Remove(this.CurrQuestion);
            this.QuestionBox.Text = this.CurrQuestion.Question;
            checkBoxes = new List<CheckBox>();
            int i = 0;
            foreach (GlobalClass.AnswerMapper sd in this.CurrQuestion.Answers)
            {
                System.Windows.Forms.CheckBox AnswerCheckBox = new System.Windows.Forms.CheckBox();
                checkBoxes.Add(AnswerCheckBox);
                AnswerCheckBox.AutoSize = true;
                AnswerCheckBox.Name = "AnswerCheckBox" + i;
                AnswerCheckBox.Size = new System.Drawing.Size(431, 167);
                AnswerCheckBox.TabIndex = 0;
                AnswerCheckBox.Text = sd.Answer;
                AnswerCheckBox.UseVisualStyleBackColor = true;
                this.tableLayoutPanel1.Controls.Add(AnswerCheckBox, i%2, (i-i%2)/2);
                i++;
                checkBoxes.Add(AnswerCheckBox);
            }

        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (this.StudAns.Count > 0)
            {
                int i = 0;
                foreach (System.Windows.Forms.CheckBox chkBx in this.checkBoxes)
                {
                    this.tableLayoutPanel1.Controls.Remove(chkBx);
                }

                this.CurrQuestion = new GlobalClass.QuestionAnswersMapper(this.StudAns.Last().ID, this.StudAns.Last().ID_subject, this.StudAns.Last().Question, this.StudAns.Last().AnswerCount, this.StudAns.Last().Answers);
                this.StudAns.Remove(this.StudAns.Last());
                this.QuestionBox.Text = this.CurrQuestion.Question;
                checkBoxes = new List<CheckBox>();
                i = 0;
                foreach (GlobalClass.AnswerMapper sd in this.CurrQuestion.Answers)
                {
                    System.Windows.Forms.CheckBox AnswerCheckBox = new System.Windows.Forms.CheckBox();
                    checkBoxes.Add(AnswerCheckBox);
                    AnswerCheckBox.AutoSize = true;
                    AnswerCheckBox.Name = "AnswerCheckBox" + i;
                    AnswerCheckBox.Size = new System.Drawing.Size(431, 167);
                    AnswerCheckBox.TabIndex = 0;
                    AnswerCheckBox.Text = sd.Answer;
                    AnswerCheckBox.UseVisualStyleBackColor = true;
                    this.tableLayoutPanel1.Controls.Add(AnswerCheckBox, i % 2, (i - i % 2) / 2);
                    i++;
                    checkBoxes.Add(AnswerCheckBox);
                }
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (this.SetTest.Count > 0)
            {
                List<GlobalClass.AnswerMapper> StudAnswers = new List<GlobalClass.AnswerMapper>();
                int i = 0;
                foreach (System.Windows.Forms.CheckBox chkBx in this.checkBoxes)
                {
                    if (chkBx.Checked)
                        StudAnswers.Add(this.CurrQuestion.Answers[i]);
                    this.tableLayoutPanel1.Controls.Remove(chkBx);
                    i++;
                }
                GlobalClass.StudQuestionAnswersMapper StudAnswer = new GlobalClass.StudQuestionAnswersMapper(this.CurrQuestion.ID, this.CurrQuestion.ID_subject,this.CurrQuestion.Question,this.CurrQuestion.AnswerCount,this.CurrQuestion.Answers,StudAnswers);
                StudAns.Add(StudAnswer);

                this.CurrQuestion = this.SetTest[0];
                this.SetTest.Remove(this.CurrQuestion);
                this.QuestionBox.Text = this.CurrQuestion.Question;
                checkBoxes = new List<CheckBox>();
                i = 0;
                foreach (GlobalClass.AnswerMapper sd in this.CurrQuestion.Answers)
                {
                    System.Windows.Forms.CheckBox AnswerCheckBox = new System.Windows.Forms.CheckBox();
                    checkBoxes.Add(AnswerCheckBox);
                    AnswerCheckBox.AutoSize = true;
                    AnswerCheckBox.Name = "AnswerCheckBox" + i;
                    AnswerCheckBox.Size = new System.Drawing.Size(431, 167);
                    AnswerCheckBox.TabIndex = 0;
                    AnswerCheckBox.Text = sd.Answer;
                    AnswerCheckBox.UseVisualStyleBackColor = true;
                    this.tableLayoutPanel1.Controls.Add(AnswerCheckBox, i % 2, (i - i % 2) / 2);
                    i++;
                    checkBoxes.Add(AnswerCheckBox);
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
