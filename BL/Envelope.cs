using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envelopee.BL
{
    class Envelope
    {
        private float _length { get; set; }
        private float _width { get; set; }


        public Envelope(float length, float width)
        {
            _length = length;
            _width = width;
        }

        public int CheckEnvelops(Envelope second)
        {
            bool IsFirstSmaller = (_length < second._length && _width < second._width) || (_length < second._width && _width < second._length);
            bool IsSecondSmaller = (second._length < _length && second._width < _width) || (second._width < _length && second._length < _width);
            if (IsFirstSmaller)
            {
                return 1;
            }
            else if (IsSecondSmaller)
            {
                return 2;
            }
            else
                return -1;
        }
    }
}