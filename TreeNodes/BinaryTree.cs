﻿using System;
using System.Collections.Generic;

namespace TreeNodes
{
    /// <summary>
    /// Represent a binary tree.
    /// </summary>
    /// <typeparam name="T">Node value type.</typeparam>
    public class BinaryTree<T> : TwoBranchTree<BinaryTree<T>, T>
        where T : IComparable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryTree{T}"/> class.
        /// </summary>
        /// <param name="value">Node value.</param>
        /// <exception cref="ArgumentNullException">The specified value is null.</exception>
        public BinaryTree(T value)
            : base(value)
        {
        }

        /// <summary>
        /// Add a value to the binary tree.
        /// </summary>
        /// <param name="value">Value to add.</param>
        public void AddValue(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            if (SearchElement(this, value))
            {
                throw new InvalidOperationException("Cannot add a duplicate value.");
            }
            AddValue(this, value);
        }

        /// <summary>
        /// Determines whether an element is in the <see cref="BinaryTree{T}"/> object.
        /// </summary>
        /// <param name="value">The value to locate in the <see cref="BinaryTree{T}"/> object.</param>
        /// <returns>True if item is found in the <see cref="BinaryTree{T}"/> object; otherwise, false.</returns>
        public bool Contains(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            return SearchElement(this, value);
        }

        private void AddValue(BinaryTree<T> element, T value)
        {
            var compareValue = element.Value.CompareTo(value);
            if (compareValue > 0)
            {
                if (element.HasLeft)
                {
                    AddValue(element.Left, value);
                }
                else
                {
                    element.SetLeftNode(new BinaryTree<T>(value));
                }
            }
            else if (compareValue < 0)
            {
                if (element.HasRight)
                {
                    AddValue(element.Right, value);
                }
                else
                {
                    element.SetRightNode(new BinaryTree<T>(value));
                }
            }
        }

        private bool SearchElement(BinaryTree<T> element, T value)
        {
            var compareValue = element.Value.CompareTo(value);
            if (compareValue == 0)
            {
                return true;
            }
            if (compareValue > 0 && element.HasLeft)
            {
                return SearchElement(element.Left, value);
            }
            if (compareValue < 0 && element.HasRight)
            {
                return SearchElement(element.Right, value);
            }
            return false;
        }
    }
}