﻿using System;
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
        // конфигурирование коннектора к базе
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
        //===================================================
        // запросы по таблице пользователей и окружающих их
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
        public System.Data.DataTable SelectUsersInfo(int ID)
        {
            string query = "select * from fullusersinfo as a where a.ID <>" + ID;
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
        public void InsertUserInfo(GlobalClass.userCreateMapper InsertingUser)
        {
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                string query = @"INSERT INTO user_info (`Name`,`Surname`,`Patronym`)
                                    VALUES ('" + InsertingUser.Name + "','" + InsertingUser.Surname + "','" + InsertingUser.Patronim + "')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                long inserted_id = -1;
                inserted_id = cmd.LastInsertedId;
                if (inserted_id > -1)
                {
                    query = @"INSERT INTO aquser (`ID_group`,`ID_info`,`passwd`)
                                     VALUES ('" + InsertingUser.id_group + "','" + inserted_id + "','" + InsertingUser.MD5HashPass + "')";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();                
                }
                
                //close connection
                this.CloseConnection();
            }
        }
        public void DeleteUser(int deleteID)
        {
            

            if (this.openConnection() == true)
            {
                string SelectUserInfoID = "select a.id_info from  aquser as a where ID=" + deleteID;
                string DeleteUserQuery = "DELETE FROM aquser WHERE ID=" + deleteID;

                MySqlCommand cmd = new MySqlCommand(SelectUserInfoID, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                dataReader.Read();
                long II = (int)((long)dataReader["id_info"]);
                dataReader.Close();
    
                string DeleteUserInfoQuery = "DELETE FROM `user_info` WHERE ID=" + II;
                MySqlCommand cmd1 = new MySqlCommand(DeleteUserQuery, dbConnect);
                cmd1.ExecuteNonQuery();

                MySqlCommand cmd2 = new MySqlCommand(DeleteUserInfoQuery, dbConnect);
                cmd2.ExecuteNonQuery();
     
                
                
                this.CloseConnection();
            }
        }
        //=================================================
        //запросы по группам
        public GlobalClass.GroupsCreateMapper SelectRoleWhere(int id)
        {
            string query = @"select a.ID, b.Name, b.Description, a.ID_info, a.ID_role FROM usergroup as a
                            JOIN group_info as b ON b.ID = a.ID_info
                            where a.ID = " + id.ToString() + " limit 1";
            GlobalClass.GroupsCreateMapper tempGroup = new GlobalClass.GroupsCreateMapper();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int II = (int)((long)dataReader["ID_info"]);
                    int IR = (int)((long)dataReader["ID_role"]);
                    int I = (int)((long)dataReader["ID"]);
                    string N = (string)dataReader["Name"];
                    string D = (string)dataReader["Description"];
                    tempGroup = new GlobalClass.GroupsCreateMapper(I, N, D, II, IR);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tempGroup;
            }
            else
            {
                return tempGroup;
            }
        }
        public void UpdateGroup(GlobalClass.GroupsCreateMapper AlteringGroup)
        {
            //Open connection
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                string query = @"UPDATE user_info 
                                    SET Name='" + AlteringGroup.Name + @"',
                                        Description='" + AlteringGroup.Description + @"'
                                    WHERE ID=" + AlteringGroup.id_info;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                query = @"UPDATE usergroup 
                                    SET ID_role=" + AlteringGroup.id_role + @"
                                    WHERE ID=" + AlteringGroup.ID;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public void InsertGroup(GlobalClass.GroupsCreateMapper InsertingGroup)
        {
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                string query = @"INSERT INTO user_info (`Name`,`Description`)
                                    VALUES ('" + InsertingGroup.Name + "','" + InsertingGroup.Description + "')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                long inserted_id = -1;
                inserted_id = cmd.LastInsertedId;
                if (inserted_id > -1)
                {
                    query = @"INSERT INTO aquser (`ID_info`,`ID_role`)
                                     VALUES ('" + inserted_id + "','" + InsertingGroup.id_role +"')";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }

                //close connection
                this.CloseConnection();
            }
        }
        public void DeleteGroup(int deleteID)
        {


            if (this.openConnection() == true)
            {
                string SelectGroupInfoID = "select a.id_info from  usergroup as a where ID=" + deleteID;

                MySqlCommand cmd = new MySqlCommand(SelectGroupInfoID, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                dataReader.Read();
                long II = (int)((long)dataReader["id_info"]);
                dataReader.Close();

                string DeleteGroupInfoQuery = "DELETE FROM `group_info` WHERE ID=" + II;
                MySqlCommand cmd1 = new MySqlCommand(DeleteGroupInfoQuery, dbConnect);
                cmd1.ExecuteNonQuery();
                

                this.CloseConnection();
            }
        }
        public BindingList<GlobalClass.classifMapper> SelectGroups()
        {
            string query = @"SELECT a.ID, a.Name FROM 
                                group_info as a";
            BindingList<GlobalClass.classifMapper> tempGroupList = new BindingList<GlobalClass.classifMapper>();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int I = (int)((long)dataReader["ID"]);
                    string N = (string)dataReader["Name"];
                    GlobalClass.classifMapper tempUser = new GlobalClass.classifMapper(I, N);
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
        // ===============================================
        //запросы по ролям
        public BindingList<GlobalClass.classifMapper> SelectRoles()
        {
            string query = @"SELECT a.ID, a.Name FROM roles as a";
            BindingList<GlobalClass.classifMapper> tempRolesList = new BindingList<GlobalClass.classifMapper>();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int I = (int)((long)dataReader["ID"]);
                    string N = (string)dataReader["Name"];
                    GlobalClass.classifMapper tempRole = new GlobalClass.classifMapper(I, N);
                    tempRolesList.Add(tempRole);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tempRolesList;
            }
            else
            {
                return tempRolesList;
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
        //===================================================
        //запросы по предметам
        public List<GlobalClass.subjectMapper> SelectSubject()
        {
            string query = @"SELECT a.ID, a.Name, a.Description FROM subject as a";
            List<GlobalClass.subjectMapper> tempSubjectList = new List<GlobalClass.subjectMapper>();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int I = (int)((long)dataReader["ID"]);
                    string N = (string)dataReader["Name"];
                    string D = (string)dataReader["Description"];
                    GlobalClass.subjectMapper tempSubject = new GlobalClass.subjectMapper(I, N, D);
                    tempSubjectList.Add(tempSubject);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tempSubjectList;
            }
            else
            {
                return tempSubjectList;
            }
        }
        public BindingList<GlobalClass.subjectMapper> SelectSubjectClr()
        {
            string query = @"SELECT a.ID, a.Name, a.Description FROM subject as a";
            BindingList<GlobalClass.subjectMapper> tempSubjectList = new BindingList<GlobalClass.subjectMapper>();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int I = (int)((long)dataReader["ID"]);
                    string N = (string)dataReader["Name"];
                    string D = (string)dataReader["Description"];
                    GlobalClass.subjectMapper tempSubject = new GlobalClass.subjectMapper(I, N, D);
                    tempSubjectList.Add(tempSubject);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tempSubjectList;
            }
            else
            {
                return tempSubjectList;
            }
        }
        public void InsertSubject(GlobalClass.subjectMapper InsertingSubject)
        {
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                string query = @"INSERT INTO subject (`Name`,`Description`)
                                    VALUES ('" + InsertingSubject.Name + "','" + InsertingSubject.Description + "')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
            }
        }
        public void DeleteSubject(int deleteID)
        {


            if (this.openConnection() == true)
            {

                string DeleteQuery = "DELETE FROM `subject` WHERE ID=" + deleteID;
                MySqlCommand cmd1 = new MySqlCommand(DeleteQuery, dbConnect);
                cmd1.ExecuteNonQuery();


                this.CloseConnection();
            }
        }
        //===================================================
        //запрос по вопросам
        /*public GlobalClass.GroupsCreateMapper SelectRoleWhere(int id)
        {
            string query = @"select a.ID, b.Name, b.Description, a.ID_info, a.ID_role FROM usergroup as a
                            JOIN group_info as b ON b.ID = a.ID_info
                            where a.ID = " + id.ToString() + " limit 1";
            GlobalClass.GroupsCreateMapper tempGroup = new GlobalClass.GroupsCreateMapper();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int II = (int)((long)dataReader["ID_info"]);
                    int IR = (int)((long)dataReader["ID_role"]);
                    int I = (int)((long)dataReader["ID"]);
                    string N = (string)dataReader["Name"];
                    string D = (string)dataReader["Description"];
                    tempGroup = new GlobalClass.GroupsCreateMapper(I, N, D, II, IR);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tempGroup;
            }
            else
            {
                return tempGroup;
            }
        }
        public void UpdateGroup(GlobalClass.GroupsCreateMapper AlteringGroup)
        {
            //Open connection
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                string query = @"UPDATE user_info 
                                    SET Name='" + AlteringGroup.Name + @"',
                                        Description='" + AlteringGroup.Description + @"'
                                    WHERE ID=" + AlteringGroup.id_info;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                query = @"UPDATE usergroup 
                                    SET ID_role=" + AlteringGroup.id_role + @"
                                    WHERE ID=" + AlteringGroup.ID;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public void InsertGroup(GlobalClass.GroupsCreateMapper InsertingGroup)
        {
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                string query = @"INSERT INTO user_info (`Name`,`Description`)
                                    VALUES ('" + InsertingGroup.Name + "','" + InsertingGroup.Description + "')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                long inserted_id = -1;
                inserted_id = cmd.LastInsertedId;
                if (inserted_id > -1)
                {
                    query = @"INSERT INTO aquser (`ID_info`,`ID_role`)
                                     VALUES ('" + inserted_id + "','" + InsertingGroup.id_role + "')";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }

                //close connection
                this.CloseConnection();
            }
        }
        public void DeleteGroup(int deleteID)
        {


            if (this.openConnection() == true)
            {
                string SelectGroupInfoID = "select a.id_info from  usergroup as a where ID=" + deleteID;

                MySqlCommand cmd = new MySqlCommand(SelectGroupInfoID, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                dataReader.Read();
                long II = (int)((long)dataReader["id_info"]);
                dataReader.Close();

                string DeleteGroupInfoQuery = "DELETE FROM `group_info` WHERE ID=" + II;
                MySqlCommand cmd1 = new MySqlCommand(DeleteGroupInfoQuery, dbConnect);
                cmd1.ExecuteNonQuery();


                this.CloseConnection();
            }
        }*/
        public List<GlobalClass.QuestionWithRepeatMapper> SelectQuestionsLimit(int idSubject, int Limit)
        {
            string query = @"SELECT 
                                `a`.`ID` AS `ID`,
                                `a`.`Question` AS `Вопрос`,
                                (select count(*) from test_pool as b where b.ID_question = a.ID) AS `Встречается`
                             FROM
                                `questions` `a`
                             WHERE
                                a.ID_subject = " + idSubject + " order by `Встречается` limit " + Limit;
            List<GlobalClass.QuestionWithRepeatMapper> tempQList = new List<GlobalClass.QuestionWithRepeatMapper>();


            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int I = (int)((long)dataReader["ID"]);
                    string Q = (string)dataReader["Вопрос"];
                    int R = (int)((long)dataReader["Встречается"]);
                    GlobalClass.QuestionWithRepeatMapper tempQuestion = new GlobalClass.QuestionWithRepeatMapper(I, Q, R);
                    tempQList.Add(tempQuestion);
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();


                //return list to be displayed
                return tempQList;
            }
            else
            {
                return tempQList;
            }
        }
        public GlobalClass.QuestionAnswersMapper SelectQuestionWithAnswers(int id)
        {
            string questionQuery = @"select a.ID, a.ID_subject, a.Question from questions as a where a.ID = " + id;
            string answersQuery = @"select  b.ID, b.answer, b.true_variant 
                                    from qs_ar as a 
                                    join answer as b ON b.ID = a.ID_A
                                    where a.ID_Q = " + id;

            List<GlobalClass.AnswerMapper> Answers = new List<GlobalClass.AnswerMapper>();
            GlobalClass.QuestionAnswersMapper tempQ = new GlobalClass.QuestionAnswersMapper();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(answersQuery, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int I = (int)((long)dataReader["ID"]);
                    string A = (string)dataReader["answer"];
                    int F = (int)((sbyte)dataReader["true_variant"]);
                    Boolean Fl;
                    if (F == 1)
                        Fl = true;
                    else
                        Fl = false;
                    GlobalClass.AnswerMapper tempAnswer = new GlobalClass.AnswerMapper(I, A, Fl);
                    Answers.Add(tempAnswer);
                }

                //close Data Reader
                dataReader.Close();

                cmd = new MySqlCommand(questionQuery, dbConnect);
                dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int I = (int)((long)dataReader["ID"]);
                    int IS = (int)((long)dataReader["ID_subject"]);
                    string A = (string)dataReader["Question"];
                    tempQ = new GlobalClass.QuestionAnswersMapper(I, IS, A, Answers.Count, Answers);
                }

                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tempQ;
            }
            else
            {
                return tempQ;
            }
        }
        public System.Data.DataTable SelectQuestions(int idSubject)
        {
            string query = @"SELECT 
                                `a`.`ID` AS `ID`,
                                `a`.`Question` AS `Вопрос`,
                                (SELECT 
                                        COUNT(`b`.`ID_A`)
                                    FROM
                                        `qs_ar` `b`
                                    WHERE
                                        (`b`.`ID_Q` = `a`.`ID`)) AS `Количество ответов`
                             FROM
                                `questions` `a`
                             WHERE
                                a.ID_subject = " + idSubject;
            System.Data.DataTable tempQList = new System.Data.DataTable();


            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list

                tempQList.Load(dataReader);
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();


                //return list to be displayed
                return tempQList;
            }
            else
            {
                return tempQList;
            }
        }
        public void InsertQuestionWithAnswers(GlobalClass.QuestionAnswersMapper InsertingThing)
        {
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                string query = @"INSERT INTO `questions` (`ID_subject`,`Question`)
                                    VALUES (" + InsertingThing.ID_subject + ",'" + InsertingThing.Question + "')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                long inserted_id_Question = -1;
                inserted_id_Question = cmd.LastInsertedId;
                if (inserted_id_Question > -1)
                {

                    foreach (GlobalClass.AnswerMapper tempAnswer in InsertingThing.Answers)
                    {
                        query = @"INSERT INTO `answer` (`answer`,`true_variant`)
                                     VALUES ('" + tempAnswer.Answer + "'," + (tempAnswer.isTrue ? 1 : 0) + ")";
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        long inserted_id_Answer = -1;
                        inserted_id_Answer = cmd.LastInsertedId;
                        if (inserted_id_Answer > -1)
                        {
                            query = @"INSERT INTO `qs_ar` (`ID_Q`,`ID_A`)
                                     VALUES ('" + inserted_id_Question + "'," + inserted_id_Answer + ")";
                            cmd.CommandText = query;
                            cmd.ExecuteNonQuery();
                        }
                    }

                }

                //close connection
                this.CloseConnection();
            }
        }
        /*public System.Data.DataTable SelectGroupsInfo()
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
        }*/
        //===================================================
        //статистика
        public System.Data.DataTable SelectAllStat()
        {
            string query = @"Select 
                                ur.ID,
	                            concat(ui.Surname,' ',right(ui.Name,1),'. ',right(ui.Patronym,1),'.') as `ФИО`,
                                ti.Description as `Тест`,
                                ur.end_time  as `Время`,
                                user_answers_count(ur.ID_test,ur.ID) as `Количество верных`,
                                ti.Amount as `Всего вопросов`
                            from  user_result as ur
                            join aquser as au on au.ID = ur.ID_user
                            join user_info as ui on ui.ID = au.ID_info
                            join test as t on t.ID = ur.ID_test
                            join test_info as ti on ti.id = t.ID_info";

            System.Data.DataTable tempTList = new System.Data.DataTable();


            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list

                tempTList.Load(dataReader);
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();


                //return list to be displayed
                return tempTList;
            }
            else
            {
                return tempTList;
            }
        }
        //===================================================
        //запрос по Тестам
        /*public void UpdateGroup(GlobalClass.GroupsCreateMapper AlteringGroup)
        {
            //Open connection
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                string query = @"UPDATE user_info 
                                    SET Name='" + AlteringGroup.Name + @"',
                                        Description='" + AlteringGroup.Description + @"'
                                    WHERE ID=" + AlteringGroup.id_info;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                query = @"UPDATE usergroup 
                                    SET ID_role=" + AlteringGroup.id_role + @"
                                    WHERE ID=" + AlteringGroup.ID;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public void InsertGroup(GlobalClass.GroupsCreateMapper InsertingGroup)
        {
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                string query = @"INSERT INTO user_info (`Name`,`Description`)
                                    VALUES ('" + InsertingGroup.Name + "','" + InsertingGroup.Description + "')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                long inserted_id = -1;
                inserted_id = cmd.LastInsertedId;
                if (inserted_id > -1)
                {
                    query = @"INSERT INTO aquser (`ID_info`,`ID_role`)
                                     VALUES ('" + inserted_id + "','" + InsertingGroup.id_role + "')";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }

                //close connection
                this.CloseConnection();
            }
        }
        public void DeleteGroup(int deleteID)
        {


            if (this.openConnection() == true)
            {
                string SelectGroupInfoID = "select a.id_info from  usergroup as a where ID=" + deleteID;

                MySqlCommand cmd = new MySqlCommand(SelectGroupInfoID, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                dataReader.Read();
                long II = (int)((long)dataReader["id_info"]);
                dataReader.Close();

                string DeleteGroupInfoQuery = "DELETE FROM `group_info` WHERE ID=" + II;
                MySqlCommand cmd1 = new MySqlCommand(DeleteGroupInfoQuery, dbConnect);
                cmd1.ExecuteNonQuery();


                this.CloseConnection();
            }
        }*/
        public void DeleteTest(int deleteID)
        {


            if (this.openConnection() == true)
            {
                string UpdateTest = @"update test_info
                                            set test_info.Availble = 0
                                            where test_info.ID in (select test.ID_info from test where test.ID = " + deleteID + ")";

                MySqlCommand cmd2 = new MySqlCommand(UpdateTest, dbConnect);
                cmd2.ExecuteNonQuery();



                this.CloseConnection();
            }
        }
        public void InsertUserResult(List<GlobalClass.StudQuestionAnswersMapper> InsertingThing, int user_id, int test_id)
        {
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                string query = @"INSERT INTO `user_result` (`ID_user`,`ID_test`)
                                    VALUES (" + user_id + ",'" + test_id + "')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                long inserted_id_Question = -1;
                inserted_id_Question = cmd.LastInsertedId;
                if (inserted_id_Question > -1)
                {

                    foreach (GlobalClass.StudQuestionAnswersMapper tempQuestion in InsertingThing)
                    {
                        foreach (GlobalClass.AnswerMapper userAnswer in tempQuestion.StudAnswers)
                        {
                            query = @"INSERT INTO `usertestdetails` (`ID_user_result`,`ID_questions`,`ID_Answer`)
                                     VALUES (" + inserted_id_Question + "," + tempQuestion.ID + "," + userAnswer.ID + ")";
                            cmd.CommandText = query;
                            cmd.ExecuteNonQuery();
                        }
                    }

                }

                //close connection
                this.CloseConnection();
            }
        }
        public void InsertNewTest(List<GlobalClass.QuestionWithRepeatMapper> InsertingThing, int subj_id, string test_descr)
        {
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect;
                string query = @"INSERT INTO `test_info` (`Amount`,`Description`)
                                    VALUES (" + InsertingThing.Count + ",'" + test_descr + "')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                long inserted_id_info = -1;
                inserted_id_info = cmd.LastInsertedId;

                if (inserted_id_info > -1)
                {

                    query = @"INSERT INTO `test` (`ID_info`,`ID_subject`)
                                    VALUES (" + inserted_id_info + "," + subj_id + ")";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    long inserted_id_test = -1;
                    inserted_id_test = cmd.LastInsertedId;
                    if (inserted_id_test > -1)
                    {
                        foreach (GlobalClass.QuestionWithRepeatMapper tempQuestion in InsertingThing)
                        {
                            query = @"INSERT INTO `test_pool` (`ID_test`,`ID_question`)
                                        VALUES (" + inserted_id_test + "," + tempQuestion.ID + ")";
                            cmd.CommandText = query;
                            cmd.ExecuteNonQuery();   
                        }
                    }

                }

                //close connection
                this.CloseConnection();
            }
        }
        public System.Data.DataTable SelectTests(int idSubject)
        {
            string query = @"SELECT 
                                a.ID AS ID,
                                b.Description AS Описание,
                                IF((b.Availble = 1),
                                            'Да',
                                            'Нет') AS Доступность,
                                (SELECT count(c.ID_question) from test_pool as c WHERE
                                        (c.ID_test = a.ID)) AS `Количество вопросов`
                            FROM
                                test as a
                            JOIN test_info as b ON b.ID = a.ID_info
                            WHERE  b.Availble = 1 and a.ID_subject=" + idSubject;
            System.Data.DataTable tempTList = new System.Data.DataTable();


            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list

                tempTList.Load(dataReader);
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();


                //return list to be displayed
                return tempTList;
            }
            else
            {
                return tempTList;
            }
        }
        public List<GlobalClass.AnswerWithQuestionMapper> SelectOneTest(int idTest)
        {
            string query = @"CALL `selectedTest`(" + idTest + ");";
            List<GlobalClass.AnswerWithQuestionMapper> tempList = new List<GlobalClass.AnswerWithQuestionMapper>();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    int IQ = (int)((long)dataReader["idQuestion"]);
                    int IA = (int)((long)dataReader["idAnswer"]);
                    string Q = (string)dataReader["Question"];
                    string A = (string)dataReader["answer"];
                    int F = (int)((sbyte)dataReader["isTrue"]);
                    GlobalClass.AnswerWithQuestionMapper tempSubject = new GlobalClass.AnswerWithQuestionMapper(IQ,IA,Q,A,(F==1));
                    tempList.Add(tempSubject);
                }

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
        public System.Data.DataTable SelectTestsForUser()
        {
            string query = @"SELECT 
                                a.ID AS ID,
                                b.Description AS Описание,
                                c.Name AS Предмет,
                                IF((b.Availble = 1),
                                            'Да',
                                            'Нет') AS Доступность,
                                (SELECT count(c.ID_question) from test_pool as c WHERE
                                        (c.ID_test = a.ID)) AS `Количество вопросов`
                            FROM
                                test as a
                            JOIN test_info as b ON b.ID = a.ID_info
                            JOIN subject as c ON c.ID = a.ID_subject
                            Where b.Availble = 1";

            System.Data.DataTable tempTList = new System.Data.DataTable();


            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnect);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list

                tempTList.Load(dataReader);
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();


                //return list to be displayed
                return tempTList;
            }
            else
            {
                return tempTList;
            }
        }
        /*public System.Data.DataTable SelectGroupsInfo()
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
        }*/
    }
}
