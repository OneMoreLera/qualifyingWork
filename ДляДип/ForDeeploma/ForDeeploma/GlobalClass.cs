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
        public class userGroupMapper
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public userGroupMapper() { }
            public userGroupMapper(int Id, string _Name)
            {
                this.ID = Id;
                this.Name = _Name;
            }
            
        }
    }
}
