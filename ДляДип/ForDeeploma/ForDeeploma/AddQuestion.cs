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
   
    public partial class AddQuestion : Form
    {
        private List<rowAddAnswer> RowListanswer = new List<rowAddAnswer>();
        private class rowAddAnswer
        {
            public System.Windows.Forms.Button DeleteBtn {get; set;}
            public System.Windows.Forms.TextBox AnswerT { get; set; }
            public System.Windows.Forms.CheckBox checkBx { get; set; }
            public rowAddAnswer(System.Windows.Forms.Button _DeleteBtn, System.Windows.Forms.TextBox _AnswerT , System.Windows.Forms.CheckBox _checkBx)
            {
                this.DeleteBtn = _DeleteBtn;
                this.AnswerT = _AnswerT;
                this.checkBx = _checkBx;
            }
        }

        private DBConnect elementBase = new DBConnect();
        private int AnsX = 72, AnsY = 60, DelX = 12, DelY = 60, CheckX = 44, CheckY = 62;
        public AddQuestion()
        {
            InitializeComponent();
        }
        private void GenerateAnswerRow()
        {
            
        }
        private void AddQuestion_Load(object sender, EventArgs e)
        {

            SubjectList.DataSource = elementBase.SelectSubject();
            SubjectList.DisplayMember = "Name";
            SubjectList.ValueMember = "ID";
            ForDeeploma.GlobalClass.incrementCounter();
        }

        private void AddQuestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            ForDeeploma.GlobalClass.decrementCounter();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox TempAnswer = new System.Windows.Forms.TextBox();
            System.Windows.Forms.CheckBox TempcheckBx = new System.Windows.Forms.CheckBox();
            System.Windows.Forms.Button TempDeleteBtn = new System.Windows.Forms.Button();
            this.panel1.Controls.Add(TempAnswer);
            this.panel1.Controls.Add(TempcheckBx);
            this.panel1.Controls.Add(TempDeleteBtn);

            rowAddAnswer TempRow = new rowAddAnswer(TempDeleteBtn, TempAnswer, TempcheckBx);
            RowListanswer.Add(TempRow);
            
            TempAnswer.Location = new System.Drawing.Point(AnsX, AnsY);
            TempAnswer.Name = "AnswerT" + RowListanswer.Count;
            TempAnswer.Text = this.NewAswer.Text;
            TempAnswer.Size = new System.Drawing.Size(231, 20);

            TempcheckBx.AutoSize = true;
            TempcheckBx.Location = new System.Drawing.Point(CheckX, CheckY);
            TempcheckBx.Name = "checkBx" + RowListanswer.Count;
            TempcheckBx.Checked = this.AddingCh.Checked;
            TempcheckBx.Size = new System.Drawing.Size(15, 14);
            TempcheckBx.UseVisualStyleBackColor = true;

            TempDeleteBtn.Location = new System.Drawing.Point(DelX, DelY);
            TempDeleteBtn.Name = "DeleteBtn" + RowListanswer.Count;
            TempDeleteBtn.Size = new System.Drawing.Size(20, 20);
            TempDeleteBtn.Text = "X";
            TempDeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            TempDeleteBtn.UseVisualStyleBackColor = true;
            AnsY += 25;
            CheckY += 25;
            DelY += 25;
            this.groupBox1.Top += 25;
            this.SaveBtn.Top += 25;
            this.Height += 25;

            this.NewAswer.Text = "";
            this.AddingCh.Checked = false;
            
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.NewAswer.Text = "";
            this.AddingCh.Checked = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            rowAddAnswer result = RowListanswer.Find(item => item.DeleteBtn == (System.Windows.Forms.Button)sender);
            int index = RowListanswer.IndexOf(result);
            this.Controls.Remove(result.checkBx);
            this.Controls.Remove(result.AnswerT);
            result.DeleteBtn.Click -= new System.EventHandler(this.DeleteBtn_Click);
            this.Controls.Remove(result.DeleteBtn);
            result.checkBx.Dispose();
            result.AnswerT.Dispose();
            result.DeleteBtn.Dispose();
            AnsY -= 25;
            CheckY -= 25;
            DelY -= 25;
            this.groupBox1.Top -= 25;
            this.SaveBtn.Top -= 25;
            this.Height -= 25;
            
            this.NewAswer.Text = "";
            this.AddingCh.Checked = false;
            for (int i = index + 1; i < RowListanswer.Count; i++ )
            {
                RowListanswer[i].AnswerT.Top -= 25;
                RowListanswer[i].checkBx.Top -= 25;
                RowListanswer[i].DeleteBtn.Top -= 25;
            }
                RowListanswer.Remove(result);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<GlobalClass.AnswerMapper> Answers = new List<GlobalClass.AnswerMapper>();
            

            foreach (rowAddAnswer oneAnswer in RowListanswer)
            {
                GlobalClass.AnswerMapper tempAnswer = new GlobalClass.AnswerMapper(0, oneAnswer.AnswerT.Text, oneAnswer.checkBx.Checked);
                Answers.Add(tempAnswer);
            }
            GlobalClass.QuestionAnswersMapper tempQ = new GlobalClass.QuestionAnswersMapper(0,(int)this.SubjectList.SelectedValue, this.QuestionT.Text, this.RowListanswer.Count , Answers);
            elementBase.InsertQuestionWithAnswers(tempQ);
            this.Close();
        }
    }
}
