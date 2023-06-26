using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public abstract class COMPONENT
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public abstract IList<COMPONENT> Childs { get; }
        public abstract void AddChild(COMPONENT c);
        public abstract void DeleteChild();

        public override string ToString()
        {
            return "";
        }


    }
}