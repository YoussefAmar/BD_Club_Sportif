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
    public partial class EcranMatch : Form
    {
        DataTable DT_Match;
        BindingSource BS_Match;
        string ChConn;
        bool Ajout = false;

        public EcranMatch(string chaine)
        {
            InitializeComponent();
            ChConn = chaine;
            RemplirDGV();
            Activer(true);
        }

        private void RemplirDGV() //Affichage des Matchs
        {
            DT_Match = new DataTable();
            DT_Match.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Match.Columns.Add("Domicile ?");
            DT_Match.Columns.Add("Evenement");
            DT_Match.Columns.Add("Score Equipe");
            DT_Match.Columns.Add("Score Adversaire");
            DT_Match.Columns.Add("Equipe");
            DT_Match.Columns.Add("Adversaire");

            List<C_Match> lTmp_M = new G_Match(ChConn).Lire("Evenement");

            foreach (C_Match Tmp in lTmp_M)
                DT_Match.Rows.Add(Tmp.IdMatch, Tmp.Domicile, Tmp.Evenement, Tmp.Score_Club, Tmp.Score_Adv, Tmp.IdEquipe_Match, Tmp.IdAdv);

            BS_Match = new BindingSource { DataSource = DT_Match };
            DGV_Match.DataSource = BS_Match;
        }

        private void Activer(bool Actif)
        {
            DGV_Match.Enabled = btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = Actif;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !Actif;

            cbDomicile.Enabled = nudEquipe.Enabled = nudAdv.Enabled = tbEquipe.Enabled = tbAdv.Enabled = dtpEvent.Enabled = !Actif;

            if (Actif)
                DGV_Match.Focus();
            else
                dtpEvent.Focus();
        }

        #region Evenement

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);

            cbDomicile.Text = tbEquipe.Text = tbAdv.Text = "" ;

            nudAdv.Value = nudEquipe.Value = 0;

            dtpEvent.Value = DateTime.Today;

            Ajout = true;
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            Activer(false);

            cbDomicile.Text = tbEquipe.Text = tbAdv.Text = "";

            nudAdv.Value = nudEquipe.Value = 0;

            dtpEvent.Value = DateTime.Today;

            Ajout = true;

            if (DGV_Match.SelectedRows.Count > 0)
            {
                Activer(false);

                C_Match Tmp = new G_Match(ChConn).Lire_ID(int.Parse(DGV_Match.SelectedRows[0].Cells["ID"].Value.ToString()));

                nudAdv.Value = Convert.ToDecimal(Tmp.Score_Adv);
                nudEquipe.Value = Convert.ToDecimal(Tmp.Score_Club);
                tbEquipe.Text = Tmp.IdEquipe_Match.ToString(); 
                tbAdv.Text = Tmp.IdAdv.ToString();
                dtpEvent.Text = Tmp.Evenement.ToString();
                cbDomicile.Text = Tmp.Domicile.ToString();

                Ajout = false;
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (DGV_Match.SelectedRows.Count > 0)
            {
                int N_ID = (int)DGV_Match.SelectedRows[0].Cells["ID"].Value;
                new G_Match(ChConn).Supprimer(N_ID);
                BS_Match.RemoveCurrent();
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if(DateTime.Compare(dtpEvent.Value, DateTime.Now) > 0)
            {
                nudAdv.Value = nudEquipe.Value = 0;   
            }

            if (dtpEvent.Text.Length == 0 || tbAdv.Text.Length == 0 || cbDomicile.Text == "" || tbEquipe.Text.Length == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }

            else
            {
                try
                {

                    if (Ajout == true) //Mode ajout
                    {
                        int N_ID = new G_Match(ChConn).Ajouter(bool.Parse(cbDomicile.Text), dtpEvent.Value, Convert.ToInt32(nudAdv.Value), Convert.ToInt32(nudEquipe.Value), int.Parse(tbEquipe.Text), int.Parse(tbAdv.Text));
                        DT_Match.Rows.Add(N_ID, cbDomicile.Text, dtpEvent.Text, nudAdv.Value, nudEquipe.Value, tbEquipe.Text, tbAdv.Text);
                    }

                    else //Mode édition
                    {
                        int N_ID = int.Parse(DGV_Match.SelectedRows[0].Cells["ID"].Value.ToString());
                        new G_Match(ChConn).Modifier(N_ID, bool.Parse(cbDomicile.Text), dtpEvent.Value, Convert.ToInt32(nudAdv.Value), Convert.ToInt32(nudEquipe.Value), int.Parse(tbEquipe.Text), int.Parse(tbAdv.Text));

                        DGV_Match.SelectedRows[0].Cells["ID"].Value = N_ID;
                        DGV_Match.SelectedRows[0].Cells["Domicile ?"].Value = cbDomicile.Text;
                        DGV_Match.SelectedRows[0].Cells["Evenement"].Value = dtpEvent.Text;
                        DGV_Match.SelectedRows[0].Cells["Score Adversaire"].Value = Convert.ToInt32(nudAdv.Value);
                        DGV_Match.SelectedRows[0].Cells["Score Equipe"].Value = Convert.ToInt32(nudEquipe.Value);
                        DGV_Match.SelectedRows[0].Cells["Equipe"].Value = tbEquipe.Text;
                        DGV_Match.SelectedRows[0].Cells["Adversaire"].Value = tbAdv.Text;

                        BS_Match.EndEdit();
                    }

                    cbDomicile.SelectedIndex = -1;
                    nudAdv.Value = 0;
                    nudEquipe.Value = 0;
                    dtpEvent.Value = DateTime.Today;
                    tbAdv.Clear();
                    tbEquipe.Clear();

                    Activer(true);
                }

                catch
                {
                    MessageBox.Show("Veuillez entrer un numéro d'équipe et/ou d'adversaire existant déjà dans la base de donnée", "Erreur d'encodage");
                }

            }

        }

        #endregion

    }
}
