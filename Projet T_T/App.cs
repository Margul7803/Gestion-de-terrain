using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Utilities.IO;
using Projet_TT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enum = System.Enum;

namespace Projet_T_T
{
    public partial class App : UserControl
    {
        public static App instance;
        public Label _Labelnom;
        public Label _Labelprenom;
        public Label _Labelrole;
        public string userMail;

        public App(string role, string mail)
        {
            InitializeComponent();
            DateTime date = DateTime.Now;
            DateTime maxDate = new DateTime(date.Year, date.Month, date.Day, 21, 00, 00);
            DateTime minDate = new DateTime(date.Year, date.Month, date.Day, 8, 00, 00);


            this.reservationDateTimePicker.MaxDate = maxDate;
            this.reservationDateTimePicker.MinDate = minDate;
            this.reservationDateTimePicker.Value = minDate;



            instance = this;
            userMail = mail;
            _Labelnom = userNameLabel;
            _Labelprenom = userPrenom;
            _Labelrole = userRole;
            espaceEncadrantButton.Visible = false;
            pictureBox5.Visible = false;
            if (role == "Encadrant")
            {
                espaceEncadrantButton.Visible = true;
                pictureBox5.Visible = true;
            }
            inscriptionPanel.Visible = false;
            mesInscriptionPanel.Visible = false;
            espaceEncadrantPanel.Visible = false;

            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Projet_T_T.ReservationTerrainContext;Integrated Security=true;User ID=MSI/Mario;\r\n";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT id,terrain,date FROM Reservations WHERE User_mail= @user", connection);
                command.Parameters.Add(new SqlParameter("@user", userMail));
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Reservation res = new Reservation(Convert.ToDateTime(dr.GetValue(dr.GetOrdinal("date"))), (Terrain)dr.GetValue(dr.GetOrdinal("terrain")), dr.GetValue(dr.GetOrdinal("id")).ToString());
                    userReservationListBox.Items.Add(res);
                }
                userReservationListBox.DisplayMember = "date";
                dr.Close();
                connection.Close();
            }


        }


        private void tournoiButton_Click(object sender, EventArgs e)
        {
            inscriptionPanel.Visible = true;
            inscriptionPanel.BringToFront();
        }

        private void mesInscriptionButton_Click_1(object sender, EventArgs e)
        {
            mesInscriptionPanel.Visible = true;
            mesInscriptionPanel.BringToFront();
        }

        private void espaceEncadrantButton_Click_1(object sender, EventArgs e)
        {
            espaceEncadrantPanel.Visible = true;
            espaceEncadrantPanel.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm logForm = new LoginForm();
            logForm.Dock = DockStyle.Fill;
            Form1.Instance.pnlContainer.Controls.Remove(this);
            Form1.Instance.pnlContainer.Controls.Add(logForm);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Projet_T_T.ReservationTerrainContext;Integrated Security=true;User ID=MSI/Mario;\r\n";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                if (terrainComboBox.SelectedIndex != -1) 
                {
                    Reservation res = new Reservation(reservationDateTimePicker.Value, (Terrain)terrainComboBox.SelectedItem);

                    SqlCommand verifExist = new SqlCommand("SELECT id FROM Reservations WHERE terrain = @terrain AND date = @date", connection);
                    verifExist.Parameters.Add(new SqlParameter("@terrain", res.terrain));
                    verifExist.Parameters.Add(new SqlParameter("@date", res.date));
                    SqlDataReader dr = verifExist.ExecuteReader();
                    if (!dr.Read())
                    {
                        dr.Close();
                        SqlCommand command = new SqlCommand("INSERT INTO Reservations VALUES (@id,@date,@terrain,@user)", connection);
                        command.Parameters.Add(new SqlParameter("@id", res.id));
                        command.Parameters.Add(new SqlParameter("@date", res.date));
                        command.Parameters.Add(new SqlParameter("@terrain", res.terrain));
                        command.Parameters.Add(new SqlParameter("@user", userMail));
                        command.ExecuteNonQuery();
                        userReservationListBox.Items.Add(res);
                        userListBox.Items.Clear();
                        reservationListBox.Items.Clear();
                        MessageBox.Show("Votre réservtion à bien été enregistrée");
                    }
                    else
                    {
                        MessageBox.Show("Le terrain est déjà réservé à cette heure-ci");
                    }

                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                }
                connection.Close();
            }
        }
        private void annuleResButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Projet_T_T.ReservationTerrainContext;Integrated Security=true;User ID=MSI/Mario;\r\n";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (userReservationListBox.SelectedIndex != -1) 
                {
                    connection.Open();
                    string id = ((Reservation)userReservationListBox.SelectedItem).id;

                    SqlCommand command = new SqlCommand("DELETE FROM Reservations WHERE id=@id", connection);
                    command.Parameters.Add(new SqlParameter("@id", id));


                    userReservationListBox.Items.RemoveAt(userReservationListBox.SelectedIndex);
                    command.ExecuteNonQuery();
                    userListBox.Items.Clear();
                    reservationListBox.Items.Clear();
                    MessageBox.Show("Votre réservtion à bien été annulée");

                    connection.Close(); 
                }
                else
                {
                    MessageBox.Show("Veuillez séléctionner une réservation");
                }
            }
        }

        private void researchButton_Click(object sender, EventArgs e)
        {
            userListBox.Items.Clear();
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Projet_T_T.ReservationTerrainContext;Integrated Security=true;User ID=MSI/Mario;\r\n";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT mail,nom,prenom,dateNaissance,role,dateFinAbo FROM Users WHERE mail= @mail", connection);
                command.Parameters.Add(new SqlParameter("@mail", ResearchTextBox.Text));



                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    Enum.TryParse(dr.GetValue(4).ToString(), out Role value);
                    DateTime annaissance = DateTime.Parse(dr.GetValue(3).ToString());
                    User user = new User(dr.GetString(1), dr.GetString(2), "****", dr.GetString(0), value, annaissance, dr.GetDateTime(5));
                    userListBox.Items.Add(user);
                    userListBox.DisplayMember = "mail";

                }
                else
                {
                    MessageBox.Show("Aucun utilisateur trouvé");
                }
                dr.Close();
                connection.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reservationListBox.Items.Clear();
            if (userListBox.Items.Count != 0)
            {
                string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Projet_T_T.ReservationTerrainContext;Integrated Security=true;User ID=MSI/Mario;\r\n";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string id = ((User)userListBox.SelectedItem).mail;

                    SqlCommand command = new SqlCommand("SELECT id,terrain,date FROM Reservations WHERE User_mail= @user", connection);
                    command.Parameters.Add(new SqlParameter("@user", id));
                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        Reservation res = new Reservation(Convert.ToDateTime(dr.GetValue(dr.GetOrdinal("date"))), (Terrain)dr.GetValue(dr.GetOrdinal("terrain")), dr.GetValue(dr.GetOrdinal("id")).ToString());
                        reservationListBox.Items.Add(res);
                    }

                    finAbonnementDateTimePicker.Value = ((User)userListBox.SelectedItem).dateFinAbo;
                    reservationListBox.DisplayMember = "date";
                    dr.Close();
                    connection.Close();
                }
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Projet_T_T.ReservationTerrainContext;Integrated Security=true;User ID=MSI/Mario;\r\n";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (roleComboBox.SelectedIndex != -1 && !string.IsNullOrEmpty(mailTextBox.Text) && !string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrEmpty(prenomTextBox.Text) && !string.IsNullOrEmpty(passTextBox.Text)) 
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO Users VALUES (@mail,@password,@nom,@prenom,@dateN,@role,@datefinabo)", connection);
                    command.Parameters.Add(new SqlParameter("@mail", mailTextBox.Text));
                    command.Parameters.Add(new SqlParameter("@password", BCrypt.Net.BCrypt.HashPassword(passTextBox.Text)));
                    command.Parameters.Add(new SqlParameter("@nom", nameTextBox.Text));
                    command.Parameters.Add(new SqlParameter("@prenom", prenomTextBox.Text));
                    command.Parameters.Add(new SqlParameter("@dateN", dateNDateTimePicker.Value));
                    command.Parameters.Add(new SqlParameter("@role", roleComboBox.SelectedIndex));
                    command.Parameters.Add(new SqlParameter("@datefinabo", DateTime.Now));

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("La création de compte à bien été effectuer");
                    }
                    catch
                    {
                        MessageBox.Show("Erreur lors de la création de compte");
                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                }
            }
        }

        private void deleteVacancier_Click(object sender, EventArgs e)
        {
            if (userListBox.Items.Count != 0)
            {
                string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Projet_T_T.ReservationTerrainContext;Integrated Security=true;User ID=MSI/Mario;\r\n";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string id = ((User)userListBox.SelectedItem).mail;

                    SqlCommand deleteReservationsCommand = new SqlCommand("DELETE FROM Reservations WHERE User_mail=@mail", connection);
                    deleteReservationsCommand.Parameters.Add(new SqlParameter("@mail", id));
                    deleteReservationsCommand.ExecuteNonQuery();

                    SqlCommand command2 = new SqlCommand("DELETE FROM Users WHERE mail=@mail", connection);
                    command2.Parameters.Add(new SqlParameter("@mail", id));
                    command2.ExecuteNonQuery();

                    userListBox.Items.RemoveAt(userListBox.SelectedIndex);
                    reservationListBox.Items.Clear();
                    MessageBox.Show("Le compte à bien été supprimé");

                    connection.Close();
                }
            }
        }

        private void dateFinAboUpdateButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Projet_T_T.ReservationTerrainContext;Integrated Security=true;User ID=MSI/Mario;\r\n";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (userListBox.SelectedIndex != -1) 
                {
                    connection.Open();
                    string id = ((User)userListBox.SelectedItem).mail;

                    SqlCommand command = new SqlCommand("UPDATE Users SET dateFinAbo=@datefa WHERE mail=@mail", connection);
                    command.Parameters.Add(new SqlParameter("@datefa", finAbonnementDateTimePicker.Value));
                    command.Parameters.Add(new SqlParameter("@mail", id));
                    command.ExecuteNonQuery();
                    User user = (User)userListBox.SelectedItem;
                    userListBox.Items.Clear();

                    User updatedUser = new User(user.nom, user.prenom, "****", user.mail, user.role, user.dateNaissance, finAbonnementDateTimePicker.Value);
                    userListBox.Items.Add(updatedUser);
                    userListBox.DisplayMember = "mail";
                    MessageBox.Show("La date de fin de l'abonnement a bien été modifier");

                    connection.Close(); 
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un utilisateur");
                }
            }
        }
    }
}
