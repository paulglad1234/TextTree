using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTree
{
    class Node
    {
        public string data;
        public Node Left;
        public Node Right;
        public Node(string data)
        {
            this.data = data;
            Left = Right = null;
        }
        public bool FindTheFollowing(string word)
        {
            int x = String.Compare(word, data);
            if (x == 0)
                return true;
            if (x < 0)
                if (Left != null)
                    return Left.FindTheFollowing(word);
            if (x > 0)
                if (Right != null)
                    return Right.FindTheFollowing(word);
            return false;
        }
        public void AddTheLeaf(string word)
        {
            int x = String.Compare(word, data);
            if (x < 0)
            {
                if (Left == null)
                    Left = new Node(word);
                else Left.AddTheLeaf(word);
            }
            if (x > 0)
            {
                if (Right == null)
                    Right = new Node(word);
                else Right.AddTheLeaf(word);
            }
        }
    }
}
