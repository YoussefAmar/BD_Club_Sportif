namespace Projet_Club_Sportif_CouUti
{
    partial class EcranAdversaire
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
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.lblRue = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.DGV_Adversaire = new System.Windows.Forms.DataGridView();
            this.tbPays = new System.Windows.Forms.TextBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.tbLocalite = new System.Windows.Forms.TextBox();
            this.lblLocalite = new System.Windows.Forms.Label();
            this.tbPostal = new System.Windows.Forms.TextBox();
            this.lblPostal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Adversaire)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(32, 583);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(229, 26);
            this.tbNumero.TabIndex = 37;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumero.Location = new System.Drawing.Point(28, 556);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(84, 24);
            this.lblNumero.TabIndex = 36;
            this.lblNumero.Text = "Numéro";
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(31, 503);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(229, 26);
            this.tbRue.TabIndex = 35;
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblRue.Location = new System.Drawing.Point(28, 476);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(47, 24);
            this.lblRue.TabIndex = 34;
            this.lblRue.Text = "Rue";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(31, 424);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(229, 26);
            this.tbNom.TabIndex = 33;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblNom.Location = new System.Drawing.Point(33, 397);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(53, 24);
            this.lblNom.TabIndex = 32;
            this.lblNom.Text = "Nom";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSupprimer.Location = new System.Drawing.Point(853, 476);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(142, 59);
            this.btnSupprimer.TabIndex = 31;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnEditer.Location = new System.Drawing.Point(703, 556);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(142, 59);
            this.btnEditer.TabIndex = 30;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAjouter.Location = new System.Drawing.Point(703, 476);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(142, 59);
            this.btnAjouter.TabIndex = 29;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAnnuler.Location = new System.Drawing.Point(853, 397);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(142, 59);
            this.btnAnnuler.TabIndex = 28;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnConfirmer.Location = new System.Drawing.Point(703, 397);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(142, 59);
            this.btnConfirmer.TabIndex = 27;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // DGV_Adversaire
            // 
            this.DGV_Adversaire.AllowUserToAddRows = false;
            this.DGV_Adversaire.AllowUserToDeleteRows = false;
            this.DGV_Adversaire.AllowUserToResizeRows = false;
            this.DGV_Adversaire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Adversaire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Adversaire.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_Adversaire.ColumnHeadersHeight = 30;
            this.DGV_Adversaire.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_Adversaire.Location = new System.Drawing.Point(31, 4);
            this.DGV_Adversaire.Name = "DGV_Adversaire";
            this.DGV_Adversaire.ReadOnly = true;
            this.DGV_Adversaire.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Adversaire.RowHeadersVisible = false;
            this.DGV_Adversaire.RowTemplate.Height = 28;
            this.DGV_Adversaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Adversaire.Size = new System.Drawing.Size(958, 367);
            this.DGV_Adversaire.TabIndex = 26;
            // 
            // tbPays
            // 
            this.tbPays.Location = new System.Drawing.Point(381, 583);
            this.tbPays.Name = "tbPays";
            this.tbPays.Size = new System.Drawing.Size(229, 26);
            this.tbPays.TabIndex = 43;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPays.Location = new System.Drawing.Point(377, 556);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(56, 24);
            this.lblPays.TabIndex = 42;
            this.lblPays.Text = "Pays";
            // 
            // tbLocalite
            // 
            this.tbLocalite.Location = new System.Drawing.Point(380, 503);
            this.tbLocalite.Name = "tbLocalite";
            this.tbLocalite.Size = new System.Drawing.Size(229, 26);
            this.tbLocalite.TabIndex = 41;
            // 
            // lblLocalite
            // 
            this.lblLocalite.AutoSize = true;
            this.lblLocalite.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocalite.Location = new System.Drawing.Point(377, 476);
            this.lblLocalite.Name = "lblLocalite";
            this.lblLocalite.Size = new System.Drawing.Size(84, 24);
            this.lblLocalite.TabIndex = 40;
            this.lblLocalite.Text = "Localité";
            // 
            // tbPostal
            // 
            this.tbPostal.Location = new System.Drawing.Point(380, 424);
            this.tbPostal.Name = "tbPostal";
            this.tbPostal.Size = new System.Drawing.Size(229, 26);
            this.tbPostal.TabIndex = 39;
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPostal.Location = new System.Drawing.Point(382, 397);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(123, 24);
            this.lblPostal.TabIndex = 38;
            this.lblPostal.Text = "Code postal";
            // 
            // EcranAdversaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1043, 668);
            this.Controls.Add(this.tbPays);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.tbLocalite);
            this.Controls.Add(this.lblLocalite);
            this.Controls.Add(this.tbPostal);
            this.Controls.Add(this.lblPostal);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.tbRue);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.DGV_Adversaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranAdversaire";
            this.ShowIcon = false;
            this.Text = "Table Adversaire";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Adversaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.DataGridView DGV_Adversaire;
        private System.Windows.Forms.TextBox tbPays;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.TextBox tbLocalite;
        private System.Windows.Forms.Label lblLocalite;
        private System.Windows.Forms.TextBox tbPostal;
        private System.Windows.Forms.Label lblPostal;
    }
}