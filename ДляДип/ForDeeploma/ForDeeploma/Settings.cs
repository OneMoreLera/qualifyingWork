using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace ForDeeploma
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        private class jsonConfig
        {
            public string server;
            public string database;
            public string uid;
            public string password;
        }
        private jsonConfig configuration;

        private jsonConfig readJsonConf()
        {
            using (StreamReader streamOfFile = new StreamReader("settings.json"))
            {
                string jsonObject = streamOfFile.ReadToEnd();
                jsonConfig config = JsonConvert.DeserializeObject<jsonConfig>(jsonObject);
                return config;
            }

        }
        private void writeJsonConf(jsonConfig newConfig)
        {
            using (StreamWriter file = File.CreateText(@"settings.json"))
            {    
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, newConfig);
            }
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            configuration = readJsonConf();
            this.serverT.Text = configuration.server;
            this.databaseT.Text = configuration.database;
            this.uidT.Text = configuration.uid;
            this.passwordT.Text = configuration.password;
            ForDeeploma.GlobalClass.incrementCounter();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            ForDeeploma.GlobalClass.decrementCounter();
        }

        private void CheckConf_Click(object sender, EventArgs e)
        {
            DBConnect elementBase = new DBConnect();
            string connectionString;
            connectionString = "SERVER=" + this.serverT.Text + ";" + "DATABASE=" +
            this.databaseT.Text + ";" + "UID=" + this.uidT.Text + ";" + "PASSWORD=" + this.passwordT.Text + ";";
            Boolean isNormal = elementBase.testConnection(connectionString);
            if (isNormal) this.CheckConf.BackColor = Color.Green;
            else this.CheckConf.BackColor = Color.Red;
        }

        private void WriteConf_Click(object sender, EventArgs e)
        {
            configuration.server = this.serverT.Text;
            configuration.database = this.databaseT.Text;
            configuration.uid = this.uidT.Text;
            configuration.password = this.passwordT.Text;
            writeJsonConf(configuration);
            this.Close();
        }
    }
}
