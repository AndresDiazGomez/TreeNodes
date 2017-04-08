using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeNodes.Test
{
    [TestClass]
    public class BinaryTreeTest
    {
        private BinaryTreeSpec GetTree()
        {
            //root
            var root = new BinaryTreeSpec(1);

            //left tree
            var firstLvlLeftNode = new BinaryTreeSpec(2);
            var secondLvlLeftNodeLeft = new BinaryTreeSpec(2);
            var secondLvlLeftNodeRight = new BinaryTreeSpec(4);
            var thirdLvlLeftNode = new BinaryTreeSpec(5);

            root.SetLeft(firstLvlLeftNode);
            firstLvlLeftNode.SetLeft(secondLvlLeftNodeLeft);
            firstLvlLeftNode.SetRigth(secondLvlLeftNodeRight);
            secondLvlLeftNodeLeft.SetLeft(thirdLvlLeftNode);

            //right tree
            var firstLvlRightNode = new BinaryTreeSpec(3);
            var secondLvlRightNodeRight = new BinaryTreeSpec(7);
            var thirdLvlRightNode = new BinaryTreeSpec(10);
            
            root.SetRigth(firstLvlRightNode);
            firstLvlRightNode.SetRigth(secondLvlRightNodeRight);
            secondLvlRightNodeRight.SetLeft(thirdLvlRightNode);

            return root;
        }


        [TestMethod]
        public void Set_left_and_right_nodes_must_set_correct_parent()
        {
            var root = GetTree();

            Assert.IsTrue(root.IsRoot);
            Assert.IsFalse(root.Left.IsRoot);
            Assert.IsFalse(root.Left.Left.IsRoot);
            Assert.IsFalse(root.Left.Right.IsRoot);
            Assert.IsFalse(root.Left.Left.Left.IsRoot);
            Assert.IsFalse(root.Right.IsRoot);
            Assert.IsFalse(root.Right.Right.IsRoot);
            Assert.IsFalse(root.Right.Right.Left.IsRoot);

            Assert.AreEqual(root.Left.Parent.Value, 1);
            Assert.AreEqual(root.Left.Left.Parent.Value, 2);
            Assert.AreEqual(root.Left.Right.Parent.Value, 2);
            Assert.AreEqual(root.Left.Left.Left.Parent.Value, 2);
            Assert.AreEqual(root.Right.Parent.Value, 1);
            Assert.AreEqual(root.Right.Right.Parent.Value, 3);
            Assert.AreEqual(root.Right.Right.Left.Parent.Value, 7);
        }

        [TestMethod]
        public void Set_left_node_must_set_HasLeft_property_true()
        {
            var root = new BinaryTreeSpec(1);
            var left = new BinaryTreeSpec(2);

            root.SetLeft(left);

            Assert.IsTrue(root.HasLeft);
        }

        [TestMethod]
        public void Set_right_node_must_set_HasRight_property_true()
        {
            var root = new BinaryTreeSpec(1);
            var right = new BinaryTreeSpec(3);

            root.SetRigth(right);

            Assert.IsTrue(root.HasRight);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Set_null_value_to_left_node_must_throw_ArgumentNullException()
        {
            var root = new BinaryTreeSpec(1);

            root.SetLeft(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Set_null_value_to_right_node_must_throw_ArgumentNullException()
        {
            var root = new BinaryTreeSpec(1);

            root.SetRigth(null);
        }

        [TestMethod]
        public void Detach_left_node_must_clear_relationship_in_both_ways()
        {
            var root = new BinaryTreeSpec(1);
            var left = new BinaryTreeSpec(2);

            root.SetLeft(left);
            root.DetachLeftNode();

            Assert.IsFalse(root.HasLeft);
            Assert.IsTrue(left.IsRoot);
        }

        [TestMethod]
        public void Detach_right_node_must_clear_relationship_in_both_ways()
        {
            var root = new BinaryTreeSpec(1);
            var right = new BinaryTreeSpec(3);

            root.SetRigth(right);
            root.DetachRightNode();

            Assert.IsFalse(root.HasLeft);
            Assert.IsTrue(right.IsRoot);
        }

        [TestMethod]
        public void Detach_not_set_node_must_not_throw_an_expetion()
        {
            var root = new BinaryTreeSpec(1);

            root.DetachLeftNode();
            root.DetachRightNode();

            Assert.IsFalse(root.HasLeft);
        }

        //[TestMethod]
        //public void Binary_tree_must_know_about_contained_elements()
        //{
        //    var root = GetTree();

        //    Assert.IsTrue(root.Contains(10));
        //    Assert.IsFalse(root.Contains(-1));
        //}

        public class BinaryTreeSpec : BinaryTree<BinaryTreeSpec, int>
        {
            public BinaryTreeSpec(int value)
                : base(value)
            {

            }

            public void SetLeft(BinaryTreeSpec node)
            {
                SetLeftNode(node);
            }

            public void SetRigth(BinaryTreeSpec node)
            {
                SetRightNode(node);
            }
        }
    }
}
