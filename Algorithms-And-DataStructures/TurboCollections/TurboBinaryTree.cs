namespace TurboCollections
{
    public class TurboBinaryTree
    {
        public class Node //The class is for each node that is created in the binary tree
        {
            public int Data { get; set; } //the data stored in the node that you insert
            
            public Node Left { get; set; } 
            
            public Node Right { get; set; }

            public Node(int data)
            {
                Data = data; //Input and set the data in that specific node
                Left = null; // You start with right and left being emppty
                Right = null; // start with right being null 
            }
        }

        public Node Root { get; set; } //root of the binary tree

        public TurboBinaryTree()
        {
            Root = null; // Start with the root being null
        }

        private void InsertNode(int data, Node node) //adding the node in the tree
        {
            if (data < node.Data) //checking the data in the node to tell where it should be in the tree
            {
                switch (node.Left)
                {
                    case null:
                        node.Left = new Node(data); //If data is less than node, move to Node Left
                        break;
                    default:
                        InsertNode(data, node.Left);
                        break;
                }
            }
            else
            {
                switch (node.Right)
                {
                    case null:
                        node.Right = new Node(data);
                        break;
                    default:
                        InsertNode(data, node.Right);
                        break;
                } 
            }
        }

        public void Insert(int data) // inserting new nodes starting from the rood and checking
        {
            if (Root == null)
            {
                Root = new Node(data);
            }
            else
            {
                InsertNode(data, Root);
            }
        }
    }
}