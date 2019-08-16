using COMP123_S2019_A5_SectionAExample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_SectionAExample.Views
{
    public partial class Selectform : Form
    {
        public Selectform()
        {
            InitializeComponent();
        }

        private void Selectform_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputer())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
        }
    }
}
