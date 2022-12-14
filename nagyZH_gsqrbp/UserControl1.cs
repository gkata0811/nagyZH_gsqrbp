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
    public partial class UserControl1 : UserControl
    {
        ModelsStudies.StudiesContext context = new ModelsStudies.StudiesContext();
        
        public UserControl1()
        {
            InitializeComponent();
            instructorBindingSource.DataSource = context.Instructors.ToList();
            statusBindingSource.DataSource = context.Statuses.ToList();
            employementBindingSource.DataSource = context.Employements.ToList();

            
            KurzusListazas();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void KurzusListazas()
        {
            var kl = from x in context.Courses select x;
            kurzusBindingSource.DataSource = kl.ToList();
        }
    }
}
