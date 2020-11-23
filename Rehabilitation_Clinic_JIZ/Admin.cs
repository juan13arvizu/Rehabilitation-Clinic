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

namespace Rehabilitation_Clinic_JIZ
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void Join()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=admin";
            string query = "SELECT * FROM user where Username = '" + UserBoxtxt1.Text + "'AND Password='" + PswBoxtxt1.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader bibliophile;

            try
            {

                databaseConnection.Open();
                bibliophile = commandDatabase.ExecuteReader();
                if (bibliophile.Read())
                {
                    MessageBox.Show("ACCESS ACCEPTED");
                }
                else
                {
                    MessageBox.Show("Username/Password, MISTAKEN.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PswBoxtxt1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void UserBoxtxt1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoginBotton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserBoxtxt1.Text == "")
                {
                    MessageBox.Show("Username is missing");

                }
                else if (PswBoxtxt1.Text == "")
                {
                    MessageBox.Show("Password is missing");

                }
                else if (UserBoxtxt1.Text == "" && PswBoxtxt1.Text == "")
                {
                    MessageBox.Show("Come on, both are missing!");

                }
                else
                {
                    Join();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


    }
}

