using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class denemesql : Form
    {
        public denemesql()
        {
            InitializeComponent();
        }

        private void denemesql_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'case_followDataSet.case_name' table. You can move, or remove it, as needed.
            this.case_nameTableAdapter.Fill(this.case_followDataSet.case_name);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.case_nameTableAdapter.Fill(this.case_followDataSet.case_name);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
