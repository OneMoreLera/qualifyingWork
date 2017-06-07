using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDeeploma
{
    public class GlobalClass
    {
        public static int globalWindowCounter = 0;
        public static void incrementCounter()
        {
            ForDeeploma.GlobalClass.globalWindowCounter++;
        }
        public static void decrementCounter(){
            ForDeeploma.GlobalClass.globalWindowCounter--;
            if (ForDeeploma.GlobalClass.globalWindowCounter == 0) Application.Exit();
        }
        public static string MD5Hashing(string s)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(s));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)sBuilder.Append(data[i].ToString("x2"));
                return sBuilder.ToString();
            }
        }
        public static Boolean VerifyMd5Hash(string i, string h)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                string hashOfInput = MD5Hashing(i);
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;
                if (0 == comparer.Compare(hashOfInput, h)) return true;
                else return false;
            }
        }
        public class userTableMapper
        {
            public int ID {get; set;}
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Patronim { get; set; }
            public string reprUser { get; set; }
            public string MD5HashPass { get; set; }

            public userTableMapper()
            {

            }

            public userTableMapper(int ID, string Name, string Surname, string Patronim, string passwd) {
                this.ID = ID;
                this.Name = Name;
                this.Surname = Surname;
                this.Patronim = Patronim;
                this.reprUser = Surname + " " + Name.Substring(0, 1).ToUpper() + "." + Patronim.Substring(0, 1).ToUpper() + ".";
                this.MD5HashPass = passwd;
            }
        }
        public class userCreateMapper
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Patronim { get; set; }
            public int id_info { get; set; }
            public int id_group  { get; set; }
            public string MD5HashPass { get; set; }
            public userCreateMapper()
            {

            }
            public userCreateMapper(int ID, string Name, string Surname, string Patronim,int idInfo, int idGroup, string passwd)
            {
                this.ID = ID;
                this.Name = Name;
                this.Surname = Surname;
                this.Patronim = Patronim;
                this.id_info = idInfo;
                this.id_group = idGroup;
                this.MD5HashPass = passwd;
            }
        }
        public class GroupsCreateMapper
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int id_info { get; set; }
            public int id_role { get; set; }
            public GroupsCreateMapper()
            {

            }
            public GroupsCreateMapper(int ID, string Name, string Description, int idInfo, int idRole)
            {
                this.ID = ID;
                this.Name = Name;
                this.Description = Description;
                this.id_info = idInfo;
                this.id_role = idRole;
            }
        }
        public class userRoleMapper
        {
            public int ID { get; set; }
            public Boolean AllowRead { get; set; }
            public Boolean AllowWrite { get; set; }
            public Boolean Admin { get; set; }
            public userRoleMapper() { }
            public userRoleMapper(int _id, Boolean _read, Boolean _write, Boolean _admin)
            {
                this.ID = _id;
                this.AllowRead = _read;
                this.AllowWrite = _write;
                this.Admin = _admin;
            }

            public void setRole(Boolean _read, Boolean _write, Boolean _admin)
            {
                this.AllowRead = _read;
                this.AllowWrite = _write;
                this.Admin = _admin;
            }
        }
        public class classifMapper
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public classifMapper() { }
            public classifMapper(int Id, string _Name)
            {
                this.ID = Id;
                this.Name = _Name;
            }
            
        }
        public class subjectMapper
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public subjectMapper() { }
            public subjectMapper(int Id, string _Name, string _Description)
            {
                this.ID = Id;
                this.Name = _Name;
                this.Description = _Description;
            }

        }
        public class QuestionSubjectMapper
        {
            public int ID { get; set; }
            public string Question { get; set; }
            public int AnswerCount { get; set; }
            public QuestionSubjectMapper() { }
            public QuestionSubjectMapper(int Id, string _Question, int _AnswerCount)
            {
                this.ID = Id;
                this.Question = _Question;
                this.AnswerCount = _AnswerCount;
            }

        }
        public class AnswerMapper
        {
            public int ID { get; set; }
            public string Answer { get; set; }
            public Boolean isTrue { get; set; }
            public AnswerMapper() { }
            public AnswerMapper(int Id, string _Answer, Boolean _True)
            {
                this.ID = Id;
                this.Answer = _Answer;
                this.isTrue = _True;
            }

        }
        public class QuestionAnswersMapper
        {
            public int ID { get; set; }
            public string Question { get; set; }
            public int AnswerCount { get; set; }
            public List<AnswerMapper> Answers { get; set; }
            public AnswerMapper rightAnswer { get; set; }
            public QuestionAnswersMapper() { }
            public QuestionAnswersMapper(int Id, string _Question, int _AnswerCount, List<AnswerMapper> _Answers, AnswerMapper _rightAnswer)
            {
                this.ID = Id;
                this.Question = _Question;
                this.AnswerCount = _AnswerCount;
                this.Answers = _Answers;
                this.rightAnswer = _rightAnswer;
            }
        }
    }
}
