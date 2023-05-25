using Projet_TT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_T_T
{
    public enum Role
    {
        Vacancier,
        Encadrant,
    }
    public class User
    {
        [Key]
        public string mail { get; set; }
        public string password { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateNaissance { get; set; }
        public List<Reservation> mesReservation { get; set; }
        public DateTime dateFinAbo { get; set; }
        public Role role { get; set; }

        public User(string nom, string prenom,string password, string mail,Role role, DateTime dateNaissance, DateTime dateFinAbo)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.password = password;
            this.dateNaissance = dateNaissance;
            this.role = role;
            this.dateFinAbo = dateFinAbo;
            this.mesReservation = new List<Reservation>();
        }

        public string GetNom() { return this.nom; }
        public string GetPrenom() { return this.prenom; }
        public string GetMail() { return this.mail; }
        public DateTime GetDateNaissance() { return dateNaissance; }
        public int GetAge()
        {
            int ageact = DateTime.Now.Year - dateNaissance.Year;
            DateTime DateAnniv = new DateTime(DateTime.Now.Year, dateNaissance.Month, dateNaissance.Day);
            if (DateAnniv > DateTime.Now)
            {
                ageact--;
            }
            return ageact;

        }
        public void SetMail(string mail) { this.mail = mail; }

        public override string ToString() { return nom + " " + prenom + " " + mail + " " + GetAge() + GetMesInscriptions(); }

        public void AjouterInscription(Reservation inscription)
        {
            this.mesReservation.Add(inscription);
        }
        public void SupprimerInscription(Reservation inscription)
        {
            this.mesReservation.Remove(inscription);
        }
        public List<Reservation> GetMesInscriptions() { return this.mesReservation; }
    }
}
