using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeNodes.Test
{
    [TestClass]
    public class BinaryTest
    {
        [TestMethod]
        public void Set_left_and_right_nodes_must_set_parent()
        {
            var root = new BinaryTreeSpec(4);

            root.SetLeft(new BinaryTreeSpec(2));
            root.SetLRigth(new BinaryTreeSpec(5));

            Assert.IsTrue(root.Left.HasParent);
            Assert.IsTrue(root.Right.HasParent);
            Assert.AreEqual(root.Left.Parent.Value, 4);
            Assert.AreEqual(root.Right.Parent.Value, 4);
        }

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

            public void SetLRigth(BinaryTreeSpec node)
            {
                SetRightNode(node);
            }
        }
    }
}
