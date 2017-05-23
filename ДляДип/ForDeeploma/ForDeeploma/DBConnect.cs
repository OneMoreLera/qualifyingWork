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
using System.Data;

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
        public Boolean testConnection(string dbString)
        {
            dbConnect = new MySqlConnection(dbString);
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
        public BindingList<GlobalClass.userGroupMapper> SelectGroups()
        {
            string query = @"SELECT a.ID, a.Name FROM 
                                group_info as a";
            BindingList<GlobalClass.userGroupMapper> tempGroupList = new BindingList<GlobalClass.userGroupMapper>();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int I = (int)((long)dataReader["ID"]);
                    string N = (string)dataReader["Name"];
                    GlobalClass.userGroupMapper tempUser = new GlobalClass.userGroupMapper(I, N);
                    tempGroupList.Add(tempUser);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tempGroupList;
            }
            else
            {
                return tempGroupList;
            }
        }
        public GlobalClass.userCreateMapper SelectUserWhere(int id)
        {
            string query = @"SELECT a.ID, b.Name, b.Surname, b.Patronym,a.ID_info, a.ID_group, a.passwd FROM aquser as a
                            JOIN user_info as b ON b.ID = a.ID_info
                            where a.ID = " + id.ToString() + " limit 1";
            GlobalClass.userCreateMapper tempUser = new GlobalClass.userCreateMapper();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int II = (int)((long)dataReader["ID_info"]);
                    int IG = (int)((long)dataReader["ID_group"]);
                    int I = (int)((long)dataReader["ID"]);
                    string N = (string)dataReader["Name"];
                    string S = (string)dataReader["Surname"];
                    string P = (string)dataReader["Patronym"];
                    string Pw = (string)dataReader["passwd"];
                    tempUser = new GlobalClass.userCreateMapper(I, N, S, P, II, IG, Pw);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tempUser;
            }
            else
            {
                return tempUser;
            }
        }

        public void UpdateUser(GlobalClass.userCreateMapper AlteringUser)
        {
            //Open connection
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                string query = @"UPDATE user_info 
                                    SET Name='" + AlteringUser.Name + @"',
                                        Surname='" + AlteringUser.Surname + @"',
                                        Patronym='" + AlteringUser.Patronim + @"'
                                    WHERE ID=" + AlteringUser.id_info;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                query = @"UPDATE aquser 
                                    SET ID_group=" + AlteringUser.id_group + @",
                                        passwd='" + AlteringUser.MD5HashPass + @"'
                                    WHERE ID=" + AlteringUser.ID;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public System.Data.DataTable SelectUsersInfo()
        {
            string query = "select * from fullusersinfo";
            System.Data.DataTable tempUserList = new System.Data.DataTable();   
            

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list

                tempUserList.Load(dataReader);
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
        public System.Data.DataTable SelectGroupsInfo()
        {
            string query = "select * from groupinfoview";
            System.Data.DataTable tempList = new System.Data.DataTable();


            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list

                tempList.Load(dataReader);
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();


                //return list to be displayed
                return tempList;
            }
            else
            {
                return tempList;
            }
        }
        public System.Data.DataTable SelectRolesInfo()
        {
            string query = "select a.id, a.name as `Название`, IF((`a`.`allowRead` = 1),'Да','Нет') AS `Чтение`, IF((`a`.`allowWrite` = 1), 'Да', 'Нет') AS `Запись`,IF((`a`.`Admin` = 1), 'Да', 'Нет') AS `Полный доступ` from roles as a";
            System.Data.DataTable tempList = new System.Data.DataTable();


            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list

                tempList.Load(dataReader);
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();


                //return list to be displayed
                return tempList;
            }
            else
            {
                return tempList;
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
