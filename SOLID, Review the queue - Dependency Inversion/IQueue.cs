using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID__Review_the_queue___Dependency_Inversion
{
    public interface IQueue<T>
    {
        public void Queue(T value);
        public T Dequeue();
        public T Peek();
    }
}
