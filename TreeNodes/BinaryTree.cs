using System;
using System.Collections;
using System.Collections.Generic;

namespace TreeNodes
{
    /// <summary>
    /// Represent a strongly type tree, with two nodes.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <typeparam name="TValue">Node value type.</typeparam>
    public abstract class BinaryTree<TNode, TValue> : Tree<TNode, TValue>//, IEnumerable<TNode>, IEnumerable
        where TValue : IComparable
        where TNode : BinaryTree<TNode, TValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryTree{TNode, TValue}"/> class.
        /// </summary>
        /// <param name="value">Node value.</param>
        /// <exception cref="ArgumentNullException">The specified value is null.</exception>
        public BinaryTree(TValue value)
           : base(value)
        {
        }

        /// <summary>
        /// Determines whether the node have a left element.
        /// </summary>
        public bool HasLeft => Left != null;

        /// <summary>
        /// Determines whether the node have a right element.
        /// </summary>
        public bool HasRight => Right != null;

        /// <summary>
        /// Left node element.
        /// </summary>
        public TNode Left { get; private set; }

        /// <summary>
        /// Right node element.
        /// </summary>
        public TNode Right { get; private set; }

        /// <summary>
        /// Detach left node tree.
        /// </summary>
        public void DetachLeftNode()
        {
            if (Left != null)
            {
                Left.Parent = null;
            }
            Left = null;
        }

        /// <summary>
        /// Detach right node tree.
        /// </summary>
        public void DetachRightNode()
        {
            if (Right != null)
            {
                Right.Parent = null;
            }
            Right = null;
        }

        /// <summary>
        /// Set the left node element.
        /// </summary>
        /// <param name="node">Node element.</param>
        /// <exception cref="ArgumentNullException">The specified node is null.</exception>
        protected void SetLeftNode(TNode node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));
            Left = node;
            Left.Parent = this as TNode;
        }

        /// <summary>
        /// Set the right node element.
        /// </summary>
        /// <param name="node">Node element.</param>
        /// <exception cref="ArgumentNullException">The specified node is null.</exception>
        protected void SetRightNode(TNode node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));
            Right = node;
            Right.Parent = this as TNode;
        }

        /// <summary>
        /// Determines whether an element is in the tree object.
        /// </summary>
        /// <param name="value">The value to locate in the tree object.</param>
        /// <returns>True if item is found in the tree object; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">The specified value is null.</exception>
        public virtual bool Contains(TValue value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            return true; // SearchElement(this, value);
        }

        //private bool SearchElement(TNode element, TValue value)
        //{
        //    if (element.Value.CompareTo(value) == 0)
        //    {
        //        return true;
        //    }
        //    if (element.HasLeft)
        //    {
        //        return SearchElement(element.Left, value);
        //    }
        //    if (element.HasRight)
        //    {
        //        return SearchElement(element.Right, value);
        //    }
        //    return false;
        //}

        //public IEnumerator<TNode> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}