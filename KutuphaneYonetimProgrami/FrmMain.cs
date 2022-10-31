using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimProgrami
{
    public partial class FrmMain : Form
    {
        Kitaplar kitaplar;
        Ogrenciler ogrenciler;
        OduncIslemler oduncIslemler;

        List<Panel> paneller;

        public FrmMain()
        {
            InitializeComponent();
            paneller = new List<Panel>() { pnlKitaplar,pnlOgrenciler };
        }

        private void PanelGoster(Panel pnlNesnesi)
        {
            foreach(var panel in paneller)
            {
                panel.Visible = false;
            }

            pnlNesnesi.Visible = true;
        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            PanelGoster(pnlKitaplar);
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            PanelGoster(pnlOgrenciler);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            PanelGoster(pnlKitaplar);
        }
    }
}
