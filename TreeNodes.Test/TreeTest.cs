using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeNodes.Test
{
    [TestClass]
    public class TreeTest
    {
        [TestMethod]
        public void Create_a_root_node_must_have_not_a_parent()
        {
            var root = new TreeSpec(5);

            Assert.IsTrue(root.IsRoot);
        }

        [TestMethod]
        public void Set_a_parent_must_change_is_root_value()
        {
            var root = new TreeSpec(5);
            var leaf = new TreeSpec(5);

            leaf.SetParent(root);

            Assert.IsTrue(root.IsRoot);
            Assert.IsFalse(leaf.IsRoot);
        }

        public class TreeSpec : Tree<TreeSpec, int>
        {
            public TreeSpec(int value)
                : base(value)
            {

            }

            public void SetParent(TreeSpec parent)
            {
                Parent = parent;
            }
        }
    }
}
