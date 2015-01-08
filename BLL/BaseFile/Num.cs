using System;
using System.Collections.Generic;
using System.Text;

namespace Hownet.BLL.BaseFile
{
    public class Num
    {
        public Num()
        {
        }
        public string GetNum(string num)
        {
            string NewNum = string.Empty;
            if (num.Length == 1)
            {
                NewNum = "00" + num;
            }
            else if (num.Length == 2)
            {
                NewNum = "0" + num;
            }
            else if (num.Length == 3)
            {
                NewNum = num;
            }
            return NewNum;
        }
    }
}
