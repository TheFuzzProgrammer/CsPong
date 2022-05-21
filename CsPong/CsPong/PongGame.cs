using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public void moveBall()
        {
            Point point = new Point(0, 0);

            int tempVel = 1;

            Panel ballDraw = this.bp;
            this.Controls.Add(ballDraw);

            while (true)
            {
                if (point.X > 0 && point.X < this.Size.Width && point.Y < this.Size.Height && point.Y < 0)
                {
                    point.X = point.X + tempVel;
                    point.Y = point.Y + tempVel;
                    ballDraw.Location = point;
                    ballDraw.Refresh();
                }
                else
                {
                    point.X = point.X + -1 * tempVel;
                    point.Y = point.Y + -1 * tempVel;
                    ballDraw.Location = point;
                    ballDraw.Refresh();

                }

            }
        }


    }
}
