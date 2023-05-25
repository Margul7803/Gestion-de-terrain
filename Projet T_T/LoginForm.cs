using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
using Projet_TT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_T_T
{
    public partial class LoginForm : UserControl
    {
        public TextBox _TextBox;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Projet_T_T.ReservationTerrainContext;Integrated Security=true;User ID=MSI/Mario;\r\n";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (!string.IsNullOrEmpty(emailTextBox.Text) && !string.IsNullOrEmpty(passwordTextBox.Text)) {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT role,prenom,nom,password FROM Users WHERE mail=@userName", connection);
                    command.Parameters.Add(new SqlParameter("@userName", emailTextBox.Text));
                    SqlDataReader dr = command.ExecuteReader();
                    dr.Read();
                    bool isConnected = BCrypt.Net.BCrypt.Verify(passwordTextBox.Text, dr["password"].ToString());


                    if (isConnected)
                    {
                        int roleUser = Int32.Parse(dr["role"].ToString());
                        string nomUser = dr["nom"].ToString();
                        string prenomUser = dr["prenom"].ToString();


                        Enum.TryParse(roleUser.ToString(), out Role value);
                        App app = new App(value.ToString(), emailTextBox.Text);
                        app.Dock = DockStyle.Fill;
                        App.instance._Labelnom.Text = nomUser;
                        App.instance._Labelprenom.Text = prenomUser;
                        App.instance._Labelrole.Text = value.ToString();
                        this.Hide();
                        Form1.Instance.pnlContainer.Controls.Add(app);
                        connection.Close();
                        dr.Close();
                    }

                    else
                    {
                        MessageBox.Show("Email ou mot de passe incorrect / Erreur de lecture de la carte");
                        passwordTextBox.Clear();
                        emailTextBox.Clear();
                        emailTextBox.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                }
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                loginButton.PerformClick();
            }
        }
    }
}