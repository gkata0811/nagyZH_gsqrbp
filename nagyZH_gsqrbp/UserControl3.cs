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
    public partial class UserControl3 : UserControl
    {
        ModelsWebshop.WebshopContext context = new ModelsWebshop.WebshopContext();
        
        public UserControl3()
        {
            InitializeComponent();

            RendelesListazas();
            TermekListazas();
        }

        private void RendelesListazas()
        {
            var rl = from x in context.Rendeles select x;
            rendelesBindingSource.DataSource = rl.ToList();
        }

        private void btnUjRendeles_Click(object sender, EventArgs e)
        {
            FormUjRendeles formUjRendeles = new FormUjRendeles();
            if(formUjRendeles.ShowDialog() == DialogResult.OK)
            {
                ModelsWebshop.Rendeles rendeles = new ModelsWebshop.Rendeles();
                rendeles.Sorszam = Convert.ToInt32(formUjRendeles.txtSorszam.Text);
                rendeles.Login = Convert.ToString(formUjRendeles.cmbLogin.SelectedValue);
                context.Rendeles.Add(rendeles);
                try
                {
                    context.SaveChanges();
                }
                catch(Exception kivétel)
                {
                    MessageBox.Show(kivétel.Message);
                }
                RendelesListazas();
                MessageBox.Show("OK-al zárult.");
            }
            else
            {
                MessageBox.Show("Nem OK-al zárult");
            }
        }

        private void TermekListazas()
        {
            var tl = from x in context.Termek
                     join k in context.Termekkategoria on x.KatId equals k.KatId
                     select new
                     {
                         Megnevezes = x.Megnevezes,
                         Kat = k.KatNev,
                         Raktarkod = x.RaktarKod,
                         Listaas = x.Listaar,
                         Keszlet = x.Keszlet,
                         Termekkod = x.Termekkod
                     };
            termekBindingSource.DataSource = tl.ToList();
        }

        private void btnUjTermek_Click(object sender, EventArgs e)
        {
            FormUjTermek formUjTermek = new FormUjTermek();
            if (formUjTermek.ShowDialog() == DialogResult.OK)
            {
                ModelsWebshop.Termek termek = new ModelsWebshop.Termek();
                termek.Megnevezes = formUjTermek.txtMegnevezes.Text;
                termek.KatId = Convert.ToInt32(formUjTermek.cmbKategoria.SelectedValue);
                termek.RaktarKod = Convert.ToInt32(formUjTermek.cmbRaktarkod.SelectedValue);
                termek.Listaar = Convert.ToInt32(formUjTermek.txtListaar.Text);
                termek.Keszlet = Convert.ToInt32(formUjTermek.txtkeszlet.Text);
                termek.Termekkod = formUjTermek.txtTermekkod.Text;
                context.Termek.Add(termek);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception kivétel)
                {
                    MessageBox.Show(kivétel.Message);
                }
                TermekListazas();
                MessageBox.Show("OK-al zárult.");
            }
            else
            {
                MessageBox.Show("Nem OK-al zárult");
            }
        }
    }
}
