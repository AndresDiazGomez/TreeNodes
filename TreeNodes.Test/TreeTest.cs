using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeNodes.Test
{
    [TestClass]
    public class TreeTest
    {
        [TestMethod]
        public void Create_a_root_node_have_not_a_parent()
        {
            var root = new TreeSpec(5);

            Assert.IsFalse(root.HasParent);
        }

        [TestMethod]
        public void Create_a_node_with_parent_must_set_hasparent_property_as_true()
        {
            var root = new TreeSpec(5);
            var leaf = new TreeSpec(1, root);

            Assert.IsTrue(leaf.HasParent);
        }

        [TestMethod]
        public void HasParent_must_return_true_if_has_parent_otherwise_false()
        {
            var root = new TreeSpec(5);
            var leaf = new TreeSpec(1, root);

            Assert.IsTrue(!root.HasParent && root.Parent == null);
            Assert.IsTrue(leaf.HasParent && leaf.Parent != null);
        }
    }

    public class TreeSpec : Tree<TreeSpec, int>
    {
        public TreeSpec(int value)
            : base(value)
        {

        }

        public TreeSpec(int value, TreeSpec parent)
            : base(value, parent)
        {

        }
    }
}
