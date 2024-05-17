namespace TurboCollections;

public class TurboBinaryTree
{
    public class Node
    {
        public int Data { get; set; }
        
        public Node Left { get; set; }
        
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data; //Input
            Left = null; // You start with right and left being empty
            Right = null;
        }
        
    }
    
    public Node Root { get; set; }

    public TurboBinaryTree()
    {
        Root = null; // Start with the root being null so no
    }
}

