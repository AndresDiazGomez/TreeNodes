using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeNodes.Test
{
    [TestClass]
    public class NodeTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Cannot_create_a_null_value_node()
        {
            new Node<string>(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Cannot_create_a_null_value_node_with_null_class()
        {
            new Node<int?>(null);
        }

        [TestMethod]
        public void Default_constructor_must_set_value_property()
        {
            var value = 1;
            var node = new Node<int>(value);

            Assert.AreEqual(node.Value, value);
        }
    }
}
