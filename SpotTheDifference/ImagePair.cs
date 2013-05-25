using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpotTheDifference
{
    public class ImagePair
    {
        public Bitmap left;
        public Bitmap right;
        public List<Point> points;

        private static global::System.Resources.ResourceManager resourceMan;
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SpotTheDifference.Properties.Resources", typeof(Properties.Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        public ImagePair() {
            left = right = null;
            points = null;
        }
        
        public ImagePair(string categoryName, int num) {
            string imageName = categoryName + "_" + num.ToString();
            left = (Bitmap)ResourceManager.GetObject(imageName + "_1");
            right = (Bitmap)ResourceManager.GetObject(imageName + "_2");
            FillPoint(imageName);
        }

        public Point isAcquired(Point p) {
            foreach (Point point in points) {
                if (distance(p, point) < 20) {
                    Point tmp = new Point(point.X, point.Y);
                    points.Remove(point);
                    return tmp;
                }
            }
            return Point.Empty;
        }

        public double distance(Point p1, Point p2) {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        public void FillPoint(string name) {
            points = new List<Point>();
            switch (name) { 
                case "nature_1":
                    points.Add(new Point(321, 67));
                    points.Add(new Point(130, 8));
                    points.Add(new Point(184, 412));
                    points.Add(new Point(466, 273));
                    points.Add(new Point(192, 172));
                    break;
                case "nature_2":
                    points.Add(new Point(45, 194));
                    points.Add(new Point(226, 9));
                    points.Add(new Point(336, 177));
                    points.Add(new Point(85, 329));
                    points.Add(new Point(295, 397));
                    break;
                case "nature_3":
                    points.Add(new Point(31, 307));
                    points.Add(new Point(448, 196));
                    points.Add(new Point(30, 33));
                    points.Add(new Point(247, 90));
                    points.Add(new Point(457, 490));
                    break;
                case "nature_4":
                    points.Add(new Point(404, 396));
                    points.Add(new Point(425, 86));
                    points.Add(new Point(10, 29));
                    points.Add(new Point(110, 472));
                    points.Add(new Point(173, 247));
                    break;
                case "nature_5":
                    points.Add(new Point(407,59));
                    points.Add(new Point(480, 240));
                    points.Add(new Point(142, 174));
                    points.Add(new Point(20, 436));
                    points.Add(new Point(261, 256));
                    break;
                case "animals_1":
                    points.Add(new Point(218,313));
                    points.Add(new Point(254, 192));
                    points.Add(new Point(484, 147));
                    points.Add(new Point(380, 357));
                    points.Add(new Point(29, 332));
                    break;
                case "animals_2":
                    points.Add(new Point(92,22));
                    points.Add(new Point(451, 343));
                    points.Add(new Point(109, 347));
                    points.Add(new Point(249, 457));
                    points.Add(new Point(15, 301));
                    break;
                case "animals_3":
                    points.Add(new Point(345, 313));
                    points.Add(new Point(344, 69));
                    points.Add(new Point(488, 393));
                    points.Add(new Point(99, 126));
                    points.Add(new Point(40, 464));
                    break;
                case "animals_4":
                    points.Add(new Point(18,21));
                    points.Add(new Point(468, 60));
                    points.Add(new Point(182, 109));
                    points.Add(new Point(396, 287));
                    points.Add(new Point(56, 305));
                    break;
                case "animals_5":
                    points.Add(new Point(287,110));
                    points.Add(new Point(232, 47));
                    points.Add(new Point(214, 359));
                    points.Add(new Point(484, 313));
                    points.Add(new Point(16, 477));
                    break;
                case "finki_1":
                    points.Add(new Point(283, 210));
                    points.Add(new Point(434, 378));
                    points.Add(new Point(357, 472));
                    points.Add(new Point(25, 101));
                    points.Add(new Point(171, 369));
                    break;
                case "finki_2":
                    points.Add(new Point(90,192));
                    points.Add(new Point(195,342));
                    points.Add(new Point(223,112));
                    points.Add(new Point(416,443));
                    points.Add(new Point(420,284));
                    break;
                case "finki_3":
                    points.Add(new Point(202,302));
                    points.Add(new Point(23, 425));
                    points.Add(new Point(260,386));
                    points.Add(new Point(352,409));
                    points.Add(new Point(222,160));
                    break;
                case "finki_4":
                    points.Add(new Point(156,372));
                    points.Add(new Point(198,90));
                    points.Add(new Point(38,382));
                    points.Add(new Point(446,278));
                    points.Add(new Point(61,494));
                    break;
                case "finki_5":
                    points.Add(new Point(10,382));
                    points.Add(new Point(410,260));
                    points.Add(new Point(57,441));
                    points.Add(new Point(148,150));
                    points.Add(new Point(43,11));
                    break;
                case "skopje_1":
                    points.Add(new Point(13,371));
                    points.Add(new Point(150,490));
                    points.Add(new Point(266,160));
                    points.Add(new Point(485,299));
                    points.Add(new Point(101,198));
                    break;
                case "skopje_2":
                    points.Add(new Point(10,164));
                    points.Add(new Point(213,249));
                    points.Add(new Point(74,333));
                    points.Add(new Point(452,25));
                    points.Add(new Point(385,279));
                    break;
                case "skopje_3":
                    points.Add(new Point(10,258));
                    points.Add(new Point(124,406));
                    points.Add(new Point(176,276));
                    points.Add(new Point(404,106));
                    points.Add(new Point(328,292));
                    break;
                case "skopje_4":
                    points.Add(new Point(106,170));
                    points.Add(new Point(27,87));
                    points.Add(new Point(325,376));
                    points.Add(new Point(433,272));
                    points.Add(new Point(213,402));
                    break;
                case "skopje_5":
                    points.Add(new Point(36,168));
                    points.Add(new Point(191,134));
                    points.Add(new Point(10,349));
                    points.Add(new Point(380,424));
                    points.Add(new Point(197,216));
                    break;
            }
        }
    }
}
