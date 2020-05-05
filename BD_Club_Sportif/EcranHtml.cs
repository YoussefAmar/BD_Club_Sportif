using System;
using System.Collections.Generic;
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
    public partial class EcranHtml : Form
    {
        public EcranHtml(string path)
        {
            InitializeComponent();
            var uri = new Uri(path); //Produit une url à l'aide du fichier
            this.Text = Path.GetFileName(path); //Affiche le nom du fichier sur la fenêtre
            wbHtml.Navigate(uri); //Lecteur de page web  
        }
    }
}
