using PersonAppPosAndCol.Models;
using PersonAppPosAndCol.ProjectAssets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAppPosAndCol
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Person loggndPerson = Login(txtUsername.Text, txtPassword.Text);
            if (loggndPerson!=null)
            {
                FormUserHome formUserHome = new FormUserHome(loggndPerson);
                formUserHome.Show();
                //this.Hide();
            }
        }

        private Person Login(string username, string password)
        {
            SqlConnection connection = new SqlConnection(DatabaseConnections.MSSQLConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("Login",connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Username",username);
            command.Parameters.AddWithValue("Password", password);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            Person person = new Person();
            person.ID =Convert.ToInt32( reader["ID"]);
            person.Name = reader["ID"].ToString();
            person.Left = Convert.ToInt32(Convert.ToInt32(reader["Left"]));
            person.Top = Convert.ToInt32(Convert.ToInt32(reader["Top"]));
            person.Username = reader["Username"].ToString();
            person.Color = reader["Color"].ToString();
            return person;
        }
    }
}
