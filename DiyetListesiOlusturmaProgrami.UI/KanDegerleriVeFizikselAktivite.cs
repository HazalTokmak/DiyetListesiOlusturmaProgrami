using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetListesiOlusturmaProgrami.UI
{
    public partial class KanDegerleriVeFizikselAktivite : Form
    {
        List<KanDegerleri> kanDegerleri = new List<KanDegerleri>();
        public KanDegerleriVeFizikselAktivite()
        {
            InitializeComponent();
        }

        private void KanDegerleriVeFizikselAktivite_Load(object sender, EventArgs e)
        {
            cmbKanDegerleri.DataSource = Enum.GetValues(typeof(KanDegerleri));
            cmbFizikselAktivite.DataSource = Enum.GetValues(typeof(FizikselAktiviteEnum));

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
