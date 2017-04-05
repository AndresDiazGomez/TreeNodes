using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeNodes.Test
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Cannot_add_duplicate_values()
        {
            var tree = new BinaryTree<int>(4);

            tree.AddValue(4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Cannot_add_null_values()
        {
            var tree = new BinaryTree<string>("4");

            tree.AddValue(null);
        }

        [TestMethod]
        public void Node_tree_must_know_about_contained_elements()
        {
            var tree = new BinaryTree<int>(4);

            tree.AddValue(2);
            tree.AddValue(1);
            tree.AddValue(3);
            tree.AddValue(5);
            tree.AddValue(7);
            tree.AddValue(10);
            tree.AddValue(9);

            Assert.IsTrue(tree.Contains(4));
            Assert.IsTrue(tree.Contains(2));
            Assert.IsTrue(tree.Contains(1));
            Assert.IsTrue(tree.Contains(3));
            Assert.IsTrue(tree.Contains(5));
            Assert.IsTrue(tree.Contains(7));
            Assert.IsTrue(tree.Contains(10));
            Assert.IsTrue(tree.Contains(9));
        }

        [TestMethod]
        public void Add_a_lower_value_must_go_to_left_side()
        {
            var valueToAdd = 2;
            var tree = new BinaryTree<int>(4);

            tree.AddValue(valueToAdd);

            Assert.AreEqual(tree.Left.Value, valueToAdd);
        }

        [TestMethod]
        public void Add_two_lower_values_must_go_to_left_bottom_root()
        {
            var valueToAdd = 1;
            var tree = new BinaryTree<int>(4);

            tree.AddValue(2);
            tree.AddValue(valueToAdd);

            Assert.AreEqual(tree.Left.Left.Value, valueToAdd);
        }

        [TestMethod]
        public void Add_three_lower_values_must_go_to_left_bottom_root()
        {
            var valueToAdd = 1;
            var tree = new BinaryTree<int>(4);

            tree.AddValue(3);
            tree.AddValue(2);
            tree.AddValue(valueToAdd);

            Assert.AreEqual(tree.Left.Left.Left.Value, valueToAdd);
        }

        [TestMethod]
        public void Add_a_higher_value_must_go_to_right_side()
        {
            var valueToAdd = 5;
            var tree = new BinaryTree<int>(4);

            tree.AddValue(valueToAdd);

            Assert.AreEqual(tree.Right.Value, valueToAdd);
        }

        [TestMethod]
        public void Add_two_higher_values_must_go_to_right_bottom_root()
        {
            var valueToAdd = 6;
            var tree = new BinaryTree<int>(4);

            tree.AddValue(5);
            tree.AddValue(valueToAdd);

            Assert.AreEqual(tree.Right.Right.Value, valueToAdd);
        }

        [TestMethod]
        public void Add_three_higher_values_must_go_to_right_bottom_root()
        {
            var valueToAdd = 7;
            var tree = new BinaryTree<int>(4);

            tree.AddValue(5);
            tree.AddValue(6);
            tree.AddValue(valueToAdd);

            Assert.AreEqual(tree.Right.Right.Right.Value, valueToAdd);
        }

        [TestMethod]
        public void Interchange_higher_and_lower_values_must_go_to_a_correct_position()
        {
            var tree = new BinaryTree<int>(4);

            tree.AddValue(2);
            tree.AddValue(1);
            tree.AddValue(3);
            tree.AddValue(5);
            tree.AddValue(7);
            tree.AddValue(10);
            tree.AddValue(9);

            Assert.AreEqual(tree.Left.Value, 2);
            Assert.AreEqual(tree.Left.Left.Value, 1);
            Assert.AreEqual(tree.Left.Right.Value, 3);
            Assert.AreEqual(tree.Right.Value, 5);
            Assert.AreEqual(tree.Right.Right.Value, 7);
            Assert.AreEqual(tree.Right.Right.Right.Value, 10);
            Assert.AreEqual(tree.Right.Right.Right.Left.Value, 9);
        }
    }
}
