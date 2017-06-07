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
    public partial class NewSubject : Form
    {
        private GlobalClass.subjectMapper AlteringSubject;
        DBConnect elementBase = new DBConnect();
        public NewSubject()
        {
            InitializeComponent();
        }
        private void AddSubject_Load(object sender, EventArgs e)
        {
            ForDeeploma.GlobalClass.incrementCounter();
        }
        private void AddSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            ForDeeploma.GlobalClass.decrementCounter();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            AlteringSubject = new GlobalClass.subjectMapper();
            AlteringSubject.Name = this.subjName.Text;
            AlteringSubject.Description = this.subjDescription.Text;
            elementBase.InsertSubject(AlteringSubject);
            this.Close();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
