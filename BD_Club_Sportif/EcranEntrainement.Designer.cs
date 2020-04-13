namespace Projet_Club_Sportif_CouUti
{
    partial class EcranEntrainement
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
            this.lblPeriode = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.DGV_Entr = new System.Windows.Forms.DataGridView();
            this.tbEquipe = new System.Windows.Forms.TextBox();
            this.lblEquipe = new System.Windows.Forms.Label();
            this.dtpPeriode = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Entr)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPeriode.Location = new System.Drawing.Point(68, 419);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(82, 24);
            this.lblPeriode.TabIndex = 40;
            this.lblPeriode.Text = "Periode";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSupprimer.Location = new System.Drawing.Point(85, 594);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(142, 59);
            this.btnSupprimer.TabIndex = 39;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnEditer.Location = new System.Drawing.Point(381, 514);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(142, 59);
            this.btnEditer.TabIndex = 38;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAjouter.Location = new System.Drawing.Point(233, 514);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(142, 59);
            this.btnAjouter.TabIndex = 37;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAnnuler.Location = new System.Drawing.Point(233, 594);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(142, 59);
            this.btnAnnuler.TabIndex = 36;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnConfirmer.Location = new System.Drawing.Point(85, 514);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(142, 59);
            this.btnConfirmer.TabIndex = 35;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // DGV_Entr
            // 
            this.DGV_Entr.AllowUserToAddRows = false;
            this.DGV_Entr.AllowUserToDeleteRows = false;
            this.DGV_Entr.AllowUserToResizeRows = false;
            this.DGV_Entr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Entr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Entr.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_Entr.ColumnHeadersHeight = 30;
            this.DGV_Entr.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_Entr.Location = new System.Drawing.Point(72, 12);
            this.DGV_Entr.Name = "DGV_Entr";
            this.DGV_Entr.ReadOnly = true;
            this.DGV_Entr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Entr.RowHeadersVisible = false;
            this.DGV_Entr.RowTemplate.Height = 28;
            this.DGV_Entr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Entr.Size = new System.Drawing.Size(527, 367);
            this.DGV_Entr.TabIndex = 34;
            // 
            // tbEquipe
            // 
            this.tbEquipe.Location = new System.Drawing.Point(364, 446);
            this.tbEquipe.Name = "tbEquipe";
            this.tbEquipe.Size = new System.Drawing.Size(229, 26);
            this.tbEquipe.TabIndex = 43;
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEquipe.Location = new System.Drawing.Point(366, 419);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(75, 24);
            this.lblEquipe.TabIndex = 42;
            this.lblEquipe.Text = "Equipe";
            // 
            // dtpPeriode
            // 
            this.dtpPeriode.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriode.Location = new System.Drawing.Point(72, 444);
            this.dtpPeriode.Name = "dtpPeriode";
            this.dtpPeriode.Size = new System.Drawing.Size(245, 26);
            this.dtpPeriode.TabIndex = 44;
            // 
            // EcranEntrainement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(674, 669);
            this.Controls.Add(this.dtpPeriode);
            this.Controls.Add(this.tbEquipe);
            this.Controls.Add(this.lblEquipe);
            this.Controls.Add(this.lblPeriode);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.DGV_Entr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranEntrainement";
            this.ShowIcon = false;
            this.Text = "EcranEntrainement";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Entr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.DataGridView DGV_Entr;
        private System.Windows.Forms.TextBox tbEquipe;
        private System.Windows.Forms.Label lblEquipe;
        private System.Windows.Forms.DateTimePicker dtpPeriode;
    }
}