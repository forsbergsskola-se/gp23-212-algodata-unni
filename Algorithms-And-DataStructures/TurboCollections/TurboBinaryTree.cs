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
        
        public bool Delete(int data)
        {
            Root = DeleteNode(Root, data, out bool deleted);
            return deleted;
        }

        private Node DeleteNode(Node node, int data, out bool deleted)
        {
            deleted = false;

            if (node == null) return null;

            if (data < node.Data)
            {
                node.Left = DeleteNode(node.Left, data, out deleted);
            }
            else if (data > node.Data)
            {
                node.Right = DeleteNode(node.Right, data, out deleted);
            }
            else
            {
                deleted = true;

                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                node.Data = MinValue(node.Right);
                node.Right = DeleteNode(node.Right, node.Data, out _);
            }

            return node;
        }

        private int MinValue(Node node)
        {
            int minValue = node.Data;
            while (node.Left != null)
            {
                node = node.Left;
                minValue = node.Data;
            }
            return minValue;
        }
    }
    }
