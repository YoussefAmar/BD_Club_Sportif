namespace Projet_Club_Sportif_CouUti
{
    partial class EcranMatch
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
            this.tbAdv = new System.Windows.Forms.TextBox();
            this.lblAdv = new System.Windows.Forms.Label();
            this.tbEquipe = new System.Windows.Forms.TextBox();
            this.lblEquipe = new System.Windows.Forms.Label();
            this.lblScore_Equipe = new System.Windows.Forms.Label();
            this.lblScore_Adv = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblDomicile = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.DGV_Match = new System.Windows.Forms.DataGridView();
            this.dtpEvent = new System.Windows.Forms.DateTimePicker();
            this.nudEquipe = new System.Windows.Forms.NumericUpDown();
            this.nudAdv = new System.Windows.Forms.NumericUpDown();
            this.cbDomicile = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdv)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAdv
            // 
            this.tbAdv.Location = new System.Drawing.Point(384, 585);
            this.tbAdv.Name = "tbAdv";
            this.tbAdv.Size = new System.Drawing.Size(229, 26);
            this.tbAdv.TabIndex = 61;
            // 
            // lblAdv
            // 
            this.lblAdv.AutoSize = true;
            this.lblAdv.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdv.Location = new System.Drawing.Point(380, 558);
            this.lblAdv.Name = "lblAdv";
            this.lblAdv.Size = new System.Drawing.Size(111, 24);
            this.lblAdv.TabIndex = 60;
            this.lblAdv.Text = "Adversaire";
            // 
            // tbEquipe
            // 
            this.tbEquipe.Location = new System.Drawing.Point(383, 505);
            this.tbEquipe.Name = "tbEquipe";
            this.tbEquipe.Size = new System.Drawing.Size(229, 26);
            this.tbEquipe.TabIndex = 59;
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEquipe.Location = new System.Drawing.Point(380, 478);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(75, 24);
            this.lblEquipe.TabIndex = 58;
            this.lblEquipe.Text = "Equipe";
            // 
            // lblScore_Equipe
            // 
            this.lblScore_Equipe.AutoSize = true;
            this.lblScore_Equipe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblScore_Equipe.Location = new System.Drawing.Point(31, 558);
            this.lblScore_Equipe.Name = "lblScore_Equipe";
            this.lblScore_Equipe.Size = new System.Drawing.Size(134, 24);
            this.lblScore_Equipe.TabIndex = 56;
            this.lblScore_Equipe.Text = "Score équipe";
            // 
            // lblScore_Adv
            // 
            this.lblScore_Adv.AutoSize = true;
            this.lblScore_Adv.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblScore_Adv.Location = new System.Drawing.Point(379, 399);
            this.lblScore_Adv.Name = "lblScore_Adv";
            this.lblScore_Adv.Size = new System.Drawing.Size(170, 24);
            this.lblScore_Adv.TabIndex = 54;
            this.lblScore_Adv.Text = "Score adversaire";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEvent.Location = new System.Drawing.Point(31, 478);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(53, 24);
            this.lblEvent.TabIndex = 52;
            this.lblEvent.Text = "Date";
            // 
            // lblDomicile
            // 
            this.lblDomicile.AutoSize = true;
            this.lblDomicile.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDomicile.Location = new System.Drawing.Point(36, 399);
            this.lblDomicile.Name = "lblDomicile";
            this.lblDomicile.Size = new System.Drawing.Size(108, 24);
            this.lblDomicile.TabIndex = 50;
            this.lblDomicile.Text = "Domicile ?";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSupprimer.Location = new System.Drawing.Point(823, 486);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(142, 59);
            this.btnSupprimer.TabIndex = 49;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnEditer.Location = new System.Drawing.Point(673, 566);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(142, 59);
            this.btnEditer.TabIndex = 48;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAjouter.Location = new System.Drawing.Point(673, 486);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(142, 59);
            this.btnAjouter.TabIndex = 47;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnAnnuler.Location = new System.Drawing.Point(823, 407);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(142, 59);
            this.btnAnnuler.TabIndex = 46;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnConfirmer.Location = new System.Drawing.Point(673, 407);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(142, 59);
            this.btnConfirmer.TabIndex = 45;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // DGV_Match
            // 
            this.DGV_Match.AllowUserToAddRows = false;
            this.DGV_Match.AllowUserToDeleteRows = false;
            this.DGV_Match.AllowUserToResizeRows = false;
            this.DGV_Match.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Match.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Match.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_Match.ColumnHeadersHeight = 33;
            this.DGV_Match.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_Match.Location = new System.Drawing.Point(64, 12);
            this.DGV_Match.Name = "DGV_Match";
            this.DGV_Match.ReadOnly = true;
            this.DGV_Match.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Match.RowHeadersVisible = false;
            this.DGV_Match.RowTemplate.Height = 28;
            this.DGV_Match.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Match.Size = new System.Drawing.Size(856, 367);
            this.DGV_Match.TabIndex = 44;
            // 
            // dtpEvent
            // 
            this.dtpEvent.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvent.Location = new System.Drawing.Point(35, 505);
            this.dtpEvent.Name = "dtpEvent";
            this.dtpEvent.Size = new System.Drawing.Size(229, 26);
            this.dtpEvent.TabIndex = 62;
            // 
            // nudEquipe
            // 
            this.nudEquipe.Location = new System.Drawing.Point(35, 586);
            this.nudEquipe.Name = "nudEquipe";
            this.nudEquipe.Size = new System.Drawing.Size(120, 26);
            this.nudEquipe.TabIndex = 65;
            // 
            // nudAdv
            // 
            this.nudAdv.Location = new System.Drawing.Point(384, 425);
            this.nudAdv.Name = "nudAdv";
            this.nudAdv.Size = new System.Drawing.Size(120, 26);
            this.nudAdv.TabIndex = 66;
            // 
            // cbDomicile
            // 
            this.cbDomicile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDomicile.FormattingEnabled = true;
            this.cbDomicile.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbDomicile.Location = new System.Drawing.Point(35, 425);
            this.cbDomicile.Name = "cbDomicile";
            this.cbDomicile.Size = new System.Drawing.Size(229, 28);
            this.cbDomicile.TabIndex = 67;
            // 
            // EcranMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(989, 653);
            this.Controls.Add(this.cbDomicile);
            this.Controls.Add(this.nudAdv);
            this.Controls.Add(this.nudEquipe);
            this.Controls.Add(this.dtpEvent);
            this.Controls.Add(this.tbAdv);
            this.Controls.Add(this.lblAdv);
            this.Controls.Add(this.tbEquipe);
            this.Controls.Add(this.lblEquipe);
            this.Controls.Add(this.lblScore_Equipe);
            this.Controls.Add(this.lblScore_Adv);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblDomicile);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.DGV_Match);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranMatch";
            this.ShowIcon = false;
            this.Text = "Table Match";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAdv;
        private System.Windows.Forms.Label lblAdv;
        private System.Windows.Forms.TextBox tbEquipe;
        private System.Windows.Forms.Label lblEquipe;
        private System.Windows.Forms.Label lblScore_Equipe;
        private System.Windows.Forms.Label lblScore_Adv;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblDomicile;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.DataGridView DGV_Match;
        private System.Windows.Forms.DateTimePicker dtpEvent;
        private System.Windows.Forms.NumericUpDown nudEquipe;
        private System.Windows.Forms.NumericUpDown nudAdv;
        private System.Windows.Forms.ComboBox cbDomicile;
    }
}