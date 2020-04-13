namespace Projet_Club_Sportif_CouUti
{
    partial class EcranMembre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Membre = new System.Windows.Forms.DataGridView();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.lblNaissance = new System.Windows.Forms.Label();
            this.tbEquipe = new System.Windows.Forms.TextBox();
            this.lblEquipe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Membre)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Membre
            // 
            this.DGV_Membre.AllowUserToAddRows = false;
            this.DGV_Membre.AllowUserToDeleteRows = false;
            this.DGV_Membre.AllowUserToResizeRows = false;
            this.DGV_Membre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Membre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Membre.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_Membre.ColumnHeadersHeight = 30;
            this.DGV_Membre.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_Membre.Location = new System.Drawing.Point(27, 12);
            this.DGV_Membre.Name = "DGV_Membre";
            this.DGV_Membre.ReadOnly = true;
            this.DGV_Membre.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Membre.RowHeadersVisible = false;
            this.DGV_Membre.RowTemplate.Height = 28;
            this.DGV_Membre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Membre.Size = new System.Drawing.Size(958, 367);
            this.DGV_Membre.TabIndex = 5;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnConfirmer.Location = new System.Drawing.Point(699, 405);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(142, 59);
            this.btnConfirmer.TabIndex = 6;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAnnuler.Location = new System.Drawing.Point(849, 405);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(142, 59);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAjouter.Location = new System.Drawing.Point(699, 484);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(142, 59);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnEditer.Location = new System.Drawing.Point(699, 564);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(142, 59);
            this.btnEditer.TabIndex = 10;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSupprimer.Location = new System.Drawing.Point(849, 484);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(142, 59);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblNom.Location = new System.Drawing.Point(29, 440);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(53, 24);
            this.lblNom.TabIndex = 16;
            this.lblNom.Text = "Nom";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(27, 467);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(229, 26);
            this.tbNom.TabIndex = 17;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(27, 546);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(229, 26);
            this.tbPrenom.TabIndex = 19;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrenom.Location = new System.Drawing.Point(24, 519);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(83, 24);
            this.lblPrenom.TabIndex = 18;
            this.lblPrenom.Text = "Prénom";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(28, 626);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(229, 26);
            this.tbMail.TabIndex = 21;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMail.Location = new System.Drawing.Point(29, 599);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(48, 24);
            this.lblMail.TabIndex = 20;
            this.lblMail.Text = "Mail";
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.CustomFormat = "dd/MM/yyyy";
            this.dtpNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNaissance.Location = new System.Drawing.Point(402, 467);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(245, 26);
            this.dtpNaissance.TabIndex = 22;
            // 
            // lblNaissance
            // 
            this.lblNaissance.AutoSize = true;
            this.lblNaissance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblNaissance.Location = new System.Drawing.Point(403, 440);
            this.lblNaissance.Name = "lblNaissance";
            this.lblNaissance.Size = new System.Drawing.Size(185, 24);
            this.lblNaissance.TabIndex = 23;
            this.lblNaissance.Text = "Date de Naissance";
            // 
            // tbEquipe
            // 
            this.tbEquipe.Location = new System.Drawing.Point(403, 546);
            this.tbEquipe.Name = "tbEquipe";
            this.tbEquipe.Size = new System.Drawing.Size(229, 26);
            this.tbEquipe.TabIndex = 25;
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEquipe.Location = new System.Drawing.Point(403, 519);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(155, 24);
            this.lblEquipe.TabIndex = 24;
            this.lblEquipe.Text = "Numéro Equipe";
            // 
            // EcranMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1003, 700);
            this.Controls.Add(this.tbEquipe);
            this.Controls.Add(this.lblEquipe);
            this.Controls.Add(this.lblNaissance);
            this.Controls.Add(this.dtpNaissance);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.DGV_Membre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranMembre";
            this.ShowIcon = false;
            this.Text = "EcranMembre";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Membre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Membre;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.TextBox tbEquipe;
        private System.Windows.Forms.Label lblEquipe;
    }
}