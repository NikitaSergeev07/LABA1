
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba1_3;
namespace Laba1_3.Tests
{
    [TestClass]
    public class TreeNodeTests
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void AddChild_AddsChildNode()
        {
            var parentNode = new TreeNode<int>(1);

            var childNode = parentNode.AddChild(2);

            Assert.IsTrue(parentNode.Children.Count == 1);
            Assert.IsTrue(parentNode.Children.First().Value == 2);
            Assert.IsTrue(childNode.Parent == parentNode);
        }

        [TestMethod]
        public void RemoveChild_RemovesChildNode()
        {
            var parentNode = new TreeNode<int>(1);
            var childNode = parentNode.AddChild(2);

            parentNode.RemoveChild(childNode);

            Assert.IsTrue(parentNode.Children.Count == 0);
        }

        [TestMethod]
        public void AddChildren_AddsMultipleChildNodes()
        {
            var parentNode = new TreeNode<int>(1);

            var childNodes = parentNode.AddChildren(2, 3, 4);

            Assert.IsTrue(parentNode.Children.Count == 3);
            Assert.IsTrue(parentNode.Children.Select(c => c.Value).SequenceEqual(new[] { 2, 3, 4 }));
            foreach (var childNode in childNodes)
            {
                Assert.IsTrue(childNode.Parent == parentNode);
            }
        }

        [TestMethod]
        public void PrintChildrenValues_PrintsCorrectly()
        {
            var parentNode = new TreeNode<int>(1);
            var childNode1 = parentNode.AddChild(2);
            var childNode2 = parentNode.AddChild(3);
            childNode1.AddChild(4);
            childNode2.AddChildren(5, 6);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                parentNode.PrintChildrenValues();
                string expectedOutput = "1\r\n  2\r\n    4\r\n  3\r\n    5\r\n    6\r\n";
                Assert.IsTrue(sw.ToString() == expectedOutput);
            }
        }
    }
}