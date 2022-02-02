using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ10
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            get
            {
                return gradus;  
            }
            set
            {
                if (value <0)
                {
                    gradus = 0;
                }
                else if (value > 360)
                {
                    gradus = value%360;
                }
                else
                {
                    gradus = value;
                }
            }
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                {
                    min = 0;
                }
                else if (value > 60)
                {
                    Gradus += value/60;
                    min = value % 60;
                }
                else
                {
                    min = value;
                }
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 0)
                {
                    sec = 0;
                }
                else if (value > 60)
                {
                    Min += value/60;
                    sec = value % 60;
                }
                else
                {
                    sec = value;
                }
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public int ToSecond()
        {
            return sec + 60 * min + 3600 * gradus;
        }


        public int ToRadians()
        {
            return (gradus+sec/60+min/3600)/180;
        }


    }

}
