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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string FirstName = textBox1.Text,
                       Surname = textBox2.Text,
                        BaseName = textBox4.Text,
                        TableName = textBox3.Text,
                       HostName = textBox5.Text,
                        SQLQuery = "";

                DataBase db = new DataBase("", "");
                db = new DataBase($"{HostName}", $"{BaseName}");

                db.openConnection();

                //SQL запрос
                SQLQuery = $"SELECT * FROM {TableName} WHERE FirstName='{FirstName}' AND Surname='{Surname}'";

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(String.Format(SQLQuery, FirstName, Surname),
                db.GetConnection());


                adapter.SelectCommand = command;
                
                

                    if (adapter.Fill(table) == 1)
                    {
                        MessageBox.Show($"Добро пожаловть!: {FirstName} {Surname}", "УСПЕХ!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Данного пользователя не существует!: {FirstName} {Surname}", "ПРОВАЛ!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    db.closeConnection();
                
                
                
                    
                
            }
        }
    }
}
