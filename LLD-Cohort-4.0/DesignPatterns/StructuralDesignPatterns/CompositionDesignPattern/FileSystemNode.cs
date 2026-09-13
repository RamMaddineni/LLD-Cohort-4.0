using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.CompositionDesignPattern
{
    internal abstract class FileSystemNode
    {
        protected String name;
        protected int size;
        protected FileSystemNode parent;
        public abstract void Properties();
        public abstract int GetSize();
        public abstract void Rename();
        public abstract void Open();
    }
}
