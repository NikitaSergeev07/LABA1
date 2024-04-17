using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Laba1_3
{
    public class TreeNode<T>
    {
        private readonly T _value;
        private readonly List<TreeNode<T>> _children = new List<TreeNode<T>>();
        private TreeNode<T> _parent;

        public TreeNode(T value)
        {
            _value = value;
        }
        public T Value { get { return _value; } }
        public TreeNode<T> Parent { get { return _parent; } private set { _parent = value; } }
        public List<TreeNode<T>> Children { get { return _children; } }

        public TreeNode<T> AddChild(T value)
        {
            var node = new TreeNode<T>(value) { Parent = this };
            _children.Add(node);
            return node;
        }

        public TreeNode<T>[] AddChildren(params T[] values)
        {
            return values.Select(AddChild).ToArray();
        }

        public bool RemoveChild(TreeNode<T> node)
        {
            return _children.Remove(node);
        }
        public void PrintChildrenValues(int level = 0)
        {


            Console.WriteLine(new string(' ', level * 2) + Value);
            foreach (var child in Children)
            {
                child.PrintChildrenValues(level + 1);
            }
        }

    }

}
