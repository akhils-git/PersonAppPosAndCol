﻿using PersonAppPosAndCol.Models;
using PersonAppPosAndCol.ProjectAssets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAppPosAndCol
{
    public partial class FormUserHome : Form
    {
        Person _person;
      
        public FormUserHome(Person person)
        {
            InitializeComponent();
            _person = person;
        }

        private void FormUserHome_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Convert.ToInt32(_person.Color));
            this.Left = _person.Left;
            this.Top = _person.Top;
            lblUsername.Text = "Welcome " + _person.Name;
        }
        private void UpdateWindowPosition(int left, int top,int personId)
        {
            SqlConnection connection = new SqlConnection(DatabaseConnections.MSSQLConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("UpdateWindowPosition", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("ID", personId);
            command.Parameters.AddWithValue("Left", left);
            command.Parameters.AddWithValue("Top", top);
            command.ExecuteNonQuery();
         
        }

        private void FormUserHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateWindowPosition(this.Left, this.Top,_person.ID);
        }

        private void lblTheme_Click(object sender, EventArgs e)
        {
            SetColor(_person.ID);
        }

        private void SetColor(int personId)
        {
            colorDialog1.ShowDialog();
            this.BackColor = Color.FromArgb(colorDialog1.Color.ToArgb());
            SqlConnection connection = new SqlConnection(DatabaseConnections.MSSQLConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SetColor", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("ID", personId);
            command.Parameters.AddWithValue("Color", colorDialog1.Color.ToArgb().ToString());
            command.ExecuteNonQuery();
        }
    }
}
