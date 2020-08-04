using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME_SHOW.Forms.MC
{
    public partial class frmAddQuestion : Form
    {
        public frmAddQuestion()
        {
            InitializeComponent();
        }

        private void frmAddQuestion_Load(object sender, EventArgs e)
        {
            rdoAnswer1.Enabled = false;
            rdoAnswer2.Enabled = false;
            rdoAnswer3.Enabled = false;
            rdoAnswer4.Enabled = false;

            txtAnswer1.Enabled = false;
            txtAnswer2.Enabled = false;
            txtAnswer3.Enabled = false;
            txtAnswer4.Enabled = false;
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            txtAnswer1.Enabled = true;
        }

        private void txtAnswer1_TextChanged(object sender, EventArgs e)
        {
            rdoAnswer1.Enabled = true;

            txtAnswer2.Enabled = true;
        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {
            rdoAnswer2.Enabled = true;

            txtAnswer3.Enabled = true;
        }

        private void txtAnswer3_TextChanged(object sender, EventArgs e)
        {
            rdoAnswer3.Enabled = true;

            txtAnswer4.Enabled = true;
        }

        private void txtAnswer4_TextChanged(object sender, EventArgs e)
        {
            rdoAnswer4.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
