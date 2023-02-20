using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizHW.BranchDepht
{
    public class BranchNode<T> where T : IComparable<T>
    {
        public string Key { get; set; }
        public T Value { get; set; }
        public List<BranchNode<T>> Children { get; set; } = new List<BranchNode<T>>();
        public BranchNode<T> Parent { get; set; }
        public bool isParent { get; set; }
        public BranchNode(string key, T value, bool isParent = false)
        {
            Key = key;
            Value = value;
            this.Parent = null;
            this.isParent = isParent;
        }

        public void Insert(BranchNode<T> child)
        {
            child.Parent = this;
            Children.Add(child);
        }

        public int GetDepth()
        {
            int maxDepth = 0;
            foreach (var child in Children)
            {
                int childDepth = child.GetDepth();
                if (childDepth > maxDepth)
                {
                    maxDepth = childDepth;
                }
            }
            return maxDepth+1;
        }
    }
}
