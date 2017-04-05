using System;

namespace TreeNodes
{
    /// <summary>
    /// Represent a strongly type node, that only can content two nodes.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <typeparam name="TValue">Node value type.</typeparam>
    public abstract class TwoBranchTree<TNode, TValue> : Node<TValue>
        where TNode : Node<TValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoBranchTree{TNode, TValue}"/> class.
        /// </summary>
        /// <param name="value">Node value.</param>
        /// <exception cref="ArgumentNullException">The specified value is null.</exception>
        public TwoBranchTree(TValue value)
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
        }
    }
}