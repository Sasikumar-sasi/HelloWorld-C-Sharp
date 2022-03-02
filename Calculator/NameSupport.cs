using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class NameSupport
    {
        string[] _name = new string[1000];
        public string this[int index]
        {
            set
            {
                if(index >=0 && index < 1000)
                {
                    _name[index] = value;
                }
                else
                {
                    Console.WriteLine($"In the index({index}) value is not present");
                }
            }
            get
            {
                if(index>=0 && index < 1000)
                {
                    return _name[index];
                }
                else
                {
                    Console.WriteLine($"The index {index} is not present");
                    return null;
                }
            }
        }
    }
}
