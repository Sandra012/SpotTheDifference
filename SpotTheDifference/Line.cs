using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpotTheDifference
{
    public class Line
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point End { get; set; }
        public int Width { get; set; }
        public Line(int x, int y, Point end, int width) {
            X = x;
            Y = y;
            End = end;
            Width = width;
        }
        public void Draw(Graphics g) {
            Pen pen = new Pen(Color.Yellow, Width);
            Point p = new Point(X, Y);
            g.DrawLine(pen, p, End);
            pen.Dispose();
        }
    }
}
