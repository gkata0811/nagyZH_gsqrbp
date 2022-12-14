using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nagyZH_gsqrbp
{
    public partial class FormUjTermek : Form
    {
        ModelsWebshop.WebshopContext context = new ModelsWebshop.WebshopContext();
        
        public FormUjTermek()
        {
            InitializeComponent();

            labelMegnevezes.Text = "Megnevezés";
            labelKategoria.Text = "Termékkód";
            labelRaktarkod.Text = "Termékkód";
            labelListaar.Text = "Listaár";
            labelKeszlet.Text = "Készlet";
            labelTermekkod.Text = "Termékkód";

            KategoriaListazas();
            RaktarkodListazas();
        }

        private void KategoriaListazas()
        {
            var kl = from x in context.Termekkategoria select x;
            termekkategoriaBindingSource.DataSource = kl.ToList();
        }

        private void RaktarkodListazas()
        {
            var rl = from x in context.Raktar select x;
            raktarBindingSource.DataSource = rl.ToList();
        }

        private bool CheckMegnevezes(string megnevezes)
        {
            return !string.IsNullOrEmpty(megnevezes);
        }

        private void txtMegnevezes_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMegnevezes, "");
        }

        private void txtMegnevezes_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckMegnevezes(txtMegnevezes.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMegnevezes, "A megnevezés nem lehet üres!");
            }
        }
        private bool CheckListaar(string listaar)
        {
            Regex r = new Regex("^[0-9]{3,4}$");
            return r.IsMatch(listaar);
        }

        private void txtListaar_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtListaar, "");
        }

        private void txtListaar_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckListaar(txtListaar.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtListaar, "Helytelen formátum!");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
