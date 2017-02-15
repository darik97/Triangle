using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_02
{
    class MyList
    {
        List<int> list;

        public MyList()
        {
            list = new List<int>();
        }

        public void Add(int x)
        {
            list.Add(x);
        }

        public int this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }
    }

}
