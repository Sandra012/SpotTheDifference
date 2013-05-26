using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotTheDifference
{
    public class Category
    {
        public string Name { get; set; }
        private int lastRandom1, lastRandom2;

        public Category(String name) {
            this.Name = name;
            lastRandom1 = lastRandom2 = -1;
        }
        
        public ImagePair getNewPair() {
            Random random = new Random();
            int num;
            while (true)
            {
                num = random.Next(5);
                if (num != lastRandom1 && num != lastRandom2)
                {
                    lastRandom2 = lastRandom1;
                    lastRandom1 = num;
                    break;
                }
            }
            ImagePair pair = new ImagePair(Name, num + 1);
            return pair;
        }
    }
}
