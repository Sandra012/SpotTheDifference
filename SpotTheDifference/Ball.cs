using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpotTheDifference
{
    public class Ball
    {
        public Color Color { get; set; }
        public float Velocity { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius = 10;
        public Ball(Color color, int x, int y) {
            Color = color;
            X = x;
            Y = y;
        }
        public void Draw(Graphics g) {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, X -Radius,Y - Radius, 2 * Radius, 2 * Radius);
            brush.Dispose();
        }
        

    }
}
