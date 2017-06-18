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
        private int testId;
        private int userId;
        List<GlobalClass.QuestionAnswersMapper>  SetTest;
        List<GlobalClass.StudQuestionAnswersMapper> StudAns = new List<GlobalClass.StudQuestionAnswersMapper>();
        GlobalClass.QuestionAnswersMapper CurrQuestion;
        private DBConnect elementBase = new DBConnect();
        public TestingForm()
        {
            InitializeComponent();

        }

        public TestingForm( List<GlobalClass.QuestionAnswersMapper> Test,int test_id, int user_id)
        {
            InitializeComponent();
            this.testId = test_id;
            this.userId = user_id;
            this.SetTest = Test;
            this.CurrQuestion = this.SetTest[0];
            this.QuestionBox.Text = this.CurrQuestion.Question;
            checkBoxes = new List<CheckBox>();
            int i = 0;
            foreach (GlobalClass.AnswerMapper sd in this.CurrQuestion.Answers)
            {
                System.Windows.Forms.CheckBox AnswerCheckBox = new System.Windows.Forms.CheckBox();
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
            this.SetTest.Remove(this.CurrQuestion);

            List<GlobalClass.AnswerMapper> StudAnswers = new List<GlobalClass.AnswerMapper>();
            int i = 0;
            foreach (System.Windows.Forms.CheckBox chkBx in this.checkBoxes)
            {
                if (chkBx.Checked)
                    StudAnswers.Add(this.CurrQuestion.Answers[i]);
                this.tableLayoutPanel1.Controls.Remove(chkBx);
                i++;
            }
            GlobalClass.StudQuestionAnswersMapper StudAnswer = new GlobalClass.StudQuestionAnswersMapper(this.CurrQuestion.ID, this.CurrQuestion.ID_subject, this.CurrQuestion.Question, this.CurrQuestion.AnswerCount, this.CurrQuestion.Answers, StudAnswers);
            StudAns.Add(StudAnswer);

            if (this.SetTest.Count > 0)
            {   
                
                this.CurrQuestion = this.SetTest[0];
                this.QuestionBox.Text = this.CurrQuestion.Question;
                checkBoxes = new List<CheckBox>();
                i = 0;
                foreach (GlobalClass.AnswerMapper sd in this.CurrQuestion.Answers)
                {
                    System.Windows.Forms.CheckBox AnswerCheckBox = new System.Windows.Forms.CheckBox();
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
                int right_answers = 0;
                foreach (GlobalClass.StudQuestionAnswersMapper SA in StudAns)
                {
                    int right_count = 0;
                    foreach (GlobalClass.AnswerMapper Ans in SA.Answers)
                       if (Ans.isTrue) right_count++;
                    
                    int stud_right_count = 0;
                    
                    if (right_count == SA.StudAnswers.Count)
                    {
                        foreach(GlobalClass.AnswerMapper Ans in SA.StudAnswers)
                            if (Ans.isTrue) stud_right_count++;
                        if (stud_right_count == right_count) right_answers++;
                    }
                }
                elementBase.InsertUserResult(StudAns, userId, testId);
                string message = "Вы ответили на " + right_answers + " из " + this.StudAns.Count + ";";
                string caption = "Окончание теста";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Hide();
                MessageBox.Show(message, caption, buttons);

                this.Close();
            }
        }

        private void TestingForm_Load(object sender, EventArgs e)
        {
            ForDeeploma.GlobalClass.incrementCounter();
        }

        private void TestingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ForDeeploma.GlobalClass.decrementCounter();
        }
    }
}
