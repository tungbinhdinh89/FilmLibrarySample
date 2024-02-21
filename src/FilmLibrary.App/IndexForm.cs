using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary.App
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new NewMovieForm().ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void IndexForm_Load(object sender, EventArgs e)
        {

        }
    }
}
