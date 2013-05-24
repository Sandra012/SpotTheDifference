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
        public Point Center { get; set;}
        public Ball(Point center, Color color) {
            Color = Color.Coral;
            Center = center;
            
        }
        

    }
}
