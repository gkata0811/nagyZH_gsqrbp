using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nagyZH_gsqrbp
{
    public partial class UserControl2 : UserControl
    {
        ModelsEtkeztetes.EtkeztetesContext context = new ModelsEtkeztetes.EtkeztetesContext();
        
        public UserControl2()
        {
            InitializeComponent();

            FogasListazas();
            NyersanyagListazas();
        }

        private void FogasListazas()
        {
            var fl = from x in context.Fogasok
                     where x.FogasNev.Contains(txtFogasSzures.Text)
                     select x;
            listBoxFogasok.DataSource = fl.ToList();
            listBoxFogasok.DisplayMember = "FogasNev";
        }

        private void txtFogasSzures_TextChanged(object sender, EventArgs e)
        {
            FogasListazas();
        }

        private void NyersanyagListazas()
        {
            var nl = from x in context.Nyersanyagok
                     where x.NyersanyagNev.Contains(txtNyersanyagSzures.Text)
                     select x;
            listBoxNyersanyagok.DataSource = nl.ToList();
            listBoxNyersanyagok.DisplayMember = "NyersanyagNev";
        }

        private void txtNyersanyagSzures_TextChanged(object sender, EventArgs e)
        {
            NyersanyagListazas();
        }

        private void listBoxFogasok_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fogasID = ((ModelsEtkeztetes.Fogasok)listBoxFogasok.SelectedValue).FogasId;
            var kivalasztottFogas = from x in context.Receptek
                                    where x.FogasId == fogasID
                                    select new
                                    {
                                        ReceptID = x.ReceptId,
                                        FogasID = x.FogasId,
                                        NyersanyagNev = x.Nyersanyag.NyersanyagNev,
                                        Mennyiseg_4fo = x.Mennyiseg4fo,
                                        EgysegNev = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                                        Ár = x.Mennyiseg4fo * (double?)x.Nyersanyag.Egysegar
                                    };
            hozzavaloBindingSource.DataSource = kivalasztottFogas.ToList();
        }

        private void HozzavaloListazas()
        {
            if (listBoxFogasok.SelectedItem == null) return;
            var kivalasztottFogas = (ModelsEtkeztetes.Fogasok)listBoxFogasok.SelectedItem;
            var hozzavalok = from x in context.Receptek
                             where x.FogasId == kivalasztottFogas.FogasId
                             select new Hozzavalo
                             {
                                 ReceptID = x.ReceptId,
                                 FogadID = x.FogasId,
                                 NyersanyagNev = x.Nyersanyag.NyersanyagNev,
                                 Mennyiseg_4fo = x.Mennyiseg4fo,
                                 EgysegNev = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                                 Ár = x.Mennyiseg4fo * (double?)x.Nyersanyag.Egysegar
                             };
         hozzavaloBindingSource.DataSource = hozzavalok.ToList();
        }

        private void btnAddHozzavalo_Click(object sender, EventArgs e)
        {
            ModelsEtkeztetes.Receptek receptek = new ModelsEtkeztetes.Receptek();
            receptek.NyersanyagId = ((ModelsEtkeztetes.Nyersanyagok)listBoxNyersanyagok.SelectedItem).NyersanyagId;
            receptek.FogasId = ((ModelsEtkeztetes.Fogasok)listBoxFogasok.SelectedItem).FogasId;
            double m;
            if (!double.TryParse(txtMennyiseg.Text, out m)) return;
            receptek.Mennyiseg4fo = m;
            context.Receptek.Add(receptek);
            context.SaveChanges();
            HozzavaloListazas();
        }

        private void HozzavaloTorles()
        {
            DataGridViewSelectedCellCollection selectedCells = dgvHozzavalok.SelectedCells;
            foreach (DataGridViewCell cells in selectedCells)
            {
                var selectedRow = cells.RowIndex;
                var receptID = Convert.ToInt32(dgvHozzavalok.Rows[cells.RowIndex].Cells[4].Value);
                var torlendo = context.Receptek.Where(x => x.ReceptId == receptID).FirstOrDefault();
                if (torlendo != null)
                    context.Receptek.Remove(torlendo);
                context.SaveChanges();
            }
        }

        private void btnRemoveHozzavalo_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Biztos törölni akarja?", "törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HozzavaloTorles();
            }
            HozzavaloListazas();
        }
    }
}
