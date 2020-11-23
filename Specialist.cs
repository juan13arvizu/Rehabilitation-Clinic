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
    public partial class Specialist : Form
    {
        public Specialist()
        {
            InitializeComponent();
        }
        private void ENTER()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=userinterfase";
            string query = "SELECT * FROM user where Username = '" + UserBoxtxt3.Text + "'AND Password='" + PswBoxtxt3.Text + "'";
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

        private void UserBoxtxt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PswBoxtxt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBotton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserBoxtxt3.Text == "")
                {
                    MessageBox.Show("Username is missing");

                }
                else if (PswBoxtxt3.Text == "")
                {
                    MessageBox.Show("Password is missing");

                }
                else if (UserBoxtxt3.Text == "" && PswBoxtxt3.Text == "")
                {
                    MessageBox.Show("Come on, both are missing!");

                }
                else
                {
                    ENTER();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SignBotton3_Click(object sender, EventArgs e)
        {

        }
    }      
}
