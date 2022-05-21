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
    public partial class PongMain : Form
    {
        private bool cursorPosition;
        private int CX,CY;
        private Point pointer;
        public PongMain()
        {
            pointer = new Point();
            
            cursorPosition = false;
            InitializeComponent();
            StartUi();

        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeLabel_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorPosition)
            {
                pointer.X = Cursor.Position.X + CX;
                pointer.Y = Cursor.Position.Y + CY;
                this.Location = pointer;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            cursorPosition = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            cursorPosition = true;
            CX = this.Location.X - Cursor.Position.X;
            CY = this.Location.Y - Cursor.Position.Y;
        }

        private void StartUi()
        {   

            PongGame pong = new PongGame()
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };

            MainWindowForm game;
            game = new MainWindowForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };

            containerPanel.Tag = pong;
            this.containerPanel.Controls.Add(pong);
            pong.Show();
        }
    }
}
