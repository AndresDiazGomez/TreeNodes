using System;

namespace TreeNodes
{
    /// <summary>
    /// Represent a strongly type tree, with two nodes.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <typeparam name="TValue">Node value type.</typeparam>
    public abstract class BinaryTree<TNode, TValue> : Tree<TNode, TValue>
        where TValue : IComparable
        where TNode : Tree<TNode, TValue>
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
        /// Set the left node element.
        /// </summary>
        /// <param name="node">Node element.</param>
        /// <exception cref="ArgumentNullException">The specified node is null.</exception>
        protected void SetLeftNode(TNode node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));
            Left = node;
            Left.
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
            //SetParent(this as TNode);
        }

        /// <summary>
        /// Determines whether an element is in the tree object.
        /// </summary>
        /// <param name="value">The value to locate in the tree object.</param>
        /// <returns>True if item is found in the tree object; otherwise, false.</returns>
        public virtual bool Contains(TValue value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            return true; // SearchElement(this, value);
        }

        //private bool SearchElement(BinaryTree<TNode, TValue> element, TValue value)
        //{
        //    var compareValue = element.Value.CompareTo(value);
        //    if (compareValue == 0)
        //    {
        //        return true;
        //    }
        //    if (compareValue > 0 && element.HasLeft)
        //    {
        //        return SearchElement(element.Left, value);
        //    }
        //    if (compareValue < 0 && element.HasRight)
        //    {
        //        return SearchElement(element.Right, value);
        //    }
        //    return false;
        //}
    }
}