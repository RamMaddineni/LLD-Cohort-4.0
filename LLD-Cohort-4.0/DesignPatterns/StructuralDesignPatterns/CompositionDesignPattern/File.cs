using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.CompositionDesignPattern
{
    internal class File : FileSystemNode
    {

        private String _content;
        public File()
        {
            _content = "";
            size = 0;
        }

        public override int GetSize()
        {
            return _content.Length;
        }

        public override void Open()
        {
            throw new NotImplementedException();
        }

        public override void Properties()
        {
            throw new NotImplementedException();
        }

        public override void Rename()
        {
            throw new NotImplementedException();
        }
    }
}
