using NUnit.Framework;
using TurboCollections;

namespace TurboCollectionTest
{
    [TestFixture]
    public class TurboBinaryTreeTest
    {
        [Test]
        public void TestTurboBinaryTree()
        {
            // Arrange new 
            TurboBinaryTree tree = new TurboBinaryTree();
            
            // Data input in node ito tree
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);

            // Assert
            Assert.NotNull(tree.Root);
            Assert.AreEqual(10, tree.Root.Data);
            Assert.NotNull(tree.Root.Left);
            Assert.AreEqual(5, tree.Root.Left.Data);
            Assert.NotNull(tree.Root.Right);
            Assert.AreEqual(15, tree.Root.Right.Data);
        }
    }
}