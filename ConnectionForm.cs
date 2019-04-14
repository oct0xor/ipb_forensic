using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace NulledViewer
{
    public partial class ConnectionForm : Form
    {
        public string ConnectionString = null;

        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            serverTextBox.Text = Properties.Settings.Default.server;
            loginTextBox.Text = Properties.Settings.Default.login;
            passwordTextBox.Text = Properties.Settings.Default.password;
            databaseTextBox.Text = Properties.Settings.Default.database;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = new MySqlConnection();
                connection.ConnectionString = "server=" + serverTextBox.Text +
                    ";uid=" + loginTextBox.Text + ";pwd=" + passwordTextBox.Text +
                    ";database=" + databaseTextBox.Text + ";Convert Zero Datetime=True";
                connection.Open();
                connection.Close();

                ConnectionString = connection.ConnectionString;

                Properties.Settings.Default.server = serverTextBox.Text;
                Properties.Settings.Default.login = loginTextBox.Text;
                Properties.Settings.Default.password = passwordTextBox.Text;
                Properties.Settings.Default.database = databaseTextBox.Text;
                Properties.Settings.Default.Save();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
