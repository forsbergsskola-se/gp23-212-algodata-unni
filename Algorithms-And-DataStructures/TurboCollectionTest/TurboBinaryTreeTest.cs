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
            Assert.That(tree.Root.Data, Is.EqualTo(10)); //10 should be the root
            Assert.NotNull(tree.Root.Left);
            Assert.That(tree.Root.Left.Data, Is.EqualTo(5)); //5 should be left 
            Assert.NotNull(tree.Root.Right);
            Assert.That(tree.Root.Right.Data, Is.EqualTo(15)); //15 right, highest number
        }

        [Test]

        public void TestReturnFalseifItemNotFound()
        {
            TurboBinaryTree tree = new TurboBinaryTree();
            
            tree.Insert(3);
            tree.Insert(5);
            tree.Insert(1);
            
            bool result = tree.Delete(4); 
            Assert.That(result, Is.False);
            
            
        }
        
      
            
        }
    }
