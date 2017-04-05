using System;

namespace TreeNodes
{
    /// <summary>
    /// Represent a strongly type tree.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <typeparam name="TValue">Node value type.</typeparam>
    public class Tree<TNode, TValue> : Node<TValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tree{TNode, TValue}"/> class.
        /// </summary>
        /// <param name="value">Node value.</param>
        /// <exception cref="ArgumentNullException">The specified value is null.</exception>
        public Tree(TValue value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tree{TNode, TValue}"/> class
        /// referred to the parent node.
        /// </summary>
        /// <param name="value">Node value.</param>
        /// <param name="parent">Parent node.</param>
        /// <exception cref="ArgumentNullException">The specified value is null.</exception>
        public Tree(TValue value, TNode parent)
           : base(value)
        {
            if (parent == null)
                throw new ArgumentNullException(nameof(parent));
            Parent = parent;
        }

        /// <summary>
        /// Determines whether the node have a parent element.
        /// </summary>
        public bool HasParent => Parent != null;

        /// <summary>
        /// Get the parent node element.
        /// </summary>
        public TNode Parent { get; private set; }
    }
}