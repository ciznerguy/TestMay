using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMay
{
    public class TriNum
    {
        private int d1;
        private int d10;
        private int d100;

        public TriNum(int num)
        {
            if (num >= 100 && num <= 999)
            {
                d1 = num%10;
                d10 = num / 10 % 10;
                d100 = num / 100;

            }
            else
            {
                d1 = 0;
                d10 = 0;
                d100 = 0;   
            }
        }

        public int SpecialRes(TriNum other)
        {
            return (this.d1 - other.d1) + (this.d10 - other.d10) + (this.d100 - other.d100);
        }

        public int ReturnNum()
        {
            return this.d1 + this.d10 * 10 + this.d100 * 100;
        }
        public TriNum Add(TriNum other)
        {
            //int sumThis = this.d1 + this.d10 * 10 + this.d100 * 100;
            //int sumOther = other.d1 + other.d10 * 10 + other.d100 * 100;
            return new TriNum(this.ReturnNum() + other.ReturnNum());
        }
    }
}
