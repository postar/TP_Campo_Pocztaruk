using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public abstract class MAPPER<T>
    {
        internal DBACCESS access = new DBACCESS();
        public abstract int Insert(T entity);
        public abstract int Edit(T entity);
        public abstract int Delete(T entity);
        public abstract List<T> List();
        public abstract T Convert(DataRow registry);
    }
}