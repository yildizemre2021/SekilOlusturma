using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilOlusturma
{
    internal class Elips : IShape
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public int alan;

        public Point getPoint()
        {
            throw new NotImplementedException();
        }

        public int alanHesaplama()
        {
            return this.width * this.height;
        }

    }
}
