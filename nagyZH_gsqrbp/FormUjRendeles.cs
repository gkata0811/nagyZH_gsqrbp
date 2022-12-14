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
    public partial class FormUjRendeles : Form
    {
        ModelsWebshop.WebshopContext context = new ModelsWebshop.WebshopContext();
        
        public FormUjRendeles()
        {
            InitializeComponent();

            labelSorszam.Text = "Sorszám";
            labelLogin.Text = "Login";

            LoginListazas();
        }

        private void LoginListazas()
        {
            var ll = from x in context.Ugyfel select x;
            ugyfelBindingSource.DataSource = ll.ToList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
