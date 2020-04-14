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
    public partial class EcranEquipe : Form
    {
        DataTable DT_Equipe;
        BindingSource BS_Equipe;
        string ChConn;
        bool Ajout = false;

        public EcranEquipe(string chaine)
        {
            InitializeComponent();
            ChConn = chaine;
            RemplirDGV();
            Activer(true);
        }

        private void RemplirDGV() //Remplissage des équipes
        {
            DT_Equipe = new DataTable();
            DT_Equipe.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Equipe.Columns.Add("Nom");

            List<C_Equipe> lTmp_E = new G_Equipe(ChConn).Lire("ID");
            foreach (C_Equipe Tmp in lTmp_E)
                DT_Equipe.Rows.Add(Tmp.IdEquipe, Tmp.Nom);

            BS_Equipe = new BindingSource { DataSource = DT_Equipe };
            DGV_Equipe.DataSource = BS_Equipe;
        }

        private void Activer(bool Actif) //Activation des boutons/box
        {
            DGV_Equipe.Enabled = btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = Actif;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !Actif;

            tbNom.Enabled = !Actif;

            if (Actif)
                DGV_Equipe.Focus();
            else
                tbNom.Focus();
        }

        #region Evenement

        private void btnAjouter_Click(object sender, EventArgs e) //Bouton ajouter
        {
            Activer(false);

            tbNom.Text = "";

            Ajout = true;
        }

        private void btnEditer_Click(object sender, EventArgs e) //Edition des infos
        {
            Activer(false);

            tbNom.Text = "";

            Ajout = true;

            if (DGV_Equipe.SelectedRows.Count > 0)
            {
                Activer(false);
                C_Equipe Tmp = new G_Equipe(ChConn).Lire_ID(int.Parse(DGV_Equipe.SelectedRows[0].Cells["ID"].Value.ToString()));
                tbNom.Text = Tmp.Nom;

                Ajout = false;
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e) //Supprime la ligne selectionner
        {
            try
            {
                if (DGV_Equipe.SelectedRows.Count > 0)
                {
                    int N_ID = (int)DGV_Equipe.SelectedRows[0].Cells["ID"].Value;
                    new G_Equipe(ChConn).Supprimer(N_ID);
                    BS_Equipe.RemoveCurrent();
                }
            }

            catch
            {
                MessageBox.Show("Suppression impossible, cette équipe est utilisée dans une autre table", "Erreur de suppression");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void btnConfirmer_Click(object sender, EventArgs e) //confirmation Ajout ou edition d'infos 
        {
            if (tbNom.Text.Length == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }

            else
            {
                if (Ajout == true) //Mode ajout
                {
                    int N_ID = new G_Equipe(ChConn).Ajouter(tbNom.Text);
                    DT_Equipe.Rows.Add(N_ID, tbNom.Text);
                }
                else //Mode édition
                {
                    int N_ID = int.Parse(DGV_Equipe.SelectedRows[0].Cells["ID"].Value.ToString());
                    new G_Equipe(ChConn).Modifier(N_ID, tbNom.Text);

                    DGV_Equipe.SelectedRows[0].Cells["ID"].Value = N_ID;
                    DGV_Equipe.SelectedRows[0].Cells["Nom"].Value = tbNom.Text;
                    
                    BS_Equipe.EndEdit();
                }

                tbNom.Clear();

                Activer(true);
            }
        }

        #endregion
    }
}
