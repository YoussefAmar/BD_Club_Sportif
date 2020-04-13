namespace Projet_Club_Sportif_CouUti
{
    partial class EcranPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMembre = new System.Windows.Forms.Label();
            this.DGV_Membre = new System.Windows.Forms.DataGridView();
            this.btnMembre = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.DGV_Equipe = new System.Windows.Forms.DataGridView();
            this.lblEquipe = new System.Windows.Forms.Label();
            this.btnEquipe = new System.Windows.Forms.Button();
            this.btnEntr = new System.Windows.Forms.Button();
            this.btnAdv = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.lblAdv = new System.Windows.Forms.Label();
            this.DGV_Adv = new System.Windows.Forms.DataGridView();
            this.DGV_Match = new System.Windows.Forms.DataGridView();
            this.lblMatch = new System.Windows.Forms.Label();
            this.lbl_Entr = new System.Windows.Forms.Label();
            this.DGV_Entr = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Membre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Adv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Entr)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMembre
            // 
            this.lblMembre.AutoSize = true;
            this.lblMembre.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembre.Location = new System.Drawing.Point(393, 9);
            this.lblMembre.Name = "lblMembre";
            this.lblMembre.Size = new System.Drawing.Size(140, 37);
            this.lblMembre.TabIndex = 0;
            this.lblMembre.Text = "Membre";
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
            this.DGV_Membre.Location = new System.Drawing.Point(153, 64);
            this.DGV_Membre.Name = "DGV_Membre";
            this.DGV_Membre.ReadOnly = true;
            this.DGV_Membre.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Membre.RowHeadersVisible = false;
            this.DGV_Membre.RowTemplate.Height = 28;
            this.DGV_Membre.Size = new System.Drawing.Size(607, 322);
            this.DGV_Membre.TabIndex = 1;
            // 
            // btnMembre
            // 
            this.btnMembre.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembre.Location = new System.Drawing.Point(38, 948);
            this.btnMembre.Name = "btnMembre";
            this.btnMembre.Size = new System.Drawing.Size(229, 59);
            this.btnMembre.TabIndex = 2;
            this.btnMembre.Text = "Gestion Membre";
            this.btnMembre.UseVisualStyleBackColor = true;
            this.btnMembre.Click += new System.EventHandler(this.btnMembre_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(1633, 948);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(229, 59);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // DGV_Equipe
            // 
            this.DGV_Equipe.AllowUserToAddRows = false;
            this.DGV_Equipe.AllowUserToDeleteRows = false;
            this.DGV_Equipe.AllowUserToResizeRows = false;
            this.DGV_Equipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Equipe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Equipe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_Equipe.ColumnHeadersHeight = 30;
            this.DGV_Equipe.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_Equipe.Location = new System.Drawing.Point(105, 471);
            this.DGV_Equipe.Name = "DGV_Equipe";
            this.DGV_Equipe.ReadOnly = true;
            this.DGV_Equipe.RowHeadersVisible = false;
            this.DGV_Equipe.RowTemplate.Height = 28;
            this.DGV_Equipe.Size = new System.Drawing.Size(307, 431);
            this.DGV_Equipe.TabIndex = 4;
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipe.Location = new System.Drawing.Point(193, 414);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(123, 37);
            this.lblEquipe.TabIndex = 5;
            this.lblEquipe.Text = "Equipe";
            // 
            // btnEquipe
            // 
            this.btnEquipe.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipe.Location = new System.Drawing.Point(346, 948);
            this.btnEquipe.Name = "btnEquipe";
            this.btnEquipe.Size = new System.Drawing.Size(229, 59);
            this.btnEquipe.TabIndex = 6;
            this.btnEquipe.Text = "Gestion Equipe";
            this.btnEquipe.UseVisualStyleBackColor = true;
            this.btnEquipe.Click += new System.EventHandler(this.btnEquipe_Click);
            // 
            // btnEntr
            // 
            this.btnEntr.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntr.Location = new System.Drawing.Point(650, 948);
            this.btnEntr.Name = "btnEntr";
            this.btnEntr.Size = new System.Drawing.Size(229, 59);
            this.btnEntr.TabIndex = 7;
            this.btnEntr.Text = "Entrainement";
            this.btnEntr.UseVisualStyleBackColor = true;
            this.btnEntr.Click += new System.EventHandler(this.btnEntr_Click);
            // 
            // btnAdv
            // 
            this.btnAdv.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdv.Location = new System.Drawing.Point(966, 948);
            this.btnAdv.Name = "btnAdv";
            this.btnAdv.Size = new System.Drawing.Size(229, 59);
            this.btnAdv.TabIndex = 8;
            this.btnAdv.Text = "Adversaire";
            this.btnAdv.UseVisualStyleBackColor = true;
            // 
            // btnMatch
            // 
            this.btnMatch.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatch.Location = new System.Drawing.Point(1297, 948);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(229, 59);
            this.btnMatch.TabIndex = 9;
            this.btnMatch.Text = "Gestion Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            // 
            // lblAdv
            // 
            this.lblAdv.AutoSize = true;
            this.lblAdv.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdv.Location = new System.Drawing.Point(1273, 414);
            this.lblAdv.Name = "lblAdv";
            this.lblAdv.Size = new System.Drawing.Size(184, 37);
            this.lblAdv.TabIndex = 11;
            this.lblAdv.Text = "Adversaire";
            // 
            // DGV_Adv
            // 
            this.DGV_Adv.AllowUserToAddRows = false;
            this.DGV_Adv.AllowUserToDeleteRows = false;
            this.DGV_Adv.AllowUserToResizeRows = false;
            this.DGV_Adv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Adv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Adv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_Adv.ColumnHeadersHeight = 30;
            this.DGV_Adv.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_Adv.Location = new System.Drawing.Point(849, 471);
            this.DGV_Adv.Name = "DGV_Adv";
            this.DGV_Adv.ReadOnly = true;
            this.DGV_Adv.RowHeadersVisible = false;
            this.DGV_Adv.RowTemplate.Height = 28;
            this.DGV_Adv.Size = new System.Drawing.Size(1059, 431);
            this.DGV_Adv.TabIndex = 10;
            // 
            // DGV_Match
            // 
            this.DGV_Match.AllowUserToAddRows = false;
            this.DGV_Match.AllowUserToDeleteRows = false;
            this.DGV_Match.AllowUserToResizeRows = false;
            this.DGV_Match.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Match.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Match.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_Match.ColumnHeadersHeight = 30;
            this.DGV_Match.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_Match.Location = new System.Drawing.Point(849, 64);
            this.DGV_Match.Name = "DGV_Match";
            this.DGV_Match.ReadOnly = true;
            this.DGV_Match.RowHeadersVisible = false;
            this.DGV_Match.RowTemplate.Height = 28;
            this.DGV_Match.Size = new System.Drawing.Size(1059, 322);
            this.DGV_Match.TabIndex = 13;
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.Location = new System.Drawing.Point(1318, 9);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(110, 37);
            this.lblMatch.TabIndex = 12;
            this.lblMatch.Text = "Match";
            // 
            // lbl_Entr
            // 
            this.lbl_Entr.AutoSize = true;
            this.lbl_Entr.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Entr.Location = new System.Drawing.Point(507, 414);
            this.lbl_Entr.Name = "lbl_Entr";
            this.lbl_Entr.Size = new System.Drawing.Size(222, 37);
            this.lbl_Entr.TabIndex = 15;
            this.lbl_Entr.Text = "Entrainement";
            // 
            // DGV_Entr
            // 
            this.DGV_Entr.AllowUserToAddRows = false;
            this.DGV_Entr.AllowUserToDeleteRows = false;
            this.DGV_Entr.AllowUserToResizeRows = false;
            this.DGV_Entr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Entr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Entr.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_Entr.ColumnHeadersHeight = 30;
            this.DGV_Entr.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_Entr.Location = new System.Drawing.Point(456, 471);
            this.DGV_Entr.Name = "DGV_Entr";
            this.DGV_Entr.ReadOnly = true;
            this.DGV_Entr.RowHeadersVisible = false;
            this.DGV_Entr.RowTemplate.Height = 28;
            this.DGV_Entr.Size = new System.Drawing.Size(333, 431);
            this.DGV_Entr.TabIndex = 14;
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1920, 1046);
            this.Controls.Add(this.lbl_Entr);
            this.Controls.Add(this.DGV_Entr);
            this.Controls.Add(this.DGV_Match);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.lblAdv);
            this.Controls.Add(this.DGV_Adv);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.btnAdv);
            this.Controls.Add(this.btnEntr);
            this.Controls.Add(this.btnEquipe);
            this.Controls.Add(this.lblEquipe);
            this.Controls.Add(this.DGV_Equipe);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnMembre);
            this.Controls.Add(this.DGV_Membre);
            this.Controls.Add(this.lblMembre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranPrincipal";
            this.ShowIcon = false;
            this.Text = "Ecran Principal";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Membre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Adv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Entr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMembre;
        private System.Windows.Forms.DataGridView DGV_Membre;
        private System.Windows.Forms.Button btnMembre;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DataGridView DGV_Equipe;
        private System.Windows.Forms.Label lblEquipe;
        private System.Windows.Forms.Button btnEquipe;
        private System.Windows.Forms.Button btnEntr;
        private System.Windows.Forms.Button btnAdv;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Label lblAdv;
        private System.Windows.Forms.DataGridView DGV_Adv;
        private System.Windows.Forms.DataGridView DGV_Match;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label lbl_Entr;
        private System.Windows.Forms.DataGridView DGV_Entr;
    }
}

