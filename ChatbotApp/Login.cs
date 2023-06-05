using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChatbotApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usernameInput = textBox1.Text;
            string passwordInput = textBox2.Text;

                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studios\repos\ChatbotApp\ChatbotApp\Login.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM LOGIN WHERE username =@username AND password =@password";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@username", usernameInput);
                    command.Parameters.AddWithValue("@password", passwordInput);

                    // Open the database connection
                    conn.Open();

                    // Execute the query
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Authentication successful
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        // Close the login form if needed
                        this.Close();
                    }
                    else
                    {
                        // Authentication failed
                        MessageBox.Show("Invalid username or password");
                    }

                    // Close the data reader and connection
                    reader.Close();
                    conn.Close();
            }
        }
    }
}
