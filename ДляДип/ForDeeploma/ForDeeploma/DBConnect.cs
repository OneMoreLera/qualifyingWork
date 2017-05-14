using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using ForDeeploma;
using System.ComponentModel;

namespace ForDeeploma
{
    class DBConnect
    {
        private MySqlConnection dbConnect;
        private class jsonConfig
        {
            public string server;
            public string database;
            public string uid;
            public string password;
        }
        private jsonConfig configuration;
        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            configuration = readJsonConf();
            string connectionString;
            connectionString = "SERVER=" + configuration.server + ";" + "DATABASE=" +
            configuration.database + ";" + "UID=" + configuration.uid + ";" + "PASSWORD=" + configuration.password + ";";
            dbConnect = new MySqlConnection(connectionString);
        }

        private jsonConfig readJsonConf()
        {
            using (StreamReader streamOfFile = new StreamReader("settings.json"))
            {
                string jsonObject = streamOfFile.ReadToEnd();
                jsonConfig config = JsonConvert.DeserializeObject<jsonConfig>(jsonObject);
                return config;
            }
            
        }

        public Boolean openConnection(){
            try
            {
                dbConnect.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public Boolean CloseConnection()
        {
            try
            {
                dbConnect.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean testConnection()
        {
            Boolean isOpen = openConnection();
            Boolean isClose = CloseConnection();
            return isOpen && isClose;
        }

        public BindingList<GlobalClass.userTableMapper> SelectUsers()
        {
            string query = "select * from loginusers";
            BindingList<GlobalClass.userTableMapper> tempUserList = new BindingList<GlobalClass.userTableMapper>();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int I = (int)((long)dataReader["ID"]);
                    string N = (string)dataReader["Name"];
                    string S = (string)dataReader["Surname"];
                    string P = (string)dataReader["Patronym"];
                    string Pw = (string)dataReader["passwd"];
                    GlobalClass.userTableMapper tempUser = new GlobalClass.userTableMapper(I,N,S,P,Pw);
                    tempUserList.Add(tempUser);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tempUserList;
            }
            else
            {
                return tempUserList;
            }
        }

        public GlobalClass.userRoleMapper roleSelectedUser(int ID)
        {
            string query = "select * from userrole where ID = " + ID + " limit 1";
            GlobalClass.userRoleMapper userRole = new GlobalClass.userRoleMapper(ID, false, false, false);
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int I = (int)((long)dataReader["ID"]);
                    Boolean R = Convert.ToBoolean((sbyte)dataReader["allowRead"]);
                    Boolean W = Convert.ToBoolean((sbyte)dataReader["allowWrite"]);
                    Boolean A = Convert.ToBoolean((sbyte)dataReader["Admin"]);
                    userRole.setRole(R, W, A);
                }
                dataReader.Close();
                this.CloseConnection();
                return userRole;
            }
            else
            {
                return userRole;
            }
        }

    }
}
