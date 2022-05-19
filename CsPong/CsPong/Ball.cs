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
    internal class Ball
    {

        private Point actual_position;
        private int[] speed;
        protected Point lastImpact;
        public int width, heigth;

        public Ball(int _width, int _height)
        {
            this.width = _width;
            this.heigth = _height;
            actual_position = new Point();
            speed = new int[2];
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            actual_position.X = 0;
            actual_position.Y = 0;
            speed[0] = 1;
            speed[1] = 1;
        }

        public void Update(Point limits)
        {
            
        }

        public void SetPosition(Point _newPosition)
        {
            actual_position = _newPosition;
        }

        public void SetSpeed(int _x, int _y)
        {
            this.speed[0] = _x;
            this.speed[1] = _y;
        }

        public void SetLastImpact(Point _impact)
        {
            this.lastImpact = _impact;
        }

        private void CalculateSpeed() // thread managed
        {
            while (true)
            {
                switch (speed[1] > 0)
                {
                    case true:
                        {

                            break;
                        }
                    case false:
                        {
                            break;
                        }
                }
            }
        }



    }
}
