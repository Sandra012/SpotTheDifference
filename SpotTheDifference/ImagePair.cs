using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotTheDifference
{
    public class ImagePair
    {
        public System.Drawing.Bitmap left;
        public System.Drawing.Bitmap right;
        public List<System.Drawing.Point> points;

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
            string tmp1 = imageName + "_1";
            string tmp2 = imageName + "_2";
            left = (System.Drawing.Bitmap) ResourceManager.GetObject(tmp1);
            right = (System.Drawing.Bitmap)ResourceManager.GetObject(tmp2);
            //FillPoint(imageName);
        }

        public void FillPoint(string name) {
            points = new List<System.Drawing.Point>();
            switch (name) { 
                case "nature_1":
                    points.Add(new System.Drawing.Point(321, 67));
                    points.Add(new System.Drawing.Point(130, 8));
                    points.Add(new System.Drawing.Point(184, 412));
                    points.Add(new System.Drawing.Point(466, 273));
                    points.Add(new System.Drawing.Point(192, 172));
                    break;
                case "nature_2":
                    points.Add(new System.Drawing.Point(45, 194));
                    points.Add(new System.Drawing.Point(226, 9));
                    points.Add(new System.Drawing.Point(336, 177));
                    points.Add(new System.Drawing.Point(85, 329));
                    points.Add(new System.Drawing.Point(295, 397));
                    break;
                case "nature_3":
                    points.Add(new System.Drawing.Point(31, 307));
                    points.Add(new System.Drawing.Point(448, 196));
                    points.Add(new System.Drawing.Point(30, 33));
                    points.Add(new System.Drawing.Point(247, 90));
                    points.Add(new System.Drawing.Point(457, 490));
                    break;
                case "nature_4":
                    points.Add(new System.Drawing.Point(404, 396));
                    points.Add(new System.Drawing.Point(425, 86));
                    points.Add(new System.Drawing.Point(10, 29));
                    points.Add(new System.Drawing.Point(110, 472));
                    points.Add(new System.Drawing.Point(173, 247));
                    break;
                case "nature_5":
                    points.Add(new System.Drawing.Point(407,59));
                    points.Add(new System.Drawing.Point(480, 240));
                    points.Add(new System.Drawing.Point(142, 174));
                    points.Add(new System.Drawing.Point(20, 436));
                    points.Add(new System.Drawing.Point(261, 256));
                    break;
                case "animals_1":
                    points.Add(new System.Drawing.Point(218,313));
                    points.Add(new System.Drawing.Point(254, 192));
                    points.Add(new System.Drawing.Point(484, 147));
                    points.Add(new System.Drawing.Point(380, 357));
                    points.Add(new System.Drawing.Point(29, 332));
                    break;
                case "animals_2":
                    points.Add(new System.Drawing.Point(92,22));
                    points.Add(new System.Drawing.Point(451, 343));
                    points.Add(new System.Drawing.Point(109, 347));
                    points.Add(new System.Drawing.Point(249, 457));
                    points.Add(new System.Drawing.Point(15, 301));
                    break;
                case "animals_3":
                    points.Add(new System.Drawing.Point(345, 313));
                    points.Add(new System.Drawing.Point(344, 69));
                    points.Add(new System.Drawing.Point(488, 393));
                    points.Add(new System.Drawing.Point(99, 126));
                    points.Add(new System.Drawing.Point(40, 464));
                    break;
                case "animals_4":
                    points.Add(new System.Drawing.Point(18,21));
                    points.Add(new System.Drawing.Point(468, 60));
                    points.Add(new System.Drawing.Point(182, 109));
                    points.Add(new System.Drawing.Point(396, 287));
                    points.Add(new System.Drawing.Point(56, 305));
                    break;
                case "animals_5":
                    points.Add(new System.Drawing.Point(287,110));
                    points.Add(new System.Drawing.Point(232, 47));
                    points.Add(new System.Drawing.Point(214, 359));
                    points.Add(new System.Drawing.Point(484, 313));
                    points.Add(new System.Drawing.Point(16, 477));
                    break;
                case "finki_1":
                    points.Add(new System.Drawing.Point(283, 210));
                    points.Add(new System.Drawing.Point(434, 378));
                    points.Add(new System.Drawing.Point(357, 472));
                    points.Add(new System.Drawing.Point(25, 101));
                    points.Add(new System.Drawing.Point(171, 369));
                    break;
                case "finki_2":
                    points.Add(new System.Drawing.Point(90,192));
                    points.Add(new System.Drawing.Point(195,342));
                    points.Add(new System.Drawing.Point(223,112));
                    points.Add(new System.Drawing.Point(416,443));
                    points.Add(new System.Drawing.Point(420,284));
                    break;
                case "finki_3":
                    points.Add(new System.Drawing.Point(202,302));
                    points.Add(new System.Drawing.Point(23, 425));
                    points.Add(new System.Drawing.Point(260,386));
                    points.Add(new System.Drawing.Point(352,409));
                    points.Add(new System.Drawing.Point(222,160));
                    break;
                case "finki_4":
                    points.Add(new System.Drawing.Point(156,372));
                    points.Add(new System.Drawing.Point(198,90));
                    points.Add(new System.Drawing.Point(38,382));
                    points.Add(new System.Drawing.Point(446,278));
                    points.Add(new System.Drawing.Point(61,494));
                    break;
                case "finki_5":
                    points.Add(new System.Drawing.Point(10,382));
                    points.Add(new System.Drawing.Point(410,260));
                    points.Add(new System.Drawing.Point(57,441));
                    points.Add(new System.Drawing.Point(148,150));
                    points.Add(new System.Drawing.Point(43,11));
                    break;
                case "skopje_1":
                    points.Add(new System.Drawing.Point(13,371));
                    points.Add(new System.Drawing.Point(150,490));
                    points.Add(new System.Drawing.Point(266,160));
                    points.Add(new System.Drawing.Point(485,299));
                    points.Add(new System.Drawing.Point(101,198));
                    break;
                case "skopje_2":
                    points.Add(new System.Drawing.Point(10,164));
                    points.Add(new System.Drawing.Point(213,249));
                    points.Add(new System.Drawing.Point(74,333));
                    points.Add(new System.Drawing.Point(452,25));
                    points.Add(new System.Drawing.Point(385,279));
                    break;
                case "skopje_3":
                    points.Add(new System.Drawing.Point(10,258));
                    points.Add(new System.Drawing.Point(124,406));
                    points.Add(new System.Drawing.Point(176,276));
                    points.Add(new System.Drawing.Point(404,106));
                    points.Add(new System.Drawing.Point(328,292));
                    break;
                case "skopje_4":
                    points.Add(new System.Drawing.Point(106,170));
                    points.Add(new System.Drawing.Point(27,87));
                    points.Add(new System.Drawing.Point(325,376));
                    points.Add(new System.Drawing.Point(433,272));
                    points.Add(new System.Drawing.Point(213,402));
                    break;
                case "skopje_5":
                    points.Add(new System.Drawing.Point(36,168));
                    points.Add(new System.Drawing.Point(191,134));
                    points.Add(new System.Drawing.Point(10,349));
                    points.Add(new System.Drawing.Point(380,424));
                    points.Add(new System.Drawing.Point(197,216));
                    break;


                //to be finished
            }
        }
    }
}
