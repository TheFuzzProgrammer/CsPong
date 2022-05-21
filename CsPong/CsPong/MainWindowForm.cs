using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsPong
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }
        public Panel GetPanel()
        {
            return this.panel1;
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }
    }
}
