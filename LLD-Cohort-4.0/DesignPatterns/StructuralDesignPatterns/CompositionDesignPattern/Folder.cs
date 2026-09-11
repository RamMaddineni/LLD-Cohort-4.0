using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.CompositionDesignPattern
{
    internal class Folder : FileSystemNode
    {

        public List<FileSystemNode> _children { get; private set; }

        public Folder()
        {
            _children = new List<FileSystemNode>();
        }
        void AddChildren(FileSystemNode fileSystemNode)
        {
            _children.Add(fileSystemNode);
        }
        public override int GetSize()
        {
            throw new NotImplementedException();
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
