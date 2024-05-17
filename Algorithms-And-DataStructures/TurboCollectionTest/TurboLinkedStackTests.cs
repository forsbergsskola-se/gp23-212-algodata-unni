namespace TurboCollectionTest;

public class TurboLinkedStackTests
{
    [Test]
    public void PushTest()
    {
        var stack = new TurboLinkedStack<int>();
        
        
        stack.Push(1); //instance of the function and calling the push function, stack is the method
        
        Assert.That(stack.LastNode.Value, Is.EqualTo(10));
Assert.AreEqual(6,stack.LastNode.Previous.Value);
Assert.AreEqual(2,stack.LastNode.Previous.Value);

    }
    
}