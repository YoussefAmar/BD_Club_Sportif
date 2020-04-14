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
    public partial class EcranEntrainement : Form
    {
        DataTable DT_Entr;
        BindingSource BS_Entr;
        string ChConn;
        bool Ajout = false;

        public EcranEntrainement(string chaine)
        {
            InitializeComponent();
            ChConn = chaine;
            RemplirDGV();
            Activer(true);
        }

        private void RemplirDGV() //Remplissage des équipes
        {
            DT_Entr = new DataTable();
            DT_Entr.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Entr.Columns.Add("Periode");
            DT_Entr.Columns.Add("Equipe");

            List<C_Entrainement> lTmp_Entr = new G_Entrainement(ChConn).Lire("Periode");

            foreach (C_Entrainement Tmp in lTmp_Entr)
                DT_Entr.Rows.Add(Tmp.IdEntr, Tmp.Periode, Tmp.IdEquipe_entr);

            BS_Entr = new BindingSource { DataSource = DT_Entr };
            DGV_Entr.DataSource = BS_Entr;
        }

        private void Activer(bool Actif) //Activation des boutons/box
        {
            DGV_Entr.Enabled = btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = Actif;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !Actif;

            tbEquipe.Enabled = dtpPeriode.Enabled = !Actif;

            if (Actif)
                DGV_Entr.Focus();
            else
                tbEquipe.Focus();
        }

        #region Evenement

        private void btnAjouter_Click(object sender, EventArgs e) //Bouton ajouter
        {
            Activer(false);

            tbEquipe.Text = "";

            dtpPeriode.Value = DateTime.Today;

            Ajout = true;
        }

        private void btnEditer_Click(object sender, EventArgs e) //Edition des infos
        {
            Activer(false);

            tbEquipe.Text = "";

            dtpPeriode.Value = DateTime.Today;

            Ajout = true;

            if (DGV_Entr.SelectedRows.Count > 0)
            {
                Activer(false);
                C_Entrainement Tmp = new G_Entrainement(ChConn).Lire_ID(int.Parse(DGV_Entr.SelectedRows[0].Cells["ID"].Value.ToString()));
                dtpPeriode.Text = Tmp.Periode.ToString();
                tbEquipe.Text = Tmp.IdEquipe_entr.ToString();

                Ajout = false;
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e) //Supprime la ligne selectionner
        {
                if (DGV_Entr.SelectedRows.Count > 0)
                {
                    int N_ID = (int)DGV_Entr.SelectedRows[0].Cells["ID"].Value;
                    new G_Entrainement(ChConn).Supprimer(N_ID);
                    BS_Entr.RemoveCurrent();
                }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void btnConfirmer_Click(object sender, EventArgs e) //confirmation Ajout ou edition d'infos 
        {
            if (tbEquipe.Text.Length == 0 || dtpPeriode.Text.Length == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }

            else
            {
                try
                {
                    if (Ajout == true) //Mode ajout
                    {
                        int N_ID = new G_Entrainement(ChConn).Ajouter(dtpPeriode.Value, int.Parse(tbEquipe.Text));
                        DT_Entr.Rows.Add(N_ID,dtpPeriode.Text, tbEquipe.Text);
                    }

                    else //Mode édition
                    {
                        int N_ID = int.Parse(DGV_Entr.SelectedRows[0].Cells["ID"].Value.ToString());
                        new G_Entrainement(ChConn).Modifier(N_ID, dtpPeriode.Value, int.Parse(tbEquipe.Text));

                        DGV_Entr.SelectedRows[0].Cells["ID"].Value = N_ID;
                        DGV_Entr.SelectedRows[0].Cells["Periode"].Value = dtpPeriode.Text;
                        DGV_Entr.SelectedRows[0].Cells["Equipe"].Value = tbEquipe.Text;

                        BS_Entr.EndEdit();
                    }

                    dtpPeriode.Value = DateTime.Today;
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

    }
}
