using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookAndSayChallenge
{
    class LookNSayLogic
    {
        private int iterations;
        private int seed;

        public int Iterations
        {
            get { return iterations; }
            set { iterations = value; }
        }

        public LookNSayLogic(int iterations)
        {
            Iterations = iterations;
        }

        public string LookNSayMagic()
        {
            seed = 1;
            string final;
            final = "";
            final = final + seed.ToString();
            string firstLine = seed.ToString();
            string nextLine;
            Dictionary<char, int> numCount = new Dictionary<char, int>();
            int i = 0;
            while (i <= Iterations)
            {
            	nextLine = "";
                if (i == 0)
                {
                    int numberOfChar = firstLine.Count();
                    for (int z = 0; z < numberOfChar; z++)
                    {
                        if(firstLine[z] == firstLine[Z+1])
                        {
                        	
                        }
                    }
                    
                }
                else
                {
                    
                }
                i += 1;
            }

            return final;
        }

    }
}
