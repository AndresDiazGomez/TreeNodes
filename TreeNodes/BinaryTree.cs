using System;

namespace TreeNodes
{
    /// <summary>
    /// Represent a strongly type tree, with two nodes.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <typeparam name="TValue">Node value type.</typeparam>
    public abstract class BinaryTree<TNode, TValue> : Tree<TNode, TValue>
        where TNode : Node<TValue>
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
        /// Initializes a new instance of the <see cref="BinaryTree{TNode, TValue}"/> class
        /// referred to the parent node.
        /// </summary>
        /// <param name="value">Node value.</param>
        /// <param name="parent">Parent node.</param>
        /// <exception cref="ArgumentNullException">The specified value is null.</exception>
        public BinaryTree(TValue value, TNode parent)
           : base(value, parent)
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