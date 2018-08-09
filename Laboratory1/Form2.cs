using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory1
{
    public partial class frmHistoria : Form
    {
        HistoryEntities db;
        public frmHistoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHistoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbo_HistoriaDataSet.Historia' table. You can move, or remove it, as needed.
            // this.historiaTableAdapter.Fill(this.dbo_HistoriaDataSet.Historia);
            db = new HistoryEntities();
            dboHistoryBindingSource.DataSource = db.dbo_History.ToList();

        }
    }
}
