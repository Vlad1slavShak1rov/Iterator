using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Enumerator : IEnumerator
    {
        private Library enumerable;
        private int current = -1;
        public Enumerator(Library enumerable)
        {
            this.enumerable = enumerable;
        }

        public bool MoveNext()
        {
            if (current < enumerable.Count - 1)
            {
                current++;
                return true;
            }
            return false;
        }
        public void Reset() { current = -1; }
        public Book Current { get { return enumerable[current]; } }
    }
}
