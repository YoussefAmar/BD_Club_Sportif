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
    public partial class EcranAdversaire : Form
    {
        DataTable DT_Adv;
        BindingSource BS_Adv;
        string ChConn;
        bool Ajout = false;

        public EcranAdversaire(string chaine)
        {
            InitializeComponent();
            ChConn = chaine;
            RemplirDGV();
            Activer(true);
        }

        private void RemplirDGV() //Remplissage des adversaires
        {
            DT_Adv = new DataTable();
            DT_Adv.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Adv.Columns.Add("Nom");
            DT_Adv.Columns.Add("Rue");
            DT_Adv.Columns.Add("Numéro");
            DT_Adv.Columns.Add("Code postal");
            DT_Adv.Columns.Add("Localité");
            DT_Adv.Columns.Add("Pays");

            List<C_Adversaire> lTmp_Adv = new G_Adversaire(ChConn).Lire("ID");

            foreach (C_Adversaire Tmp in lTmp_Adv)
                DT_Adv.Rows.Add(Tmp.IdAdv, Tmp.Nom, Tmp.Rue, Tmp.Numero, Tmp.Code_postale, Tmp.Localite, Tmp.Pays);

            BS_Adv = new BindingSource { DataSource = DT_Adv };
            DGV_Adversaire.DataSource = BS_Adv;
        }

        private void Activer(bool Actif) //Activation des boutons/box
        {
            DGV_Adversaire.Enabled = btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = Actif;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !Actif;

            tbNom.Enabled = tbRue.Enabled = tbNumero.Enabled = tbPostal.Enabled = tbLocalite.Enabled = tbPays.Enabled = !Actif;

            if (Actif)
                DGV_Adversaire.Focus();
            else
                tbNom.Focus();
        }

        #region Evenement

        private void btnAjouter_Click(object sender, EventArgs e) //Bouton ajouter
        {
            Activer(false);

            tbNom.Text = tbRue.Text = tbNumero.Text = tbPostal.Text = tbLocalite.Text = tbPays.Text = "";

            Ajout = true;
        }

        private void btnEditer_Click(object sender, EventArgs e) //Edition des infos
        {
            Activer(false);

            tbNom.Text = tbRue.Text = tbNumero.Text = tbPostal.Text = tbLocalite.Text = tbPays.Text = "";

            Ajout = true;

            if (DGV_Adversaire.SelectedRows.Count > 0)
            {
                Activer(false);
                C_Adversaire Tmp = new G_Adversaire(ChConn).Lire_ID(int.Parse(DGV_Adversaire.SelectedRows[0].Cells["ID"].Value.ToString()));
                tbNom.Text = Tmp.Nom;
                tbRue.Text = Tmp.Rue;
                tbNumero.Text = Tmp.Numero.ToString();
                tbPostal.Text = Tmp.Code_postale.ToString();
                tbLocalite.Text = Tmp.Localite;
                tbPays.Text = Tmp.Pays;

                Ajout = false;
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e) //Supprime la ligne selectionner
        {
            try
            {
                if (DGV_Adversaire.SelectedRows.Count > 0)
                {
                    int N_ID = (int)DGV_Adversaire.SelectedRows[0].Cells["ID"].Value;
                    new G_Adversaire(ChConn).Supprimer(N_ID);
                    BS_Adv.RemoveCurrent();
                }
            }

            catch
            {
                MessageBox.Show("Suppression impossible, cet adversaire est utilisé dans une autre table", "Erreur de suppression");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void btnConfirmer_Click(object sender, EventArgs e) //confirmation Ajout ou edition d'infos 
        {
            if (tbPays.Text == "")
            {
                tbPays.Text = "Belgique";
            }

            if (tbNom.Text.Length == 0 || tbRue.Text.Length == 0 || tbNumero.Text.Length == 0 || tbLocalite.Text.Length == 0 || tbPostal.Text.Length == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }         

            else
            {
                if (Ajout == true) //Mode ajout
                {
                    int N_ID = new G_Adversaire(ChConn).Ajouter(tbNom.Text,tbRue.Text, int.Parse(tbNumero.Text), int.Parse(tbPostal.Text), tbLocalite.Text, tbPays.Text);
                    DT_Adv.Rows.Add(N_ID, tbNom.Text, tbRue.Text, int.Parse(tbNumero.Text), int.Parse(tbPostal.Text), tbLocalite.Text, tbPays.Text);
                }
                else //Mode édition
                {
                    int N_ID = int.Parse(DGV_Adversaire.SelectedRows[0].Cells["ID"].Value.ToString());
                    new G_Adversaire(ChConn).Modifier(N_ID, tbNom.Text, tbRue.Text, int.Parse(tbNumero.Text), int.Parse(tbPostal.Text), tbLocalite.Text, tbPays.Text);

                    DGV_Adversaire.SelectedRows[0].Cells["ID"].Value = N_ID;
                    DGV_Adversaire.SelectedRows[0].Cells["Nom"].Value = tbNom.Text;
                    DGV_Adversaire.SelectedRows[0].Cells["Rue"].Value = tbRue.Text;
                    DGV_Adversaire.SelectedRows[0].Cells["Numéro"].Value = int.Parse(tbNumero.Text);
                    DGV_Adversaire.SelectedRows[0].Cells["Code postal"].Value = int.Parse(tbPostal.Text);
                    DGV_Adversaire.SelectedRows[0].Cells["Localité"].Value = tbLocalite.Text;
                    DGV_Adversaire.SelectedRows[0].Cells["Pays"].Value = tbPays.Text;

                    BS_Adv.EndEdit();
                }

                tbNom.Clear();
                tbRue.Clear();
                tbNumero.Clear();
                tbPostal.Clear();
                tbLocalite.Clear();
                tbPays.Clear();

                Activer(true);
            }
        }


        #endregion

    }
}
