using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID__Review_the_queue___Dependency_Inversion
{
    public class MyQueue<T> : IQueue<T>
    {
        private ArrayStorage<T> storage;
        private ILogger logger; 
        public MyQueue(int size, ILogger logger)
        {
            storage = new ArrayStorage<T>(size);
            this.logger = logger;
        }
        
        public void Queue(T value)
         {
            storage.Queue(value);
            logger.Info("sto inserendo all'interno della coda il numero " + value);
         }

        public T Dequeue()
        {
            var element = storage.Dequeue();
            logger.Info("sto eliminando l'ultimo elemento della coda" + element);
            return element;
            
        }

        public T Peek()
        {
            var element = storage.Peek();
            logger.Info("sto prendendo l'ultimo elemento della coda" + element);
            return element;
        }       
    }
}
