using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace CraigSeeker.Models
{
    public class Repository<T>
    {
        public Repository()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> Iterator()
        {
            throw new NotImplementedException();
        }

        public T Add(T item)
        {
            throw new NotImplementedException();
        }

        public T Update(T item)
        {
            throw new NotImplementedException();
        }

        public T Remove(T item)
        {
            throw new NotImplementedException();
        }

    /* These methods below depend on what columns are in the database table. I don't know that
     * I can make a fully generic class for this and I don't think I want to, so I'll
     * just leave these here for now and cry when I figure out why it was a bad design decision
     * later.
     **/
        public T GetById()
        {
            throw new NotImplementedException();
        }

        public List<T> GetByEmail()
        {
            throw new NotImplementedException();
        }
    }
}