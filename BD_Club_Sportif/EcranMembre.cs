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
using System.Data.SqlTypes;
using System.IO;
using Projet_Club_Sportif.Classes;
using Projet_Club_Sportif.Gestion;

namespace Projet_Club_Sportif_CouUti
{
    public partial class EcranMembre : Form
    {
        DataTable DT_Membre;
        BindingSource BS_Membre;
        string ChConn;
        bool Ajout = false;

        public EcranMembre(string chaine)
        {
            InitializeComponent();
            ChConn = chaine;
            RemplirDGV();
            Activer(true);
        }

        private void RemplirDGV() //Affichage des membres
        {
            DT_Membre = new DataTable();
            DT_Membre.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Membre.Columns.Add("Nom");
            DT_Membre.Columns.Add("Prénom");
            DT_Membre.Columns.Add("Naissance");
            DT_Membre.Columns.Add("Mail");
            DT_Membre.Columns.Add("Equipe");
            DT_Membre.Columns.Add("Poids (kg)");
            DT_Membre.Columns.Add("Taille (cm)");

            List<C_Membre> lTmp_M = new G_Membre(ChConn).Lire("Nom");
            foreach (C_Membre Tmp in lTmp_M)
            {
                DT_Membre.Rows.Add(Tmp.IdMembre, Tmp.Nom, Tmp.Prenom, Tmp.Naissance.ToShortDateString(), Tmp.Mail, Tmp.IdEquipe_membre, Tmp.Poids, Tmp.Taille);
            }

            BS_Membre = new BindingSource{DataSource = DT_Membre};
            DGV_Membre.DataSource = BS_Membre;
        }

        private void Activer(bool Actif)
        {
            DGV_Membre.Enabled = btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = Actif;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !Actif;

            tbNom.Enabled = tbPrenom.Enabled = tbMail.Enabled = tbEquipe.Enabled = dtpNaissance.Enabled = !Actif;

            if (Actif)
                DGV_Membre.Focus();
            else
                tbNom.Focus();
        }

        #region Evenement

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);

            tbNom.Text = tbEquipe.Text = tbPrenom.Text = tbMail.Text = "";

            dtpNaissance.Value = DateTime.Today;
  
            Ajout = true;
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            Activer(false);

            tbNom.Text = tbEquipe.Text = tbPrenom.Text = tbMail.Text = "";

            dtpNaissance.Value = DateTime.Today;

            Ajout = true;

            if (DGV_Membre.SelectedRows.Count > 0)
            {
                Activer(false);
                C_Membre Tmp = new G_Membre(ChConn).Lire_ID(int.Parse(DGV_Membre.SelectedRows[0].Cells["ID"].Value.ToString()));
                tbNom.Text = Tmp.Nom;
                tbEquipe.Text = Tmp.IdEquipe_membre.ToString();
                tbPrenom.Text = Tmp.Prenom;
                tbMail.Text = Tmp.Mail;
                dtpNaissance.Text = Tmp.Naissance.ToShortDateString();
              
                Ajout = false;
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

                if (DGV_Membre.SelectedRows.Count > 0)
                {
                    int N_ID = (int)DGV_Membre.SelectedRows[0].Cells["ID"].Value;
                    new G_Membre(ChConn).Supprimer(N_ID);
                    BS_Membre.RemoveCurrent();
                }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (dtpNaissance.Text.Length == 0 || tbNom.Text.Length == 0 || tbPrenom.Text.Length == 0 || tbEquipe.Text.Length == 0 || tbMail.Text.Length == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }

            else
            {
                try
                {

                    if (Ajout == true) //Mode ajout
                    {
                        int N_ID = new G_Membre(ChConn).Ajouter(tbNom.Text, tbPrenom.Text, dtpNaissance.Value.Date, tbMail.Text, int.Parse(tbEquipe.Text), int.Parse(tbPoids.Text),int.Parse(tbTaille.Text));
                        DT_Membre.Rows.Add(N_ID, tbNom.Text, tbPrenom.Text, dtpNaissance.Text, tbMail.Text, tbEquipe.Text, tbPoids.Text, tbTaille.Text);
                    }

                    else //Mode édition
                    {
                        int N_ID = int.Parse(DGV_Membre.SelectedRows[0].Cells["ID"].Value.ToString());
                        new G_Membre(ChConn).Modifier(N_ID, tbNom.Text, tbPrenom.Text, dtpNaissance.Value.Date, tbMail.Text, int.Parse(tbEquipe.Text),int.Parse(tbPoids.Text),int.Parse(tbTaille.Text));

                        DGV_Membre.SelectedRows[0].Cells["ID"].Value = N_ID;
                        DGV_Membre.SelectedRows[0].Cells["Nom"].Value = tbNom.Text;
                        DGV_Membre.SelectedRows[0].Cells["Prénom"].Value = tbPrenom.Text;
                        DGV_Membre.SelectedRows[0].Cells["Naissance"].Value = dtpNaissance.Value.ToShortDateString();
                        DGV_Membre.SelectedRows[0].Cells["Mail"].Value = tbMail.Text;
                        DGV_Membre.SelectedRows[0].Cells["Equipe"].Value = tbEquipe.Text;
                        DGV_Membre.SelectedRows[0].Cells["Poids (kg)"].Value = tbPoids.Text;
                        DGV_Membre.SelectedRows[0].Cells["Taille (cm)"].Value = tbTaille.Text;

                        BS_Membre.EndEdit();
                    }

                    tbNom.Clear();
                    tbPrenom.Clear();
                    dtpNaissance.Value = DateTime.Today;
                    tbMail.Clear();
                    tbEquipe.Clear();

                    Activer(true);
                }

                catch
                {
                MessageBox.Show("Veuillez entrer un numéro d'équipe existant déjà dans la base de donnée", "Equipe inexistante");
                }

            }
     
        }

        #endregion

        #region inutile
        private void lblNom_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
