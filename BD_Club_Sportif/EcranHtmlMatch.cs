using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Club_Sportif_CouUti
{
    public partial class EcranHtmlMatch : Form
    {
        public EcranHtmlMatch(string path)
        {
            InitializeComponent();
            var uri = new Uri(path);
            wbHtml.Navigate(uri);
            
        }
    }
}
