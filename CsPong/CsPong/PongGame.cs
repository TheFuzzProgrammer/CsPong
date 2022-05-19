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
   
    public partial class PongGame : Form
    {
        private Ball ball;
        private Paddle paddle;
        public PongGame()
        {
            InitializeComponent();
        }
    }
}
