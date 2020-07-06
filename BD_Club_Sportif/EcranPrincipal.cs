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
using System.Threading;

namespace Projet_Club_Sportif_CouUti
{
    public partial class EcranPrincipal : Form
    {

        DataTable DT_Membre, DT_Equipe, DT_Match, DT_Entr, DT_Adv;
        BindingSource BS_Membre, BS_Equipe, BS_Match, BS_Entr, BS_Adv;

        private string ChConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\banon\OneDrive\Documents\IS2\Progra-event\Club_Sportif\Club_Sportif_MSSQL\BD_Club_Sportif.mdf;Integrated Security=True;Connect Timeout=30";

        public EcranPrincipal()
        {
            InitializeComponent();
            Remplir_DGV();
            tscbNom.SelectedIndex = 0; //Se lance avec le premier objet selectionner dans la combobox
            tscbID.SelectedIndex = 0;
        }

        void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Remplir_DGV();
        }

        public void Remplir_DGV() //Remplis les grid avec les données indiquées dans les tables
        {
            DT_Membre = new DataTable(); //initialise les tables
            DT_Equipe = new DataTable();
            DT_Match = new DataTable();
            DT_Entr = new DataTable();
            DT_Adv = new DataTable();

            List<C_Membre> lTmp_M = new G_Membre(ChConn).Lire("Nom");
            List<C_Equipe> lTmp_E = new G_Equipe(ChConn).Lire("ID"); //Liste equipe
            List<C_Adversaire> lTmp_A = new G_Adversaire(ChConn).Lire("ID"); //Liste adversaire
            List<C_Entrainement> lTmp_Entr = new G_Entrainement(ChConn).Lire("Periode"); //Liste entrainement
            List<C_Match> lTmp_Ma = new G_Match(ChConn).Lire("Evenement"); //Liste Match

            //ajoute colonne dans table equipe

            DT_Equipe.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32"))); 
            DT_Equipe.Columns.Add("Nom");

            foreach (C_Equipe Tmp in lTmp_E) //Ajout des infos dans la table equipe
                DT_Equipe.Rows.Add(Tmp.IdEquipe, Tmp.Nom);

            //ajoute colonne dans table membre

            DT_Membre.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Membre.Columns.Add("Nom");
            DT_Membre.Columns.Add("Prénom");
            DT_Membre.Columns.Add("Equipe");

            foreach (C_Membre Tmp in lTmp_M)
                DT_Membre.Rows.Add(Tmp.IdMembre, Tmp.Nom, Tmp.Prenom, Tmp.IdEquipe_membre);

            //ajoute colonne dans table adversaire

            DT_Adv.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Adv.Columns.Add("Nom");
            DT_Adv.Columns.Add("Rue");
            DT_Adv.Columns.Add("Numéro");
            DT_Adv.Columns.Add("Code Postale");
            DT_Adv.Columns.Add("Localité");
            DT_Adv.Columns.Add("Pays");

            foreach (C_Adversaire Tmp in lTmp_A)
                DT_Adv.Rows.Add(Tmp.IdAdv, Tmp.Nom, Tmp.Rue, Tmp.Numero, Tmp.Code_postale, Tmp.Localite, Tmp.Pays);

            //ajoute colonne dans table entrainement

            DT_Entr.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32"))); 
            DT_Entr.Columns.Add("Periode");
            DT_Entr.Columns.Add("Equipe");

            foreach (C_Entrainement Tmp in lTmp_Entr)
            {
               if(Math.Abs((Tmp.Periode - DateTime.Now).TotalDays) <= 7) //Ajoute la ligne seulement si la période d'entrainement à moins d'une semaine d'écart avec la date actuel

                    DT_Entr.Rows.Add(Tmp.IdEntr, Tmp.Periode, Tmp.IdEquipe_entr);
            }

            //ajoute colonne dans table match

            DT_Match.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Match.Columns.Add("Domicile ?");
            DT_Match.Columns.Add("Evenement");
            DT_Match.Columns.Add("Score Equipe");
            DT_Match.Columns.Add("Score Adversaire");
            DT_Match.Columns.Add("Equipe");
            DT_Match.Columns.Add("Adversaire");

            foreach (C_Match Tmp in lTmp_Ma)
            {
                if (Math.Abs((Tmp.Evenement - DateTime.Now).TotalDays) <= 7)

                    DT_Match.Rows.Add(Tmp.IdMatch, Tmp.Domicile, Tmp.Evenement, Tmp.Score_Club, Tmp.Score_Adv, Tmp.IdEquipe_Match, Tmp.IdAdv);
            }  

            BS_Membre = new BindingSource();
            BS_Equipe = new BindingSource();
            BS_Entr = new BindingSource();
            BS_Adv = new BindingSource();
            BS_Match = new BindingSource();

            BS_Membre.DataSource = DT_Membre;
            BS_Equipe.DataSource = DT_Equipe;
            BS_Adv.DataSource = DT_Adv;
            BS_Entr.DataSource = DT_Entr;
            BS_Match.DataSource = DT_Match;

            //Préparation des DGV

            DGV_Membre.DataSource = BS_Membre;
            DGV_Equipe.DataSource = BS_Equipe;
            DGV_Adv.DataSource = BS_Adv;
            DGV_Entr.DataSource = BS_Entr;
            DGV_Match.DataSource = BS_Match;

        }

        #region Bouton

        private void btnMembre_Click(object sender, EventArgs e)
        {
            EcranMembre f = new EcranMembre(ChConn);

            f.FormClosed += new FormClosedEventHandler(Form_FormClosed);

            f.ShowDialog();
        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {
            EcranEquipe f = new EcranEquipe(ChConn);

            f.FormClosed += new FormClosedEventHandler(Form_FormClosed);

            f.ShowDialog();
        }

        private void btnEntr_Click(object sender, EventArgs e)
        {
            EcranEntrainement f = new EcranEntrainement(ChConn);

            f.FormClosed += new FormClosedEventHandler(Form_FormClosed);

            f.ShowDialog();
        }

        private void btnAdv_Click(object sender, EventArgs e)
        {
            EcranAdversaire f = new EcranAdversaire(ChConn);

            f.FormClosed += new FormClosedEventHandler(Form_FormClosed);

            f.ShowDialog();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            EcranMatch f = new EcranMatch(ChConn);

            f.FormClosed += new FormClosedEventHandler(Form_FormClosed);

            f.ShowDialog();
        }

        private void ModifGrid()
        {
            DT_Match = new DataTable();
            BS_Match = new BindingSource();

            List<C_Match> lTmp_Ma = new G_Match(ChConn).Lire("Evenement"); //Liste Match

            DT_Match.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Match.Columns.Add("Domicile ?");
            DT_Match.Columns.Add("Evenement");
            DT_Match.Columns.Add("Score Equipe");
            DT_Match.Columns.Add("Score Adversaire");
            DT_Match.Columns.Add("Equipe");
            DT_Match.Columns.Add("Adversaire");

            foreach (C_Match Tmp in lTmp_Ma)
            {
                if ((Tmp.Evenement - DateTime.Now).TotalDays <= 7 && (Tmp.Evenement - DateTime.Now).TotalDays >= 0)

                    DT_Match.Rows.Add(Tmp.IdMatch, Tmp.Domicile, Tmp.Evenement, Tmp.Score_Club, Tmp.Score_Adv, Tmp.IdEquipe_Match, Tmp.IdAdv);
            }

            BS_Match.DataSource = DT_Match;
            DGV_Match.DataSource = BS_Match;

            //On remplis la grid uniquement avec les matchs se déroulant dans la semaine
        }

        private void GenererHtml()
        {
            //Table start
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

            //Ajout en tête
            html += "<tr>";
            foreach (DataGridViewColumn column in DGV_Match.Columns)
            {
                html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.HeaderText + "</th>";
            }
            html += "</tr>";

            //Ajout ligne.
            foreach (DataGridViewRow row in DGV_Match.Rows)
            {

                html += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    html += "<td style='width:120px;border: 1px solid #ccc'>" + cell.Value.ToString() + "</td>";
                }
                html += "</tr>";

            }

            //Table end
            html += "</table>";

            string file = "Programme.htm";

            string path = Path.GetFullPath(file); //Chemin complet

            File.WriteAllText(path, html); //Ecriture du fichier

            MessageBox.Show("Chemin du fichier : " + path, "Sauvegarde du fichier HTML"); //Affichage
        }

        private void tsbtnSavehtml_Click(object sender, EventArgs e) //Sauve les matchs sous html
        {
            Thread tHtml = new Thread(GenererHtml);
            ModifGrid();
            tHtml.Start();
            Remplir_DGV(); //Retour à la normal pour la grid utilisée
        }

        private void tsbtnOpen_Click(object sender, EventArgs e) //Ouverture de l'html match
        {
            string file = "Programme.htm";

            string path = Path.GetFullPath(file);

            EcranHtml f = new EcranHtml(path);

            f.FormClosed += new FormClosedEventHandler(Form_FormClosed);

            f.ShowDialog();
        }

        private void tsbSaveHtmlE_Click(object sender, EventArgs e) //Sauve les entrainements sous html
        {
            DT_Entr = new DataTable();
            BS_Entr = new BindingSource();

            List<C_Entrainement> lTmp_Entr = new G_Entrainement(ChConn).Lire("Periode"); //Liste entrainement

            DT_Entr.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Entr.Columns.Add("Periode");
            DT_Entr.Columns.Add("Equipe");

            foreach (C_Entrainement Tmp in lTmp_Entr)
            {
                if ((Tmp.Periode - DateTime.Now).TotalDays <= 7 && (Tmp.Periode - DateTime.Now).TotalDays >= 0)

                    DT_Entr.Rows.Add(Tmp.IdEntr, Tmp.Periode, Tmp.IdEquipe_entr);
            }

            BS_Entr.DataSource = DT_Entr;
            DGV_Entr.DataSource = BS_Entr;

            //On remplis la grid uniquement avec les entrainement se déroulant dans la semaine

            //Table start
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

            //Ajout en tête
            html += "<tr>";
            foreach (DataGridViewColumn column in DGV_Entr.Columns)
            {
                html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.HeaderText + "</th>";
            }
            html += "</tr>";

            //Ajout ligne.
            foreach (DataGridViewRow row in DGV_Entr.Rows)
            {

                html += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    html += "<td style='width:120px;border: 1px solid #ccc'>" + cell.Value.ToString() + "</td>";
                }
                html += "</tr>";

            }

            //Table end
            html += "</table>";

            string file = "Entrainement.htm";

            string path = Path.GetFullPath(file); //Chemin complet

            File.WriteAllText(path, html); //Ecriture du fichier

            MessageBox.Show("Chemin du fichier : " + path, "Sauvegarde du fichier HTML"); //Affichage

            Remplir_DGV(); //Retour à la normal pour la grid utilisée
        }

        private void tsbOpenE_Click(object sender, EventArgs e) //Ouverture de l'html entrainement
        {
            string file = "Entrainement.htm";

            string path = Path.GetFullPath(file);

            EcranHtml f = new EcranHtml(path);

            f.FormClosed += new FormClosedEventHandler(Form_FormClosed);

            f.ShowDialog();
        }

        #endregion

        #region filtre

        //Filtrage via Nom

        private void tstbNom_TextChanged(object sender, EventArgs e) //Si du texte est ajouté dans la textbox
        {
            if(tscbNom.Text == "Membre") //Si la textbox est sur Membre
            {
                DataView DV = new DataView(DT_Membre);
                DV.RowFilter = string.Format("Nom LIKE '%{0}%'", tstbNom.Text); //Filtrage selon le Nom en rapport avec le contenu de la textbox
                DGV_Membre.DataSource = DV;
            }

            else if(tscbNom.Text == "Equipe")
            {
                DataView DV = new DataView(DT_Equipe);
                DV.RowFilter = string.Format("Nom LIKE '%{0}%'", tstbNom.Text);
                DGV_Equipe.DataSource = DV;
            }

            else if(tscbNom.Text == "Adversaire")
            {
                DataView DV = new DataView(DT_Adv);
                DV.RowFilter = string.Format("Nom LIKE '%{0}%'", tstbNom.Text);
                DGV_Adv.DataSource = DV;
            }

        }

        private void tscbNom_DropDownClosed(object sender, EventArgs e) //Reset les grids et la textbox lorsque l'on modifie la combobox
        {
            Remplir_DGV();
            tstbNom.Text = "";
        }

        //Filtrage via ID

        private void tstbID_TextChanged(object sender, EventArgs e)
        {
            int parsedValue; //Variable int de test

            if (int.TryParse(tstbID.Text, out parsedValue)) //Si la textbox contient que des nombres
            {

                if (tscbID.Text == "Equipe")
                {
                    DataView DV_Equipe = new DataView(DT_Equipe);
                    DataView DV_Membre = new DataView(DT_Membre);
                    DataView DV_Entr = new DataView(DT_Entr);
                    DataView DV_Match = new DataView(DT_Match);
                    DV_Equipe.RowFilter = "ID = " + Int32.Parse(tstbID.Text); //Filtrage selon int encoder
                    DV_Membre.RowFilter = "Equipe = " + Int32.Parse(tstbID.Text);
                    DV_Entr.RowFilter = "Equipe = " + Int32.Parse(tstbID.Text);
                    DV_Match.RowFilter = "Equipe = " + Int32.Parse(tstbID.Text);

                    DGV_Equipe.DataSource = DV_Equipe;
                    DGV_Membre.DataSource = DV_Membre;
                    DGV_Entr.DataSource = DV_Entr;
                    DGV_Match.DataSource = DV_Match;
                }

                else if (tscbID.Text == "Adversaire")
                {
                    DataView DV_Adv = new DataView(DT_Adv);
                    DataView DV_Match = new DataView(DT_Match);
                    DV_Adv.RowFilter = "ID = " + Int32.Parse(tstbID.Text);
                    DV_Match.RowFilter = "Adversaire = " + Int32.Parse(tstbID.Text);

                    DGV_Adv.DataSource = DV_Adv;
                    DGV_Match.DataSource = DV_Match;
                }
            }

            else //Si la textbox ne contient pas que des nombres, on reset le filtre
            {
                Remplir_DGV();
            }
        }

        private void tscbID_DropDownClosed(object sender, EventArgs e) //Reset les grids et la textbox lorsque l'on modifie la combobox
        {
            Remplir_DGV();
            tstbID.Text = "";
        }

        #endregion
    }
}
