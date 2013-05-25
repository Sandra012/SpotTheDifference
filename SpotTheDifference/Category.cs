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
        private int lastRandom;

        public Category(String name) {
            this.Name = name;
            lastRandom = -1;
        }
        
        public ImagePair getNewPair() {
            Random random = new Random();
            int num;
            while (true)
            {
                num = random.Next(5);
                if (num != lastRandom)
                {
                    lastRandom = num;
                    break;
                }
            }
            ImagePair pair = new ImagePair(Name, num + 1);
            return pair;
        }
    }
}
