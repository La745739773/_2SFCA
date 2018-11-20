using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SFCA可达性计算
{
    public partial class Main_frame : Form
    {
        public Main_frame()
        {
            InitializeComponent();
        }

        private void TwosFCA_menuItem_Click(object sender, EventArgs e)
        {
            _2SFCAForm _2SFCA = new _2SFCAForm();
            _2SFCA.ShowDialog();
        }

        private void Extend_Ga2SFCA_menuItem_Click(object sender, EventArgs e)
        {
            Extend_Ga2SFCA _form = new Extend_Ga2SFCA();
            _form.ShowDialog();
        }
    }
}
