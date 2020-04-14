namespace Projet_Club_Sportif_CouUti
{
    partial class EcranHtmlMatch
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
            this.wbHtml = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbHtml
            // 
            this.wbHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbHtml.Location = new System.Drawing.Point(0, 0);
            this.wbHtml.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbHtml.Name = "wbHtml";
            this.wbHtml.Size = new System.Drawing.Size(1132, 675);
            this.wbHtml.TabIndex = 0;
            // 
            // EcranHtml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 675);
            this.Controls.Add(this.wbHtml);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranHtml";
            this.ShowIcon = false;
            this.Text = "Fichier Html Affrontement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbHtml;
    }
}